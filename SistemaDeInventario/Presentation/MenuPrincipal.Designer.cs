namespace SistemaDeInventario
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnWindow = new System.Windows.Forms.Panel();
            this.LeftButtonPanel2 = new System.Windows.Forms.Panel();
            this.pbCompararActivos = new System.Windows.Forms.PictureBox();
            this.pbOpciones = new System.Windows.Forms.PictureBox();
            this.pbRegistro = new System.Windows.Forms.PictureBox();
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.pbPage2 = new System.Windows.Forms.PictureBox();
            this.pbPage1 = new System.Windows.Forms.PictureBox();
            this.LeftButtonPanel1 = new System.Windows.Forms.Panel();
            this.pbRegistrarActivo = new System.Windows.Forms.PictureBox();
            this.pbListaActivos = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbPrestamos = new System.Windows.Forms.PictureBox();
            this.pbListaDepa = new System.Windows.Forms.PictureBox();
            this.pbActivos = new System.Windows.Forms.PictureBox();
            this.pbRegistrarDepa = new System.Windows.Forms.PictureBox();
            this.pbDepartamentos = new System.Windows.Forms.PictureBox();
            this.pbWallpaper = new System.Windows.Forms.PictureBox();
            this.LeftButtonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompararActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPage1)).BeginInit();
            this.LeftButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrarActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaDepa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrarDepa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHora
            // 
            this.lbHora.BackColor = System.Drawing.Color.DarkGreen;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbHora.Location = new System.Drawing.Point(776, 51);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(127, 30);
            this.lbHora.TabIndex = 8;
            this.lbHora.Text = "HH:MM";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.DarkGreen;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbFecha.Location = new System.Drawing.Point(764, 10);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(152, 27);
            this.lbFecha.TabIndex = 7;
            this.lbFecha.Text = "DD/MM/YY";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsuario
            // 
            this.lbUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuario.Location = new System.Drawing.Point(248, 36);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(358, 28);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUsuario.Click += new System.EventHandler(this.lbUsuario_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnWindow
            // 
            this.pnWindow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnWindow.Location = new System.Drawing.Point(215, 92);
            this.pnWindow.Name = "pnWindow";
            this.pnWindow.Size = new System.Drawing.Size(720, 478);
            this.pnWindow.TabIndex = 28;
            // 
            // LeftButtonPanel2
            // 
            this.LeftButtonPanel2.BackgroundImage = global::SistemaDeInventario.Properties.Resources.LeftPanelWallpaper;
            this.LeftButtonPanel2.Controls.Add(this.pbCompararActivos);
            this.LeftButtonPanel2.Controls.Add(this.pbOpciones);
            this.LeftButtonPanel2.Controls.Add(this.pbRegistro);
            this.LeftButtonPanel2.Controls.Add(this.pbInformacion);
            this.LeftButtonPanel2.Location = new System.Drawing.Point(0, 111);
            this.LeftButtonPanel2.Name = "LeftButtonPanel2";
            this.LeftButtonPanel2.Size = new System.Drawing.Size(215, 401);
            this.LeftButtonPanel2.TabIndex = 31;
            this.LeftButtonPanel2.Visible = false;
            // 
            // pbCompararActivos
            // 
            this.pbCompararActivos.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_CompararActivos;
            this.pbCompararActivos.Location = new System.Drawing.Point(0, 11);
            this.pbCompararActivos.Name = "pbCompararActivos";
            this.pbCompararActivos.Size = new System.Drawing.Size(215, 79);
            this.pbCompararActivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCompararActivos.TabIndex = 24;
            this.pbCompararActivos.TabStop = false;
            this.pbCompararActivos.Click += new System.EventHandler(this.pbCompararActivos_Click);
            this.pbCompararActivos.MouseLeave += new System.EventHandler(this.pbCompararActivos_MouseLeave);
            this.pbCompararActivos.MouseHover += new System.EventHandler(this.pbCompararActivos_MouseHover);
            // 
            // pbOpciones
            // 
            this.pbOpciones.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Opciones;
            this.pbOpciones.Location = new System.Drawing.Point(0, 312);
            this.pbOpciones.Name = "pbOpciones";
            this.pbOpciones.Size = new System.Drawing.Size(215, 79);
            this.pbOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOpciones.TabIndex = 15;
            this.pbOpciones.TabStop = false;
            this.pbOpciones.Click += new System.EventHandler(this.pbOpciones_Click);
            this.pbOpciones.MouseLeave += new System.EventHandler(this.pbOpciones_MouseLeave_1);
            this.pbOpciones.MouseHover += new System.EventHandler(this.pbOpciones_MouseHover_1);
            // 
            // pbRegistro
            // 
            this.pbRegistro.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Registro;
            this.pbRegistro.Location = new System.Drawing.Point(0, 110);
            this.pbRegistro.Name = "pbRegistro";
            this.pbRegistro.Size = new System.Drawing.Size(215, 79);
            this.pbRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRegistro.TabIndex = 13;
            this.pbRegistro.TabStop = false;
            this.pbRegistro.Click += new System.EventHandler(this.pbRegistro_Click);
            this.pbRegistro.MouseLeave += new System.EventHandler(this.pbRegistro_MouseLeave);
            this.pbRegistro.MouseHover += new System.EventHandler(this.pbRegistro_MouseHover);
            // 
            // pbInformacion
            // 
            this.pbInformacion.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Informacion;
            this.pbInformacion.Location = new System.Drawing.Point(0, 211);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(215, 79);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInformacion.TabIndex = 14;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.Click += new System.EventHandler(this.pbInformacion_Click);
            this.pbInformacion.MouseLeave += new System.EventHandler(this.pbInformacion_MouseLeave);
            this.pbInformacion.MouseHover += new System.EventHandler(this.pbInformacion_MouseHover);
            // 
            // pbPage2
            // 
            this.pbPage2.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Page_Unselected1;
            this.pbPage2.Location = new System.Drawing.Point(129, 535);
            this.pbPage2.Name = "pbPage2";
            this.pbPage2.Size = new System.Drawing.Size(16, 16);
            this.pbPage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPage2.TabIndex = 32;
            this.pbPage2.TabStop = false;
            this.pbPage2.Click += new System.EventHandler(this.pbPage2_Click);
            // 
            // pbPage1
            // 
            this.pbPage1.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Page_Unselected1;
            this.pbPage1.Location = new System.Drawing.Point(55, 535);
            this.pbPage1.Name = "pbPage1";
            this.pbPage1.Size = new System.Drawing.Size(16, 16);
            this.pbPage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPage1.TabIndex = 31;
            this.pbPage1.TabStop = false;
            this.pbPage1.Click += new System.EventHandler(this.pbPage1_Click);
            // 
            // LeftButtonPanel1
            // 
            this.LeftButtonPanel1.BackgroundImage = global::SistemaDeInventario.Properties.Resources.LeftPanelWallpaper;
            this.LeftButtonPanel1.Controls.Add(this.pbRegistrarActivo);
            this.LeftButtonPanel1.Controls.Add(this.pbListaActivos);
            this.LeftButtonPanel1.Controls.Add(this.pbUsuario);
            this.LeftButtonPanel1.Controls.Add(this.pbPrestamos);
            this.LeftButtonPanel1.Controls.Add(this.pbListaDepa);
            this.LeftButtonPanel1.Controls.Add(this.pbActivos);
            this.LeftButtonPanel1.Controls.Add(this.pbRegistrarDepa);
            this.LeftButtonPanel1.Controls.Add(this.pbDepartamentos);
            this.LeftButtonPanel1.Location = new System.Drawing.Point(0, 111);
            this.LeftButtonPanel1.Name = "LeftButtonPanel1";
            this.LeftButtonPanel1.Size = new System.Drawing.Size(215, 401);
            this.LeftButtonPanel1.TabIndex = 30;
            // 
            // pbRegistrarActivo
            // 
            this.pbRegistrarActivo.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_RegistrarActivo;
            this.pbRegistrarActivo.Location = new System.Drawing.Point(0, 211);
            this.pbRegistrarActivo.Name = "pbRegistrarActivo";
            this.pbRegistrarActivo.Size = new System.Drawing.Size(215, 41);
            this.pbRegistrarActivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRegistrarActivo.TabIndex = 32;
            this.pbRegistrarActivo.TabStop = false;
            this.pbRegistrarActivo.Visible = false;
            this.pbRegistrarActivo.Click += new System.EventHandler(this.pbRegistrarActivo_Click);
            this.pbRegistrarActivo.MouseLeave += new System.EventHandler(this.pbRegistrarActivo_MouseLeave);
            this.pbRegistrarActivo.MouseHover += new System.EventHandler(this.pbRegistrarActivo_MouseHover);
            // 
            // pbListaActivos
            // 
            this.pbListaActivos.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_VerLista;
            this.pbListaActivos.Location = new System.Drawing.Point(0, 252);
            this.pbListaActivos.Name = "pbListaActivos";
            this.pbListaActivos.Size = new System.Drawing.Size(215, 41);
            this.pbListaActivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbListaActivos.TabIndex = 35;
            this.pbListaActivos.TabStop = false;
            this.pbListaActivos.Visible = false;
            this.pbListaActivos.Click += new System.EventHandler(this.pbListaActivos_Click);
            this.pbListaActivos.MouseLeave += new System.EventHandler(this.pbListaActivos_MouseLeave);
            this.pbListaActivos.MouseHover += new System.EventHandler(this.pbListaActivos_MouseHover);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Usuario;
            this.pbUsuario.Location = new System.Drawing.Point(0, 11);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(215, 79);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsuario.TabIndex = 24;
            this.pbUsuario.TabStop = false;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            this.pbUsuario.MouseLeave += new System.EventHandler(this.pbUsuario_MouseLeave);
            this.pbUsuario.MouseHover += new System.EventHandler(this.pbUsuario_MouseHover);
            // 
            // pbPrestamos
            // 
            this.pbPrestamos.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Prestamos;
            this.pbPrestamos.Location = new System.Drawing.Point(0, 312);
            this.pbPrestamos.Name = "pbPrestamos";
            this.pbPrestamos.Size = new System.Drawing.Size(215, 79);
            this.pbPrestamos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPrestamos.TabIndex = 15;
            this.pbPrestamos.TabStop = false;
            this.pbPrestamos.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pbPrestamos.MouseLeave += new System.EventHandler(this.pbPrestamos_MouseLeave);
            this.pbPrestamos.MouseHover += new System.EventHandler(this.pbPrestamos_MouseHover);
            // 
            // pbListaDepa
            // 
            this.pbListaDepa.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_VerLista;
            this.pbListaDepa.Location = new System.Drawing.Point(0, 148);
            this.pbListaDepa.Name = "pbListaDepa";
            this.pbListaDepa.Size = new System.Drawing.Size(215, 41);
            this.pbListaDepa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbListaDepa.TabIndex = 36;
            this.pbListaDepa.TabStop = false;
            this.pbListaDepa.Visible = false;
            this.pbListaDepa.Click += new System.EventHandler(this.pbListaDepa_Click);
            this.pbListaDepa.MouseLeave += new System.EventHandler(this.pbListaDepa_MouseLeave);
            this.pbListaDepa.MouseHover += new System.EventHandler(this.pbListaDepa_MouseHover);
            // 
            // pbActivos
            // 
            this.pbActivos.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Activos;
            this.pbActivos.Location = new System.Drawing.Point(0, 211);
            this.pbActivos.Name = "pbActivos";
            this.pbActivos.Size = new System.Drawing.Size(215, 79);
            this.pbActivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbActivos.TabIndex = 14;
            this.pbActivos.TabStop = false;
            this.pbActivos.MouseLeave += new System.EventHandler(this.pbActivos_MouseLeave);
            this.pbActivos.MouseHover += new System.EventHandler(this.pbActivos_MouseHover);
            // 
            // pbRegistrarDepa
            // 
            this.pbRegistrarDepa.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_RegistrarActivo;
            this.pbRegistrarDepa.Location = new System.Drawing.Point(0, 110);
            this.pbRegistrarDepa.Name = "pbRegistrarDepa";
            this.pbRegistrarDepa.Size = new System.Drawing.Size(215, 41);
            this.pbRegistrarDepa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRegistrarDepa.TabIndex = 34;
            this.pbRegistrarDepa.TabStop = false;
            this.pbRegistrarDepa.Visible = false;
            this.pbRegistrarDepa.Click += new System.EventHandler(this.pbRegistrarDepa_Click);
            this.pbRegistrarDepa.MouseLeave += new System.EventHandler(this.pbRegistrarDepa_MouseLeave);
            this.pbRegistrarDepa.MouseHover += new System.EventHandler(this.pbRegistrarDepa_MouseHover);
            // 
            // pbDepartamentos
            // 
            this.pbDepartamentos.Image = global::SistemaDeInventario.Properties.Resources.btn_MP_Departamento;
            this.pbDepartamentos.Location = new System.Drawing.Point(0, 110);
            this.pbDepartamentos.Name = "pbDepartamentos";
            this.pbDepartamentos.Size = new System.Drawing.Size(215, 79);
            this.pbDepartamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDepartamentos.TabIndex = 13;
            this.pbDepartamentos.TabStop = false;
            this.pbDepartamentos.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbDepartamentos.MouseLeave += new System.EventHandler(this.pbDepartamentos_MouseLeave);
            this.pbDepartamentos.MouseHover += new System.EventHandler(this.pbDepartamentos_MouseHover);
            // 
            // pbWallpaper
            // 
            this.pbWallpaper.Image = global::SistemaDeInventario.Properties.Resources.MenuPrincipalWallpaper;
            this.pbWallpaper.Location = new System.Drawing.Point(0, 1);
            this.pbWallpaper.Name = "pbWallpaper";
            this.pbWallpaper.Size = new System.Drawing.Size(936, 570);
            this.pbWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbWallpaper.TabIndex = 27;
            this.pbWallpaper.TabStop = false;
            this.pbWallpaper.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbWallpaper_MouseDoubleClick);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 567);
            this.Controls.Add(this.LeftButtonPanel2);
            this.Controls.Add(this.pbPage2);
            this.Controls.Add(this.pbPage1);
            this.Controls.Add(this.LeftButtonPanel1);
            this.Controls.Add(this.pnWindow);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.pbWallpaper);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Sistema de inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.LeftButtonPanel2.ResumeLayout(false);
            this.LeftButtonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompararActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPage1)).EndInit();
            this.LeftButtonPanel1.ResumeLayout(false);
            this.LeftButtonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrarActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaDepa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrarDepa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPrestamos;
        private System.Windows.Forms.PictureBox pbActivos;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbDepartamentos;
        private System.Windows.Forms.Panel pnWindow;
        private System.Windows.Forms.Panel LeftButtonPanel1;
        private System.Windows.Forms.Panel LeftButtonPanel2;
        private System.Windows.Forms.PictureBox pbCompararActivos;
        private System.Windows.Forms.PictureBox pbOpciones;
        private System.Windows.Forms.PictureBox pbRegistro;
        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.PictureBox pbPage1;
        private System.Windows.Forms.PictureBox pbPage2;
        private System.Windows.Forms.PictureBox pbRegistrarActivo;
        private System.Windows.Forms.PictureBox pbRegistrarDepa;
        private System.Windows.Forms.PictureBox pbListaActivos;
        private System.Windows.Forms.PictureBox pbListaDepa;
        private System.Windows.Forms.PictureBox pbWallpaper;
    }
}



