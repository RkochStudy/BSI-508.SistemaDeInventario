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
    public partial class AgregarPrestamo : Form
    {
        Logic lg = new Logic();

        public int Id { set; get; }
        public string Activo { set; get; }
        public int Cantidad { set; get; }
        public int DepaOrigen { set; get; }

        public AgregarPrestamo()
        {
            InitializeComponent();
        }

        public void InicializarItems ()
        {
            if(Cantidad == 1)
            {
                txtCantidad.ReadOnly = true;
                txtCantidad.Text = "1";
            }
            else
            {
                txtCantidad.ReadOnly = false;
                txtCantidad.Text = "";
            }

            cbDepartaPrestamo = lg.LlenarComboBoxDepartamentos(cbDepartaPrestamo, DepaOrigen);
            lbNombre.Text = Activo;
        }

        public bool Validar()
        {
            if (txtFechaRetorno.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        public void Limpiar ()
        {
            txtCantidad.Text = "";
            cbDepartaPrestamo.SelectedIndex = 0;
            txtFechaRetorno.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            lg.Mensaje('I', "Se han limpiado los campos");
        }

        private void AgregarPrestamo_Load(object sender, EventArgs e)
        {
            InicializarItems();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                lg.RegistrarPrestamo(Id, Activo, Cantidad, DepaOrigen, (cbDepartaPrestamo.SelectedIndex) + 2, txtFechaRetorno.Text);
                Limpiar();
                lg.Mensaje('I',"Se ha registrado el prestamo");
            }
            else
            {
                lg.Mensaje('A', "No se puede realizar el\nprestamo si deja un campo vacio");
            }
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
