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

        private void Btn_InicioSesion_Click(object sender, EventArgs e)
        {
            if (!Txt_Contraseña.Text.Equals("") && !Txt_CorreoE.Text.Equals(""))
            {

                if (Cerebro.ValidarFormatoCorreo(Txt_CorreoE.Text) && Cerebro.ValidarFormatoContraseña(Txt_Contraseña.Text))
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
                            while (row.Read()) {
                                login_exitoso.usuario_conectado = new Usuario(row["correo_electronico"].ToString(), row["nombre_usuario"].ToString(), row["contraseña"].ToString(), Convert.ToBoolean(row["adminstatus"]));
                            }
                            login_exitoso.cerrar_sesion = this;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error de identificación, favor de verificar datos.");
                        }
                    }
                    catch (NullReferenceException ex) {
                        MessageBox.Show("Error de identificación, favor de verificar datos."+ex.Message);
                    }
                }
                else
                {
                    if (!Cerebro.ValidarFormatoCorreo(Txt_CorreoE.Text) && !Cerebro.ValidarFormatoContraseña(Txt_Contraseña.Text))
                    {
                        MessageBox.Show("Correo electronico y contraseña no validos.");
                    }
                    else if (!Cerebro.ValidarFormatoCorreo(Txt_CorreoE.Text))
                    {
                        MessageBox.Show("Direccion de correo electronico invalida.");
                    }
                    else
                    {
                        MessageBox.Show("Contraseña invalida, debe contener al menos 8 caracteres.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos de correo electronico y contraseña antes de continuar.");
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
    }
}
