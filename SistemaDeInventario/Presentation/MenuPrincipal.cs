using SistemaDeInventario.Presentation;
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

namespace SistemaDeInventario
{
    public partial class MenuPrincipal : Form
    {
        int hover = 0;

        Logic lg = new Logic();

        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pbPage1.Image = SistemaDeInventario.Properties.Resources.btn_MP_Page_Selected;
        }

        public void AbrirRegistrar (char type)
        {
            if (type == 'A')
            {
                AgregarActivo ag = new AgregarActivo('A');
                ag.TopLevel = false;
                ag.AutoScroll = true;
                pnWindow.Controls.Add(ag);
                ag.Show();
            }
            else
            {
                AgregarDepartamento ad = new AgregarDepartamento('A');
                ad.TopLevel = false;
                ad.AutoScroll = true;
                pnWindow.Controls.Add(ad);
                ad.Show();
            }
        }

        public void InicializarTextos()
        {
            string nombre = " ";
            if (Global.Rol == 1)
            {
                nombre = " - Administrador ";
            }

            lbUsuario.Text = Global.Usuario + "" + nombre + "(X)";
            lbFecha.Text = lg.ObtenerFecha();
            timer1.Start();

            pbUsuario.Image = lg.logos[lg.ObtenerIdioma()][0];
            pbDepartamentos.Image = lg.logos[lg.ObtenerIdioma()][1];

            pbRegistrarDepa.Image = lg.logos[lg.ObtenerIdioma()][11];
            pbListaDepa.Image = lg.logos[lg.ObtenerIdioma()][12];

            pbActivos.Image = lg.logos[lg.ObtenerIdioma()][2];
            pbRegistrarActivo.Image = lg.logos[lg.ObtenerIdioma()][11];
            pbListaActivos.Image = lg.logos[lg.ObtenerIdioma()][12];

            pbPrestamos.Image = lg.logos[lg.ObtenerIdioma()][3];
            pbCompararActivos.Image = lg.logos[lg.ObtenerIdioma()][7];
            pbRegistro.Image = lg.logos[lg.ObtenerIdioma()][8];
            pbInformacion.Image = lg.logos[lg.ObtenerIdioma()][9];
            pbOpciones.Image = lg.logos[lg.ObtenerIdioma()][10];
        }

        public void Cerrar()
        {
            this.Close();
        }

        public void LabelsTransparentes ()
        {
            lbUsuario.Parent = pbWallpaper;
            lbUsuario.BackColor = Color.Transparent;

            lbFecha.Parent = pbWallpaper;
            lbFecha.BackColor = Color.Transparent;

            lbHora.Parent = pbWallpaper;
            lbHora.BackColor = Color.Transparent;
        }

        private void CambiarPagina ()
        {
            if(LeftButtonPanel1.Visible)
            {
                LeftButtonPanel2.Visible = true;
                LeftButtonPanel1.Visible = false;
                pbPage2.Image = SistemaDeInventario.Properties.Resources.btn_MP_Page_Selected;
                pbPage1.Image = SistemaDeInventario.Properties.Resources.btn_MP_Page_Unselected;
            }
            else
            {
                LeftButtonPanel2.Visible = false;
                LeftButtonPanel1.Visible = true;
                pbPage2.Image = SistemaDeInventario.Properties.Resources.btn_MP_Page_Unselected;
                pbPage1.Image = SistemaDeInventario.Properties.Resources.btn_MP_Page_Selected;
            }
        }

