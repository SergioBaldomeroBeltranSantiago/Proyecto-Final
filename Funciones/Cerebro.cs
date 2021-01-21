using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Funciones
{
    public class Cerebro
    {

        public static bool ValidarFormatoCorreo(string correo_electronico) {
            Regex validar = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})*$");
            return validar.IsMatch(correo_electronico);
        }

        public static bool ValidarFormatoContraseña(string contraseña) {
            Regex validar = new Regex(@"^.{8,}$");
            return validar.IsMatch(contraseña);
        }
    }
}
