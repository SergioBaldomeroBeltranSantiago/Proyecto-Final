using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Reservacion
    {

        private int id, num_hab;
        private string correo_e_usuario;
        private double costo_reservacion;
        private DateTime inicio_reservacion, fin_reservacion;

        public Reservacion() { }

        public Reservacion(int id, int num, string correo_e, double costo, DateTime inicio, DateTime fin) {
            this.id = id;
            this.num_hab = num;
            this.correo_e_usuario = correo_e;
            this.costo_reservacion = costo;
            this.inicio_reservacion = inicio;
            this.fin_reservacion = fin;
        }

        public double CalcularCosto(int dias, double preciodia, int especial, float descuento) {
            return ((dias * preciodia)+especial)-(((dias * preciodia) + especial)*descuento);
        }

        public int getId() {
            return this.id;
        }

        public int getNum_hab() {
            return this.num_hab;
        }

        public string getCorreo_e_usuario() {
            return this.correo_e_usuario;
        }

        public double getCosto_reservacion() {
            return this.costo_reservacion;
        }

        public DateTime getInicio_reservacion() {
            return this.inicio_reservacion;
        }

        public DateTime getFin_reservacion() {
            return this.fin_reservacion;
        }
    }
}
