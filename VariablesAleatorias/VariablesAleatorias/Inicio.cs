using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VariablesAleatorias.Formularios;

namespace VariablesAleatorias
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_Generador_Uniforme_Click(object sender, EventArgs e)
        {
            Generador_Uniforme form_generador_uniforme = new Generador_Uniforme();
            form_generador_uniforme.Show();
        }

        private void btn_Generador_Normal_Click(object sender, EventArgs e)
        {
            Generador_Normal form_generador_normal = new Generador_Normal();
            form_generador_normal.Show();
        }

        private void btn_Generador_Exponencial_Click(object sender, EventArgs e)
        {
            Generador_Variable_Exponencial form_generador_exponencial = new Generador_Variable_Exponencial();
            form_generador_exponencial.Show();
        }
    }
}
