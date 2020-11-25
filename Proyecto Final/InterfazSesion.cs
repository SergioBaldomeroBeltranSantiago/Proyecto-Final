using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class InterfazSesion : Form
    {
        public InterfazSesion()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!(txtUNNombre.Text.Equals("") || txtUNCorreo.Text.Equals("") || txtUNContraseña.Text.Equals("") || txtUNContraConfirm.Text.Equals(""))) {
                if (txtUNCorreo.Text.Contains(".com") && txtUNCorreo.Text.Contains("@")&&txtUNContraseña.Text.Equals(txtUNContraConfirm.Text)) {
                    Usuario usuario_nuevo = new Usuario(txtUNNombre.Text, txtUNCorreo, txtUNContraseña, txtUNContraConfirm, false);
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
