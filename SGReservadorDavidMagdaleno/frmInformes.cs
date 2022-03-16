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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnAulaReserva_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {

                var qConsultaAgrup = from resv in objBD.RESERVAS
                                     group resv by resv.Fecha into grupo
                                     select new
                                     {
                                         fecha = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var maxValor = qConsultaAgrup.Max(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == maxValor);

                var consulta4 = from re in subConsulta.ToList()
                                from au in objBD.AULAS
                                from rev in objBD.RESERVAS
                                where re.fecha == rev.Fecha && rev.Aula==au.Cod_aula && au.Borrado==0
                                select new
                                {
                                    au.Descripcion,
                                    rev.Fecha,
                                    Numero_Reservas = re.Num_veces
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnAulasBorradas_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {

                var qConsultaAgrup = from resv in objBD.RESERVAS
                                     group resv by resv.Fecha into grupo
                                     select new
                                     {
                                         fecha = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var minValor = qConsultaAgrup.Min(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == minValor);

                var consulta4 = from re in subConsulta.ToList()
                                from au in objBD.AULAS
                                from rev in objBD.RESERVAS
                                where re.fecha == rev.Fecha && rev.Aula == au.Cod_aula && au.Borrado == -1
                                orderby au.Descripcion
                                select new
                                {
                                    au.Descripcion,
                                    rev.Fecha,
                                    Numero_Reservas = re.Num_veces
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnUsuariosReservas_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {

                var qConsultaAgrup = from resv in objBD.RESERVAS
                                     group resv by resv.Usuario into grupo
                                     select new
                                     {
                                         User = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var maxValor = qConsultaAgrup.Max(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces == maxValor);

                var consulta4 = from re in subConsulta.ToList()
                                from us in objBD.USUARIOS
                                from rev in objBD.RESERVAS
                                where re.User == rev.Usuario && rev.Usuario == us.Login && us.Borrado == 0
                                select new
                                {
                                    us.Login,
                                    us.Password,
                                    Numero_Reservas=re.Num_veces
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnUsuMedia_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {

                var qConsultaAgrup = from resv in objBD.RESERVAS
                                     group resv by resv.Usuario into grupo
                                     select new
                                     {
                                         User = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var mediaValor = qConsultaAgrup.Average(x => x.Num_veces);
                var subConsulta = qConsultaAgrup.Where(x => x.Num_veces >= mediaValor);

                var consulta4 = from re in subConsulta.ToList()
                                from us in objBD.USUARIOS
                                from rev in objBD.RESERVAS
                                where re.User == rev.Usuario && rev.Usuario == us.Login
                                select new
                                {
                                    us.Login,
                                    Media=mediaValor,
                                    Numero_Reservas = re.Num_veces
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }

        private void btnResevAntigua_Click(object sender, EventArgs e)
        {
            using (reservadorEntities objBD = new reservadorEntities())
            {
                var qConsultaAgrup = from resv in objBD.RESERVAS
                                     group resv by resv.Fecha into grupo
                                     select new
                                     {
                                         fecha = grupo.Key,
                                         Num_veces = grupo.Count()
                                     };
                var minValor = qConsultaAgrup.Min(x => x.fecha);
                var subConsulta = qConsultaAgrup.Where(x => x.fecha == minValor);

                var consulta4 = from re in subConsulta.ToList()
                                from us in objBD.USUARIOS
                                from rev in objBD.RESERVAS
                                from au in objBD.AULAS
                                where re.fecha == rev.Fecha && rev.Aula == au.Cod_aula && rev.Usuario==us.Login
                                select new
                                {
                                    au.Descripcion,
                                    us.Login,
                                    re.fecha
                                };

                dgvInformes.DataSource = consulta4.Distinct().ToList();
            }
        }
    }
}
