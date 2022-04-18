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
        reservadorDataSetTableAdapters.USUARIOSTableAdapter Us = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
        reservadorDataSet dsUs = new reservadorDataSet();
        private void btnEn_Click(object sender, EventArgs e)
        {
            string salida = "";
            using (reservadorEntities objBD = new reservadorEntities())
            {
                if (!String.IsNullOrEmpty(txtUser.Text) && !String.IsNullOrEmpty(txtPw.Text))
                {
                    //Us.FillByMayus(dsUs.USUARIOS, txtUser.Text, txtPw.Text);
                    //if (dsUs.USUARIOS.Count > 0)
                    //{
                    //    dgvaux.DataSource = dsUs.USUARIOS[0];
                    //    if (dgvaux.Rows[0].Cells[0].Value.ToString() != txtUser.Text) { }
                    //    frmPrincipal p = new frmPrincipal(int.Parse(dgvaux.Rows[0].Cells[3].Value.ToString()), dgvaux.Rows[0].Cells[0].Value.ToString(), this);
                    //    p.Show();
                    //    this.Hide();
                    //}
                    var consultausuario = from login in objBD.USUARIOS
                                          where login.Login == txtUser.Text && login.Borrado == 0
                                          select login;

                    var r = consultausuario.Distinct().ToList();
                    if (r.Count > 0)
                    {
                        var consultapass = from login in objBD.USUARIOS
                                           where login.Password == txtPw.Text && login.Borrado == 0
                                           select login;

                        var x = consultapass.Distinct().ToList();
                        if (x.Count > 0)
                        {
                            var consulta2 = from login in objBD.USUARIOS
                                            where login.Login == txtUser.Text && login.Password == txtPw.Text && login.Borrado == 0
                                            select login;

                            var d = consulta2.Distinct().ToList();

                            if (d.Count > 0)
                            {
                                dgvaux.DataSource = r;
                                frmPrincipal p = new frmPrincipal(int.Parse(dgvaux.Rows[0].Cells[3].Value.ToString()), dgvaux.Rows[0].Cells[0].Value.ToString(), this);
                                p.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            txtUser.Text = "";
                            txtPw.Text = "";
                            salida += "\nContraseña incorrecta";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto o borrado");
                        txtUser.Text = "";
                        txtPw.Text = "";
                        salida += "\nUsuario incorrecto o borrado";
                    }

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Vacios");
                    txtUser.Text = "";
                    txtPw.Text = "";
                    salida += "\nUsuario o Contraseña Vacios";
                }
                //MessageBox.Show(salida);--sale un mensaje en blanco
            }
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
