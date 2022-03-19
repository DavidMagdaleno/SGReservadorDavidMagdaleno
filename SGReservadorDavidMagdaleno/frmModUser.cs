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
    public partial class frmModUser : Form
    {
        private string log;
        private int per;
        public frmModUser(String login, String Pw, String Email, int Perfil, int Borr)
        {
            InitializeComponent();
            txtLogMod.Text = login;
            txtPWMod.Text = Pw;
            txtEmailMod.Text = Email;
            per = Perfil;
            log = login;
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

        private void aux(int i)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                var consulta2 = from pr in objBD.PERFILES
                                where pr.Id_Perfil == i + 1
                                select pr.Descripcion;

                var p = consulta2.ToList();
                var s = p.FirstOrDefault();
                cbPerfilMod.Items.Add(s);
            }

            using (reservadorEntities objBD = new reservadorEntities())
            {
                var consulta2 = from pr in objBD.PERFILES
                                where pr.Id_Perfil == per
                                select pr.Descripcion;

               
                var p = consulta2.ToList();
                var s = p.FirstOrDefault();
                
                cbPerfilMod.Text = s;
            }
        }

        private void btnSalirMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcepMod_Click(object sender, EventArgs e)
        {

            using (reservadorEntities objBD = new reservadorEntities())
            {
                USUARIOS objUser = objBD.USUARIOS.Find(txtLogMod.Text);

                if (objUser != null)
                {
                    if (!txtEmailMod.Text.Equals("") || !txtPWMod.Text.Equals("") || txtPWMod.Text.Length < 10 || cbPerfilMod.SelectedIndex != -1)
                    {
                        //objUser.Login = txtLogMod.Text;
                        objUser.Password = txtPWMod.Text;
                        objUser.Email = txtEmailMod.Text;

                        var consulta = from pr in objBD.PERFILES
                                       where pr.Descripcion == cbPerfilMod.SelectedItem.ToString()
                                       select pr.Id_Perfil;

                        var n = consulta.ToList();
                        var t = n.First();

                        objUser.Perfil = t;
                        objUser.Borrado = 0;

                        //se guardan los cambios
                        //objBD.USUARIOS.Add(objUser); //solo para insertar
                        objBD.SaveChanges();


                        MessageBox.Show("Modificado");
                    }
                    else {
                        MessageBox.Show("Hay campos en blanco y la contraseña no puede ser mayor a 10 caracteres");
                    }
                }
                else
                {
                    MessageBox.Show("Ese Usuario no existe");
                }
            }
        }
    }
}
