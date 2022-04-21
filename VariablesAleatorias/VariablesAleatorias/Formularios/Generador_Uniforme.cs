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
    public partial class Generador_Uniforme : Form
    {
        private double[] vector;
        Random random = new Random();
        DataTable data_table;

        public Generador_Uniforme()
        {
            InitializeComponent();   
        }

        private void Generador_Uniforme_Load(object sender, EventArgs e)
        {
            btn_histograma.Enabled = false;
        }

        private void crear_data_table()
        {
            data_table = new DataTable();
            data_table.Columns.Add("Muestra");
            data_table.Columns.Add("RND");
            data_table.Columns.Add("Nro uniforme generado");
        }

        public void agregarFilaAGrilla()
        {
            crear_data_table();
            btn_histograma.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            grilla_uniforme.VirtualMode = true;
          
            double limite_inferior = double.Parse(txt_limite_inferior.Text);
            double limite_superior = double.Parse(txt_limite_superior.Text);
            int N = int.Parse(txt_muestra.Text);
            vector = new double[N];
            double aux = 0.0;

            for (int i = 0; i < N; i++)
            {
                progress_bar.Value = (int) (100 / double.Parse(N.ToString()) * (i + 1));
                double rnd = Decimal_Utils.limitar_4_decimales(random.NextDouble());
                aux = (limite_superior - limite_inferior) * rnd + limite_inferior;

                data_table.Rows.Add(i + 1, rnd, aux);
                vector[i] = aux;
            }

            grilla_uniforme.DataSource = data_table;

            progress_bar.Value = 100;
            btn_histograma.Enabled = true;
            Cursor.Current = Cursors.Default;
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
