using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAR
{
    public partial class MenuPrincipal : Form
    {
        private int rol_usuario;

        public MenuPrincipal(int rol)
        {
            rol_usuario = rol;
            InitializeComponent();
            InicializarControles(rol_usuario);
            InicializarFiltros(rol_usuario);
            InicializarEventos();
            CargarRequerimientos(this, null);
        }

        private void InicializarControles(int rol)
        {
            if (rol == 1)
            {
                estadisticasMI.Visible = false;
            }
        }

        private void InicializarFiltros(int rol)
        {
            int anio;

            anio = DateTime.Now.Year;

            DateTime fechaInicio = new DateTime(anio, 1, 1);

            if (rol == 0)
            {
                psAltaCB.SelectedItem = "Todos";
            }
            else
            {
                psAltaCB.SelectedItem = "Todos";
                //psAltaCB.SelectedItem = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }

            fechaDesdeDP.Value = fechaInicio;
            estadoCB.SelectedItem = "Todos";
            prioridadCB.SelectedItem = "Todas";
        }

        private void InicializarEventos()
        {
            psAltaCB.SelectedValueChanged += CargarRequerimientos;
            fechaDesdeDP.ValueChanged += CargarRequerimientos;
            fechaHastaDP.ValueChanged += CargarRequerimientos;
            estadoCB.SelectedValueChanged += CargarRequerimientos;
            prioridadCB.SelectedValueChanged += CargarRequerimientos;
            grillaReq.ContextMenuStrip = menuGrilla;
        }

        public void CargarRequerimientos(object sender, EventArgs e)
        {
            int fecha_desde, fecha_hasta;

            fecha_desde = fechaDesdeDP.Value.Year * 10000 + fechaDesdeDP.Value.Month * 100 + fechaDesdeDP.Value.Day;
            fecha_hasta = fechaHastaDP.Value.Year * 10000 + fechaHastaDP.Value.Month * 100 + fechaHastaDP.Value.Day;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=DESKTOP-D148EGN\\DBMUSERS;Database=DBMUSERS;Trusted_Connection=true";
                SqlCommand cmd = new SqlCommand("dbo.Requerimientos_L", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PS", psAltaCB.SelectedItem);
                cmd.Parameters.AddWithValue("@FechaDesde", fecha_desde.ToString());
                cmd.Parameters.AddWithValue("@FechaHasta", fecha_hasta.ToString());
                cmd.Parameters.AddWithValue("@Prioridad", prioridadCB.SelectedItem);
                cmd.Parameters.AddWithValue("@Estado", estadoCB.SelectedItem);

                conn.Open();
                cmd.ExecuteNonQuery();

                using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    grillaReq.DataSource = dt;
                }
            }
        }

        private void salirMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoRequerimientoMI_Click(object sender, EventArgs e)
        {
            NuevoRequerimiento nuevoReqForm = new NuevoRequerimiento(this, rol_usuario);
            nuevoReqForm.Show();
        }

        private void seleccionarFila(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string estado;

                modificarMI.Visible = true;
                eliminarMI.Visible = true;
                actualizarEstadoMI.Visible = true;
                cargarHorasMI.Visible = true;

                var hti = grillaReq.HitTest(e.X, e.Y);
                grillaReq.ClearSelection();
                grillaReq.Rows[hti.RowIndex].Selected = true;

                if (rol_usuario == 1)
                {
                    modificarMI.Visible = false;
                    eliminarMI.Visible = false;
                }

                estado = grillaReq.Rows[hti.RowIndex].Cells[8].Value.ToString();

                if (estado == "En Aprobacion" && rol_usuario == 1)
                {
                    actualizarEstadoMI.Visible = false;
                }

                if (estado == "En Aprobacion")
                {
                    cargarHorasMI.Visible = false;
                }
            }
        }
    }
}
