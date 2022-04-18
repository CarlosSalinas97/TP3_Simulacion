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
    public partial class PopUp_Intervalos : Form
    {
        private int intervalos_seleccionado;
        private string generador;
        public double[] serie_generada;

        public PopUp_Intervalos(string generador_seleccionado)
        {
            InitializeComponent();
            generador = generador_seleccionado;
        }

        private void PopUp_Intervalos_Load(object sender, EventArgs e)
        {
            cmb_intervalos.Items.Add(5);
            cmb_intervalos.Items.Add(10);
            cmb_intervalos.Items.Add(15);
            cmb_intervalos.Items.Add(20);
            btn_Continuar.Enabled = false;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            Histograma formHistograma = new Histograma(generador);
            formHistograma.intervalos_seleccionado = intervalos_seleccionado;
            formHistograma.serie_generada = serie_generada;
            formHistograma.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            intervalos_seleccionado = (int)cmb_intervalos.SelectedItem;
            btn_Continuar.Enabled = true;
        }
    }
}
