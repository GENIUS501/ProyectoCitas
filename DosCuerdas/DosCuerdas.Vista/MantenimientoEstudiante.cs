using DosCuerdas.Controlador;
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
    public partial class MantenimientoEstudiante : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public int IdPersona { get; set; }
        #endregion
        public MantenimientoEstudiante()
        {
            InitializeComponent();
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
                }
                else if (Accion == "M")
                {
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtTelefono1.Enabled = true;
                    this.txtTelefono2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenimientoEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A")
                {
                    this.lblid.Visible = false;
                    this.txtId.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    this.Text = "Modificar Estudiante";
                    this.txtId.Enabled = false;
                    llenar();
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtCorreo.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtTelefono1.Enabled = true;
                    this.txtTelefono2.Enabled = true;
                    if (Accion == "C")
                    {
                        this.Text = "Consultar Estudiante";
                        this.groupBox1.Enabled = false;
                        this.groupBox2.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        EEstudiantes obj = new EEstudiantes();

                        obj.Cedula = this.txtCedula.Text;
                        obj.Nombre = this.txtNombre.Text;
                        obj.PrimerApellido = this.txtApellido1.Text;
                        obj.SegundoApellido = this.txtApellido2.Text;
                        obj.Genero = "NA";
                        obj.FechaNacimiento = DateTime.Now;
                        obj.Correo = this.txtCorreo.Text;
                        obj.Telefono = this.txtTelefono1.Text;
                        obj.TelefonoAdisional = this.txtTelefono2.Text;
                        obj.Horario = Convert.ToDateTime(this.txtHorario.Text);
                        obj.Sucursal = this.cmbSucursal.SelectedItem.ToString();
                        obj.TipoClase = this.txtClase.Text;
                        EstudiantesController Negocios = new EstudiantesController();
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
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
                            obj.Id_Estudiante = int.Parse(this.txtId.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void llenar()
        {
            EstudiantesController Controller = new EstudiantesController();
            EEstudiantes obj = new EEstudiantes();
            obj = Controller.Mostrar().Where(x => x.Id_Estudiante == Id).FirstOrDefault();
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
