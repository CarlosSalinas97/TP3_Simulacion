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
    public partial class Generador_Uniforme : Form
    {
        private double[] vector;

        public Generador_Uniforme()
        {
            InitializeComponent();
        }

        private void Generador_Uniforme_Load(object sender, EventArgs e)
        {
            btn_histograma.Enabled = false;
        }

        public void agregarFilaAGrilla()
        {
            btn_histograma.Enabled = false;
            grilla_uniforme.Rows.Clear();
            vector = new Double[int.Parse(txt_muestra.Text)];
            double x = 0;
            Cursor.Current = Cursors.WaitCursor;

            for (int i = 0; i < int.Parse(txt_muestra.Text); i++)
            {
                double rnd = generarNroAleatorio();
                x = double.Parse(txt_limite_inferior.Text) + rnd * ( double.Parse(txt_limite_superior.Text) -
                                 double.Parse(txt_limite_inferior.Text) );

                vector[i] = x;
                grilla_uniforme.Rows.Add( i+1, rnd, vector[i] );
                grilla_uniforme.Refresh();
            }
            btn_histograma.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

     

        public Double generarNroAleatorio()
        {
            Random nro = new Random();
            Double rnd;

            rnd = (Math.Truncate(nro.NextDouble() * 10000) / 10000);
            return rnd;
        }

        private void btn_generar_uniforme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_limite_inferior.Text) || string.IsNullOrEmpty(txt_limite_superior.Text) || string.IsNullOrEmpty(txt_muestra.Text))
            {
                MessageBox.Show("Uno de los parámetros está vacío.");
            } else
            {
                agregarFilaAGrilla();
            }
        }

        private void btn_histograma_Click(object sender, EventArgs e)
        {
            PopUp_Intervalos popUpForm = new PopUp_Intervalos("uniforme");
            popUpForm.serie_generada = vector;
            popUpForm.Show();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
