﻿using System;
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
            ingrearAc = new AcercaDe();
            ingrearAc.MdiParent = this;
            ingrearAc.Show();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MantenimientoUsuario frm = new MantenimientoUsuario();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void mantenimientoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ListaRoles frm = new ListaRoles();
            MantenimientoRoles frm = new MantenimientoRoles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mantenimientoDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientes frm = new ListaClientes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}