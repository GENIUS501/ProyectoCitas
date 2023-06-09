﻿using DosCuerdas.Controlador;
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
    public partial class ListaProfesores : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public int Id_Rol { get; set; }
        int valorcelda = -1;
        #endregion
        public ListaProfesores()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txt_buscar_id_profesor, "");
                if (this.txt_buscar_id_profesor.Text != "")
                {
                    ProfesoresController Negocios = new ProfesoresController();
                    var Id = int.Parse(this.txt_buscar_id_profesor.Text);
                    dat_principal.DataSource = Negocios.Mostrar().Where(x => x.Id_Profesor == Id).ToList();
                }
                else
                {
                    errorProvider1.SetError(txt_buscar_id_profesor, "Debe llenar este campo!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txt_nombre, "");
                if (this.txt_nombre.Text != "")
                {
                    ProfesoresController Negocios = new ProfesoresController();
                    dat_principal.DataSource = Negocios.Mostrar().Where(x => x.Nombre.Contains(this.txt_nombre.Text)).ToList();
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "Debe llenar este campo!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("M");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorcelda != -1)
                {
                    DialogResult dr = MessageBox.Show("Realmente desea eliminar el profesor?", "Eliminar el profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Int32 FilasAfectadas = 0;
                        ProfesoresController Negocios = new ProfesoresController();
                        FilasAfectadas = Negocios.Eliminar(valorcelda, Usuario);
                        if (FilasAfectadas > 0)
                        {
                            MessageBox.Show("Profesor eliminado satisfactoriamente", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el profesor!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        valorcelda = -1;
                        ListaProfesores_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un profesor!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El registro que esta tratando de eliminar esta relacionado con otro.\nPor favor verifique antes de borrar este registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaProfesores_Load(object sender, EventArgs e)
        {
            try
            {
                ProfesoresController Negocios = new ProfesoresController();
                EProfesores Entidad = new EProfesores();
                dat_principal.DataSource = Negocios.Mostrar();
                valorcelda = -1;
                this.dat_principal.ReadOnly = true;
                RolesController NegociosRoles = new RolesController();
                List<EPermisos> perm = new List<EPermisos>();
                perm = NegociosRoles.llenar_Permisos(Id_Rol, "Profesores");
                if (perm.Where(x => x.Accion == "Agregar").FirstOrDefault() != null)
                {
                    this.btn_agregar.Enabled = true;
                }
                if (perm.Where(x => x.Accion == "Modificar").FirstOrDefault() != null)
                {
                    this.btn_editar.Enabled = true;
                }
                if (perm.Where(x => x.Accion == "Eliminar").FirstOrDefault() != null)
                {
                    this.btn_eliminar.Enabled = true;
                }
                if (perm.Where(x => x.Accion == "Consultar").FirstOrDefault() != null)
                {
                    this.btn_consultar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    ListaProfesores_Load(null, null);
                }
                else
                {
                    valorcelda = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(string Accion)
        {
            try
            {

                if (Accion != "A" && Accion == "M" && valorcelda != -1 || Accion != "A" && Accion == "E" && valorcelda != -1 || Accion != "A" && Accion == "C" && valorcelda != -1)
                {
                    //valorcelda = dat_usuarios.CurrentRow.Index;
                    MantenimientoProfesor frm = new MantenimientoProfesor();
                    frm.Accion = Accion;
                    frm.Id = valorcelda;
                    frm.Usuario = Usuario;
                    frm.ShowDialog();
                    valorcelda = -1;
                    ListaProfesores_Load(null, null);
                }
                else
                {
                    if (Accion == "A")
                    {
                        MantenimientoProfesor frm = new MantenimientoProfesor();
                        frm.Accion = Accion;
                        frm.Id = valorcelda;
                        frm.Usuario = Usuario;
                        frm.ShowDialog();
                        valorcelda = -1;
                        ListaProfesores_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un profesor!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
