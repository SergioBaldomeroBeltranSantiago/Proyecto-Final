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
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        private InterfazRealizarAgenda inra;
        private InterfazLibroAgendas inla;
        private InterfazSesion ins;

        private void Btn_RealizarAgenda_Click(object sender, EventArgs e)
        {
            inra = new InterfazRealizarAgenda();
            inra.Show();
        }

        private void Btn_LibroAgenda_Click(object sender, EventArgs e)
        {
            inla = new InterfazLibroAgendas();
            inra.Show();
        }

        private void Btn_Sesion_Click(object sender, EventArgs e)
        {
            ins = new InterfazSesion();
            ins.Show();
        }
    }
}
