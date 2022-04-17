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
        public Generador_Variable_Exponencial()
        {
            InitializeComponent();
        }

        private void Generador_Variable_Exponencial_Load(object sender, EventArgs e)
        {

        }

        public void agregarFilaAGrilla()
        {
            double[] vector = new Double[int.Parse(txt_muestra_exp.Text)];
            double x = 0;

            for (int i = 0; i < int.Parse(txt_muestra_exp.Text); i++)
            {
                if (txt_lambda_exp.Visible == true && txt_media_exp.Visible == false)
                {
                    double rnd = generarNroAleatorio();
                    x = (-1 / double.Parse(txt_lambda_exp.Text)) * (Math.Log10(1 - rnd));
                    vector[i] = x;
                    grilla_exponencial.Rows.Add(rnd, (Math.Truncate(vector[i] * 10000) / 10000));
                    grilla_exponencial.Refresh();

                }

                else if (txt_media_exp.Visible == true && txt_lambda_exp.Visible == false)
                {
                    double rnd = generarNroAleatorio();
                    double lbd = (1 / double.Parse(txt_media_exp.Text));
                    x = (-1 / lbd) * (Math.Log10(1 - rnd));
                    vector[i] = x;
                    grilla_exponencial.Rows.Add(rnd, (Math.Truncate(vector[i] * 10000) / 10000));
                    grilla_exponencial.Refresh();

                }

                else { MessageBox.Show("debe seleccionar un parametro"); }

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
                txt_lambda_exp.Visible = false;
                txt_media_exp.Visible = true;
            }

            if (selectedItem.ToString() == "lambda")
            {
                txt_media_exp.Visible = false;
                txt_lambda_exp.Visible = true;
            }
        }

        private void btn_generar_exp_Click(object sender, EventArgs e)
        {
            if (txt_muestra_exp.Text == "")
            {
                MessageBox.Show("debe especificar la cantidad de numeros a generar");
            }

            else { agregarFilaAGrilla(); }
        }
    }
}
