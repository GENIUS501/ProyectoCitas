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
    public partial class AgendarClases : Form
    {
        #region Variables
        public int Usuario { get; set; }
        int Profesor = -1;
        int Estudiante = -1;
        #endregion
        public AgendarClases()
        {
            InitializeComponent();
        }

        private void AgendarClases_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCedulaProfesor.Text != "")
                {
                    ProfesoresController Controlador = new ProfesoresController();
                    dat_profesores.DataSource = Controlador.Mostrar().Select(Item => new
                    {
                        Id_de_profesor = Item.Id_Profesor,
                        Cedula = Item.Cedula,
                        Nombre = Item.Nombre,
                        PrimerApellido = Item.PrimerApellido,
                        SegundoApellido = Item.SegundoApellido,
                        Instrumento = Item.instrumento
                    }).Where(x => x.Cedula.Contains(this.txtCedulaProfesor.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCedulaEstudiante.Text != "")
                {
                    EstudiantesController Controlador = new EstudiantesController();
                    datEstudiantes.DataSource = Controlador.Mostrar().Select(Item => new
                    {
                        Id_de_estudiante = Item.Id_Estudiante,
                        Cedula = Item.Cedula,
                        Nombre = Item.Nombre,
                        PrimerApellido = Item.PrimerApellido,
                        SegundoApellido = Item.SegundoApellido,
                    }).Where(x => x.Cedula.Contains(this.txtEstudiante.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_profesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_profesores.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {

                }
                else
                {
                    Profesor = int.Parse(this.dat_profesores.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var mostrar = this.datEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + this.datEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + this.datEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.txtEstudiante.Text = mostrar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.datEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {

                }
                else
                {
                    Estudiante = int.Parse(this.datEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var mostrar = this.datEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + this.datEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + this.datEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.txtEstudiante.Text = mostrar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validar()
        {
            bool ok = false;
            try
            {
                if (Profesor == -1)
                {
                    errorProvider1.SetError(this.dat_profesores, "Debe seleccionar un profesor");
                    ok = true;
                }
                if (Estudiante == -1)
                {
                    errorProvider1.SetError(this.datEstudiantes, "Debe seleccionar un estudiante");
                    ok = true;
                }
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
                errorProvider1.SetError(this.datEstudiantes, "");
                errorProvider1.SetError(this.dat_profesores, "");
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
                borrar_error();
                if (!validar())
                {
                    ECita obj = new ECita();

                    obj.Id_Estudiante = Estudiante;
                    obj.Id_Profesor = Profesor;
                    obj.Id_Usuario = Usuario;
                    obj.FECHACITA = Convert.ToDateTime(this.txtFecha.Text);
                    obj.HORA_CITA = this.cbo_hora.SelectedItem.ToString();
                    obj.DURACION = 1;
                    obj.ESTADO = "Pendiente";
                    obj.Observaciones = this.txtObservaciones.Text;
                    CitaController Negocios = new CitaController();
                    Int32 FilasAfectadas = 0;
                    FilasAfectadas = Negocios.Agregar(obj, Usuario);

                    if (FilasAfectadas > 0)
                    {
                        MessageBox.Show("Se agendo la clase", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        if (FilasAfectadas == -1)
                        {
                            MessageBox.Show("La clase se agendo exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agendar la clase!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}