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
using System.Collections;

namespace SistemaDeInventario.Presentation
{
    public partial class MostarDatos : Form
    {
        char Type = 'n';
        Connection cn = new Connection();
        Logic lg = new Logic();
        public Panel fatherWindow { set; get; }
        public string table { set; get; }

        public MostarDatos(char type)
        {
            InitializeComponent();
            Type = type;
            if (table == null)
            {
                table = "";
            }
        }

        public void InicializarItems()
        {
            switch (Type)
            {
                case 'D':
                    lbDepartamento.Visible = false;
                    cbDepartamento.Visible = false;
                    btnMostrar.Visible = false;
                    break;

                case 'A':
                    lbDepartamento.Visible = true;
                    cbDepartamento.Visible = true;
                    btnMostrar.Visible = true;
                    break;

                case 'P':
                    lbDepartamento.Visible = true;
                    cbDepartamento.Visible = true;
                    btnMostrar.Visible = true;
                    btnPrestar.Text = "Devolver";
                    btnEditar.Visible = false;
                    btnBorrar.Visible = false;
                    break;

                case 'U':
                    lbDepartamento.Visible = false;
                    cbDepartamento.Visible = false;
                    btnMostrar.Visible = false;
                    btnEditar.Visible = false;
                    btnPrestar.Text = "Añandir";
                    btnPrestar.Location = new System.Drawing.Point(225, 398);
                    btnBorrar.Location = new System.Drawing.Point(358, 398);
                    break;

                case 'R':
                    lbDepartamento.Visible = false;
                    cbDepartamento.Visible = false;
                    btnMostrar.Visible = false;
                    btnEditar.Visible = false;
                    btnPrestar.Visible = false;
                    btnBorrar.Visible = false;
                    break;
            }

            cbDepartamento = lg.LlenarComboBoxDepartamentos(cbDepartamento);

            lbDepartamento.Text = lg.text[lg.ObtenerIdioma()][11];
            btnMostrar.Text = lg.text[(lg.ObtenerIdioma()) + 2][5];
            btnEditar.Text = lg.text[(lg.ObtenerIdioma()) + 2][6];
            btnBorrar.Text = lg.text[(lg.ObtenerIdioma()) + 2][7];

            if (table.Equals(""))
            {
                DataGridView.DataSource = cn.LlenarTabla(GenerarQuery());
            }
            else
            {
                DataGridView.DataSource = cn.LlenarTabla(table);
            }
        }

        public string ObtenerNombreTabla()
        {
            switch (Type)
            {
                case 'A':
                    return "dbo.Activo";

                case 'D':
                    return "dbo.Departamento";

                case 'P':
                    return "dbo.Prestamo";

                case 'R':
                    return "dbo.Registro";

                case 'U':
                    return "dbo.Usuario";

                default:
                    return "Vacio";
            }
        }

        public string ObtenerNombreCasilla()
        {
            switch (Type)
            {
                case 'A':
                    return "departamento";

                case 'P':
                    return "departamentoOrigen";

                default:
                    return "Vacio";
            }
        }

        private string GenerarQuery()
        {
            return String.Format("Select * from {0};", ObtenerNombreTabla());
        }

        private string GenerarQuery(int _indice)
        {
            return String.Format("Select * from {0} where {1} = {2};", ObtenerNombreTabla(), ObtenerNombreCasilla(), _indice);
        }

        private void LlenarTabla()
        {
            if (table.Equals(""))
            {
                table = GenerarQuery(cbDepartamento.SelectedIndex + 1);
            }
            DataGridView.DataSource = cn.LlenarTabla(table);
        }

        private void Edit()
        {
            foreach (DataGridViewRow row in this.DataGridView.SelectedRows)
            {
                if (Type == 'A')
                {
                    AgregarActivo ag = new AgregarActivo('U');

                    int Id = int.Parse(row.Cells[0].Value.ToString());
                    int NumSerie = int.Parse(row.Cells[1].Value.ToString());
                    string Nombre = row.Cells[2].Value.ToString();
                    string Marca = row.Cells[4].Value.ToString();
                    string Descripcion = row.Cells[5].Value.ToString();
                    int Cantidad = int.Parse(row.Cells[6].Value.ToString());
                    string Tipo = row.Cells[7].Value.ToString();
                    int Departamento = int.Parse(row.Cells[8].Value.ToString());

                    ag.TopLevel = false;
                    ag.AutoScroll = true;
                    fatherWindow.Controls.Add(ag);
                    ag.Show();
                    ag.ColocarDatos(Id, NumSerie, Nombre, Marca, Descripcion, Cantidad, Tipo, Departamento);
                }
                else
                {
                    AgregarDepartamento ad = new AgregarDepartamento('U');

                    int Id = int.Parse(row.Cells[0].Value.ToString());
                    string Nombre = row.Cells[1].Value.ToString();
                    string Encargado = row.Cells[2].Value.ToString();
                    string subencargado = row.Cells[3].Value.ToString();

                    ad.TopLevel = false;
                    ad.AutoScroll = true;
                    fatherWindow.Controls.Add(ad);
                    ad.Show();
                    ad.ColocarDatos(Nombre, int.Parse(Encargado), int.Parse(subencargado), Id);
                }
                this.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaActivos_Load(object sender, EventArgs e)
        {
            InicializarItems();
            cbDepartamento.SelectedItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.DataGridView.SelectedRows)
            {
                int elemento = int.Parse(row.Cells[0].Value.ToString());
                if (elemento == cn.ObtenerID())
                {
                    lg.Mensaje('E', "No se puede eliminiar el usuario actual");
                }
                else
                {
                    cn.EliminarElemento(elemento, ObtenerNombreTabla());
                }
            }
            LlenarTabla();
            this.Refresh();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (Type == 'U')
            {
                fatherWindow.Controls.Clear();
                AdministrarUsuario user = new AdministrarUsuario('U');
                user.FatherWindow = this.fatherWindow;
                user.TopLevel = false;
                user.AutoScroll = true;
                fatherWindow.Controls.Add(user);
                user.Show();
            }
            else
            {
                if (Type == 'A')
                {
                    foreach (DataGridViewRow row in this.DataGridView.SelectedRows)
                    {
                        AgregarPrestamo ap = new AgregarPrestamo();
                        ap.Id = int.Parse(row.Cells[0].Value.ToString());
                        ap.Activo = row.Cells[2].Value.ToString();
                        ap.Cantidad = int.Parse(row.Cells[6].Value.ToString());
                        ap.DepaOrigen = int.Parse(row.Cells[8].Value.ToString());
                        ap.TopLevel = false;
                        ap.AutoScroll = true;
                        fatherWindow.Controls.Add(ap);
                        ap.Show();
                        this.Close();
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in this.DataGridView.SelectedRows)
                    {
                        int id = int.Parse(row.Cells[0].Value.ToString());
                        string nombre = row.Cells[1].Value.ToString();
                        int DepaOrigen = int.Parse(row.Cells[2].Value.ToString());
                        int DepaPrestamo = int.Parse(row.Cells[3].Value.ToString());
                        lg.Mensaje('I', lg.DevolverPrestamo(id, nombre, DepaOrigen, DepaPrestamo));
                        table = "Select * from dbo.Prestamo";
                        LlenarTabla();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
