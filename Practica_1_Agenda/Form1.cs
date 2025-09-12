using Newtonsoft.Json;
using Practica_1_Agenda.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Practica_1_Agenda
{
    public partial class AGENDA : Form
    {
        public String ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "informacion.json");
        public AGENDA()
        {
            InitializeComponent();
            //globo de notifiacion
            NInotificacion.Icon = SystemIcons.Information;
            NInotificacion.Visible = true;
            NInotificacion.BalloonTipTitle = "BIENVENIDO";
            NInotificacion.BalloonTipText = "Tu agenda está lista para hoy!!! \n Que tengas buen dia";
            NInotificacion.BalloonTipIcon = ToolTipIcon.Info;
            NInotificacion.ShowBalloonTip(4000);

            if (File.Exists(ruta) == false)
            {
                var comodin = new BaseDatosJson
                {
                    persona = new List<Persona>(),
                    totalRegistros = 0,
                    UltimaActualizacion = DateTime.Now
                };
                guardar(comodin);
            }
            try
            {                
                String json = File.ReadAllText(ruta);
                var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                cargar(registros);
                etiquetaSS1.Text = "Fecha de guardado: " + registros.UltimaActualizacion.ToString() + "\n  Registros: " + registros.persona.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estas seguro de limpiar tu agenda?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                DGVDatos.Rows.Clear();
                NInotificacion.Icon = SystemIcons.Information;
                NInotificacion.Visible = true;
                NInotificacion.BalloonTipTitle = "Tabla Limpia";
                NInotificacion.BalloonTipText = "Tabla limpiada correctamente";
                NInotificacion.BalloonTipIcon = ToolTipIcon.Info;
                NInotificacion.ShowBalloonTip(3000);
            }
            else
                return;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guardar(BaseDatosJson lista)
        {
            var Caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,
            };
            String json = JsonConvert.SerializeObject(lista, Caracteristicas);
            File.WriteAllText(ruta,json);
        }

        private BaseDatosJson Abrir()
        {
            var registros = new BaseDatosJson();
            foreach (DataGridViewRow fila in DGVDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? "";
                    persona.apellido_pat = fila.Cells[1].Value?.ToString() ?? "";
                    persona.apellido_mat = fila.Cells[2].Value?.ToString() ?? "";
                    persona.direccion = fila.Cells[3].Value?.ToString() ?? "";
                    persona.telefono = fila.Cells[4].Value?.ToString() ?? "";
                    persona.correo = fila.Cells[5].Value?.ToString() ?? "";
                }
                registros.persona.Add(persona);
            }
            registros.totalRegistros = registros.persona.Count;
            return registros;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cargar(BaseDatosJson registros)
        {
            DGVDatos.Rows.Clear();
            foreach (var registro in registros.persona)
            {
                DGVDatos.Rows.Add(new object[] { registro.nombre, registro.apellido_pat, registro.apellido_mat, registro.direccion, registro.telefono, registro.correo });
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            try
            {
                var BaseDatos = Abrir();
                guardar(BaseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
