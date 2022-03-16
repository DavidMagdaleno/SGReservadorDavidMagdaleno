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
    public partial class frmPrincipal : Form
    {
        private String usuariologin="";
        public frmPrincipal(int r, string s)
        {
            InitializeComponent();
            if (r==2)
            {
                usuariosToolStripMenuItem.Visible = true;
                aulasToolStripMenuItem.Visible = true;
                iNFORMESToolStripMenuItem.Visible = true;
            }
            usuariologin = s;
            
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmUsuarios")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmUsuarios f1 = new frmUsuarios();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmUsuarios f1 = new frmUsuarios();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmAulas")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmAulas f1 = new frmAulas();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmAulas f1 = new frmAulas();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void rESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmReservas")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmReservas f1 = new frmReservas(usuariologin);
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmReservas f1 = new frmReservas(usuariologin);
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "frmUsuarios")
                {
                    DialogResult rs = MessageBox.Show("¿ Deseas cerrar las " + MdiChildren[0].Name + "?", "!ATENCION¡", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        frmInformes f1 = new frmInformes();
                        f1.MdiParent = this;
                        f1.Dock = DockStyle.Fill;
                        f1.Show();
                    }
                }
            }
            else
            {
                frmInformes f1 = new frmInformes();
                f1.MdiParent = this;
                f1.Dock = DockStyle.Fill;
                f1.Show();
            }
        }
    }
}
