using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Usuario
    {
        private string Nombre,Correo_E,Contraseña;
        private bool isAdmin;

        public Usuario(string Nombre_entrada, string Correo_E_entrada, string Contraseña_entrada, bool isAdmin_entrada) {
            Nombre = Nombre_entrada;
            Correo_E = Correo_E_entrada;
            Contraseña = Contraseña_entrada;
            isAdmin = isAdmin_entrada;
        }
    }
}
