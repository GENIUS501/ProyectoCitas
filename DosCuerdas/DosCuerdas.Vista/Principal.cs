using DosCuerdas.Controlador;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DosCuerdas.Vista
{
    public partial class Principal : Form
    {
        #region Variables
        public int Idsession { get; set; }
        public EUsuarios UsuarioLogueado { get; set; }
        #endregion
        public Principal()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        private void Cerrar()
        {
            try
            {
                EBitacora_Sesiones Ses = new EBitacora_Sesiones();
                Bitacora_SesionesController Negocios = new Bitacora_SesionesController();
                Int32 FilasAfectadas;
                Ses.codigo_ingreso_salida = Idsession;
                Ses.fecha_hora_salida = DateTime.Now;
                FilasAfectadas = Negocios.Modificar(Ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AcercaDe ingrearAc = new AcercaDe();
                ingrearAc.MdiParent = this;
                ingrearAc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListaUsuarios frm = new ListaUsuarios();
                frm.Usuario = UsuarioLogueado.Id_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol??0;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListaRoles frm = new ListaRoles();
                frm.Usuario = UsuarioLogueado.Id_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol ?? 0;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListaClientes frm = new ListaClientes();
                frm.Usuario = UsuarioLogueado.Id_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol ?? 0;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListaEstudiantes frm = new ListaEstudiantes();
                frm.Usuario = UsuarioLogueado.Id_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol ?? 0;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mantenimientoDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ListaProfesores frm = new ListaProfesores();
                frm.Usuario = UsuarioLogueado.Id_Usuario;
                frm.Id_Rol = UsuarioLogueado.Id_Rol ?? 0;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteDeEstudiantreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteEstudiantes frm = new ReporteEstudiantes();
                frm.Usuario = UsuarioLogueado.Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteProfesores frm = new ReporteProfesores();
                frm.Usuario = UsuarioLogueado.Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AgendarClases frm = new AgendarClases();
                frm.Usuario = UsuarioLogueado.Id_Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EBitacora_Sesiones Ses = new EBitacora_Sesiones();
            Bitacora_SesionesController Negocios = new Bitacora_SesionesController();
            Int32 FilasAfectadas;
            Ses.codigo_ingreso_salida = Idsession;
            Ses.fecha_hora_salida = DateTime.Now;
            FilasAfectadas = Negocios.Modificar(Ses);
            if (FilasAfectadas > 0)
            {
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cerrar();
        }

        private void bitcoraDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BitacoraSesiones frm = new BitacoraSesiones();
                frm.Usuariologueado = UsuarioLogueado.Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BitacoraMovimientos frm = new BitacoraMovimientos();
                frm.Usuario = UsuarioLogueado.Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
