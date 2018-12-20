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
using SistemaDeInventario.Structures;

namespace SistemaDeInventario.Presentation
{
    public partial class AgregarActivo : Form
    {
        Logic lg = new Logic();

        int id = 0;
        string numSerie = "";

        public char tipo { set; get; }

        public AgregarActivo(char _tipo)
        {
            tipo = _tipo;
            InitializeComponent();
            ObtenerNombre();
            cbTipo.SelectedIndex = 0;
        }

        private string Limpiar ()
        {
            txtNumSerie.Text = "0";
            txtNombre.Text = "";
            txtMarca.Text = "";
            rtDescripcion.Text = "";
            txtCantidad.Text = "1";
            cbDepartamento.SelectedItem = 0;

            return "Todos los campos \n se han borrado";
        }

        private void CambiarEstado (bool placa)
        {
           
            if (placa == true)
            {
                txtNumSerie.ReadOnly = false;

                txtMarca.ReadOnly = false;

                txtNumSerie.Text = numSerie;
                txtCantidad.Text = 1 + "";
                txtCantidad.ReadOnly = true;
            }
            else
            {
                txtNumSerie.Text = "0";
                txtNumSerie.ReadOnly = true;
                txtMarca.ReadOnly = true;

                txtCantidad.Text ="";
                txtCantidad.ReadOnly = false;
            }
        }

        private void AnalizarCbTipoActivo ()
        {
            bool state = false;
            if (cbTipoActivo.SelectedIndex == 0)
            {
                state = true;
            }
            CambiarEstado(state);
        }

        public void ColocarDatos (int id, int NumSerie, string Nombre, string Marca, string Descripcion, int Cantidad, string Tipo, int Departamento)
        {
            txtNumSerie.Text = NumSerie+"";
            txtNombre.Text = Nombre;
            txtMarca.Text = Marca;
            rtDescripcion.Text = Descripcion;
            txtCantidad.Text = Cantidad+"";
            cbDepartamento.SelectedItem = Departamento-1;
            cbTipo.SelectedText = Tipo;

            this.id = id;
        }

        public void ObtenerNombre()
        {
            switch(tipo)
            {
                case 'A':
                    this.Name = "Registrar Activo";
                    btnRegistrar.Text = "Registrar";
                    break;

                case 'U':
                    this.Name = "Actualizar Activo";
                    btnRegistrar.Text = "Actualizar";
                break;
            }
        }

        public void InicializarItems()
        {
            cbDepartamento = lg.LlenarComboBoxDepartamentos(cbDepartamento);

            lbTitulo.Text = lg.text[lg.ObtenerIdioma()][2];
            lbTipoActivo.Text = lg.text[lg.ObtenerIdioma()][3];
            lbNumSerie.Text = lg.text[lg.ObtenerIdioma()][4];
            lbNombre.Text = lg.text[lg.ObtenerIdioma()][5];
            lbMarca.Text = lg.text[lg.ObtenerIdioma()][6];
            lbDescipcion.Text = lg.text[lg.ObtenerIdioma()][7];
            lbCantidad.Text = lg.text[lg.ObtenerIdioma()][8];
            lbTipo.Text = lg.text[lg.ObtenerIdioma()][9];
            lbDepartamento.Text = lg.text[lg.ObtenerIdioma()][10];

            btnVolver.Text = lg.text[lg.ObtenerIdioma()+2][2];
            btnLimpiar.Text = lg.text[lg.ObtenerIdioma()+2][3];
            btnRegistrar.Text = lg.text[lg.ObtenerIdioma()+2][4];
        }

        private bool ValidarCampos ()
        {
            if(txtNombre.Text.Equals("") || txtNombre.Text.Equals(" "))
            {
                return false;
            }
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numSerie = lg.GenerarNumSerie()+"";
            MessageBox.Show(Limpiar(), "Información", MessageBoxButtons.OK ,MessageBoxIcon.Information );
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tipo == 'A')
            {
                if(ValidarCampos())
                {
                    lg.Mensaje('I',lg.RegistrarActivo(int.Parse(txtNumSerie.Text), txtNombre.Text, txtMarca.Text, rtDescripcion.Text, int.Parse(txtCantidad.Text), cbTipo.SelectedItem.ToString(), cbDepartamento.SelectedIndex));
                    Limpiar();
                }
                else
                {
                    lg.Mensaje('E',"No puede registrar un articulo sin nombre");
                }
            }
            else
            {
                if (ValidarCampos())
                {
                   lg.Mensaje('I',lg.ActualizarActivo(id, int.Parse(txtNumSerie.Text), txtNombre.Text, txtMarca.Text, rtDescripcion.Text, int.Parse(txtCantidad.Text), cbTipo.SelectedItem.ToString(), cbDepartamento.SelectedIndex));
                }
                else
                {
                    lg.Mensaje('E', "No puede actualizar el articulo sin nombre");
                }
            }
        }

        private void AgregarActivo_Load(object sender, EventArgs e)
        {
            InicializarItems();
            cbTipoActivo.SelectedIndex = 0;
            cbTipo.SelectedItem = 1;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTipo_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoActivo_SelectedValueChanged(object sender, EventArgs e)
        {
            AnalizarCbTipoActivo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
