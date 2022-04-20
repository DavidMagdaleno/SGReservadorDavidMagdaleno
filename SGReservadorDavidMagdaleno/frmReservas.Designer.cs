
namespace SGReservadorDavidMagdaleno
{
    partial class frmReservas
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
            this.cb_aula = new System.Windows.Forms.ComboBox();
            this.pbReservas = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // cb_aula
            // 
            this.cb_aula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aula.FormattingEnabled = true;
            this.cb_aula.Location = new System.Drawing.Point(85, 35);
            this.cb_aula.Name = "cb_aula";
            this.cb_aula.Size = new System.Drawing.Size(121, 21);
            this.cb_aula.TabIndex = 2;
            this.cb_aula.SelectedIndexChanged += new System.EventHandler(this.cb_aula_SelectedIndexChanged);
            // 
            // pbReservas
            // 
            this.pbReservas.Location = new System.Drawing.Point(150, 96);
            this.pbReservas.Name = "pbReservas";
            this.pbReservas.Size = new System.Drawing.Size(222, 125);
            this.pbReservas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReservas.TabIndex = 4;
            this.pbReservas.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Location = new System.Drawing.Point(210, 241);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(12, 286);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(500, 150);
            this.dgvReservas.TabIndex = 6;
            this.dgvReservas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReservas_CellMouseClick);
            // 
            // btnReservar
            // 
            this.btnReservar.Enabled = false;
            this.btnReservar.Location = new System.Drawing.Point(210, 452);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(317, 36);
            this.dtFecha.MinDate = new System.DateTime(2022, 4, 20, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(159, 20);
            this.dtFecha.TabIndex = 8;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 496);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.pbReservas);
            this.Controls.Add(this.cb_aula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            ((System.ComponentModel.ISupportInitialize)(this.pbReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_aula;
        private System.Windows.Forms.PictureBox pbReservas;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}