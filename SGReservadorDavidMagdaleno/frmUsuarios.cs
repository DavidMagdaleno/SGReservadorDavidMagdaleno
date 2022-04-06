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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            cargarusuarios();
        }

        public void cargarusuarios()
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                var consulta = from us in objBD.USUARIOS
                               from pr in objBD.PERFILES
                               where us.Perfil == pr.Id_Perfil && us.Borrado == 0
                               select new { us.Login, us.Password, us.Email, pr.Descripcion, us.Borrado, us.Perfil };
             
                dgvUsers.DataSource = consulta.ToList();
                dgvUsers.Columns[4].Visible = false;
                dgvUsers.Columns[5].Visible = false;
            }
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            frmInsertUser u = new frmInsertUser();
            //u.ShowDialog();
            DialogResult dres = u.ShowDialog();
            if (dres == DialogResult.Cancel)
            {
                cargarusuarios();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            frmModUser m = new frmModUser(dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), dgvUsers.SelectedRows[0].Cells[1].Value.ToString(), dgvUsers.SelectedRows[0].Cells[2].Value.ToString(),int.Parse(dgvUsers.SelectedRows[0].Cells[5].Value.ToString()),int.Parse(dgvUsers.SelectedRows[0].Cells[4].Value.ToString()));
            //m.ShowDialog();
            DialogResult dres = m.ShowDialog();
            if (dres == DialogResult.Cancel)
            {
                cargarusuarios();
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                USUARIOS objSoc = objBD.USUARIOS.Find(dgvUsers.SelectedRows[0].Cells[0].Value);
                if (objSoc != null)
                {
                    DialogResult resp = new DialogResult();
                    resp = MessageBox.Show("Estas seguro de quieres eliminar el usuario", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (resp == DialogResult.Yes)
                    {
                        objSoc.Borrado = -1;
                        //se elemina el objeto de la tabla, para quitarlo como registro
                        //objBD.EQUIPOS.Remove(objSoc);
                        //se guardan los cambios
                        objBD.SaveChanges();

                        cargarusuarios();

                        MessageBox.Show("Eliminado");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún usuario");
                }
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                
                var consulta = from us in objBD.USUARIOS
                               from pr in objBD.PERFILES
                               where us.Perfil==pr.Id_Perfil && us.Borrado==0
                               select new { us.Login,us.Password, us.Email, pr.Descripcion,us.Borrado, us.Perfil};

                dgvUsers.DataSource = consulta.ToList();
                dgvUsers.Columns[4].Visible = false;
                dgvUsers.Columns[5].Visible = false;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmModUser m = new frmModUser(dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), dgvUsers.SelectedRows[0].Cells[1].Value.ToString(), dgvUsers.SelectedRows[0].Cells[2].Value.ToString(), int.Parse(dgvUsers.SelectedRows[0].Cells[3].Value.ToString()), int.Parse(dgvUsers.SelectedRows[0].Cells[4].Value.ToString()));
            //m.ShowDialog();
        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmModUser m = new frmModUser(dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), dgvUsers.SelectedRows[0].Cells[1].Value.ToString(), dgvUsers.SelectedRows[0].Cells[2].Value.ToString(), int.Parse(dgvUsers.SelectedRows[0].Cells[5].Value.ToString()), int.Parse(dgvUsers.SelectedRows[0].Cells[4].Value.ToString()));
            //m.ShowDialog();
            DialogResult dres = m.ShowDialog();
            if (dres == DialogResult.Cancel)
            {
                cargarusuarios();
            }
        }
    }
}
