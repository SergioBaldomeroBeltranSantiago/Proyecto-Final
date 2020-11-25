using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Reservacion
    {
        private Usuario Reservador;
        private DateTime Fecha_Inicio;
        private DateTime Fecha_Final;
        private Double Precio_Reservacion;

        public Reservacion(Usuario Reservador_entrada, DateTime Fecha_Inicio_entrada, DateTime Fecha_Final_entrada, Double Precio_Reservacion_entrada) {
            Reservador = Reservador_entrada;
            Fecha_Inicio = Fecha_Inicio_entrada;
            Fecha_Final = Fecha_Final_entrada;
            Precio_Reservacion = Precio_Reservacion_entrada;
        }
    }
}
