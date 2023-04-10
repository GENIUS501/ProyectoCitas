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
    public partial class MantenimientoProfesor : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public int IdPersona { get; set; }
        #endregion
        public MantenimientoProfesor()
        {
            InitializeComponent();
        }

        private void MantenimientoProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void llenar()
        {
            ProfesoresController Controller = new ProfesoresController();
            EProfesores obj = new EProfesores();
            obj = Controller.Mostrar().Where(x => x.Id_Profesor == Id).FirstOrDefault();
            if (obj != null)
            {
                this.txtCedula.Text = obj.Cedula;
                this.txtNombre.Text = obj.Nombre;
                this.txtApellido1.Text = obj.PrimerApellido;
                this.txtApellido2.Text = obj.SegundoApellido;
                this.txtCorreo.Text = obj.Correo;
                this.txtTelefono1.Text = obj.Telefono;
                this.txtTelefono2.Text = obj.TelefonoAdisional;
                this.txtId.Text = obj.Id_Estudiante.ToString();
                this.txtClase.Text = obj.TipoClase;
                this.txtHorario.Text = obj.Horario.ToString();
                this.cmbSucursal.SelectedItem = obj.Sucursal;
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
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
