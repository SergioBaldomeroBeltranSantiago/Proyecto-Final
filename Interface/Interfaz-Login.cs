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
    public partial class Interfaz_Login : Form
    {

        public Interfaz_Login()
        {
            InitializeComponent();
        }

        Conexion conectar = new Conexion();
        bool CorreoValido = false, ContraseñaValida = false;

        private void Btn_InicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                string sqlquery = "SELECT * FROM Usuarios WHERE correo_electronico ='" + Txt_CorreoE.Text + "' AND contraseña ='" + Txt_Contraseña.Text + "'";
                MySqlDataReader row = conectar.ExecuteReader(sqlquery);
                if (row.HasRows)
                {
                    Interfaz_Principal login_exitoso = new Interfaz_Principal();
                    login_exitoso.Show();
                    while (row.Read())
                    {
                        login_exitoso.usuario_conectado = new Usuario(row["correo_electronico"].ToString(), row["nombre_usuario"].ToString(), row["contraseña"].ToString(), Convert.ToBoolean(row["adminstatus"]));
                    }
                    login_exitoso.cerrar_sesion = this;
                    login_exitoso.lb_NombreUsuario.Text = row["nombre_usuario"].ToString();
                    this.Visible = false;
                }
                else {
                    MessageBox.Show("Usuario no existente o contraseña incorrecta, favor de verificar los datos");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Base de datos vacia." + ex.Message);
            }
        }

        private void Btn_Registro_Click(object sender, EventArgs e)
        {
            Interfaz_Registro registro_usuario = new Interfaz_Registro();
            registro_usuario.cancelar_registro = this;
            registro_usuario.Show();
            this.Visible = false;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_CorreoE_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_CorreoE.Text != "")
            {
                CorreoValido = Cerebro.ValidarFormatoCorreo(Txt_CorreoE.Text);
                if (CorreoValido)
                {
                    Lb_Correo.Text = "Formato de correo valido.";
                    Lb_Correo.ForeColor = Color.Green;
                }
                else
                {
                    Lb_Correo.Text = "Formato de correo invalido.";
                    Lb_Correo.ForeColor = Color.Red;
                }
                UnlockButton();
            }
            else
            {
                Lb_Correo.Text = "";
            }
        }

        private void Txt_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_Contraseña.Text != "")
            {
                ContraseñaValida = Cerebro.ValidarFormatoContraseña(Txt_Contraseña.Text);
                if (ContraseñaValida)
                {
                    Lb_Contraseña.Text = "Formato de contraseña valido.";
                    Lb_Contraseña.ForeColor = Color.Green;
                }
                else
                {
                    Lb_Contraseña.Text = "Formato de contraseña invalido.";
                    Lb_Contraseña.ForeColor = Color.Red;
                }
                UnlockButton();
            }
            else
            {
                Lb_Contraseña.Text = "";
            }
        }

        private void UnlockButton()
        {
            if (CorreoValido && ContraseñaValida)
            {
                Btn_InicioSesion.Enabled = true;
            }
            else
            {
                Btn_InicioSesion.Enabled = false;
            }
        }
    }
}
