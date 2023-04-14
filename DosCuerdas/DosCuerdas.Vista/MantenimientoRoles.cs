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
        public int Id { get; set; }
        public string Accion { get; set; }
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
                        RolesController Negocios = new RolesController();
                        ERoles Rol = new ERoles();
                        Int32 FilasAfectadas = 0;
                        Rol.NombreRol = this.txt_nombre_perfil.Text;
                        Rol.Descripcion = this.txtdescripcion.Text;
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(Rol, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                var Permi = Permisos(FilasAfectadas);
                                Negocios.AgregarPermisos(Permi, FilasAfectadas);
                                MessageBox.Show("Rol agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar el rol!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (Accion == "M")
                        {
                            Rol.Id_Rol = int.Parse(this.txt_id_perfil.Text);
                            FilasAfectadas = Negocios.Modificar(Rol, Usuario);
                            var Permi = Permisos(int.Parse(this.txt_id_perfil.Text));
                            Negocios.AgregarPermisos(Permi, int.Parse(this.txt_id_perfil.Text));
                            MessageBox.Show("Rol modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    if (Accion == "C")
                    {
                        this.Close();
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
                this.Text = "Modificar rol";
                this.txt_id_perfil.Enabled = false;
                Llenar();
                if (Accion == "C")
                {
                    this.Text = "Consultar rol";
                    this.groupBox1.Enabled = false;
                    this.groupBox2.Enabled = false;
                }
            }
        }
        #region llenar Permisos
        private void Llenar()
        {
            try
            {
                RolesController Negocios = new RolesController();
                ERoles Obj = new ERoles();
                Obj = Negocios.Mostrar().Where(x => x.Id_Rol == Id).FirstOrDefault();
                if (Obj != null)
                {
                    this.txt_id_perfil.Text = Obj.Id_Rol.ToString();
                    this.txt_nombre_perfil.Text = Obj.NombreRol;
                    this.txtdescripcion.Text = Obj.Descripcion;
                }
                List<EPermisos> Permisos = new List<EPermisos>();
                ERoles Rol = new ERoles();
                Permisos = Negocios.llenar_Permisos(Id);
                Rol = Negocios.Mostrar().Where(x => x.Id_Rol == Id).FirstOrDefault();
                this.txt_id_perfil.Text = Rol.Id_Rol.ToString();
                this.txt_nombre_perfil.Text = Rol.NombreRol.ToString();
                #region Roles 1
                ////////Roles//1////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Roles").FirstOrDefault() != null)
                {
                    this.grp_roles.Enabled = true;
                    this.chb_rol.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_rol_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_rol_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_rol_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_rol_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Usuarios 2
                ////////Usuarios//2////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Usuarios").FirstOrDefault() != null)
                {
                    this.grp_usuarios.Enabled = true;
                    this.chb_usuarios.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Profesores 3
                ////////Profesores//3////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Profesores").FirstOrDefault() != null)
                {
                    this.grp_profesores.Enabled = true;
                    this.chb_profesores.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Profesores" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_profesores_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_profesores_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Profesores" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_profesores_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_profesores_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Profesores" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_profesores_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_profesores_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Profesores" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_profesores_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_profesores_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Clientes
                ////////Clientes//////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Clientes").FirstOrDefault() != null)
                {
                    this.grp_clientes.Enabled = true;
                    this.chb_clientes.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Clientes" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_clientes_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_clientes_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Clientes" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_clientes_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_clientes_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Clientes" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_clientes_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_clientes_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Clientes" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_clientes_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_clientes_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Estudiantes 5
                ////////Estudiantes//5////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Estudiantes").FirstOrDefault() != null)
                {
                    this.grp_estudiantes.Enabled = true;
                    this.chb_estudiantes.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Estudiantes" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_estudiantes_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_estudiantes_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Estudiantes" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_estudiantes_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_estudiantes_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Estudiantes" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_estudiantes_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_estudiantes_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Estudiantes" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_estudiantes_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_estudiantes_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Reporte de estudiantes
                if (Permisos.Where(x => x.Modulo == "ReporteEstudiantes").FirstOrDefault() != null)
                {
                    this.chb_estudiante_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de agenda
                if (Permisos.Where(x => x.Modulo == "ReporteAgenda").FirstOrDefault() != null)
                {
                    this.chb_agenda_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de profesores
                if (Permisos.Where(x => x.Modulo == "ReporteProfesores").FirstOrDefault() != null)
                {
                    this.chb_profesores_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Bitacora de sesiones
                if (Permisos.Where(x => x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    this.chb_bit_sesiones.Checked = true;
                }
                else
                {

                }
                #endregion              
                #region Bitacora de Movimientos
                if (Permisos.Where(x => x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    this.chb_bit_movimientos.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Agendar Clases
                if (Permisos.Where(x => x.Modulo == "Agendar").FirstOrDefault() != null)
                {
                    this.chbAgendarClases.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Cancelar Clases
                if (Permisos.Where(x => x.Modulo == "Cancelar").FirstOrDefault() != null)
                {
                    this.chbCancelarClases.Checked = true;
                }
                else
                {

                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Agregar Permisos
        private List<EPermisos> Permisos(int Id_Rol)
        {
            try
            {
                List<EPermisos> Lista_Permisos = new List<EPermisos>();
                EPermisos Permisos = new EPermisos();
                ///////////////////Roles/////////////////////////////////////////////////////////////////////////////
                if (this.chb_rol.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Roles";
                    Permisos.Accion = "Roles";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_roles.Enabled == true)
                    {
                        if (chk_rol_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }

                /////////Usuarios/////////////////////////////////////////////////////////////////////////////
                if (this.chb_usuarios.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Usuarios";
                    Permisos.Accion = "Usuarios";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_usuarios.Enabled == true)
                    {
                        if (chk_usuarios_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////clientes//////3///////////////////////////////////////////////////////////////////////
                if (this.chb_clientes.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Clientes";
                    Permisos.Accion = "Clientes";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_clientes.Enabled == true)
                    {
                        if (chk_clientes_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Clientes";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_clientes_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Clientes";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_clientes_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Clientes";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_clientes_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Clientes";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Estudiantes/////////////////////////////////////////////////////////////////////////////
                if (this.chb_estudiantes.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Estudiantes";
                    Permisos.Accion = "Estudiantes";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_estudiantes.Enabled == true)
                    {
                        if (chk_estudiantes_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Estudiantes";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_estudiantes_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Estudiantes";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_estudiantes_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Estudiantes";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_estudiantes_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Estudiantes";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                ////////Profesores//////5///////////////////////////////////////////////////////////////////////
                if (this.chb_profesores.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Profesores";
                    Permisos.Accion = "Profesores";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_profesores.Enabled == true)
                    {
                        if (chk_profesores_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Profesores";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_profesores_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Profesores";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_profesores_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Profesores";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_profesores_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Profesores";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                if (this.chb_estudiante_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteEstudiantes";
                    Permisos.Accion = "ReporteEstudiantes";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reportes_Estudiantes////10//////////////////////////////////////////////////////////////////////////////////
                if (this.chb_agenda_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteAgenda";
                    Permisos.Accion = "ReporteAgenda";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reporte_Clientes//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_profesores_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteProfesores";
                    Permisos.Accion = "ReporteProfesores";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Bitacora_sesiones//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_bit_sesiones.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "BitacoraSesiones";
                    Permisos.Accion = "BitacoraSesiones";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Bitacora_movimientos//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_bit_movimientos.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "BitacoraMovimientos";
                    Permisos.Accion = "BitacoraMovimientos";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ///////////AgendarClases/////////////////////////////
                if (this.chbAgendarClases.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Agendar";
                    Permisos.Accion = "Agendar";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                //////////CancelarClases////////////////////////////
                if (this.chbCancelarClases.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Cancelar";
                    Permisos.Accion = "Cancelar";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                return Lista_Permisos;
            }
            catch (Exception)
            {
                return new List<EPermisos>();
            }
        }
        #endregion

        private void chb_usuarios_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_usuarios.Checked == true)
                {
                    grp_usuarios.Enabled = true;
                }
                else
                {
                    grp_usuarios.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_rol_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_rol.Checked == true)
                {
                    grp_roles.Enabled = true;
                }
                else
                {
                    grp_roles.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_clientes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_clientes.Checked == true)
                {
                    grp_clientes.Enabled = true;
                }
                else
                {
                    grp_clientes.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_estudiantes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_estudiantes.Checked == true)
                {
                    grp_estudiantes.Enabled = true;
                }
                else
                {
                    grp_estudiantes.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_profesores_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_profesores.Checked == true)
                {
                    grp_profesores.Enabled = true;
                }
                else
                {
                    grp_profesores.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
