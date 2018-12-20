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
    public partial class RegistrarPrestamo : Form
    {
        Logic lg = new Logic();

        public int ID { set; get; }
        public string Activo { set; get; }
        public int Departamento { set; get; }
        public int Cantidad { set; get; }

        public RegistrarPrestamo()
        {
            InitializeComponent();
        }

        public void InicializarCampos()
        {
            lbActivoNombre.Text = Activo;
            if(Cantidad != 1)
            {
                txtCantidad.Text = "";
                txtCantidad.ReadOnly = false;
            }
            cbDepartamento.DataSource = lg.LlenarComboBoxDepartamentos();
            cbDepartamento.DisplayMember = "Nombre";
            cbDepartamento.SelectedIndex = 0;
        }

        public void Limpiar()
        {
            txtCantidad.Text = "";
            cbDepartamento.SelectedIndex = 0;
            txtFechaRetorno.Text = "";
        }

        public bool ValidarDatos()
        {
            if(txtCantidad.Text.Equals("") || txtFechaRetorno.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        public void RealizarPrestamo()
        {
            if (!ValidarDatos())
            {
                lg.Mensaje('E',"Error el los datos introducidos\n no son validos");
            }
            else
            {
                lg.RegistrarPrestamo(ID, Activo,Departamento,(cbDepartamento.SelectedIndex)+1,int.Parse(txtCantidad.Text),txtFechaRetorno.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            lg.Mensaje('I',"Se han limpiado los campos");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        {
            InicializarCampos();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            RealizarPrestamo();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
