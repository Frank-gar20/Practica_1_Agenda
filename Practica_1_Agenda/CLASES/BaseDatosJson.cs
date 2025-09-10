using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Agenda.CLASES
{
    internal class BaseDatosJson
    {
        public List<Persona> persona { get; set; }
        public DateTime UltimaActualizacion { get; set; }
        public int totalRegistros { get; set; }
        public BaseDatosJson()
        {
            persona = new List<Persona>();
            UltimaActualizacion = DateTime.Now;
        }
    }
}
