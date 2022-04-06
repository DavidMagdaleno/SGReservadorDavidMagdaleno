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
    public partial class frmInsertUser : Form
    {
        public frmInsertUser()
        {
            InitializeComponent();
            cargarPerfil();
        }

        public void cargarPerfil()
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                var consulta = from us in objBD.USUARIOS
                               select us.Perfil;

                var n = consulta.Distinct().ToList();
                //objBD.SaveChanges();
                for (int i = 0; i < n.Count; i++)
                {
                    aux(i);
                }
            }
        }

        private void aux(int i) {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                var consulta2 = from pr in objBD.PERFILES
                                where pr.Id_Perfil == i + 1
                                select pr.Descripcion;

                var p = consulta2.ToList();
                var s = p.FirstOrDefault();
                cbPerfil.Items.Add(s);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                USUARIOS objUser = objBD.USUARIOS.Find(txtLog.Text);

                if (objUser != null)
                {
                    MessageBox.Show("Ese Login ya esta en uso");
                }
                else {
                    objUser = objBD.USUARIOS.Create();

                    if (!txtLog.Text.Equals(""))
                    {
                        objUser.Login = txtLog.Text;
                        if (!txtPW.Text.Equals(""))
                        {
                            objUser.Password = txtPW.Text;
                            if (!txtEmail.Text.Equals(""))
                            {
                                objUser.Email = txtEmail.Text;
                                if (cbPerfil.SelectedIndex != -1)
                                {
                                    var consulta = from pr in objBD.PERFILES
                                                   where pr.Descripcion == cbPerfil.SelectedItem.ToString()
                                                   select pr.Id_Perfil;

                                    var n = consulta.ToList();
                                    var t = n.FirstOrDefault();

                                    objUser.Perfil = t;
                                    objUser.Borrado = 0;
                                    //se guardan los cambios
                                    objBD.USUARIOS.Add(objUser);
                                    objBD.SaveChanges();
                                    MessageBox.Show("Añadido");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR, Campo perfil en blanco");
                                }
                            }
                            else
                            {
                                MessageBox.Show("ERROR, Campo email en blanco");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR, Campo password en blanco");
                        }
                    }
                    else {
                        MessageBox.Show("ERROR, Campo login en blanco");
                    }
                }
            }
        }
    }
}
