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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosController Negocios = new UsuariosController();
                EUsuarios Usu = new EUsuarios();
                int Id_Session = 0;
                string pass = Helper.EncodePassword(string.Concat(this.txtUsuario.Text.ToString(), this.txtContrasena.ToString()));
                Usu = Negocios.Login(this.txtUsuario.Text, pass);
                if (Usu != null)
                {
                    Bitacora_SesionesController Ses = new Bitacora_SesionesController();
                    EBitacora_Sesiones EntidadSesion = new EBitacora_Sesiones();
                    EntidadSesion.fecha_hora_ingreso = DateTime.Now;
                    EntidadSesion.Id_Usuario = Usu.Id_Usuario;
                    Id_Session = Ses.Agregar(EntidadSesion);
                    if (Id_Session > 0)
                    {
                        this.Hide();
                        Principal form = new Principal();
                        form.Idsession = Id_Session;
                        form.UsuarioLogueado = Usu;
                        MessageBox.Show("Bienvenido: " + Usu.Usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error usuario o contraseña invalido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
