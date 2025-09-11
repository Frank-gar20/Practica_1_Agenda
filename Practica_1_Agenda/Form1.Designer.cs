namespace Practica_1_Agenda
{
    partial class AGENDA
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SSInformacion = new System.Windows.Forms.StatusStrip();
            this.etiquetaSS1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MSmenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFDabrir = new System.Windows.Forms.OpenFileDialog();
            this.SFDguardar = new System.Windows.Forms.SaveFileDialog();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SSInformacion.SuspendLayout();
            this.MSmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // SSInformacion
            // 
            this.SSInformacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SSInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaSS1});
            this.SSInformacion.Location = new System.Drawing.Point(0, 373);
            this.SSInformacion.Name = "SSInformacion";
            this.SSInformacion.Size = new System.Drawing.Size(886, 22);
            this.SSInformacion.TabIndex = 0;
            this.SSInformacion.Text = "statusStrip1";
            // 
            // etiquetaSS1
            // 
            this.etiquetaSS1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.etiquetaSS1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.etiquetaSS1.Name = "etiquetaSS1";
            this.etiquetaSS1.Size = new System.Drawing.Size(0, 17);
            // 
            // MSmenu
            // 
            this.MSmenu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.MSmenu.Location = new System.Drawing.Point(0, 0);
            this.MSmenu.Name = "MSmenu";
            this.MSmenu.Size = new System.Drawing.Size(886, 26);
            this.MSmenu.TabIndex = 1;
            this.MSmenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoToolStripMenuItem.Text = "Limpiar tabla";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // DGVDatos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido_Pat,
            this.Apellido_mat,
            this.Direccion,
            this.Telefono,
            this.Correo});
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.Location = new System.Drawing.Point(0, 26);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.Size = new System.Drawing.Size(886, 347);
            this.DGVDatos.TabIndex = 2;
            // 
            // Nombre
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido_Pat
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_Pat.DefaultCellStyle = dataGridViewCellStyle3;
            this.Apellido_Pat.HeaderText = "Apellido Paterno";
            this.Apellido_Pat.Name = "Apellido_Pat";
            this.Apellido_Pat.Width = 120;
            // 
            // Apellido_mat
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_mat.DefaultCellStyle = dataGridViewCellStyle4;
            this.Apellido_mat.HeaderText = "Apellido Materno";
            this.Apellido_mat.Name = "Apellido_mat";
            this.Apellido_mat.Width = 120;
            // 
            // Direccion
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.DefaultCellStyle = dataGridViewCellStyle5;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // Telefono
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle6;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Correo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 150;
            // 
            // OFDabrir
            // 
            this.OFDabrir.FileName = "openFileDialog1";
            this.OFDabrir.Filter = "Agenda|*.json";
            // 
            // SFDguardar
            // 
            this.SFDguardar.Filter = "Agenda|*.json";
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 500;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AGENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 395);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.SSInformacion);
            this.Controls.Add(this.MSmenu);
            this.MainMenuStrip = this.MSmenu;
            this.Name = "AGENDA";
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SSInformacion.ResumeLayout(false);
            this.SSInformacion.PerformLayout();
            this.MSmenu.ResumeLayout(false);
            this.MSmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SSInformacion;
        private System.Windows.Forms.MenuStrip MSmenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.OpenFileDialog OFDabrir;
        private System.Windows.Forms.SaveFileDialog SFDguardar;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaSS1;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

