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
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public int IdPersona { get; set; }
        #endregion
        public MantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {
            #region Carga de listados
            RolesController NegociosRoles = new RolesController();
            this.cmbrol.DisplayMember = "Text";
            this.cmbrol.ValueMember = "Value";

            var RolesDataSource = NegociosRoles.Mostrar().Select(x => new
            {
                Text = x.NombreRol,
                Value = x.Id_Rol
            });
            this.cmbrol.DataSource = RolesDataSource.ToArray();
            this.cmbGenero.DisplayMember = "Text";
            this.cmbGenero.ValueMember = "Value";
            List<dynamic> Generos = new List<dynamic> {
                new { Text = "Masculino", Value = "Masculino" },
                new { Text = "Femenino", Value = "Femenino" },
                new { Text = "No indicado", Value = "NA" }
            };
            
            var GenerosArray = Generos.Select(x => new { x.Text, x.Value }).ToArray();
            this.cmbGenero.DataSource = GenerosArray;
            #endregion

            if (Accion == "A")
            {
                this.lblid.Visible = false;
                this.txtId.Visible = false;
            }
            if (Accion == "M" || Accion == "C")
            {
                this.Text = "Modificar usuario";
                this.txtId.Enabled = false;
               // llenar();
                this.txtApellido1.Enabled = true;
                this.txtApellido2.Enabled = true;
                this.txtCorreo.Enabled = true;
                this.txtNombre.Enabled = true;
                this.txtTelefono1.Enabled = true;
                this.txtTelefono2.Enabled = true;
                if (Accion == "C")
                {
                    this.Text = "Consultar usuario";
                    this.groupBox2.Enabled = false;
                    this.groupBox2.Enabled = false;
                }
            }

        }
    }
}
