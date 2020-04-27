namespace ConsumoDeApi
{
    partial class FormularioProvincias
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescriocionProvincia = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(174, 83);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(130, 20);
            this.txtProvincia.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Provincia a Buscar";
            // 
            // lblDescriocionProvincia
            // 
            this.lblDescriocionProvincia.AutoSize = true;
            this.lblDescriocionProvincia.Location = new System.Drawing.Point(92, 140);
            this.lblDescriocionProvincia.Name = "lblDescriocionProvincia";
            this.lblDescriocionProvincia.Size = new System.Drawing.Size(172, 13);
            this.lblDescriocionProvincia.TabIndex = 14;
            this.lblDescriocionProvincia.Text = "La Provincia No se fue encontrada";
            this.lblDescriocionProvincia.Visible = false;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(12, 171);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(0, 13);
            this.lblToken.TabIndex = 15;
            this.lblToken.Visible = false;
            // 
            // FormularioProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 205);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.lblDescriocionProvincia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label1);
            this.Name = "FormularioProvincias";
            this.Text = "Buscar Lat y Lon";
            this.Load += new System.EventHandler(this.FormularioProvincias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescriocionProvincia;
        private System.Windows.Forms.Label lblToken;
    }
}