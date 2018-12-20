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
    public partial class AgregarDepartamento : Form
    {
        Logic lg = new Logic();

        public int id = 0;
        public char Type { set; get; }

        public AgregarDepartamento(char _type)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Type = _type;
        }

        private string Limpiar()
        {
            txtNombre.Text = "";
            //txtEncargado.Text = "";
            //txtSubencargado.Text = "";
            return "Todos los campos \n se han borrado";
        }

        public void InicializarTextos()
        {
            lbTitulo.Text = lg.text[lg.ObtenerIdioma()][12];
            lbNombre.Text = lg.text[lg.ObtenerIdioma()][5];
            lbEncargado.Text = lg.text[lg.ObtenerIdioma()][12];
            lbSubEncargado.Text = lg.text[lg.ObtenerIdioma()][13];

            btnVolver.Text = lg.text[lg.ObtenerIdioma()+2][2];
            btnLimpiar.Text = lg.text[lg.ObtenerIdioma()+2][3];
            btnRegistrar.Text = lg.text[lg.ObtenerIdioma()+2][4];

            cbEncargado = lg.LlenarComboBoxUsuarios(cbEncargado);
            cbSubEncargado = lg.LlenarComboBoxUsuarios(cbSubEncargado);
        }

        public void ColocarDatos (string _nombre, int _encargado, int _subencargado, int id)
        {
            txtNombre.Text = _nombre;
            cbEncargado.SelectedIndex = _encargado;
            cbSubEncargado.SelectedIndex = _subencargado;
            this.id = id;
        }

        private bool Validar ()
        {
            if(txtNombre.Text.Equals("") || txtNombre.Text.Equals(" "))
            {
                return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Limpiar(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Type == 'A')
            {
                if (Validar())
                {
                    MessageBox.Show(lg.RegistrarDepartamento(txtNombre.Text, cbEncargado.SelectedIndex, cbSubEncargado.SelectedIndex));
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se puede registrar un departamento sin el nombre");
                }
            }
            else
            {
                if (Validar())
                {
                    MessageBox.Show(lg.ActualizarDepartamento(txtNombre.Text, cbEncargado.SelectedIndex, cbSubEncargado.SelectedIndex, id));
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se puede actualizar un departamento sin el nombre");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarDepartamento_Load(object sender, EventArgs e)
        {
            InicializarTextos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
