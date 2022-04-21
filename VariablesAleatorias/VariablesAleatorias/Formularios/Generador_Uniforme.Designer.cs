
namespace VariablesAleatorias.Formularios
{
    partial class Generador_Uniforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_limite_inferior = new System.Windows.Forms.TextBox();
            this.txt_limite_superior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grilla_uniforme = new System.Windows.Forms.DataGridView();
            this.txt_muestra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generar_uniforme = new System.Windows.Forms.Button();
            this.btn_histograma = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_uniforme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador Uniforme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite Inferior";
            // 
            // txt_limite_inferior
            // 
            this.txt_limite_inferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limite_inferior.Location = new System.Drawing.Point(144, 92);
            this.txt_limite_inferior.Name = "txt_limite_inferior";
            this.txt_limite_inferior.Size = new System.Drawing.Size(68, 23);
            this.txt_limite_inferior.TabIndex = 1;
            // 
            // txt_limite_superior
            // 
            this.txt_limite_superior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limite_superior.Location = new System.Drawing.Point(144, 146);
            this.txt_limite_superior.Name = "txt_limite_superior";
            this.txt_limite_superior.Size = new System.Drawing.Size(68, 23);
            this.txt_limite_superior.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limite Superior";
            // 
            // grilla_uniforme
            // 
            this.grilla_uniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_uniforme.Location = new System.Drawing.Point(330, 30);
            this.grilla_uniforme.Name = "grilla_uniforme";
            this.grilla_uniforme.Size = new System.Drawing.Size(372, 285);
            this.grilla_uniforme.TabIndex = 6;
            this.grilla_uniforme.TabStop = false;
            // 
            // txt_muestra
            // 
            this.txt_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_muestra.Location = new System.Drawing.Point(144, 199);
            this.txt_muestra.Name = "txt_muestra";
            this.txt_muestra.Size = new System.Drawing.Size(68, 23);
            this.txt_muestra.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Muestra";
            // 
            // btn_generar_uniforme
            // 
            this.btn_generar_uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_uniforme.Location = new System.Drawing.Point(12, 242);
            this.btn_generar_uniforme.Name = "btn_generar_uniforme";
            this.btn_generar_uniforme.Size = new System.Drawing.Size(100, 50);
            this.btn_generar_uniforme.TabIndex = 4;
            this.btn_generar_uniforme.Text = "Generar";
            this.btn_generar_uniforme.UseVisualStyleBackColor = true;
            this.btn_generar_uniforme.Click += new System.EventHandler(this.btn_generar_uniforme_Click);
            // 
            // btn_histograma
            // 
            this.btn_histograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_histograma.Location = new System.Drawing.Point(118, 242);
            this.btn_histograma.Name = "btn_histograma";
            this.btn_histograma.Size = new System.Drawing.Size(100, 50);
            this.btn_histograma.TabIndex = 5;
            this.btn_histograma.Text = "Histograma";
            this.btn_histograma.UseVisualStyleBackColor = true;
            this.btn_histograma.Click += new System.EventHandler(this.btn_histograma_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(223, 242);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(100, 50);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(12, 298);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(311, 17);
            this.progress_bar.TabIndex = 8;
            // 
            // Generador_Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 327);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_histograma);
            this.Controls.Add(this.btn_generar_uniforme);
            this.Controls.Add(this.txt_muestra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grilla_uniforme);
            this.Controls.Add(this.txt_limite_superior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_limite_inferior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generador_Uniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Uniforme";
            this.Load += new System.EventHandler(this.Generador_Uniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_uniforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_limite_inferior;
        private System.Windows.Forms.TextBox txt_limite_superior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla_uniforme;
        private System.Windows.Forms.TextBox txt_muestra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_generar_uniforme;
        private System.Windows.Forms.Button btn_histograma;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ProgressBar progress_bar;
    }
}