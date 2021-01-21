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
    }
}
