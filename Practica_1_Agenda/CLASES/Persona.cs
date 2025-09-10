using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Agenda.CLASES
{
    internal class Persona
    {
        public String nombre { get; set; }
        public String apellido_pat { get; set; }
        public String apellido_mat { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }

        public Persona()
        {

        }
        public Persona(String nombre, String apellido_Pat, String apellido_mat, String direccion, String telefono, String correo)
        {
            this.nombre = nombre;
            this.apellido_pat = apellido_Pat;
            this.apellido_mat = apellido_mat;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
        }
    }
}
