namespace VariablesAleatorias.Formularios
{
    partial class PopUp_Intervalos
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.cmb_intervalos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 84);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(113, 37);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(180, 88);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(111, 33);
            this.btn_Continuar.TabIndex = 1;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // cmb_intervalos
            // 
            this.cmb_intervalos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_intervalos.FormattingEnabled = true;
            this.cmb_intervalos.Location = new System.Drawing.Point(151, 31);
            this.cmb_intervalos.Name = "cmb_intervalos";
            this.cmb_intervalos.Size = new System.Drawing.Size(94, 21);
            this.cmb_intervalos.TabIndex = 0;
            this.cmb_intervalos.Text = "Intervalos";
            this.cmb_intervalos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intervalos: ";
            // 
            // PopUp_Intervalos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_intervalos);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.btn_Volver);
            this.Name = "PopUp_Intervalos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intervalos";
            this.Load += new System.EventHandler(this.PopUp_Intervalos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.ComboBox cmb_intervalos;
        private System.Windows.Forms.Label label1;
    }
}