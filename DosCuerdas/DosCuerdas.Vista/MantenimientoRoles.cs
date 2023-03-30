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
    public partial class MantenimientoRoles : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        #endregion
        public MantenimientoRoles()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txt_nombre_perfil.Text == "")
                {
                    errorProvider1.SetError(txt_nombre_perfil, "Debe ingresar el nombre");
                    ok = true;
                }
                if (this.txtdescripcion.Text == "")
                {
                    errorProvider1.SetError(txtdescripcion, "Debe ingresar la descripcion");
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
                errorProvider1.SetError(txt_nombre_perfil, "");
                errorProvider1.SetError(txtdescripcion, "");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void llenar()
        {
            RolesController Controller = new RolesController();
            ERoles Obj = new ERoles();
            Obj = Controller.Mostrar().Where(x => x.Id_Rol == Id).FirstOrDefault();
            if (Obj != null)
            {
                this.txt_id_perfil.Text = Obj.Id_Rol.ToString();
                this.txt_nombre_perfil.Text = Obj.NombreRol;
                this.txtdescripcion.Text = Obj.Descripcion;
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
                        ERoles obj = new ERoles();
                        obj.NombreRol = this.txt_nombre_perfil.Text;
                        obj.Descripcion = this.txtdescripcion.Text;
                        RolesController Negocios = new RolesController();
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Se agrego el rol", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El rol se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo agregar el rol!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            obj.Id_Rol = int.Parse(this.txt_id_perfil.Text);
                            FilasAfectadas = Negocios.Modificar(obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Rol modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El rol se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo modificar el rol!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MantenimientoRoles_Load(object sender, EventArgs e)
        {
            if (Accion == "A")
            {
                this.Lbl_Perfil.Visible = false;
                this.txt_id_perfil.Visible = false;
            }
            if (Accion == "M" || Accion == "C")
            {
                this.Text = "Modificar Loteria";
                this.txt_id_perfil.Enabled = false;
                llenar();
                if (Accion == "C")
                {
                    this.Text = "Consultar Loteria";
                    this.groupBox1.Enabled = false;
                }
            }
        }
    }
}
