using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGReservadorDavidMagdaleno
{
    public partial class frmReservas : Form
    {
        private string user = "";
        public frmReservas(string s)
        {
            InitializeComponent();
            cargarAulas();
            user = s;
            dtFecha.MinDate = DateTime.Today;
        }
        bool aux = false;
        bool aux2 = false;
        bool aux3 = true;

        List<String> codigoaula = new List<String>();

        reservadorDataSetTableAdapters.AULASTableAdapter Au = new reservadorDataSetTableAdapters.AULASTableAdapter();
        reservadorDataSet As = new reservadorDataSet();
        reservadorDataSetTableAdapters.RESERVASTableAdapter R = new reservadorDataSetTableAdapters.RESERVASTableAdapter();
        reservadorDataSet dsR = new reservadorDataSet();
        reservadorDataSetTableAdapters.USUARIOSTableAdapter Us= new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
        reservadorDataSet dsUs = new reservadorDataSet();
        //balonmanoDataSetTableAdapters.PARTIDOSTableAdapter Pa = new balonmanoDataSetTableAdapters.PARTIDOSTableAdapter();
        //balonmanoDataSet dsPa = new balonmanoDataSet();

        public void cargarAulas()
        {
            //cb_aula.Items.Add("Selecciona Aula");
            Au.FillByActivas(As.AULAS,0);
            for (int i = 0; i < As.AULAS.Count; i++)
            {
                cb_aula.Items.Add(As.AULAS[i].Descripcion);
                codigoaula.Add(As.AULAS[i].Cod_aula);
            }
        }

        private void cb_aula_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_aula.SelectedItem.ToString().Equals("Selecciona Aula"))
            if (cb_aula.SelectedIndex==-1)
            {
                dgvReservas.Rows.Clear();
                if (pbReservas.Image != null)
                {
                    pbReservas.Image.Dispose();
                    pbReservas.Image = null;
                }
            }
            else
            {
                dgvReservas.Rows.Clear();
                Au.FillByCod(As.AULAS, codigoaula[cb_aula.SelectedIndex]);
                DataRow myRow = As.AULAS.Rows[0];
                if (!myRow["Foto"].ToString().Equals(""))
                {
                    byte[] MyData = (byte[])myRow["Foto"];
                    MemoryStream stream = new MemoryStream(MyData);
                    pbReservas.Image = Image.FromStream(stream);
                }
                if (myRow["Foto"].ToString().Equals("")) {
                    
                    pbReservas.Image = null;
                }

                btnMostrar.Enabled = true;
                aux3 = false;
            }
        }
        
        //private void alaReserva()
        //{
        //    if (aux3)
        //    {
        //        btnReservar.Enabled = true;
        //    }
        //}

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            
        }
        bool p = true;
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnReservar.Enabled = true;
            dgvReservas.Rows.Clear();
            //bool aux = false;
            //R.FillByAula(dsR.RESERVAS, codigoaula[cb_aula.SelectedIndex], dtFecha.Value.ToString());
            if (p) {
                dgvReservas.Columns.Add("Aula", "Aula");
                dgvReservas.Columns.Add("Usuario", "Usuario");
                dgvReservas.Columns.Add("Hora", "Hora");
                dgvReservas.Columns.Add("Libre", "Libre");
                dgvReservas.Columns.Add("Id", "Id");
                p = false;
            }
            verReservas();
            dgvReservas.Columns[4].Visible = false; 
        }

        private void verReservas() {
            dgvReservas.Rows.Clear();
            bool aux = false;
            R.FillByAula(dsR.RESERVAS, codigoaula[cb_aula.SelectedIndex], dtFecha.Value.ToString());
            for (int i = 1; i <= 6; i++)
            {
                aux = true;
                //MessageBox.Show(dsR.RESERVAS.Count.ToString());
                for (int j = 0; j < dsR.RESERVAS.Count; j++)
                {
                    if (i == dsR.RESERVAS[j].Num_hora)
                    {
                        aux = false;
                        Au.FillByCod(As.AULAS, dsR.RESERVAS[j].Aula);
                        //MessageBox.Show("esta es i=" + i + " Num_hora=" + dsR.RESERVAS[j].Num_hora);
                        dgvReservas.Rows.Add(As.AULAS[0].Descripcion, dsR.RESERVAS[j].Usuario, i, "NO", dsR.RESERVAS[j].Id_reserva);
                    }
                }
                if (aux)
                {
                    dgvReservas.Rows.Add(As.AULAS[0].Descripcion, " ", i, "SI", -1);
                }
            }

        }


        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvReservas.SelectedRows.Count; i++)
                {
                    if (int.Parse(dgvReservas.SelectedRows[i].Cells[4].Value.ToString()) == -1)
                    {
                        R.InsertQueryRev(user, codigoaula[cb_aula.SelectedIndex], dtFecha.Value.ToString(), int.Parse(dgvReservas.SelectedRows[i].Cells[2].Value.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Esa aula ya esta reservada para esa hora y fecha");
                    }
                }
                verReservas();
            }
            else {
                MessageBox.Show("No has seleccionado ninguna hora de reserva");
            }
        }

        private void dgvReservas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //aux3 = true;
            //alaReserva();
        }
    }
}
