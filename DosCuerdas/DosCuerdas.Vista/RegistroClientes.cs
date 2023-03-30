using System;
using System.Collections;
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
    public partial class RegistroClientes : Form
    {
        //private DataTable datos;
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void agregar()
        {
            try
            {


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            this.txtCedula.Clear();
            this.txtNombre.Clear();
            this.txtApellido1.Clear();
            this.txtApellido2.Clear();
            this.txtTelefono1.Clear();
            this.txtTelefono2.Clear();
            this.txtCorreo.Clear();
            this.txtDireccion.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            agregar();
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
