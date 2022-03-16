using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGReservadorDavidMagdaleno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                if (!String.IsNullOrEmpty(txtUser.Text) && !String.IsNullOrEmpty(txtPw.Text))
                {
                    var consulta2 = from login in objBD.USUARIOS
                                    where login.Login == txtUser.Text && login.Password == txtPw.Text && login.Borrado == 0
                                    select login;

                    var r = consulta2.Distinct().ToList();

                    if (r.Count > 0)
                    {
                        dgvaux.DataSource = r;
                        frmPrincipal p = new frmPrincipal(int.Parse(dgvaux.Rows[0].Cells[3].Value.ToString()), dgvaux.Rows[0].Cells[0].Value.ToString());
                        p.ShowDialog();
                    }
                    else {
                        MessageBox.Show("Usuario o Contraseña incorrectos");
                    }
                }
                else {
                    MessageBox.Show("Usuario o Contraseña Vacios");
                }
            }
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
