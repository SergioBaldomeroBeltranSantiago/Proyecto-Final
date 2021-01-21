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

        private void Btn_IniciarRegistro_Click(object sender, EventArgs e)
        {
            if (!(Txt_NuevoCorreo.Text.Equals("") || Txt_NuevoNombre.Text.Equals("") || Txt_NuevaContraseñaOne.Text.Equals("") || Txt_NuevaContraseñaTwo.Text.Equals("")))
            {
                if (Cerebro.ValidarFormatoContraseña(Txt_NuevaContraseñaOne.Text))
                {
                    if (Txt_NuevaContraseñaOne.Text.Equals(Txt_NuevaContraseñaTwo.Text))
                    {
                        if (Cerebro.ValidarFormatoCorreo(Txt_NuevoCorreo.Text))
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
                                catch (NullReferenceException ex) {
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
                        else
                        {
                            MessageBox.Show("Debe ingresar un correo electronico valido para continuar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ambas contraseñas deben coincidir para continuar.");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe contener al menos 8 caracteres o digitos.");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos no opcionales antes de continuar.");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelar_registro.Visible = true;
            this.Dispose();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
