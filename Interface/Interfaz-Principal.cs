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

namespace Interface
{
    public partial class Interfaz_Principal : Form
    {
        public Interfaz_Principal()
        {
            InitializeComponent();
        }

        public Usuario usuario_conectado;
        public Reservacion reservacion_realizada;
        public Interfaz_Login cerrar_sesion;

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
            perfil_usuario.Show();
            this.Visible = false;
        }
    }
}
