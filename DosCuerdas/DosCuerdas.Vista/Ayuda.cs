using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DosCuerdas.Vista
{
    public partial class Ayuda : Form
    {
        string Ruta = "";
        public Ayuda()
        {
            InitializeComponent();
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Ruta.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar el pdf", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                Ruta = (0, 0, path + "/Ayuda.pdf").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
