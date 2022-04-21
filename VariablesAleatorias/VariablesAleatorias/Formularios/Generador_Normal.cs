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
    public partial class Generador_Normal : Form
    {
        double media;
        double desviacion;
        int muestra;
        private Random random = new Random();
        double[] vector;
        DataTable data_table;

        public Generador_Normal()
        {
            InitializeComponent();
        }

        private void crear_data_table()
        {
            data_table = new DataTable();
            data_table.Columns.Add("Muestra");
            data_table.Columns.Add("RND");
            data_table.Columns.Add("Nro normal generado");
        }

        private void Generador_Normal_Load(object sender, EventArgs e)
        {
            btn_histograma.Enabled = false;
            txt_media.Text = "0";
            txt_desviacion.Text = "1";
            txt_muestra.Text = "5";
        }

        public void generarNormal()
        {
            vector = new double[muestra];        

            for (int i = 0; i < muestra; i++)
            {
                progress_bar.Value = (int)(100 / Convert.ToDouble(muestra) * (i + 1));

                double aux1 = Decimal_Utils.limitar_4_decimales(random.NextDouble());
                double aux2 = Decimal_Utils.limitar_4_decimales(random.NextDouble());

                aux1 = aux1 == 0 ? 1 : aux1;
                aux2 = aux2 == 0 ? 1 : aux2;

                double z = Decimal_Utils.limitar_4_decimales(Math.Sqrt(-2 * Math.Log(aux1)) * Math.Sin(2 * Math.PI * aux2) * desviacion + media);
                double z2 = Decimal_Utils.limitar_4_decimales(Math.Sqrt(-2 * Math.Log(aux1)) * Math.Cos(2 * Math.PI * aux2) * desviacion + media);

                data_table.Rows.Add(i+1, aux1, z);
                vector[i] = z;

                i++;

                data_table.Rows.Add(i+1, aux2, z2);
                vector[i] = z2;
            }

            grilla_normal.DataSource = data_table;
            progress_bar.Value = 100;
            btn_histograma.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_desviacion.Text) || string.IsNullOrEmpty(txt_media.Text) || string.IsNullOrEmpty(txt_muestra.Text)) {
                MessageBox.Show("Uno de los parámetros está vacío.");
            } else
            {
                btn_histograma.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                media = double.Parse(txt_media.Text);
                desviacion = double.Parse(txt_desviacion.Text);
                muestra = int.Parse(txt_muestra.Text);
                crear_data_table();
                grilla_normal.VirtualMode = true;

                generarNormal();
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
