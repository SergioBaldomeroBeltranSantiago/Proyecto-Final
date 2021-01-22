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
    public partial class Interfaz_ModificarCuenta : Form
    {
        public Interfaz_ModificarCuenta()
        {
            InitializeComponent();
        }

        Conexion conectasion = new Conexion();
        public Usuario usuario_actual = new Usuario();
        public Interfaz_Principal regresar_pantalla;
        public Interfaz_Login cuenta_eliminada;
        bool CambioCorreo = false, CorreoValido = false, CambioNombre = false, CambioContraseña = false, ContraseñaValida = false, MismaContraseña = false;

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            regresar_pantalla.Visible = true;
            this.Dispose();
        }

        private void Txt_NombreUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NombreUsuario.Text != "" && Txt_NombreUsuario.Text != usuario_actual.getNombre_usuario())
            {
                Lb_Nombre.Text = "Nuevo nombre aceptado.";
                Lb_Nombre.ForeColor = Color.Green;
                CambioNombre = true;
            }
            else
            {
                Lb_Nombre.Text = "";
                CambioNombre = false;
            }
            UnlockChange();
        }

        private void Txt_CorreoE_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_CorreoE.Text != "" && Txt_CorreoE.Text != usuario_actual.getCorreo_electronico())
            {
                if (Cerebro.ValidarFormatoCorreo(Txt_CorreoE.Text))
                {
                    Lb_Correo.Text = "Nuevo correo valido y aceptado.";
                    Lb_Correo.ForeColor = Color.Green;
                    CambioCorreo = CorreoValido = true;
                }
                else
                {
                    Lb_Correo.Text = "Nuevo correo invalido.";
                    Lb_Correo.ForeColor = Color.Red;
                    CorreoValido = false;
                    CambioCorreo = true;
                }
            }
            else
            {
                Lb_Correo.Text = "";
                CambioCorreo = false;
            }
            UnlockChange();
        }

        private void Txt_NuevaContraOne_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NuevaContraOne.Text != "")
            {
                if (Cerebro.ValidarFormatoContraseña(Txt_NuevaContraOne.Text))
                {
                    Lb_ContraOne.Text = "Nueva contraseña valida.";
                    Lb_ContraOne.ForeColor = Color.Green;
                    CambioContraseña = ContraseñaValida = true;
                }
                else
                {
                    Lb_ContraOne.Text = "Nueva contraseña invalida.";
                    Lb_ContraOne.ForeColor = Color.Red;
                    ContraseñaValida = false;
                    CambioContraseña = true;
                }
            }
            else
            {
                Lb_ContraOne.Text = "";
                Lb_MismaContra.Text = "";
                CambioContraseña = false;
            }
            UnlockChange();
            SamePassword();
        }

        private void Txt_NuevaContraTwo_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NuevaContraTwo.Text != "")
            {
                if (Cerebro.ValidarFormatoContraseña(Txt_NuevaContraTwo.Text))
                {
                    Lb_ContraTwo.Text = "Nueva contraseña valida.";
                    Lb_ContraTwo.ForeColor = Color.Green;
                    CambioContraseña = ContraseñaValida = true;
                }
                else
                {
                    Lb_ContraTwo.Text = "Nueva contraseña invalida.";
                    Lb_ContraTwo.ForeColor = Color.Red;
                    ContraseñaValida = false;
                    CambioContraseña = true;
                }
            }
            else
            {
                Lb_ContraTwo.Text = "";
                Lb_MismaContra.Text = "";
                CambioContraseña = false;
            }
            UnlockChange();
            SamePassword();
        }

        private void Txt_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            UnlockDeletion();
            UnlockChange();
        }

        private void UnlockDeletion()
        {
            if (Txt_Contraseña.Text.Equals(usuario_actual.getContraseña()))
            {
                Btn_EliminarCuenta.Enabled = true;
            }
            else
            {
                Btn_EliminarCuenta.Enabled = false;
            }
        }

        private void UnlockChange()
        {
            if (Txt_Contraseña.Text.Equals(usuario_actual.getContraseña()) && (CambioNombre || (CambioCorreo && CorreoValido) || (CambioContraseña && ContraseñaValida && MismaContraseña)))
            {
                Btn_ActualizarCuenta.Enabled = true;
            }
            else
            {
                Btn_ActualizarCuenta.Enabled = false;
            }
        }

        private void Interfaz_ModificarCuenta_Load(object sender, EventArgs e)
        {
            Txt_NombreUsuario.Text = usuario_actual.getNombre_usuario();
            Txt_CorreoE.Text = usuario_actual.getCorreo_electronico();
        }

        private void SamePassword()
        {
            if (ContraseñaValida && Txt_NuevaContraOne.Text.Equals(Txt_NuevaContraTwo.Text))
            {
                MismaContraseña = true;
                Lb_MismaContra.Text = "Ambas contraseñas son correctas.";
                Lb_MismaContra.ForeColor = Color.Green;
            }
            else
            {
                MismaContraseña = false;
                Lb_MismaContra.Text = "Las contraseñas no coinciden.";
                Lb_MismaContra.ForeColor = Color.Red;
            }
        }
        private void Btn_EliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult seguridad = MessageBox.Show("¿Esta seguro de querer eliminar su cuenta?\nEste es un proceso irreversible.", "Borrar cuenta", MessageBoxButtons.YesNo);
            if (seguridad == DialogResult.Yes)
            {
                try
                {
                    conectasion.Open();
                    string sql = "DELETE FROM proyecto.usuarios WHERE correo_electronico = '" + usuario_actual.getCorreo_electronico() + "'";
                    MySqlDataReader borrador = conectasion.ExecuteReader(sql);
                    if (borrador != null)
                    {
                        while (borrador.Read())
                        {

                        }
                        MessageBox.Show("Borrado exitoso, ahora se le redirigira a la pantalla de inicio de sesion.");
                        string sqltwo = "DELETE FROM proyecto.reservaciones WHERE correo_e_usuario = '" + usuario_actual.getCorreo_electronico() + "'";
                        conectasion.Close();
                        conectasion.Open();
                        borrador = conectasion.ExecuteReader(sqltwo);
                        if (borrador != null) {
                            MessageBox.Show("Reservaciones a nombre de la cuenta recientemente borrada han sido eliminadas.");
                        }
                    }
                    else {
                        MessageBox.Show("Error en el intento de borrado, se le redirigira a la pantalla de inicio de sesion.");
                    }
                    conectasion.Close();
                    cuenta_eliminada.Visible = true;
                    regresar_pantalla.Dispose();
                    this.Dispose();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Btn_ActualizarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult seguridad = MessageBox.Show("¿Esta seguro de querer modificar su cuenta?", "Modificar cuenta", MessageBoxButtons.YesNo);
            if (seguridad == DialogResult.Yes)
            {
                try
                {
                    conectasion.Open();
                    string nuevocorreo = CambioCorreo ? Txt_CorreoE.Text : usuario_actual.getCorreo_electronico();
                    string nuevonombre = CambioNombre ? Txt_NombreUsuario.Text : usuario_actual.getNombre_usuario();
                    string nuevacontraseña = (CambioContraseña && MismaContraseña) ? Txt_NuevaContraOne.Text : usuario_actual.getContraseña();
                    string sql = "UPDATE proyecto.usuarios SET correo_electronico='" + nuevocorreo + "' ,nombre_usuario = '" + nuevonombre + "' , contraseña = '" + nuevacontraseña + "' WHERE correo_electronico = '" + usuario_actual.getCorreo_electronico() + "'";
                    MySqlDataReader modificador = conectasion.ExecuteReader(sql);

                    if (modificador != null)
                    {
                        while (modificador.Read())
                        {

                        }
                        MessageBox.Show("Modificacion exitosa, ahora se le regresara a la pantalla principal.");
                        if (CambioCorreo) {
                            conectasion.Close();
                            conectasion.Open();
                            string sqltwo = "UPDATE proyecto.reservaciones SET correo_e_usuario = '" + nuevocorreo + "' WHERE correo_e_usuario ='" + usuario_actual.getCorreo_electronico() + "'";
                            modificador = conectasion.ExecuteReader(sqltwo);
                            if (modificador != null)
                            {
                                MessageBox.Show("Se han actualizado las reservaciones.");
                            }
                            else {
                                MessageBox.Show("Error en la actualizacion de las reservaciones, contacte con un administrador.");
                            }
                        }
                        conectasion.Close();
                        regresar_pantalla.usuario_conectado = new Usuario();
                        usuario_actual = new Usuario(nuevocorreo, nuevonombre, nuevacontraseña, usuario_actual.isAdmin());
                        regresar_pantalla.usuario_conectado = usuario_actual;
                    }
                    else {
                        MessageBox.Show("Error en la modificacion, se le regresara a la pantalla principal");
                    }
                    conectasion.Close();
                    regresar_pantalla.Visible = true;
                    this.Dispose();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
