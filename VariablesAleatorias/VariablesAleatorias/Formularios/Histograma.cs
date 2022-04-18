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
        public int intervalos_seleccionado;
        public double[] serie_generada;
        private List<int> serie_por_intervalos;
        private double[] intervalos;

        public Histograma()
        {
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            serie_por_intervalos = new List<int>(new int[intervalos_seleccionado]);
            asignar_intervalos();

            double frecuencia_esperada = serie_generada.Length / intervalos_seleccionado;

            for (int i = 0; i < intervalos.Length; i++)
            {
                //Carga el grafico de barra para las frecuencias observadas FO.
                chart1.Series["FO"].Points.AddXY(intervalos[i].ToString(), serie_por_intervalos[i].ToString());
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
                }
                else
                {// Si es cualquier otro intervalo, suma el max anterior + ancho de los intervalos + 0.0001 (Para ajustar y tomar todos los valores).
                    intervalos[i] = limitar_4_decimales(intervalos[i-1] + ancho_intervalo + 0.0001);
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
    }
}
