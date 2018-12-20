namespace SistemaDeInventario.Presentation
{
    partial class CambiarContrasena
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtPassNueva2 = new System.Windows.Forms.TextBox();
            this.lbNuevaContrasena2 = new System.Windows.Forms.Label();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.lbContrasenna = new System.Windows.Forms.Label();
            this.txtPassNueva = new System.Windows.Forms.TextBox();
            this.lbNuevaContrasena = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(199, 36);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(295, 46);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "Cambiar contraseña";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassNueva2
            // 
            this.txtPassNueva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNueva2.Location = new System.Drawing.Point(240, 285);
            this.txtPassNueva2.MaxLength = 5000;
            this.txtPassNueva2.Name = "txtPassNueva2";
            this.txtPassNueva2.PasswordChar = '*';
            this.txtPassNueva2.Size = new System.Drawing.Size(218, 26);
            this.txtPassNueva2.TabIndex = 2;
            this.txtPassNueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassNueva2.Leave += new System.EventHandler(this.txtPassNueva2_Leave);
            // 
            // lbNuevaContrasena2
            // 
            this.lbNuevaContrasena2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNuevaContrasena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaContrasena2.Location = new System.Drawing.Point(245, 262);
            this.lbNuevaContrasena2.Name = "lbNuevaContrasena2";
            this.lbNuevaContrasena2.Size = new System.Drawing.Size(206, 20);
            this.lbNuevaContrasena2.TabIndex = 21;
            this.lbNuevaContrasena2.Text = "Repita la nueva contraseña";
            this.lbNuevaContrasena2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassActual
            // 
            this.txtPassActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassActual.Location = new System.Drawing.Point(240, 141);
            this.txtPassActual.MaxLength = 5000;
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.PasswordChar = '*';
            this.txtPassActual.Size = new System.Drawing.Size(218, 26);
            this.txtPassActual.TabIndex = 0;
            this.txtPassActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassActual.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lbContrasenna
            // 
            this.lbContrasenna.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenna.Location = new System.Drawing.Point(236, 118);
            this.lbContrasenna.Name = "lbContrasenna";
            this.lbContrasenna.Size = new System.Drawing.Size(222, 20);
            this.lbContrasenna.TabIndex = 20;
            this.lbContrasenna.Text = "Digite su contraseña actual";
            this.lbContrasenna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassNueva
            // 
            this.txtPassNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNueva.Location = new System.Drawing.Point(240, 212);
            this.txtPassNueva.MaxLength = 5000;
            this.txtPassNueva.Name = "txtPassNueva";
            this.txtPassNueva.PasswordChar = '*';
            this.txtPassNueva.Size = new System.Drawing.Size(218, 26);
            this.txtPassNueva.TabIndex = 1;
            this.txtPassNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassNueva.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // lbNuevaContrasena
            // 
            this.lbNuevaContrasena.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNuevaContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevaContrasena.Location = new System.Drawing.Point(239, 189);
            this.lbNuevaContrasena.Name = "lbNuevaContrasena";
            this.lbNuevaContrasena.Size = new System.Drawing.Size(207, 20);
            this.lbNuevaContrasena.TabIndex = 19;
            this.lbNuevaContrasena.Text = "Digite la nueva contraseña";
            this.lbNuevaContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(227, 359);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnListo
            // 
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Location = new System.Drawing.Point(356, 359);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(110, 32);
            this.btnListo.TabIndex = 4;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // CambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(706, 439);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtPassNueva2);
            this.Controls.Add(this.lbNuevaContrasena2);
            this.Controls.Add(this.txtPassActual);
            this.Controls.Add(this.lbContrasenna);
            this.Controls.Add(this.txtPassNueva);
            this.Controls.Add(this.lbNuevaContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarContrasena";
            this.Text = "CambiarContrasena";
            this.Load += new System.EventHandler(this.CambiarContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtPassNueva2;
        private System.Windows.Forms.Label lbNuevaContrasena2;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.Label lbContrasenna;
        private System.Windows.Forms.TextBox txtPassNueva;
        private System.Windows.Forms.Label lbNuevaContrasena;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListo;
    }
}