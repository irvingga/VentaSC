namespace SisVentasCS
{
    partial class FormRecuperarContraseña
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
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.buttonRecuperar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(179, 28);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(147, 20);
            this.txtCurp.TabIndex = 0;
            // 
            // buttonRecuperar
            // 
            this.buttonRecuperar.Location = new System.Drawing.Point(372, 25);
            this.buttonRecuperar.Name = "buttonRecuperar";
            this.buttonRecuperar.Size = new System.Drawing.Size(75, 23);
            this.buttonRecuperar.TabIndex = 1;
            this.buttonRecuperar.Text = "Recuperar";
            this.buttonRecuperar.UseVisualStyleBackColor = true;
            this.buttonRecuperar.Click += new System.EventHandler(this.buttonRecuperar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(28, 54);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(298, 78);
            this.txtMensaje.TabIndex = 2;
            // 
            // FormRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 222);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.buttonRecuperar);
            this.Controls.Add(this.txtCurp);
            this.Name = "FormRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecuperarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Button buttonRecuperar;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}