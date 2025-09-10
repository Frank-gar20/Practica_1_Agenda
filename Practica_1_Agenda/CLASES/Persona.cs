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
        public String telefono { get; set; }
        public String correo { get; set; }

        public Persona()
        {

        }
        public Persona(String nombre, String telefono, String correo)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
