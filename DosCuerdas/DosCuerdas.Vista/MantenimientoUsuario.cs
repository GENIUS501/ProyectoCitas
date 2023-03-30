using DosCuerdas.Controlador;
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
    public partial class MantenimientoUsuario : Form
    {
        #region Variables
        UsuariosController controladorUsuarios;
        #endregion
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
