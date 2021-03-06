﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Usuario
    {

        private string correo_electronico, nombre_usuario, contraseña;
        private bool admin_status;

        public Usuario() { 
            
        }

        public Usuario(string correo_e, string nombre_us, string contra_us, bool admin_s) {
            this.correo_electronico = correo_e;
            this.contraseña = contra_us;
            this.nombre_usuario = nombre_us;
            this.admin_status = admin_s;
        }

        public string getCorreo_electronico() {
            return this.correo_electronico;
        }

        public string getNombre_usuario() {
            return this.nombre_usuario;
        }

        public string getContraseña() {
            return this.contraseña;
        }

        public bool isAdmin() {
            return this.admin_status;
        }
    }
}
