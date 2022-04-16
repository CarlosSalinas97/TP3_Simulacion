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
        

        public Generador_Uniforme()
        {
            InitializeComponent();
        }

        private void Generador_Uniforme_Load(object sender, EventArgs e)
        {
            
        }

        public void agregarFilaAGrilla()
        {
            double[] vector = new Double[int.Parse(txt_muestra.Text)];
            double x = 0;


            for (int i = 0; i < int.Parse(txt_muestra.Text); i++)
            {
                double rnd = generarNroAleatorio();
                x = double.Parse(txt_limite_inferior.Text) + rnd * ( double.Parse(txt_limite_superior.Text) -
                                 double.Parse(txt_limite_inferior.Text) );

                vector[i] = x;
                grilla_uniforme.Rows.Add( i+1, rnd, vector[i] );
            }
            

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
            agregarFilaAGrilla();
        }
    }
}
