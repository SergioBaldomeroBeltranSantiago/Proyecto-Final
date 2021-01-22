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

namespace Interface
{
    public partial class Interfaz_ModificarCuenta : Form
    {
        public Interfaz_ModificarCuenta()
        {
            InitializeComponent();
        }

        public Usuario usuario_actual;
        public Interfaz_Principal regresar_pantalla;

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            regresar_pantalla.Visible = true;
            this.Dispose();
        }
    }
}
