using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeInventario.Data;

namespace SistemaDeInventario.Presentation
{
    public partial class LogIn : Form
    {
        Logic lg = new Logic();

        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void InicializarTextos()
        {
            pbCancelar.Image = lg.logos[lg.ObtenerIdioma()][6];
            pbIngresar.Image = lg.logos[lg.ObtenerIdioma()][5];
        }

        private void LimpiarCampos ()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void IniciarSesion ()
        {
            Connection cn = new Connection();
            if (cn.LogIn(txtUsuario.Text, txtContrasena.Text) == 1)
            {
                Global.Usuario = txtUsuario.Text;
                MenuPrincipal mp = new MenuPrincipal();
                Global.Rol = cn.ObtenerRol();
                mp.Show();
                this.Hide();
            }
            else
            {
               lg.Mensaje('E',"Error nombre de usuario\ncontraseña invalido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            InicializarTextos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IniciarSesion();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir?", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lg.CerrarSesion();
                Application.Exit();
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void pbCancelar_MouseHover(object sender, EventArgs e)
        {
            pbCancelar.Image = lg.logos[lg.ObtenerIdioma()+2][6];
        }

        private void pbCancelar_MouseLeave(object sender, EventArgs e)
        {
            pbCancelar.Image = lg.logos[lg.ObtenerIdioma()][6];
        }

        private void pbIngresar_MouseHover(object sender, EventArgs e)
        {
            pbIngresar.Image = lg.logos[lg.ObtenerIdioma() + 2][5];
        }

        private void pbIngresar_MouseLeave(object sender, EventArgs e)
        {
            pbIngresar.Image = lg.logos[lg.ObtenerIdioma()][5];
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
