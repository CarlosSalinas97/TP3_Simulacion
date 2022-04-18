using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesAleatorias.Formularios
{
    public partial class Generador_Normal : Form
    {
        double media;
        double desviacion;
        int muestra;
        private static Random rnd = new Random();
        double[] vector;

        public Generador_Normal()
        {
            InitializeComponent();
        }

        private void Generador_Normal_Load(object sender, EventArgs e)
        {
            btn_histograma.Enabled = false;
            txt_media.Text = "0";
            txt_desviacion.Text = "1";
            txt_muestra.Text = "5";
            grilla_normal.Refresh();
        }

        public void generarNormal(double media, double desviacion, int n)
        {
            vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                double aux1 = (Math.Truncate(rnd.NextDouble() * 10000) / 10000);
                double aux2 = (Math.Truncate(rnd.NextDouble() * 10000) / 10000);

                double z = Math.Sqrt(-2 * Math.Log(aux1)) * Math.Sin(2 * Math.PI * aux2);

                double z2 = Math.Sqrt(-2 * Math.Log(aux1)) * (Math.Cos(2 * Math.PI * aux2));

                if (i % 2 == 0) //Condicion para utiizar la funcion con seno o coseno
                {
                    grilla_normal.Rows.Add(i, aux1 + "/" + aux2, Math.Truncate(z * 10000) / 10000);
                    vector[i] = Math.Truncate(z * 10000) / 10000;
                }
                else
                {
                    grilla_normal.Rows.Add(i, aux1 + "/" + aux2, Math.Truncate(z2 * 10000) / 10000);
                    vector[i] = Math.Truncate(z2 * 10000) / 10000;
                }

                btn_histograma.Enabled = true;

                //double rndNormal = media + desviacion * (z);  
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_desviacion.Text) || string.IsNullOrEmpty(txt_media.Text) || string.IsNullOrEmpty(txt_muestra.Text)) {
                MessageBox.Show("Uno de los parámetros está vacío.");
            } else
            {
                grilla_normal.Rows.Clear();
                media = double.Parse(txt_media.Text);
                desviacion = double.Parse(txt_desviacion.Text);
                muestra = int.Parse(txt_muestra.Text);

                generarNormal(media, desviacion, muestra);
            }
        }

        private void btn_histograma_Click(object sender, EventArgs e)
        {
            PopUp_Intervalos popUpForm = new PopUp_Intervalos("normal");
            popUpForm.serie_generada = vector;
            popUpForm.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
