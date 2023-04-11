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
        private AcercaDe ingrearAc;
        public Principal()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ingrearAc = new AcercaDe();
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
