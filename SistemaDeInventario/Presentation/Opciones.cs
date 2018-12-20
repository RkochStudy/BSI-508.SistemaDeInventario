using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventario.Presentation
{
    public partial class Opciones : Form
    {
        Logic lg = new Logic();
        public MenuPrincipal FatherForm { set; get; }

        public Opciones()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void InicializarTextos()
        {
            lbIdioma.Text = lg.text[lg.ObtenerIdioma()][14];

            btnCancelar.Text = lg.text[(lg.ObtenerIdioma())+2][1];
            btnAceptar.Text = lg.text[(lg.ObtenerIdioma())+2][8];
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            cbIdiomas.SelectedIndex = lg.ObtenerIdioma();
            InicializarTextos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FatherForm.Enabled = true;
            lg.ActualizarIdioma(cbIdiomas.SelectedIndex);
            FatherForm.InicializarTextos();
            this.Hide();
        }
    }
}