        private void OcultarBotones (char type)
        {
            if(type == 'A')
            {
                if(hover == 2)
                {
                    pbRegistrarActivo.Hide();
                    pbListaActivos.Hide();
                    hover = 1;
                }
                else
                {
                    hover++;
                }
            }
            else
            {
                if (hover == 2)
                {
                    pbRegistrarDepa.Hide();
                    pbListaDepa.Hide();
                    hover = 1;
                }
                else
                {
                    hover++;
                }
            }
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            LabelsTransparentes();
            InicializarTextos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = lg.ObtenerHora();
        }

        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            lg.CerrarSesion();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MostarDatos ls = new MostarDatos('D');
            ls.TopLevel = false;
            ls.AutoScroll = true;
            pnWindow.Controls.Add(ls);
            ls.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            MostarDatos ls = new MostarDatos('P');
            ls.TopLevel = false;
            ls.AutoScroll = true;
            pnWindow.Controls.Add(ls);
            ls.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Opciones op = new Opciones();
            op.ShowDialog(this);
            InicializarTextos();
        }

        private void pbDepartamentos_MouseHover(object sender, EventArgs e)
        {
            pbDepartamentos.Image = lg.logos[lg.ObtenerIdioma() + 2][1];
            pbRegistrarDepa.Show();
            pbListaDepa.Show();
        }

        private void pbDepartamentos_MouseLeave(object sender, EventArgs e)
        {
            pbDepartamentos.Image = lg.logos[lg.ObtenerIdioma()][1];
        }

        private void pbActivos_MouseHover(object sender, EventArgs e)
        {
            pbActivos.Image = lg.logos[lg.ObtenerIdioma() + 2][2];
            pbRegistrarActivo.Show();
            pbListaActivos.Show();
        }

        private void pbActivos_MouseLeave(object sender, EventArgs e)
        {
            pbActivos.Image = lg.logos[lg.ObtenerIdioma()][2];
        }

        private void pbPrestamos_MouseHover(object sender, EventArgs e)
        {
            pbPrestamos.Image = lg.logos[lg.ObtenerIdioma() + 2][3];
        }

        private void pbPrestamos_MouseLeave(object sender, EventArgs e)
        {
            pbPrestamos.Image = lg.logos[lg.ObtenerIdioma()][3];
        }

        private void pbUsuario_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            AdministrarUsuario user = new AdministrarUsuario('A');
            user.FatherWindow = this.pnWindow;
            user.TopLevel = false;
            user.AutoScroll = true;
            pnWindow.Controls.Add(user);
            user.Show();
        }

        private void pbUsuario_MouseHover(object sender, EventArgs e)
        {
            pbUsuario.Image = lg.logos[lg.ObtenerIdioma()+2][0];
        }

        private void pbUsuario_MouseLeave(object sender, EventArgs e)
        {
            pbUsuario.Image = lg.logos[lg.ObtenerIdioma()][0];
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            lg.CerrarSesion();
            LogIn log = new LogIn();
            log.Show();
        }

        private void pbCompararActivos_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
        }

        private void pbRegistro_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            MostarDatos ls = new MostarDatos('R');
            ls.fatherWindow = pnWindow;
            ls.TopLevel = false;
            ls.AutoScroll = true;
            pnWindow.Controls.Add(ls);
            ls.Show();
        }

        private void pbInformacion_Click(object sender, EventArgs e)
        {
            lg.Mensaje('I', "Sistema de inventario de activos v.3.1\nhttps://goo.gl/VMOx3J");
        }

        private void pbOpciones_Click(object sender, EventArgs e)
        {
            Opciones op = new Opciones();
            op.FatherForm = this;
            this.Enabled = false;
            op.TopMost = true;
            op.Show();            
        }

        private void pbPage1_Click(object sender, EventArgs e)
        {
            CambiarPagina();
        }

        private void pbPage2_Click(object sender, EventArgs e)
        {
            CambiarPagina();
        }

        private void pbRegistrarDepa_MouseLeave(object sender, EventArgs e)
        {
            OcultarBotones('D');
            pbRegistrarDepa.Image = lg.logos[lg.ObtenerIdioma()][11];
        }

        private void pbListaDepa_MouseLeave(object sender, EventArgs e)
        {
            pbListaDepa.Image = lg.logos[lg.ObtenerIdioma()][12];
            OcultarBotones('D');
        }

        private void pbRegistrarActivo_MouseLeave(object sender, EventArgs e)
        {
            pbRegistrarActivo.Image = lg.logos[lg.ObtenerIdioma()][11];
            OcultarBotones('A');
        }

        private void pbListaActivos_MouseLeave(object sender, EventArgs e)
        {
            pbListaActivos.Image = lg.logos[lg.ObtenerIdioma()][12];
            OcultarBotones('A');
        }

        private void pbCompararActivos_MouseHover(object sender, EventArgs e)
        {
            pbCompararActivos.Image = lg.logos[lg.ObtenerIdioma() + 2][7];
        }

        private void pbCompararActivos_MouseLeave(object sender, EventArgs e)
        {
            pbCompararActivos.Image = lg.logos[lg.ObtenerIdioma()][7];
        }

        private void pbRegistro_MouseHover(object sender, EventArgs e)
        {
            pbRegistro.Image = lg.logos[lg.ObtenerIdioma()+2][8];
        }

        private void pbRegistro_MouseLeave(object sender, EventArgs e)
        {
            pbRegistro.Image = lg.logos[lg.ObtenerIdioma()][8];
        }

        private void pbInformacion_MouseHover(object sender, EventArgs e)
        {
            pbInformacion.Image = lg.logos[lg.ObtenerIdioma() + 2][9];
        }

        private void pbInformacion_MouseLeave(object sender, EventArgs e)
        {
            pbInformacion.Image = lg.logos[lg.ObtenerIdioma()][9];
        }

        private void pbOpciones_MouseLeave_1(object sender, EventArgs e)
        {
            pbOpciones.Image = lg.logos[lg.ObtenerIdioma()][10];
        }

        private void pbOpciones_MouseHover_1(object sender, EventArgs e)
        {
            pbOpciones.Image = lg.logos[lg.ObtenerIdioma()+2][10];
        }

        private void pbRegistrarDepa_MouseHover(object sender, EventArgs e)
        {
            pbRegistrarDepa.Image = lg.logos[lg.ObtenerIdioma()+2][11];
        }

        private void pbRegistrarActivo_MouseHover(object sender, EventArgs e)
        {
            pbRegistrarActivo.Image = lg.logos[lg.ObtenerIdioma() + 2][11];
        }

        private void pbListaActivos_MouseHover(object sender, EventArgs e)
        {
            pbListaActivos.Image = lg.logos[lg.ObtenerIdioma() + 2][12];
        }

        private void pbListaDepa_MouseHover(object sender, EventArgs e)
        {
            pbListaDepa.Image = lg.logos[lg.ObtenerIdioma() + 2][12];
        }

        private void pbRegistrarDepa_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            if (Global.Rol == 1)
            {
                AbrirRegistrar('D');
            }
            else
            {
                lg.Mensaje('A', "Su usuario no posee los privilegios\npara realizar esta accion");
            }
        }

        private void pbRegistrarActivo_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            if (Global.Rol == 1)
            {
                AbrirRegistrar('A');
            }
            else
            {
                lg.Mensaje('A', "Su usuario no posee los privilegios\npara realizar esta accion");
            }
        }

        private void pbListaActivos_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            MostarDatos ls = new MostarDatos('A');
            ls.fatherWindow = pnWindow;
            ls.TopLevel = false;
            ls.AutoScroll = true;
            pnWindow.Controls.Add(ls);
            ls.Show();
        }

        private void pbListaDepa_Click(object sender, EventArgs e)
        {
            pnWindow.Controls.Clear();
            MostarDatos ls = new MostarDatos('D');
            ls.fatherWindow = pnWindow;
            ls.TopLevel = false;
            ls.AutoScroll = true;
            pnWindow.Controls.Add(ls);
            ls.Show();
        }

        private void pbWallpaper_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Global.Rol == 1)
            {
                Terminal cmd = new Terminal();
                cmd.Show(); 
            }
        }
    }
}
