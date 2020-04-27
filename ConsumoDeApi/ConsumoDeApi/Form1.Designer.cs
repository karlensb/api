namespace ConsumoDeApi
{
    partial class Form1
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
            this.txtPas = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPasInvalido = new System.Windows.Forms.Label();
            this.chkApiSegura = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(97, 105);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(82, 20);
            this.txtPas.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(97, 68);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(82, 20);
            this.txtUser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pasword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // lblPasInvalido
            // 
            this.lblPasInvalido.AutoSize = true;
            this.lblPasInvalido.Location = new System.Drawing.Point(94, 202);
            this.lblPasInvalido.Name = "lblPasInvalido";
            this.lblPasInvalido.Size = new System.Drawing.Size(83, 13);
            this.lblPasInvalido.TabIndex = 11;
            this.lblPasInvalido.Text = "Usuario Invalido";
            this.lblPasInvalido.Visible = false;
            // 
            // chkApiSegura
            // 
            this.chkApiSegura.AutoSize = true;
            this.chkApiSegura.Location = new System.Drawing.Point(205, 68);
            this.chkApiSegura.Name = "chkApiSegura";
            this.chkApiSegura.Size = new System.Drawing.Size(119, 21);
            this.chkApiSegura.TabIndex = 12;
            this.chkApiSegura.Text = "Utilizar Api Segura";
            this.chkApiSegura.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.chkApiSegura);
            this.Controls.Add(this.lblPasInvalido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPasInvalido;
        private System.Windows.Forms.CheckBox chkApiSegura;
    }
}

