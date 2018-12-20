namespace SistemaDeInventario.Presentation
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.pbIngresar = new System.Windows.Forms.PictureBox();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.pbWallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(129, 277);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 22);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContrasena.Location = new System.Drawing.Point(129, 383);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(294, 22);
            this.txtContrasena.TabIndex = 16;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_KeyDown);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            // 
            // pbIngresar
            // 
            this.pbIngresar.Image = ((System.Drawing.Image)(resources.GetObject("pbIngresar.Image")));
            this.pbIngresar.Location = new System.Drawing.Point(296, 445);
            this.pbIngresar.Name = "pbIngresar";
            this.pbIngresar.Size = new System.Drawing.Size(127, 35);
            this.pbIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIngresar.TabIndex = 22;
            this.pbIngresar.TabStop = false;
            this.pbIngresar.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pbIngresar.MouseLeave += new System.EventHandler(this.pbIngresar_MouseLeave);
            this.pbIngresar.MouseHover += new System.EventHandler(this.pbIngresar_MouseHover);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Image = global::SistemaDeInventario.Properties.Resources.btn_Login_Acceder;
            this.pbCancelar.Location = new System.Drawing.Point(72, 445);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(127, 35);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCancelar.TabIndex = 21;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbCancelar.MouseLeave += new System.EventHandler(this.pbCancelar_MouseLeave);
            this.pbCancelar.MouseHover += new System.EventHandler(this.pbCancelar_MouseHover);
            // 
            // pbWallpaper
            // 
            this.pbWallpaper.Image = ((System.Drawing.Image)(resources.GetObject("pbWallpaper.Image")));
            this.pbWallpaper.Location = new System.Drawing.Point(-1, -1);
            this.pbWallpaper.Name = "pbWallpaper";
            this.pbWallpaper.Size = new System.Drawing.Size(490, 510);
            this.pbWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbWallpaper.TabIndex = 0;
            this.pbWallpaper.TabStop = false;
            this.pbWallpaper.UseWaitCursor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 505);
            this.Controls.Add(this.pbIngresar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbWallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWallpaper;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.PictureBox pbIngresar;
    }
}