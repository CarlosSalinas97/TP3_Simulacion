using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VariablesAleatorias.Formularios
{
    public partial class Histograma : Form
    {
        private string generador;
        public int intervalos_seleccionado;
        public double[] serie_generada;
        private double[] serie_por_intervalos;
        private double[] intervalos;
        private double[] intervalos_min;
        private double[] marca_clase;
        private double[] frecuencia_esperada;
        private double[] probabilidad_obs;
        private double[] probabilidad_esp;

        public Histograma(string generador_seleccionado)
        {
            generador = generador_seleccionado.Trim();
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            inicializar_arreglos();
            asignar_intervalos();
            set_marca_clase();

            // Carga el histograma
            switch (generador)
            {
                case "uniforme":
                    histograma_uniforme();
                    break;
                case "normal":
                    histograma_normal();
                    break;
                case "exponencial":
                    histograma_exponencial();
                    break;
            }

            // Carga la tabla de frecuencias
            generar_tabla_frec();
        }

        private void inicializar_arreglos()
        {
            serie_por_intervalos = new double[intervalos_seleccionado];
            intervalos_min = new double[intervalos_seleccionado];
            marca_clase = new double[intervalos_seleccionado];
            frecuencia_esperada = new double[intervalos_seleccionado];
            probabilidad_obs = new double[intervalos_seleccionado];
            probabilidad_esp = new double[intervalos_seleccionado];
        }

        //Obtiene la FO de cada valor de la serie y lo asigna a la lista 'serie_por_intervalos'.
        private void asignar_intervalos()
        {
            intervalos = generar_intervalos();
            for (int i = 0; i < serie_generada.Length; i++)
            {
                bool band = true;
                for (int j = 0; j < intervalos.Length; j++)
                {
                    
                    if (serie_generada[i] <= intervalos[j] && band)
                    {
                        serie_por_intervalos[j]++;
                        band = false;
                    }
                   
                }
            }
        }

        // Genera un array con el valor max (hasta) de cada intervalo.
        private double[] generar_intervalos()
        {
            double min = serie_generada.Min();
            double max = serie_generada.Max();
            double ancho_intervalo = (max - min) / intervalos_seleccionado;
            double[] intervalos = new double[intervalos_seleccionado];


            for (int i = 0; i < intervalos_seleccionado; i++)
            {
                if (i == 0)
                {// Si es el primer intervalo, suma el minimo + ancho de los intervalos.
                    intervalos[i] = limitar_4_decimales(min + ancho_intervalo);
                    intervalos_min[i] = min; 
                }
                else
                {// Si es cualquier otro intervalo, suma el max anterior + ancho de los intervalos + 0.0001 (Para ajustar y tomar todos los valores).
                    intervalos[i] = limitar_4_decimales(intervalos[i-1] + ancho_intervalo + 0.0001);
                    intervalos_min[i] = intervalos[i-1] + 0.0001;
                }

            }
            return intervalos;
        }

        // Limita un double a 4 decimales.
        // Se podría poner en una clase utilitaria.
        private double limitar_4_decimales(double valor)
        {
            return Math.Truncate(valor * 10000) / 10000;
        }

        private void set_marca_clase()
        {
            
            for (int i = 0; i < intervalos.Length; i++)
            {
                marca_clase[i] = limitar_4_decimales(((intervalos[i] - intervalos_min[i]) / 2) + intervalos_min[i]);
            }
        }

        private void histograma_uniforme()
        {
            double frecuencia_esperada = serie_generada.Length / intervalos_seleccionado;
            int N = serie_generada.Length;

            for (int i = 0; i < intervalos.Length; i++)
            {
                this.frecuencia_esperada[i] = frecuencia_esperada;
                probabilidad_obs[i] = serie_por_intervalos[i] / N;
                probabilidad_esp[i] = frecuencia_esperada / N == 0.04 ? 0.05 : frecuencia_esperada / N; // Ajuste para 20 intervalos
                //Carga el grafico de barra para las frecuencias observadas FO.
                chart1.Series["FO"].Points.AddXY(marca_clase[i].ToString(), serie_por_intervalos[i].ToString());
                chart1.Series["FO"].Points[i].Label = serie_por_intervalos[i].ToString();
            }

            // Genera la linea que marca la frecuencia esperada FE
            StripLine linea = new StripLine
            {
                Interval = 0,
                IntervalOffset = frecuencia_esperada,
                StripWidth = frecuencia_esperada * 0.01 > 0.1 ? frecuencia_esperada * 0.01 : 0.1,
                BackColor = Color.Red,
                Text = "FE = " + frecuencia_esperada

            };
            chart1.ChartAreas[0].AxisY.StripLines.Add(linea);
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private void histograma_normal()
        {
            double densidad_normal = 0.0;
            double densidad_ajustada = 0.0;
            int N = serie_generada.Length;

            for (int i = 0; i < intervalos.Length; i++)
            {
                probabilidad_obs[i] = limitar_4_decimales(serie_por_intervalos[i] / N);
                //Carga el grafico de barra para las frecuencias observadas FO.
                chart1.Series["FO"].Points.AddXY(marca_clase[i].ToString(), serie_por_intervalos[i].ToString());
                chart1.Series["FO"].Points[i].Label = serie_por_intervalos[i].ToString();
                densidad_normal = distribucion_normal(marca_clase[i]);
                densidad_ajustada = densidad_normal * (intervalos[i] - intervalos_min[i]);
                frecuencia_esperada[i] = limitar_4_decimales(densidad_ajustada * N);
                probabilidad_esp[i] = limitar_4_decimales(densidad_ajustada);
                chart1.Series["FE"].Points.AddXY(intervalos[i].ToString(), densidad_ajustada * N);
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private double distribucion_normal(double marca_clase)
        {
            double media = media_serie();
            double desv_std = desviacion_standar_normal();

            return Math.Pow(Math.E, -0.5 * Math.Pow((marca_clase - media) / desv_std, 2)) / (desv_std * Math.Sqrt(2 * Math.PI));
        }

        private double desviacion_standar_normal()
        {
            return Math.Sqrt(varianza_normal());
        }

        private double varianza_normal()
        {
            double acumulador = 0.0;
            double media = media_serie();

            for (int i = 0; i < serie_generada.Length; i++)
            {
                acumulador = acumulador + Math.Pow(serie_generada[i] - media, 2);
            }
            return acumulador / (serie_generada.Length - 1);
        }

        private void histograma_exponencial()
        {
            double max_intervalo;
            double min_intervalo;
            double densidad;
            int N = serie_generada.Length;

            for (int i = 0; i < intervalos.Length; i++)
            {
                probabilidad_obs[i] = limitar_4_decimales(serie_por_intervalos[i] / N);
                //Carga el grafico de barra para las frecuencias observadas FO.
                chart1.Series["FO"].Points.AddXY(marca_clase[i].ToString(), serie_por_intervalos[i].ToString());
                chart1.Series["FO"].Points[i].Label = serie_por_intervalos[i].ToString();
                max_intervalo = intervalos[i];
                min_intervalo = intervalos_min[i];
                densidad = densidad_exponencial(max_intervalo, min_intervalo);
                frecuencia_esperada[i] = limitar_4_decimales(densidad * N);
                probabilidad_esp[i] = limitar_4_decimales(densidad);
                chart1.Series["FE"].Points.AddXY(intervalos[i].ToString(), densidad*N);
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private double densidad_exponencial(double max_intervalo, double min_invertavlo)
        {
            double lambda = 1 / media_serie();
            double lambda_max = Math.Pow(Math.E, -lambda * max_intervalo);
            double lambda_min = Math.Pow(Math.E, -lambda * min_invertavlo);
            return (1 - lambda_max) - (1 - lambda_min);
        }

        private double media_serie()
        {
            double acumulador = 0.0;
            double media = 0.0;

            for (int i = 0; i < serie_generada.Length; i++)
            {
                acumulador = (acumulador + serie_generada[i]);
            }

            media = acumulador / serie_generada.Length;
            return media;
        }

        private void generar_tabla_frec()
        {
            Clases.Intervalos_Constructor constructor_int = new Clases.Intervalos_Constructor();
            double po_acumulada = 0.0;
            double pe_acumulada = 0.0;

            for (int i = 0; i < intervalos.Length; i++)
            {
                constructor_int.minimo_int = limitar_4_decimales(intervalos_min[i]);
                constructor_int.maximo_int = limitar_4_decimales(intervalos[i]);
                po_acumulada = po_acumulada + probabilidad_obs[i];
                pe_acumulada = pe_acumulada + probabilidad_esp[i];

                grilla_frecuencias.Rows.Add(constructor_int.get_intervalo(), marca_clase[i], serie_por_intervalos[i], 
                    frecuencia_esperada[i], probabilidad_obs[i], probabilidad_esp[i], po_acumulada, pe_acumulada);
            }
        }
    }
}
