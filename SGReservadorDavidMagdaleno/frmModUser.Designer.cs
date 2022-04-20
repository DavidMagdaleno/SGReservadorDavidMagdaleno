
namespace SGReservadorDavidMagdaleno
{
    partial class frmModUser
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
            this.btnSalirMod = new System.Windows.Forms.Button();
            this.btnAcepMod = new System.Windows.Forms.Button();
            this.cbPerfilMod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailMod = new System.Windows.Forms.TextBox();
            this.txtPWMod = new System.Windows.Forms.TextBox();
            this.txtLogMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirMod
            // 
            this.btnSalirMod.Location = new System.Drawing.Point(248, 196);
            this.btnSalirMod.Name = "btnSalirMod";
            this.btnSalirMod.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMod.TabIndex = 19;
            this.btnSalirMod.Text = "SALIR";
            this.btnSalirMod.UseVisualStyleBackColor = true;
            this.btnSalirMod.Click += new System.EventHandler(this.btnSalirMod_Click);
            // 
            // btnAcepMod
            // 
            this.btnAcepMod.Location = new System.Drawing.Point(112, 196);
            this.btnAcepMod.Name = "btnAcepMod";
            this.btnAcepMod.Size = new System.Drawing.Size(75, 23);
            this.btnAcepMod.TabIndex = 18;
            this.btnAcepMod.Text = "MODIFICAR";
            this.btnAcepMod.UseVisualStyleBackColor = true;
            this.btnAcepMod.Click += new System.EventHandler(this.btnAcepMod_Click);
            // 
            // cbPerfilMod
            // 
            this.cbPerfilMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfilMod.FormattingEnabled = true;
            this.cbPerfilMod.Location = new System.Drawing.Point(179, 134);
            this.cbPerfilMod.Name = "cbPerfilMod";
            this.cbPerfilMod.Size = new System.Drawing.Size(121, 21);
            this.cbPerfilMod.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Perfil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña:";
            // 
            // txtEmailMod
            // 
            this.txtEmailMod.Location = new System.Drawing.Point(179, 96);
            this.txtEmailMod.Name = "txtEmailMod";
            this.txtEmailMod.Size = new System.Drawing.Size(100, 20);
            this.txtEmailMod.TabIndex = 13;
            // 
            // txtPWMod
            // 
            this.txtPWMod.Location = new System.Drawing.Point(179, 60);
            this.txtPWMod.Name = "txtPWMod";
            this.txtPWMod.Size = new System.Drawing.Size(100, 20);
            this.txtPWMod.TabIndex = 12;
            // 
            // txtLogMod
            // 
            this.txtLogMod.Location = new System.Drawing.Point(179, 21);
            this.txtLogMod.Name = "txtLogMod";
            this.txtLogMod.ReadOnly = true;
            this.txtLogMod.Size = new System.Drawing.Size(100, 20);
            this.txtLogMod.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login:";
            // 
            // frmModUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 241);
            this.Controls.Add(this.btnSalirMod);
            this.Controls.Add(this.btnAcepMod);
            this.Controls.Add(this.cbPerfilMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailMod);
            this.Controls.Add(this.txtPWMod);
            this.Controls.Add(this.txtLogMod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirMod;
        private System.Windows.Forms.Button btnAcepMod;
        private System.Windows.Forms.ComboBox cbPerfilMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailMod;
        private System.Windows.Forms.TextBox txtPWMod;
        private System.Windows.Forms.TextBox txtLogMod;
        private System.Windows.Forms.Label label1;
    }
}