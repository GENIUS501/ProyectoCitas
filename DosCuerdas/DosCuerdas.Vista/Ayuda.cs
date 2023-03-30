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
        public Ayuda()
        {
            InitializeComponent();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Systare\Systare\MANUAL DE USUARIO.pdf");//aqui va la direccion del manuel
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
