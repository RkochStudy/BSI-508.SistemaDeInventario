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
    public partial class CambiarContrasena : Form
    {
        Logic lg = new Logic();

        public char type { set; get; }

        public CambiarContrasena(char _type)
        {
            InitializeComponent();
            this.type = _type;
        }

        private bool ValidarContrasena()
        {
            if (!lg.ObtenerContrasenaActual().Equals(txtPassActual.Text))
            {
                lg.Mensaje('E', "La contraseña introducida no es correcta");
                return false;
            }
            return true;
        }

        private bool ValidarNuevaContrasena()
        {
            if (!txtPassNueva.Text.Equals(txtPassNueva2.Text))
            {
                lg.Mensaje('E', "Las contraseñas no son iguales");
                return false;
            }
            return true;
        }

        private void Limpiar()
        {
            txtPassActual.Text = "";
            txtPassNueva.Text = "";
            txtPassNueva2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            ValidarContrasena();
        }

        private void txtPassNueva2_Leave(object sender, EventArgs e)
        {
            ValidarNuevaContrasena();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if(type == 'A')
            {
                if (ValidarContrasena() && ValidarNuevaContrasena())
                {
                    lg.Mensaje('I', lg.CambiarContrasena(txtPassNueva2.Text));
                    Limpiar();
                }
            }
            else
            {
                if (ValidarNuevaContrasena())
                {
                    lg.Mensaje('I', lg.CambiarContrasena(txtPassNueva2.Text, 0));
                    Limpiar();
                }
            }
        }

        private void CambiarContrasena_Load(object sender, EventArgs e)
        {
            if(type == 'U')
            {
                lbContrasenna.Visible = false;
                txtPassActual.Visible = false;
            }
        }
    }
}
