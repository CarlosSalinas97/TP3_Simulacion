namespace VariablesAleatorias.Formularios
{
    partial class Generador_Normal
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
            this.txt_media = new System.Windows.Forms.TextBox();
            this.txt_desviacion = new System.Windows.Forms.TextBox();
            this.Muestra = new System.Windows.Forms.Label();
            this.txt_muestra = new System.Windows.Forms.TextBox();
            this.grilla_normal = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_histograma = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_normal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desviacion";
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(141, 104);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(72, 20);
            this.txt_media.TabIndex = 1;
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.Location = new System.Drawing.Point(141, 150);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.Size = new System.Drawing.Size(72, 20);
            this.txt_desviacion.TabIndex = 2;
            // 
            // Muestra
            // 
            this.Muestra.AutoSize = true;
            this.Muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muestra.Location = new System.Drawing.Point(57, 199);
            this.Muestra.Name = "Muestra";
            this.Muestra.Size = new System.Drawing.Size(55, 16);
            this.Muestra.TabIndex = 4;
            this.Muestra.Text = "Muestra";
            // 
            // txt_muestra
            // 
            this.txt_muestra.Location = new System.Drawing.Point(141, 198);
            this.txt_muestra.Name = "txt_muestra";
            this.txt_muestra.Size = new System.Drawing.Size(72, 20);
            this.txt_muestra.TabIndex = 3;
            // 
            // grilla_normal
            // 
            this.grilla_normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_normal.Location = new System.Drawing.Point(338, 12);
            this.grilla_normal.Name = "grilla_normal";
            this.grilla_normal.Size = new System.Drawing.Size(364, 303);
            this.grilla_normal.TabIndex = 7;
            this.grilla_normal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Generador Normal";
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(12, 242);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(100, 50);
            this.btn_generar.TabIndex = 4;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
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
            this.btn_volver.Location = new System.Drawing.Point(224, 242);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(100, 50);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(12, 298);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(312, 17);
            this.progress_bar.TabIndex = 10;
            // 
            // Generador_Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 327);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_histograma);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grilla_normal);
            this.Controls.Add(this.txt_muestra);
            this.Controls.Add(this.Muestra);
            this.Controls.Add(this.txt_desviacion);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generador_Normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Normal";
            this.Load += new System.EventHandler(this.Generador_Normal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_normal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.TextBox txt_desviacion;
        private System.Windows.Forms.Label Muestra;
        private System.Windows.Forms.TextBox txt_muestra;
        private System.Windows.Forms.DataGridView grilla_normal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_histograma;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ProgressBar progress_bar;
    }
}