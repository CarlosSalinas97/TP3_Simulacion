
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_generar_exp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_exponencial)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generador Exponencial";
            // 
            // txt_muestra_exp
            // 
            this.txt_muestra_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_muestra_exp.Location = new System.Drawing.Point(101, 226);
            this.txt_muestra_exp.Name = "txt_muestra_exp";
            this.txt_muestra_exp.Size = new System.Drawing.Size(66, 23);
            this.txt_muestra_exp.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "muestra";
            // 
            // txt_media_exp
            // 
            this.txt_media_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_media_exp.Location = new System.Drawing.Point(101, 168);
            this.txt_media_exp.Name = "txt_media_exp";
            this.txt_media_exp.Size = new System.Drawing.Size(66, 23);
            this.txt_media_exp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "media";
            // 
            // txt_lambda_exp
            // 
            this.txt_lambda_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lambda_exp.Location = new System.Drawing.Point(101, 111);
            this.txt_lambda_exp.Name = "txt_lambda_exp";
            this.txt_lambda_exp.Size = new System.Drawing.Size(66, 23);
            this.txt_lambda_exp.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "lambda";
            // 
            // cmb_exponencial
            // 
            this.cmb_exponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_exponencial.FormattingEnabled = true;
            this.cmb_exponencial.Items.AddRange(new object[] {
            "media",
            "lambda"});
            this.cmb_exponencial.Location = new System.Drawing.Point(217, 111);
            this.cmb_exponencial.Name = "cmb_exponencial";
            this.cmb_exponencial.Size = new System.Drawing.Size(121, 24);
            this.cmb_exponencial.TabIndex = 15;
            this.cmb_exponencial.SelectionChangeCommitted += new System.EventHandler(this.cmb_exponencial_SelectionChangeCommitted);
            // 
            // grilla_exponencial
            // 
            this.grilla_exponencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_exponencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grilla_exponencial.Location = new System.Drawing.Point(217, 168);
            this.grilla_exponencial.Name = "grilla_exponencial";
            this.grilla_exponencial.Size = new System.Drawing.Size(273, 150);
            this.grilla_exponencial.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RND";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NRO GENERADO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // btn_generar_exp
            // 
            this.btn_generar_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_exp.Location = new System.Drawing.Point(39, 294);
            this.btn_generar_exp.Name = "btn_generar_exp";
            this.btn_generar_exp.Size = new System.Drawing.Size(86, 50);
            this.btn_generar_exp.TabIndex = 17;
            this.btn_generar_exp.Text = "Generar";
            this.btn_generar_exp.UseVisualStyleBackColor = true;
            this.btn_generar_exp.Click += new System.EventHandler(this.btn_generar_exp_Click);
            // 
            // Generador_Variable_Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 400);
            this.Controls.Add(this.btn_generar_exp);
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
            this.Text = "Generador_Variable_Exponencial";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_generar_exp;
    }
}