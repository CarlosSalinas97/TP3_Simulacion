
namespace VariablesAleatorias.Formularios
{
    partial class Generador_Variable_Exponencial
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_muestra_exp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_media_exp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lambda_exp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_exponencial = new System.Windows.Forms.ComboBox();
            this.grilla_exponencial = new System.Windows.Forms.DataGridView();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_histograma = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_exponencial)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generador Exponencial";
            // 
            // txt_muestra_exp
            // 
            this.txt_muestra_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_muestra_exp.Location = new System.Drawing.Point(200, 245);
            this.txt_muestra_exp.Name = "txt_muestra_exp";
            this.txt_muestra_exp.Size = new System.Drawing.Size(85, 29);
            this.txt_muestra_exp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Muestra";
            // 
            // txt_media_exp
            // 
            this.txt_media_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_media_exp.Location = new System.Drawing.Point(200, 155);
            this.txt_media_exp.Name = "txt_media_exp";
            this.txt_media_exp.Size = new System.Drawing.Size(85, 29);
            this.txt_media_exp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Media";
            // 
            // txt_lambda_exp
            // 
            this.txt_lambda_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lambda_exp.Location = new System.Drawing.Point(200, 200);
            this.txt_lambda_exp.Name = "txt_lambda_exp";
            this.txt_lambda_exp.Size = new System.Drawing.Size(85, 29);
            this.txt_lambda_exp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lambda";
            // 
            // cmb_exponencial
            // 
            this.cmb_exponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_exponencial.FormattingEnabled = true;
            this.cmb_exponencial.Items.AddRange(new object[] {
            "media",
            "lambda"});
            this.cmb_exponencial.Location = new System.Drawing.Point(173, 100);
            this.cmb_exponencial.Name = "cmb_exponencial";
            this.cmb_exponencial.Size = new System.Drawing.Size(121, 32);
            this.cmb_exponencial.TabIndex = 1;
            this.cmb_exponencial.SelectionChangeCommitted += new System.EventHandler(this.cmb_exponencial_SelectionChangeCommitted);
            // 
            // grilla_exponencial
            // 
            this.grilla_exponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_exponencial.Location = new System.Drawing.Point(366, 12);
            this.grilla_exponencial.Name = "grilla_exponencial";
            this.grilla_exponencial.Size = new System.Drawing.Size(356, 537);
            this.grilla_exponencial.TabIndex = 16;
            this.grilla_exponencial.TabStop = false;
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(12, 327);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(110, 50);
            this.btn_generar.TabIndex = 5;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_exp_Click);
            // 
            // btn_histograma
            // 
            this.btn_histograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_histograma.Location = new System.Drawing.Point(128, 327);
            this.btn_histograma.Name = "btn_histograma";
            this.btn_histograma.Size = new System.Drawing.Size(116, 50);
            this.btn_histograma.TabIndex = 6;
            this.btn_histograma.Text = "Histograma";
            this.btn_histograma.UseVisualStyleBackColor = true;
            this.btn_histograma.Click += new System.EventHandler(this.btn_histograma_exp_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(250, 327);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(110, 50);
            this.btn_volver.TabIndex = 7;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(12, 383);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(348, 17);
            this.progress_bar.TabIndex = 17;
            // 
            // Generador_Variable_Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_histograma);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.grilla_exponencial);
            this.Controls.Add(this.cmb_exponencial);
            this.Controls.Add(this.txt_muestra_exp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_media_exp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lambda_exp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Generador_Variable_Exponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Exponencial";
            this.Load += new System.EventHandler(this.Generador_Variable_Exponencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_exponencial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_muestra_exp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_media_exp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lambda_exp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_exponencial;
        private System.Windows.Forms.DataGridView grilla_exponencial;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_histograma;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ProgressBar progress_bar;
    }
}