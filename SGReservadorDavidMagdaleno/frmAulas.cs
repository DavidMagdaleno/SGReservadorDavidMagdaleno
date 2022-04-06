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
    public partial class frmAulas : Form
    {
        private bool exist = false;
        public frmAulas()
        {
            InitializeComponent();
        }
        reservadorDataSetTableAdapters.AULASTableAdapter tbres = new reservadorDataSetTableAdapters.AULASTableAdapter();
        private void aULASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.aULASBindingSource.EndEdit();
                DialogResult resp = new DialogResult();
                resp = MessageBox.Show("Estas seguro de quieres Guardar el Aula", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (resp == DialogResult.Yes && !exist)
                {
                    this.tableAdapterManager.UpdateAll(this.reservadorDataSet);
                }
            }
            catch (Exception x)
            {
                if (descripcionTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Campos en blanco");
                }
                else {
                    MessageBox.Show("Ese Codigo de Aula ya existe");
                }
            }
            
            
        }

        private void frmAulas_Load(object sender, EventArgs e)
        {
            
            //this.aULASTableAdapter.Fill(this.reservadorDataSet.AULAS);
            this.aULASTableAdapter.FillByActivas(this.reservadorDataSet.AULAS,0);

        }

        private void cod_aulaLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //Suponemos que ofdExaminar es un OpenFileDialog incorporado al formulario
            ofdFoto.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = ofdFoto.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //para guardar la ruta al fichero con la imagen en un TextBox (por si se quiere mostrar)
            //txtRutaFichero.Text = ofdExaminar.FileName;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            fotoPictureBox.Image = Image.FromFile(ofdFoto.FileName);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Estas seguro de quieres eliminar el Aula", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (resp == DialogResult.Yes)
            {
                tbres.UpdateQueryEliminarAula (-1,cod_aulaTextBox.Text.ToString(), cod_aulaTextBox.Text.ToString());
            }
        }

        
    }
}
