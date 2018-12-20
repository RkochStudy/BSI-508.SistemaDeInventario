using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeInventario.Structures;
using SistemaDeInventario.Data;

namespace SistemaDeInventario.Presentation
{
    public partial class AdministrarUsuario : Form
    {
        Logic lg = new Logic();

        public char type { set; get; }

        public Panel FatherWindow;

        Usuario user = new Usuario();

        public AdministrarUsuario(char _type)
        {
            InitializeComponent();
            this.type = _type;
        }

        private void Inicializar()
        {
           if (type == 'A')
            {
                user = lg.ObtenerUsuario();
                txtNombre.Text = user.Name;
                txtUsuario.Text = user.User;
                txtUsuario.Enabled = false;
                txtCorreo.Text = user.Mail;
                txtEdad.Text = user.Age + "";
                cbRol.SelectedIndex = user.Rol;
            }
            else
            {
                lbTitle.Text = "Agregar Usuario";
                cbRol.SelectedIndex = 0;
                lbNombre.Visible = false;
                txtNombre.Visible = false;
                lbCorreo.Visible = false;
                txtCorreo.Visible = false;
                btnCambiarPass.Visible = false;
                btnAdministarUser.Visible = false;
                btnLimpiar.Visible = false;
                lbEdad.Visible = false;
                lbRol.Location = new System.Drawing.Point(286, 227);
                cbRol.Location = new System.Drawing.Point(285, 249);
                btnListo.Text = "Siguiente";
            }
        }

        private bool Validar ()
        {
            if (txtNombre.Text.Equals("") || txtCorreo.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private void SeleccionarTipo ()
        {
            if (Global.Rol != 1)
            {
                lbRol.Visible = false;
                cbRol.Visible = false;
                btnAdministarUser.Visible = false;
            }
            else
            {
                lbRol.Visible = true;
                cbRol.Visible = true;
                btnAdministarUser.Visible = true;
            }
        }

        private void GuardarDatos()
        {
            lg.Mensaje('I', lg.ActualizarUsuario(user.id, txtNombre.Text, txtCorreo.Text, cbRol.SelectedIndex, int.Parse(txtEdad.Text)));
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtEdad.Text = "";
            cbRol.SelectedIndex = 0;
        }

        private void RegistraNuevoUsuario()
        {
            lg.RegistraNuevoUsuario(txtUsuario.Text,cbRol.SelectedIndex);
            FatherWindow.Controls.Clear();
            CambiarContrasena cc = new CambiarContrasena('U');
            cc.TopLevel = false;
            cc.AutoScroll = true;
            FatherWindow.Controls.Add(cc);
            cc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            Inicializar();
            SeleccionarTipo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(type == 'A')
            {
                if (Validar())
                {
                    GuardarDatos();
                    Limpiar();
                }
                else
                {
                    lg.Mensaje('A', "los campos no pueden quedar vacios");
                }
            }
            else
            {
                RegistraNuevoUsuario();
            }
        }

        private void btnDesactivarUser_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bntCambiarPass_Click(object sender, EventArgs e)
        {
            FatherWindow.Controls.Clear();
            CambiarContrasena cc = new CambiarContrasena('A');
            cc.TopLevel = false;
            cc.AutoScroll = true;
            FatherWindow.Controls.Add(cc);
            cc.Show();
        }

        private void btnAdministarUser_Click(object sender, EventArgs e)
        {
            FatherWindow.Controls.Clear();
            MostarDatos ls = new MostarDatos('U');
            ls.fatherWindow = FatherWindow;
            ls.TopLevel = false;
            ls.AutoScroll = true;
            ls.table = "Select id, Usuario, Nombre, Rol from dbo.Usuario;";
            FatherWindow.Controls.Add(ls);
            ls.Show();
        }
    }
}
