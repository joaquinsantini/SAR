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
using System.IO;

namespace SAR
{
    public partial class NuevoRequerimiento : Form
    {
        int rol_usuario;
        MenuPrincipal menu_prin;

        public NuevoRequerimiento(MenuPrincipal menu, int rol)
        {
            rol_usuario = rol;
            menu_prin = menu;
            InitializeComponent();
            InicializarControles(rol_usuario);
        }

        private void InicializarControles(int rol)
        {
            if (rol == 1)
            {
                prioridadCB.Visible = false;
                prioridadL.Visible = false;
            }

            CargarComboBoxSolicitantes();
        }

        private void CargarComboBoxSolicitantes()
        {
            using (SqlConnection conn = new SqlConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.Solicitantes_L", conn))
            {
                conn.ConnectionString = "Server=DESKTOP-D148EGN\\DBMUSERS;Database=DBMUSERS;Trusted_Connection=true";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                cmd.ExecuteNonQuery();

                using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adap.Fill(ds, "Solicitantes");
                    solicitanteCB.DisplayMember = "SolicitanteNombre";
                    solicitanteCB.ValueMember = "SolicitantePS";
                    solicitanteCB.DataSource = ds.Tables["Solicitantes"];
                }
            }
        }

        private void aceptarB_Click(object sender, EventArgs e)
        {
            string usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string prioridad = "";
            int fecha = fEntEstimadaDP.Value.Year * 10000 + fEntEstimadaDP.Value.Month * 100 + fEntEstimadaDP.Value.Day; ;
            string carpeta = "";
            int numero = 0;

            if (rol_usuario == 0)
            {
                prioridad = prioridadCB.SelectedItem.ToString();
            }

            if (tituloTB.Text.Trim() == "")
            {
                MessageBox.Show("Campo Título incompleto!");
                tituloTB.Select();
                return;
            }

            if (detalleTB.Text.Trim() == "")
            {
                MessageBox.Show("Campo Detalle incompleto!");
                detalleTB.Select();
                return;
            }

            if (tituloTB.Text.Trim().Length > 63)
            {
                MessageBox.Show("El campo Título debe tener menos de 63 caracteres!");
                tituloTB.Select();
                return;
            }

            if (detalleTB.Text.Trim().Length > 2046)
            {
                MessageBox.Show("El campo Detalle debe tener menos de 2046 caracteres!");
                detalleTB.Select();
                return;
            }

            if (fEntEstimadaDP.Value.Year < System.DateTime.Now.Year &&
                fEntEstimadaDP.Value.Month < System.DateTime.Now.Month &&
                fEntEstimadaDP.Value.Day < System.DateTime.Now.Day)
            {
                MessageBox.Show("La fecha de entrega estimada no puede ser menor a Hoy!");
                fEntEstimadaDP.Select();
                return;
            }

            using (SqlConnection conn = new SqlConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.Requerimientos_A", conn))
            {
                conn.ConnectionString = "Server=DESKTOP-D148EGN\\DBMUSERS;Database=DBMUSERS;Trusted_Connection=true";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Titulo", SqlDbType.VarChar, 63);
                cmd.Parameters.Add("@Detalle", SqlDbType.VarChar, 2046);
                cmd.Parameters.Add("@PSAlta", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@PSSolicitante", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@Prioridad", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@FEntrega_Estimada", SqlDbType.VarChar, 8);
                cmd.Parameters.Add("@Carpeta", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Numero", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@Titulo"].Value = tituloTB.Text;
                cmd.Parameters["@Detalle"].Value = detalleTB.Text;
                cmd.Parameters["@PSAlta"].Value = usuario;
                cmd.Parameters["@PSSolicitante"].Value = solicitanteCB.SelectedValue;
                cmd.Parameters["@Prioridad"].Value = prioridad;
                cmd.Parameters["@FEntrega_Estimada"].Value = fecha.ToString();
                cmd.Parameters["@Carpeta"].Value = carpeta;
                cmd.Parameters["@Numero"].Value = numero;

                conn.Open();
                cmd.ExecuteNonQuery();

                carpeta = Convert.ToString(cmd.Parameters["@Carpeta"].Value);
                numero = Convert.ToInt32(cmd.Parameters["@Numero"].Value);
            }

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            MessageBox.Show("Requerimiento " + numero.ToString() + " creado con éxito!");

            menu_prin.CargarRequerimientos(this, null);

            this.Close();
        }

        private void cancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
