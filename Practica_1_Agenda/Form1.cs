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

namespace Practica_1_Agenda
{
    public partial class AGENDA : Form
    {
        private BaseDatosJson baseDatos;
        public AGENDA()
        {
            InitializeComponent();


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
            DialogResult res = MessageBox.Show("¿Estas seguro de Generar un archivo nuevo?","Sistema",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                DGVDatos.Rows.Clear();
            else
                return;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var baseDatos = Abirir();
                if (SFDguardar.ShowDialog() == DialogResult.OK)
                {
                    guardar(baseDatos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            File.WriteAllText(SFDguardar.FileName, json);
        }

        private BaseDatosJson Abirir()
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
            if (OFDabrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String json = File.ReadAllText(OFDabrir.FileName);
                    var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                    cargar(registros);
                    etiquetaSS1.Text = "Fecha de guardado: "+ registros.UltimaActualizacion.ToString() + "\n  Registros: " + registros.persona.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cargar(BaseDatosJson registros)
        {
            DGVDatos.Rows.Clear();
            foreach (var registro in registros.persona)
            {
                DGVDatos.Rows.Add(new object[] { registro.nombre, registro.telefono, registro.correo });
            }
        }
    }
}
