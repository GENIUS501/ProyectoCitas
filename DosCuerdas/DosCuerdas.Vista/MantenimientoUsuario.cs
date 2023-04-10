using DosCuerdas.Controlador;
using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string UsuarioViniente = string.Empty;
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
                new { Text = "No indicado", Value = "NA" },
                new { Text = "Femenino", Value = "Femenino" },
                new { Text = "Masculino", Value = "Masculino" }
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
                this.txtClave.Enabled = true;
                this.txtNombre.Enabled = true;
                this.txtTelefono1.Enabled = true;
                this.txtTelefono2.Enabled = true;
                this.txtFechaNac.Enabled = true;
                this.cmbGenero.Enabled = true;
                if (Accion == "C")
                {
                    this.Text = "Consultar usuario";
                    this.GrpDatosPersonales.Enabled = false;
                    this.groupBox2.Enabled = false;
                }
            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                var Existe = llenarDatosPersonales();
                if (!Existe && Accion == "A")
                {
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtTelefono1.Enabled = true;
                    this.txtTelefono2.Enabled = true;
                    this.txtFechaNac.Enabled = true;
                    this.cmbGenero.Enabled = true;
                }
                else if (Accion == "M")
                {
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtTelefono1.Enabled = true;
                    this.txtTelefono2.Enabled = true;
                    this.txtFechaNac.Enabled = true;
                    this.cmbGenero.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenar()
        {
            UsuariosController Controller = new UsuariosController();
            EUsuarios obj = new EUsuarios();
            obj = Controller.Mostrar().Where(x => x.Id_Usuario == Id).FirstOrDefault();
            if (obj != null)
            {
                this.txtCedula.Text = obj.Cedula;
                this.txtNombre.Text = obj.Nombre;
                this.txtApellido1.Text = obj.PrimerApellido;
                this.txtApellido2.Text = obj.SegundoApellido;
                this.txtCorreo.Text = obj.Correo;
                this.txtTelefono1.Text = obj.Telefono;
                this.txtTelefono2.Text = obj.TelefonoAdisional;
                this.txtId.Text = obj.Id_Usuario.ToString();
                this.txtFechaNac.Text = obj.FechaNacimiento.ToString();
                this.cmbGenero.SelectedValue = obj.Genero;
                IdPersona = obj.ID_PERSONA;
            }
        }
        private bool llenarDatosPersonales()
        {
            bool Existe = false;
            PersonasController Controller = new PersonasController();
            EPersonas obj = new EPersonas();
            obj = Controller.Mostrar().Where(x => x.Cedula == this.txtCedula.Text).FirstOrDefault();
            if (obj != null)
            {
                this.txtNombre.Text = obj.Nombre;
                this.txtApellido1.Text = obj.PrimerApellido;
                this.txtApellido2.Text = obj.SegundoApellido;
                this.txtCorreo.Text = obj.Correo;
                this.txtTelefono1.Text = obj.Telefono;
                this.txtTelefono2.Text = obj.TelefonoAdisional;
                this.txtFechaNac.Text = obj.FechaNacimiento.ToString();
                this.cmbGenero.SelectedValue = obj.Genero;
                IdPersona = obj.ID_PERSONA;
                Existe = true;
            }
            else
            {
                IdPersona = 0;
            }
            return Existe;
        }

        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txtUsuario.Text == "")
                {
                    errorProvider1.SetError(this.txtUsuario, "Debe ingresar el nombre de usuario");
                    ok = true;
                }
                if (this.txtCedula.Text.Length < 9)
                {
                    errorProvider1.SetError(this.txtCedula, "Formato de cedula invalido.");
                    ok = true;
                }

                if (this.txtNombre.Text == "")
                {
                    errorProvider1.SetError(this.txtNombre, "Debe ingresar el nombre");
                    ok = true;
                }
                if (this.txtApellido1.Text == "")
                {
                    errorProvider1.SetError(this.txtApellido1, "Debe ingresar el primer apellido");
                    ok = true;
                }
                if (this.txtApellido2.Text == "")
                {
                    errorProvider1.SetError(this.txtApellido2, "Debe ingresar el segundo apellido");
                    ok = true;
                }
                if (this.txtTelefono1.Text == "")
                {
                    errorProvider1.SetError(this.txtTelefono1, "Debe ingresar el telefono");
                    ok = true;
                }
                if (this.txtTelefono2.Text == "")
                {
                    errorProvider1.SetError(this.txtTelefono2, "Debe ingresar el telefono adicional");
                    ok = true;
                }
                if (this.txtTelefono1.TextLength != 8)
                {
                    errorProvider1.SetError(this.txtTelefono1, "El formato esta incorrecto.");
                    ok = true;
                }
                if (this.txtTelefono2.TextLength != 8)
                {
                    errorProvider1.SetError(this.txtTelefono2, "El formato esta incorrecto.");
                    ok = true;
                }
                if (this.txtCorreo.Text == "")
                {
                    errorProvider1.SetError(this.txtCorreo, "Debe ingresar el correo");
                    ok = true;
                }
                String expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(this.txtCorreo.Text, expresion))
                {
                    if (Regex.Replace(this.txtCorreo.Text, expresion, String.Empty).Length == 0)
                    {

                    }
                    else
                    {
                        errorProvider1.SetError(this.txtCorreo, "Formato de correo invalido");
                        ok = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(this.txtCorreo, "Formato de correo invalido");
                    ok = true;
                }
                if (this.txtClave.Text != this.txtCClave.Text && Accion == "A")
                {
                    errorProvider1.SetError(this.txtCClave, "Las contraseñas no coinciden.");
                    ok = true;
                }
                Regex Regexa = new Regex(@"^(?=.*[\d])(?=.*[A-Z])(?=.*[a-z])[\w\d]{8,}$");
                Match Match = Regexa.Match(this.txtClave.Text);
                if (Match.Success || this.txtClave.Text == "********")
                {

                }
                else
                {
                    errorProvider1.SetError(this.txtClave, "La contraseña debe de tener un mínimo de 8 caracteres, con lo siguiente: " +
                    "\n Al menos una mayúscula" +
                    "\n Al menos una minúscula" +
                    "\n Al menos un número" +
                    "\n No debe tener caracteres especiales ni espacios");
                    ok = true;
                }
                if (this.cmbrol.SelectedValue == null)
                {
                    errorProvider1.SetError(this.cmbrol, "Debe seleccionar un rol");
                    ok = true;
                }
                if (this.txtUsuario.Text != UsuarioViniente && Accion == "M" && this.txtClave.Text == "********")
                {
                    errorProvider1.SetError(this.txtClave, "Debe cambiar la clave necesariamente si cambia el usuario.");
                    ok = true;
                }
                //
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ok;
        }
        private void borrar_error()
        {
            try
            {
                errorProvider1.SetError(this.txtCedula, "");
                errorProvider1.SetError(this.txtApellido1, "");
                errorProvider1.SetError(this.txtApellido2, "");
                errorProvider1.SetError(this.txtCorreo, "");
                errorProvider1.SetError(this.txtId, "");
                errorProvider1.SetError(this.txtNombre, "");
                errorProvider1.SetError(this.txtTelefono1, "");
                errorProvider1.SetError(this.txtTelefono2, "");
                errorProvider1.SetError(this.cmbrol, "");
                errorProvider1.SetError(this.txtClave, "");
                errorProvider1.SetError(this.txtCClave, "");
                errorProvider1.SetError(this.txtUsuario, "");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "C")
                {
                    this.Close();
                }
                borrar_error();
                if (!validar())
                {
                    if (Accion == "A" || Accion == "M")
                    {
                        EUsuarios obj = new EUsuarios();

                        obj.Cedula = this.txtCedula.Text;
                        obj.Nombre = this.txtNombre.Text;
                        obj.PrimerApellido = this.txtApellido1.Text;
                        obj.SegundoApellido = this.txtApellido2.Text;
                        obj.Genero = this.cmbGenero.SelectedValue.ToString();
                        obj.FechaNacimiento = Convert.ToDateTime(this.txtFechaNac.Text);
                        obj.Correo = this.txtCorreo.Text;
                        obj.Telefono = this.txtTelefono1.Text;
                        obj.TelefonoAdisional = this.txtTelefono2.Text;
                        obj.Usuario = this.txtUsuario.Text;
                        obj.Id_Rol = int.Parse(this.cmbrol.SelectedValue.ToString());
                        obj.Estado = 1;
                        UsuariosController Negocios = new UsuariosController();
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            obj.Contrasena = Helper.EncodePassword(string.Concat(this.txtUsuario.Text.ToString(), this.txtClave.ToString()));
                            FilasAfectadas = Negocios.Agregar(obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Se agrego el estudiante", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El estudiante se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo agregar el estudiante!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            obj.Id_Usuario = int.Parse(this.txtId.Text);
                            obj.ID_PERSONA = IdPersona;
                            FilasAfectadas = Negocios.Modificar(obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Estudiante modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El estudiante se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo modificar el estudiante!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
