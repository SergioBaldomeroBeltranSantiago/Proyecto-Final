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
    public partial class Interfaz_Habitaciones : Form
    {
        public Interfaz_Habitaciones()
        {
            InitializeComponent();
        }

        public Interfaz_Principal regresar_pantalla;
        public Usuario usuario_actual = new Usuario();
        Conexion enchufe = new Conexion();
        public double costo_dia, costo_total;
        public int num_dias, num_hab;

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            regresar_pantalla.Visible = true;
            this.Dispose();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                enchufe.Open();
                costo_total += Check_ServicioE.Checked ? 200 : 0;
                DateTime inicio = new DateTime(CalendarReservacion.SelectionRange.Start.Year, CalendarReservacion.SelectionRange.Start.Month, CalendarReservacion.SelectionRange.Start.Day);
                DateTime fin = new DateTime(CalendarReservacion.SelectionRange.End.Year, CalendarReservacion.SelectionRange.End.Month, CalendarReservacion.SelectionRange.End.Day);
                usuario_actual = regresar_pantalla.usuario_conectado;
                string query = "INSERT INTO proyecto.reservaciones(num_hab,correo_e_usuario,inicio_reservacion,fin_reservacion,costo_reservacion) VALUES ('" + num_hab + "','" + usuario_actual.getCorreo_electronico() + "','" 
                    + CalendarReservacion.SelectionRange.Start.Year+"-"+ CalendarReservacion.SelectionRange.Start.Month +"-"+ CalendarReservacion.SelectionRange.Start.Day + "','" 
                    + CalendarReservacion.SelectionRange.End.Year + "-" + CalendarReservacion.SelectionRange.End.Month + "-" + CalendarReservacion.SelectionRange.End.Day + "', '" 
                    + costo_total + "')";
                MySqlDataReader pepe;
                pepe = enchufe.ExecuteReader(query);
                if (pepe != null)
                {
                    MessageBox.Show("Reservacion exitosa, se le regresara al menu principal.");
                    while (pepe.Read())
                    {
                        
                    }
                }
                else {
                    MessageBox.Show("Error en la reservacion, se le regresara al menu principal.");
                }
                enchufe.Close();
                regresar_pantalla.Visible = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Check_ServicioE_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_ServicioE.Checked)
            {
                Lb_ServicioE.Text = "+$200 por servicio especial.";
            }
            else
            {
                Lb_ServicioE.Text = "";
            }
        }

        private void CalendarReservacion_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (CalendarReservacion.SelectionRange.Start > DateTime.Now)
            {
                TimeSpan dias = CalendarReservacion.SelectionRange.End.Date - CalendarReservacion.SelectionRange.Start.Date;
                num_dias = int.Parse(dias.TotalDays.ToString()) + 1;
                if (num_dias > 0)
                {
                    costo_total = costo_dia * num_dias;
                    Lb_CostoTotal.Text = "$" + (costo_total).ToString() + " mxn en total.";
                    Btn_Confirmar.Enabled = true;
                }
                else
                {
                    Lb_CostoTotal.Text = "Costo total.";
                    Btn_Confirmar.Enabled = false;
                }
            }
            else
            {
                Btn_Confirmar.Enabled = false;
            }
        }
    }
}
