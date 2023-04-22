namespace DosCuerdas.Vista
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Agendar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.ReporteAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacoras = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.Agendar,
            this.Cancelar,
            this.Mantenimientos,
            this.Reportes,
            this.Bitacoras});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem1,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem2});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem1.Text = "Cerrar Sesión";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem2
            // 
            this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            this.salirToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem2.Text = "Salir";
            this.salirToolStripMenuItem2.Click += new System.EventHandler(this.salirToolStripMenuItem2_Click);
            // 
            // Agendar
            // 
            this.Agendar.Name = "Agendar";
            this.Agendar.Size = new System.Drawing.Size(100, 20);
            this.Agendar.Text = "Agendar Clases";
            this.Agendar.Click += new System.EventHandler(this.mantenimieToolStripMenuItem_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(147, 20);
            this.Cancelar.Text = "Modificar citas de clases";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Mantenimientos
            // 
            this.Mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoEstudiantes,
            this.MantenimientoClientes,
            this.MantenimientoRoles,
            this.MantenimientoProfesores,
            this.MantenimientoUsuarios});
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Size = new System.Drawing.Size(106, 20);
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // MantenimientoEstudiantes
            // 
            this.MantenimientoEstudiantes.Name = "MantenimientoEstudiantes";
            this.MantenimientoEstudiantes.Size = new System.Drawing.Size(235, 22);
            this.MantenimientoEstudiantes.Text = "Mantenimiento de Estudientes";
            this.MantenimientoEstudiantes.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // MantenimientoClientes
            // 
            this.MantenimientoClientes.Name = "MantenimientoClientes";
            this.MantenimientoClientes.Size = new System.Drawing.Size(235, 22);
            this.MantenimientoClientes.Text = "Mantenimiento de Clientes";
            this.MantenimientoClientes.Click += new System.EventHandler(this.mantenimientoDeClienteToolStripMenuItem_Click);
            // 
            // MantenimientoRoles
            // 
            this.MantenimientoRoles.Name = "MantenimientoRoles";
            this.MantenimientoRoles.Size = new System.Drawing.Size(235, 22);
            this.MantenimientoRoles.Text = "Mantenimiento de Roles";
            this.MantenimientoRoles.Click += new System.EventHandler(this.mantenimientoDeToolStripMenuItem_Click);
            // 
            // MantenimientoProfesores
            // 
            this.MantenimientoProfesores.Name = "MantenimientoProfesores";
            this.MantenimientoProfesores.Size = new System.Drawing.Size(235, 22);
            this.MantenimientoProfesores.Text = "Mantenimiento de Profesores";
            this.MantenimientoProfesores.Click += new System.EventHandler(this.mantenimientoDeToolStripMenuItem1_Click);
            // 
            // MantenimientoUsuarios
            // 
            this.MantenimientoUsuarios.Name = "MantenimientoUsuarios";
            this.MantenimientoUsuarios.Size = new System.Drawing.Size(235, 22);
            this.MantenimientoUsuarios.Text = "Mantenimiento de Usuarios";
            this.MantenimientoUsuarios.Click += new System.EventHandler(this.mantenimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteEstudiantes,
            this.reporteProfesores,
            this.ReporteAgenda});
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 20);
            this.Reportes.Text = "Reportes";
            // 
            // reporteEstudiantes
            // 
            this.reporteEstudiantes.Name = "reporteEstudiantes";
            this.reporteEstudiantes.Size = new System.Drawing.Size(225, 22);
            this.reporteEstudiantes.Text = "Reporte de Estudiantes";
            this.reporteEstudiantes.Click += new System.EventHandler(this.reporteDeEstudiantreToolStripMenuItem_Click);
            // 
            // reporteProfesores
            // 
            this.reporteProfesores.Name = "reporteProfesores";
            this.reporteProfesores.Size = new System.Drawing.Size(225, 22);
            this.reporteProfesores.Text = "Reporte de Profesores";
            this.reporteProfesores.Click += new System.EventHandler(this.reporteDeToolStripMenuItem_Click);
            // 
            // ReporteAgenda
            // 
            this.ReporteAgenda.Name = "ReporteAgenda";
            this.ReporteAgenda.Size = new System.Drawing.Size(225, 22);
            this.ReporteAgenda.Text = "Reporte de clases agendadas";
            this.ReporteAgenda.Click += new System.EventHandler(this.ReporteAgenda_Click);
            // 
            // Bitacoras
            // 
            this.Bitacoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraIngresos,
            this.bitacoraMovimientos});
            this.Bitacoras.Name = "Bitacoras";
            this.Bitacoras.Size = new System.Drawing.Size(67, 20);
            this.Bitacoras.Text = "Bitacoras";
            // 
            // bitacoraIngresos
            // 
            this.bitacoraIngresos.Name = "bitacoraIngresos";
            this.bitacoraIngresos.Size = new System.Drawing.Size(201, 22);
            this.bitacoraIngresos.Text = "Bitcora de Ingreso";
            this.bitacoraIngresos.Click += new System.EventHandler(this.bitcoraDeToolStripMenuItem_Click);
            // 
            // bitacoraMovimientos
            // 
            this.bitacoraMovimientos.Name = "bitacoraMovimientos";
            this.bitacoraMovimientos.Size = new System.Drawing.Size(201, 22);
            this.bitacoraMovimientos.Text = "Bitacora de Movimiento";
            this.bitacoraMovimientos.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 355);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Agendar;
        private System.Windows.Forms.ToolStripMenuItem Mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoClientes;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoRoles;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoProfesores;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem reporteEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem reporteProfesores;
        private System.Windows.Forms.ToolStripMenuItem ReporteAgenda;
        private System.Windows.Forms.ToolStripMenuItem Bitacoras;
        private System.Windows.Forms.ToolStripMenuItem bitacoraIngresos;
        private System.Windows.Forms.ToolStripMenuItem bitacoraMovimientos;
        private System.Windows.Forms.ToolStripMenuItem Cancelar;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

