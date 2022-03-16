
namespace SGReservadorDavidMagdaleno
{
    partial class frmInformes
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
            this.dgvInformes = new System.Windows.Forms.DataGridView();
            this.btnAulaReserva = new System.Windows.Forms.Button();
            this.btnAulasBorradas = new System.Windows.Forms.Button();
            this.btnUsuariosReservas = new System.Windows.Forms.Button();
            this.btnUsuMedia = new System.Windows.Forms.Button();
            this.btnResevAntigua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformes
            // 
            this.dgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformes.Location = new System.Drawing.Point(12, 100);
            this.dgvInformes.Name = "dgvInformes";
            this.dgvInformes.Size = new System.Drawing.Size(449, 338);
            this.dgvInformes.TabIndex = 0;
            // 
            // btnAulaReserva
            // 
            this.btnAulaReserva.Location = new System.Drawing.Point(12, 36);
            this.btnAulaReserva.Name = "btnAulaReserva";
            this.btnAulaReserva.Size = new System.Drawing.Size(75, 23);
            this.btnAulaReserva.TabIndex = 1;
            this.btnAulaReserva.Text = "Consulta 1";
            this.btnAulaReserva.UseVisualStyleBackColor = true;
            this.btnAulaReserva.Click += new System.EventHandler(this.btnAulaReserva_Click);
            // 
            // btnAulasBorradas
            // 
            this.btnAulasBorradas.Location = new System.Drawing.Point(105, 36);
            this.btnAulasBorradas.Name = "btnAulasBorradas";
            this.btnAulasBorradas.Size = new System.Drawing.Size(75, 23);
            this.btnAulasBorradas.TabIndex = 2;
            this.btnAulasBorradas.Text = "Consulta 2";
            this.btnAulasBorradas.UseVisualStyleBackColor = true;
            this.btnAulasBorradas.Click += new System.EventHandler(this.btnAulasBorradas_Click);
            // 
            // btnUsuariosReservas
            // 
            this.btnUsuariosReservas.Location = new System.Drawing.Point(197, 36);
            this.btnUsuariosReservas.Name = "btnUsuariosReservas";
            this.btnUsuariosReservas.Size = new System.Drawing.Size(75, 23);
            this.btnUsuariosReservas.TabIndex = 3;
            this.btnUsuariosReservas.Text = "Consulta 3";
            this.btnUsuariosReservas.UseVisualStyleBackColor = true;
            this.btnUsuariosReservas.Click += new System.EventHandler(this.btnUsuariosReservas_Click);
            // 
            // btnUsuMedia
            // 
            this.btnUsuMedia.Location = new System.Drawing.Point(290, 36);
            this.btnUsuMedia.Name = "btnUsuMedia";
            this.btnUsuMedia.Size = new System.Drawing.Size(75, 23);
            this.btnUsuMedia.TabIndex = 4;
            this.btnUsuMedia.Text = "Consulta 4";
            this.btnUsuMedia.UseVisualStyleBackColor = true;
            this.btnUsuMedia.Click += new System.EventHandler(this.btnUsuMedia_Click);
            // 
            // btnResevAntigua
            // 
            this.btnResevAntigua.Location = new System.Drawing.Point(386, 36);
            this.btnResevAntigua.Name = "btnResevAntigua";
            this.btnResevAntigua.Size = new System.Drawing.Size(75, 23);
            this.btnResevAntigua.TabIndex = 5;
            this.btnResevAntigua.Text = "Consulta 5";
            this.btnResevAntigua.UseVisualStyleBackColor = true;
            this.btnResevAntigua.Click += new System.EventHandler(this.btnResevAntigua_Click);
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btnResevAntigua);
            this.Controls.Add(this.btnUsuMedia);
            this.Controls.Add(this.btnUsuariosReservas);
            this.Controls.Add(this.btnAulasBorradas);
            this.Controls.Add(this.btnAulaReserva);
            this.Controls.Add(this.dgvInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInformes;
        private System.Windows.Forms.Button btnAulaReserva;
        private System.Windows.Forms.Button btnAulasBorradas;
        private System.Windows.Forms.Button btnUsuariosReservas;
        private System.Windows.Forms.Button btnUsuMedia;
        private System.Windows.Forms.Button btnResevAntigua;
    }
}