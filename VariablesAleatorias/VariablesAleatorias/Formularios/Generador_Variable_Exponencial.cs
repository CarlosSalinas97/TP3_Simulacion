using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VariablesAleatorias.Clases;

namespace VariablesAleatorias.Formularios
{
    public partial class Generador_Variable_Exponencial : Form
    {
        private double[] vector;
        private bool isLambda = false;
        private Random random = new Random();

        public Generador_Variable_Exponencial()
        {
            InitializeComponent();
        }

        private void Generador_Variable_Exponencial_Load(object sender, EventArgs e)
        {
            btn_histograma.Enabled = false;
            cmb_exponencial.SelectedIndex = 0;
            cmb_exponencial_SelectionChangeCommitted(sender, e);
        }

        public void agregarFilaAGrilla()
        { 
            btn_histograma.Enabled = false;
            grilla_exponencial.Rows.Clear();
            Cursor.Current = Cursors.WaitCursor;

            int N = int.Parse(txt_muestra_exp.Text);
            vector = new double[N];
            double aux = 0.0;
            double lambda = 0.0;
            double media = 0.0;


            if (string.IsNullOrEmpty(txt_lambda_exp.Text) && string.IsNullOrEmpty(txt_media_exp.Text)) { 
                MessageBox.Show("Debe seleccionar un parametro.");
            } else
            {
                if (isLambda)
                {
                    lambda = double.Parse(txt_lambda_exp.Text);
                } else
                {
                    media = double.Parse(txt_media_exp.Text);
                }
               
                for (int i = 0; i < int.Parse(txt_muestra_exp.Text); i++)
                {
                    progress_bar.Value = (int)(100 / double.Parse(txt_muestra_exp.Text) * (i + 1));
                    double rnd = Decimal_Utils.limitar_4_decimales(random.NextDouble());

                    if (isLambda)
                    {
                        aux = Decimal_Utils.limitar_4_decimales(-1 / lambda * Math.Log(1 - rnd));
                    }

                    else
                    {
                        aux = Decimal_Utils.limitar_4_decimales(-1 / (1 / media) * Math.Log(1 - rnd));
                    }

                    vector[i] = aux;
                    grilla_exponencial.Rows.Add(i + 1, rnd, aux);
                }
                progress_bar.Value = 100;
                btn_histograma.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void cmb_exponencial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Object selectedItem = cmb_exponencial.SelectedItem;

            if (selectedItem.ToString() == "media")
            {
                txt_lambda_exp.Enabled = false;
                txt_lambda_exp.Clear();
                txt_media_exp.Enabled = true;
                isLambda = false;
            }

            if (selectedItem.ToString() == "lambda")
            {
                txt_media_exp.Enabled = false;
                txt_media_exp.Clear();
                txt_lambda_exp.Enabled = true;
                isLambda = true;
            }
        }

        private void btn_generar_exp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_muestra_exp.Text))
            {
                MessageBox.Show("Debe especificar la cantidad de numeros a generar.");
            }

            else { agregarFilaAGrilla(); }
        }

        private void btn_histograma_exp_Click(object sender, EventArgs e)
        {
            PopUp_Intervalos popUpForm = new PopUp_Intervalos("exponencial");
            popUpForm.serie_generada = vector;
            popUpForm.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
