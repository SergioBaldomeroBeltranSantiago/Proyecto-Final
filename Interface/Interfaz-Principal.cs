using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funciones;
using Datos;
using MySql.Data.MySqlClient;

namespace Interface
{
    public partial class Interfaz_Principal : Form
    {
        public Interfaz_Principal()
        {
            InitializeComponent();
        }

        public Usuario usuario_conectado;
        public Interfaz_Login cerrar_sesion;
        public Interfaz_Habitaciones crear_reservacion;
        Conexion cable = new Conexion();
        bool PresenteFuturo = true;
        int seleccion_futuro;

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            usuario_conectado = null;
            cerrar_sesion.Visible = true;
            this.Dispose();
        }

        private void Btn_ModifCuenta_Click(object sender, EventArgs e)
        {
            Interfaz_ModificarCuenta perfil_usuario = new Interfaz_ModificarCuenta();
            perfil_usuario.usuario_actual = usuario_conectado;
            perfil_usuario.regresar_pantalla = this;
            perfil_usuario.cuenta_eliminada = cerrar_sesion;
            perfil_usuario.Show();
            this.Visible = false;
        }

        public void AbrirHab(string num_hab, string nombre_hab,string cap_hab,double costo_dia, string descripcion) {
            crear_reservacion = new Interfaz_Habitaciones();
            crear_reservacion.regresar_pantalla = this;
            crear_reservacion.Lb_NombreHabitacion.Text = num_hab + " " + nombre_hab;
            crear_reservacion.Lb_CapacidadHabitacion.Text = cap_hab;
            crear_reservacion.Lb_CostopDia.Text = "$"+costo_dia.ToString() + " mxn por dia.";
            crear_reservacion.Txt_Descripcion.Text = descripcion;
            crear_reservacion.costo_dia = costo_dia;
            crear_reservacion.num_hab = int.Parse(num_hab);
            crear_reservacion.Show();
            this.Visible = false;
        }
        private void Btn_Hab01_Click(object sender, EventArgs e)
        {
            AbrirHab("1","Albino","2 personas",240.00,"Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab02_Click(object sender, EventArgs e)
        {
            AbrirHab("2", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab03_Click(object sender, EventArgs e)
        {
            AbrirHab("3", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab04_Click(object sender, EventArgs e)
        {
            AbrirHab("4", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab05_Click(object sender, EventArgs e)
        {
            AbrirHab("5", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab06_Click(object sender, EventArgs e)
        {
            AbrirHab("6", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab07_Click(object sender, EventArgs e)
        {
            AbrirHab("7", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab08_Click(object sender, EventArgs e)
        {
            AbrirHab("8", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab09_Click(object sender, EventArgs e)
        {
            AbrirHab("9", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab10_Click(object sender, EventArgs e)
        {
            AbrirHab("10", "Albino", "2 personas", 240.00, "Habitacion normal con 2 camas individuales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab11_Click(object sender, EventArgs e)
        {
            AbrirHab("11", "Leucistico", "4 personas", 480.00, "Habitacion normal con 2 camas matrimoniales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab12_Click(object sender, EventArgs e)
        {
            AbrirHab("12", "Leucistico", "4 personas", 480.00, "Habitacion normal con 2 camas matrimoniales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab13_Click(object sender, EventArgs e)
        {
            AbrirHab("13", "Leucistico", "4 personas", 480.00, "Habitacion normal con 2 camas matrimoniales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab14_Click(object sender, EventArgs e)
        {
            AbrirHab("14", "Leucistico", "4 personas", 480.00, "Habitacion normal con 2 camas matrimoniales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab15_Click(object sender, EventArgs e)
        {
            AbrirHab("15", "Leucistico", "4 personas", 480.00, "Habitacion normal con 2 camas matrimoniales, baño completo, television por cable y telefono para servicios del hotel.");
        }

        private void Btn_Hab16_Click(object sender, EventArgs e)
        {
            AbrirHab("16", "Dorado", "4 personas", 600.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.");
        }

        private void Btn_Hab17_Click(object sender, EventArgs e)
        {
            AbrirHab("17", "Dorado", "4 personas", 600.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.");
        }

        private void Btn_Hab18_Click(object sender, EventArgs e)
        {
            AbrirHab("18", "Dorado", "4 personas", 600.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.");
        }

        private void Btn_Hab19_Click(object sender, EventArgs e)
        {
            AbrirHab("19", "Dorado", "4 personas", 600.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.");
        }

        private void Btn_Hab20_Click(object sender, EventArgs e)
        {
            AbrirHab("20", "Dorado", "4 personas", 600.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.");
        }

        private void Btn_Hab21_Click(object sender, EventArgs e)
        {
            AbrirHab("21", "Silvestre", "4 personas", 720.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.\n Tambien incluimos guia turistica por todo el lago xochimilco completamente gratis, ademas de un 50% de descuento en el museo del ajolote");
        }

        private void Btn_Hab22_Click(object sender, EventArgs e)
        {
            AbrirHab("22", "Silvestre", "4 personas", 720.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.\n Tambien incluimos guia turistica por todo el lago xochimilco completamente gratis, ademas de un 50% de descuento en el museo del ajolote");
        }

        private void Btn_Hab23_Click(object sender, EventArgs e)
        {
            AbrirHab("23", "Silvestre", "4 personas", 720.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.\n Tambien incluimos guia turistica por todo el lago xochimilco completamente gratis, ademas de un 50% de descuento en el museo del ajolote");
        }

        private void Btn_Hab24_Click(object sender, EventArgs e)
        {
            AbrirHab("24", "Silvestre", "4 personas", 720.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.\n Tambien incluimos guia turistica por todo el lago xochimilco completamente gratis, ademas de un 50% de descuento en el museo del ajolote");
        }

        private void Btn_Hab25_Click(object sender, EventArgs e)
        {
            AbrirHab("25", "Silvestre", "4 personas", 720.00, "Habitacion de lujo con 2 camas matrimoniales, 2 baños completo, television por cable con acceso a canales premium, acceso al buffet  y telefono para servicios del hotel.\n Tambien incluimos guia turistica por todo el lago xochimilco completamente gratis, ademas de un 50% de descuento en el museo del ajolote");
        }

        private void Interfaz_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_reservaciones_DataSet.reservaciones' Puede moverla o quitarla según sea necesario.
            this.reservacionesTableAdapter1.Fill(this.proyecto_reservaciones_DataSet.reservaciones);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.reservaciones' Puede moverla o quitarla según sea necesario.
            this.reservacionesTableAdapter.Fill(this.proyectoDataSet.reservaciones);

        }

        private void Btn_CancelarReservacion_Click(object sender, EventArgs e)
        {
            try
            {
                cable.Open();
                string deletion = DGrid_PresenteFuturo.Rows[seleccion_futuro].Cells[0].Value.ToString();
                string query = "DELETE FROM proyecto.reservaciones WHERE id = '" + deletion + "'";
                MySqlDataReader cancelador = cable.ExecuteReader(query);
                if (cancelador != null)
                {
                    while (cancelador.Read()) { }
                    MessageBox.Show("Cancelacion exitosa.");
                    DGrid_PresenteFuturo.Rows.Remove(DGrid_PresenteFuturo.Rows[seleccion_futuro]);
                    cancelador.NextResult();
                }
                else
                {
                    MessageBox.Show("Error en la cancelacion, contacte a un administrador.");
                }
                cable.Close();
                Btn_Cargar_Click(sender, e);
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            cable.Open();
            string sql = "SELECT * FROM proyecto.reservaciones WHERE correo_e_usuario = '"+usuario_conectado.getCorreo_electronico()+"'";
            MySqlDataReader buscador = cable.ExecuteReader(sql);
            if (buscador.HasRows && buscador != null)
            {
                while (buscador.Read())
                {
                    DateTime fin = DateTime.Parse(buscador["fin_reservacion"].ToString());
                    if (fin >= DateTime.Now)
                    {
                        int n = DGrid_PresenteFuturo.Rows.Count;
                        if (n == 0)
                        {
                            DGrid_PresenteFuturo.Rows.Add();
                            DGrid_PresenteFuturo.Rows[n].Cells[0].Value = buscador["id"].ToString();
                            DGrid_PresenteFuturo.Rows[n].Cells[1].Value = buscador["num_hab"].ToString();
                            DGrid_PresenteFuturo.Rows[n].Cells[2].Value = buscador["correo_e_usuario"].ToString();
                            DGrid_PresenteFuturo.Rows[n].Cells[3].Value = buscador["inicio_reservacion"].ToString();
                            DGrid_PresenteFuturo.Rows[n].Cells[4].Value = buscador["fin_reservacion"].ToString();
                            DGrid_PresenteFuturo.Rows[n].Cells[5].Value = buscador["costo_reservacion"].ToString();
                        }
                        else {
                            bool repetido = false;
                            for (int i = n; i > 0; i--) {
                                if (DGrid_PresenteFuturo.Rows[i-1].Cells[0].Value.ToString() == buscador["id"].ToString()) {
                                    repetido = true;
                                    break;
                                }
                            }
                            if (repetido)
                            {
                                buscador.NextResult();
                            }
                            else {
                                int m = DGrid_PresenteFuturo.Rows.Add();
                                DGrid_PresenteFuturo.Rows[m].Cells[0].Value = buscador["id"].ToString();
                                DGrid_PresenteFuturo.Rows[m].Cells[1].Value = buscador["num_hab"].ToString();
                                DGrid_PresenteFuturo.Rows[m].Cells[2].Value = buscador["correo_e_usuario"].ToString();
                                DGrid_PresenteFuturo.Rows[m].Cells[3].Value = buscador["inicio_reservacion"].ToString();
                                DGrid_PresenteFuturo.Rows[m].Cells[4].Value = buscador["fin_reservacion"].ToString();
                                DGrid_PresenteFuturo.Rows[m].Cells[5].Value = buscador["costo_reservacion"].ToString();
                            }
                        }
                    }
                    else {
                        int n = DGrid_Pasado.Rows.Count;
                        if (n == 0) {
                            int m = DGrid_Pasado.Rows.Add();
                            DGrid_Pasado.Rows[n].Cells[0].Value = buscador["id"].ToString();
                            DGrid_Pasado.Rows[n].Cells[1].Value = buscador["num_hab"].ToString();
                            DGrid_Pasado.Rows[n].Cells[2].Value = buscador["correo_e_usuario"].ToString();
                            DGrid_Pasado.Rows[n].Cells[3].Value = buscador["inicio_reservacion"].ToString();
                            DGrid_Pasado.Rows[n].Cells[4].Value = buscador["fin_reservacion"].ToString();
                            DGrid_Pasado.Rows[n].Cells[5].Value = buscador["costo_reservacion"].ToString();
                        }
                        else
                        {
                            bool repetido = false;
                            for (int i = n; i > 0; i--)
                            {
                                if (DGrid_Pasado.Rows[i-1].Cells[0].Value.ToString() == buscador["id"].ToString())
                                {
                                    repetido = true;
                                    break;
                                }
                            }
                            if (repetido)
                            {
                                buscador.NextResult();
                            }
                            else
                            {
                                int m = DGrid_Pasado.Rows.Add();
                                DGrid_Pasado.Rows[m].Cells[0].Value = buscador["id"].ToString();
                                DGrid_Pasado.Rows[m].Cells[1].Value = buscador["num_hab"].ToString();
                                DGrid_Pasado.Rows[m].Cells[2].Value = buscador["correo_e_usuario"].ToString();
                                DGrid_Pasado.Rows[m].Cells[3].Value = buscador["inicio_reservacion"].ToString();
                                DGrid_Pasado.Rows[m].Cells[4].Value = buscador["fin_reservacion"].ToString();
                                DGrid_Pasado.Rows[m].Cells[5].Value = buscador["costo_reservacion"].ToString();
                            }
                        }
                    }
                }
                buscador.NextResult();
            }
            else {
                MessageBox.Show("No tienes reservaciones registradas.");
            }
            cable.Close();
        }

        private void DGrid_PresenteFuturo_SelectionChanged(object sender, EventArgs e)
        {
            if (DGrid_PresenteFuturo.Rows.Count>0) {
                if (PresenteFuturo)
                {
                    PresenteFuturo = false;
                }
                else
                {
                    seleccion_futuro = DGrid_PresenteFuturo.CurrentCell.RowIndex;
                }
                UnlockButton();
            }
        }

        private void UnlockButton() {
            if (!PresenteFuturo)
            {
                Btn_CancelarReservacion.Enabled = true;
            }
            else {
                Btn_CancelarReservacion.Enabled = false;
            }
        }
    }
}
