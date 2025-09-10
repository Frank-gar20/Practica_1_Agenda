using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
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

        private String ruta = "Agenda.json";
        public BaseDatosJson()
        {
            persona = new List<Persona>();
            UltimaActualizacion = DateTime.Now;
            Abrir();
        }

        public void Abrir()
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                var baseDatos = JsonConvert.DeserializeObject<BaseDatosJson>(json);

                if (baseDatos != null)
                {
                    this.persona = baseDatos.persona ?? new List<Persona>();
                    this.UltimaActualizacion = baseDatos.UltimaActualizacion;
                    this.totalRegistros = baseDatos.totalRegistros;
                }
            }
        }

        public void Guardar()
        {
            UltimaActualizacion = DateTime.Now;
            totalRegistros = persona.Count;
            String json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(ruta, json);
        }

        public void agregar(Persona per)
        {
            persona.Add(per);
            Guardar();
        }

        public void actualizar()
        {
            Guardar();
        }
    }
}
