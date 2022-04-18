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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHistograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_normal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desviacion";
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(114, 69);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(72, 20);
            this.txt_media.TabIndex = 2;
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.Location = new System.Drawing.Point(114, 118);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.Size = new System.Drawing.Size(72, 20);
            this.txt_desviacion.TabIndex = 3;
            // 
            // Muestra
            // 
            this.Muestra.AutoSize = true;
            this.Muestra.Location = new System.Drawing.Point(31, 169);
            this.Muestra.Name = "Muestra";
            this.Muestra.Size = new System.Drawing.Size(45, 13);
            this.Muestra.TabIndex = 4;
            this.Muestra.Text = "Muestra";
            // 
            // txt_muestra
            // 
            this.txt_muestra.Location = new System.Drawing.Point(114, 162);
            this.txt_muestra.Name = "txt_muestra";
            this.txt_muestra.Size = new System.Drawing.Size(72, 20);
            this.txt_muestra.TabIndex = 5;
            // 
            // grilla_normal
            // 
            this.grilla_normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_normal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grilla_normal.Location = new System.Drawing.Point(265, 69);
            this.grilla_normal.Name = "grilla_normal";
            this.grilla_normal.Size = new System.Drawing.Size(361, 177);
            this.grilla_normal.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Muestra";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RND";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numero Normal Gnerado";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(34, 223);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Generador Normal";
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(34, 252);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(75, 23);
            this.btnHistograma.TabIndex = 10;
            this.btnHistograma.Text = "Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // Generador_Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 307);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grilla_normal);
            this.Controls.Add(this.txt_muestra);
            this.Controls.Add(this.Muestra);
            this.Controls.Add(this.txt_desviacion);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generador_Normal";
            this.Text = "Generador_Normal";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHistograma;
    }
}