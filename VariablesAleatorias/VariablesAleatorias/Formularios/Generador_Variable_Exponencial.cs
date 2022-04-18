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
    public partial class Generador_Variable_Exponencial : Form
    {
        private double[] vector;
        private bool isLambda = false;

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
            grilla_exponencial.Rows.Clear();
            vector = new Double[int.Parse(txt_muestra_exp.Text)];
            double x = 0;
            btn_histograma.Enabled = false;

            if (string.IsNullOrEmpty(txt_lambda_exp.Text) && string.IsNullOrEmpty(txt_media_exp.Text)) { 
                MessageBox.Show("Debe seleccionar un parametro.");
            } else
            {
                for (int i = 0; i < int.Parse(txt_muestra_exp.Text); i++)
                {
                    if (isLambda)
                    {
                        double rnd = generarNroAleatorio();
                        x = (-1 / double.Parse(txt_lambda_exp.Text)) * (Math.Log10(1 - rnd));
                        vector[i] = x;
                        grilla_exponencial.Rows.Add((i + 1), rnd, (Math.Truncate(vector[i] * 10000) / 10000));
                        grilla_exponencial.Refresh();

                    }

                    else
                    {
                        double rnd = generarNroAleatorio();
                        double lbd = (1 / double.Parse(txt_media_exp.Text));
                        x = (-1 / lbd) * (Math.Log10(1 - rnd));
                        vector[i] = x;
                        grilla_exponencial.Rows.Add((i + 1), rnd, (Math.Truncate(vector[i] * 10000) / 10000));
                        grilla_exponencial.Refresh();

                    }
                }
                btn_histograma.Enabled = true;
            }
        }

        public Double generarNroAleatorio()
        {
            Random nro = new Random();
            Double rnd;

            rnd = (Math.Truncate(nro.NextDouble() * 10000) / 10000);
            return rnd;
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
            PopUp_Intervalos popUpForm = new PopUp_Intervalos();
            popUpForm.serie_generada = vector;
            popUpForm.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
