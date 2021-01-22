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
    public partial class Interfaz_Registro : Form
    {
        public Interfaz_Registro()
        {
            InitializeComponent();
        }

        public Interfaz_Login cancelar_registro;
        Conexion conectar = new Conexion();
        bool CorreoValido = false, NombreIngresado = false, ContraseñaValida = false,MismaContraseña=false;

        private void Btn_IniciarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                string isadmin = (Txt_CodigoAdmin.Text.ToLower().Equals("bird is the word") ? 1 : 0).ToString();
                string query = "INSERT INTO proyecto.usuarios(correo_electronico,nombre_usuario,contraseña,adminstatus) VALUES ('" + Txt_NuevoCorreo.Text + "','" + Txt_NuevoNombre.Text + "','" + Txt_NuevaContraseñaOne.Text + "','" + isadmin + "')";
                MySqlDataReader pepe;
                pepe = conectar.ExecuteReader(query);
                MessageBox.Show("Usuario registrado con exito. Ahora se le regresara a la pantalla de inicio de sesion");
                try
                {
                    while (pepe.Read()) { }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conectar.Close();
                cancelar_registro.Visible = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelar_registro.Visible = true;
            this.Dispose();
        }

        private void Txt_NuevoCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NuevoCorreo.Text != "")
            {
                if (Cerebro.ValidarFormatoCorreo(Txt_NuevoCorreo.Text))
                {
                    Lb_Correo.Text = "Formato de correo valido.";
                    Lb_Correo.ForeColor = Color.Green;
                    CorreoValido = true;
                }
                else {
                    Lb_Correo.Text = "Formato de correo invalido.";
                    Lb_Correo.ForeColor = Color.Red;
                    CorreoValido = false;
                }
            }
            else {
                Lb_Correo.Text = "";
            }
            UnlockButton();
        }

        private void Txt_NuevoNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NuevoNombre.Text != "")
            {
                NombreIngresado = true;
            }
            else
            {
                NombreIngresado = false;
            }
            UnlockButton();
        }

        private void Txt_NuevaContraseñaOne_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NuevaContraseñaOne.Text != "")
            {
                if (Cerebro.ValidarFormatoContraseña(Txt_NuevaContraseñaOne.Text))
                {
                    Lb_ContraseñaOne.Text = "Formato de contraseña valido.";
                    Lb_ContraseñaOne.ForeColor = Color.Green;
                    ContraseñaValida = true;
                }
                else
                {
                    Lb_ContraseñaOne.Text = "Formato de contraseña invalido.";
                    Lb_ContraseñaOne.ForeColor = Color.Red;
                    ContraseñaValida = false;
                }
            }
            else
            {
                Lb_ContraseñaOne.Text = "";
                Lb_MismaContraseña.Text = "";
            }
            CheckSamePassword();
            UnlockButton();
        }

        private void Txt_NuevaContraseñaTwo_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_NuevaContraseñaTwo.Text != "")
            {
                if (Cerebro.ValidarFormatoContraseña(Txt_NuevaContraseñaTwo.Text))
                {
                    Lb_ContraseñaTwo.Text = "Formato de contraseña valido.";
                    Lb_ContraseñaTwo.ForeColor = Color.Green;
                    ContraseñaValida = true;
                }
                else
                {
                    Lb_ContraseñaTwo.Text = "Formato de contraseña invalido.";
                    Lb_ContraseñaTwo.ForeColor = Color.Red;
                    ContraseñaValida = false;
                }
            }
            else
            {
                Lb_ContraseñaTwo.Text = "";
                Lb_MismaContraseña.Text = "";
            }
            CheckSamePassword();
            UnlockButton();
        }

        private void UnlockButton() {
            if (CorreoValido && NombreIngresado && ContraseñaValida && MismaContraseña)
            {
                Btn_IniciarRegistro.Enabled = true;
            }
            else {
                Btn_IniciarRegistro.Enabled = false;
            }
        }

        private void CheckSamePassword() {
            if (Txt_NuevaContraseñaOne.Text != "" && Txt_NuevaContraseñaTwo.Text != "") {
                if (ContraseñaValida)
                {
                    MismaContraseña = Txt_NuevaContraseñaOne.Text.Equals(Txt_NuevaContraseñaTwo.Text);
                    if (MismaContraseña)
                    {
                        Lb_MismaContraseña.Text = "Contraseñas aceptadas";
                        Lb_MismaContraseña.ForeColor = Color.Green;
                    }
                    else
                    {
                        Lb_MismaContraseña.Text = "Las contraseñas deben coincidir.";
                        Lb_MismaContraseña.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
