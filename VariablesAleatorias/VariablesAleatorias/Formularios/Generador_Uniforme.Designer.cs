﻿
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_muestra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generar_uniforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_uniforme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
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
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limite Superior";
            // 
            // grilla_uniforme
            // 
            this.grilla_uniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_uniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grilla_uniforme.Location = new System.Drawing.Point(273, 92);
            this.grilla_uniforme.Name = "grilla_uniforme";
            this.grilla_uniforme.Size = new System.Drawing.Size(361, 177);
            this.grilla_uniforme.TabIndex = 6;
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
            this.Column3.HeaderText = "Numero Uniforme Gnerado";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // txt_muestra
            // 
            this.txt_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_muestra.Location = new System.Drawing.Point(141, 199);
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
            this.btn_generar_uniforme.Location = new System.Drawing.Point(24, 257);
            this.btn_generar_uniforme.Name = "btn_generar_uniforme";
            this.btn_generar_uniforme.Size = new System.Drawing.Size(93, 48);
            this.btn_generar_uniforme.TabIndex = 4;
            this.btn_generar_uniforme.Text = "Generar";
            this.btn_generar_uniforme.UseVisualStyleBackColor = true;
            this.btn_generar_uniforme.Click += new System.EventHandler(this.btn_generar_uniforme_Click);
            // 
            // Generador_Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 333);
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
            this.Text = "Generador_Uniforme";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_generar_uniforme;
    }
}