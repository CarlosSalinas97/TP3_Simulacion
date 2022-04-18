
namespace VariablesAleatorias
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Generador_Uniforme = new System.Windows.Forms.Button();
            this.btn_Generador_Normal = new System.Windows.Forms.Button();
            this.btn_Generador_Exponencial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Generador_Uniforme
            // 
            this.btn_Generador_Uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generador_Uniforme.Location = new System.Drawing.Point(100, 50);
            this.btn_Generador_Uniforme.Name = "btn_Generador_Uniforme";
            this.btn_Generador_Uniforme.Size = new System.Drawing.Size(200, 50);
            this.btn_Generador_Uniforme.TabIndex = 0;
            this.btn_Generador_Uniforme.Text = "Generador Uniforme";
            this.btn_Generador_Uniforme.UseVisualStyleBackColor = true;
            this.btn_Generador_Uniforme.Click += new System.EventHandler(this.btn_Generador_Uniforme_Click);
            // 
            // btn_Generador_Normal
            // 
            this.btn_Generador_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generador_Normal.Location = new System.Drawing.Point(100, 125);
            this.btn_Generador_Normal.Name = "btn_Generador_Normal";
            this.btn_Generador_Normal.Size = new System.Drawing.Size(200, 50);
            this.btn_Generador_Normal.TabIndex = 1;
            this.btn_Generador_Normal.Text = "Generador Normal";
            this.btn_Generador_Normal.UseVisualStyleBackColor = true;
            this.btn_Generador_Normal.Click += new System.EventHandler(this.btn_Generador_Normal_Click);
            // 
            // btn_Generador_Exponencial
            // 
            this.btn_Generador_Exponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generador_Exponencial.Location = new System.Drawing.Point(100, 200);
            this.btn_Generador_Exponencial.Name = "btn_Generador_Exponencial";
            this.btn_Generador_Exponencial.Size = new System.Drawing.Size(200, 50);
            this.btn_Generador_Exponencial.TabIndex = 2;
            this.btn_Generador_Exponencial.Text = "Generador Exponencial";
            this.btn_Generador_Exponencial.UseVisualStyleBackColor = true;
            this.btn_Generador_Exponencial.Click += new System.EventHandler(this.btn_Generador_Exponencial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo 6 - SIM 4K3 2022";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Generador_Exponencial);
            this.Controls.Add(this.btn_Generador_Normal);
            this.Controls.Add(this.btn_Generador_Uniforme);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 Simulación";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generador_Uniforme;
        private System.Windows.Forms.Button btn_Generador_Normal;
        private System.Windows.Forms.Button btn_Generador_Exponencial;
        private System.Windows.Forms.Label label1;
    }
}

