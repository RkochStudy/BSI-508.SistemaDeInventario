namespace SistemaDeInventario.Presentation
{
    partial class RegistrarPrestamo
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
            this.lbActivoNombre = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.lbFechaRetorno = new System.Windows.Forms.Label();
            this.lbActivo = new System.Windows.Forms.Label();
            this.txtFechaRetorno = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbActivoNombre
            // 
            this.lbActivoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivoNombre.Location = new System.Drawing.Point(338, 113);
            this.lbActivoNombre.Name = "lbActivoNombre";
            this.lbActivoNombre.Size = new System.Drawing.Size(254, 23);
            this.lbActivoNombre.TabIndex = 0;
            this.lbActivoNombre.Text = "Nombre";
            this.lbActivoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(342, 164);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(250, 29);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(123, 169);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(168, 24);
            this.lbCantidad.TabIndex = 2;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(123, 243);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(168, 24);
            this.lbDepartamento.TabIndex = 4;
            this.lbDepartamento.Text = "Departamento";
            this.lbDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFechaRetorno
            // 
            this.lbFechaRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaRetorno.Location = new System.Drawing.Point(123, 321);
            this.lbFechaRetorno.Name = "lbFechaRetorno";
            this.lbFechaRetorno.Size = new System.Drawing.Size(168, 24);
            this.lbFechaRetorno.TabIndex = 6;
            this.lbFechaRetorno.Text = "Fecha retorno";
            this.lbFechaRetorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbActivo
            // 
            this.lbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivo.Location = new System.Drawing.Point(120, 112);
            this.lbActivo.Name = "lbActivo";
            this.lbActivo.Size = new System.Drawing.Size(168, 24);
            this.lbActivo.TabIndex = 8;
            this.lbActivo.Text = "Activo";
            this.lbActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFechaRetorno
            // 
            this.txtFechaRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRetorno.Location = new System.Drawing.Point(342, 321);
            this.txtFechaRetorno.Mask = "00/00/0000";
            this.txtFechaRetorno.Name = "txtFechaRetorno";
            this.txtFechaRetorno.Size = new System.Drawing.Size(250, 29);
            this.txtFechaRetorno.TabIndex = 9;
            this.txtFechaRetorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Realizar prestamo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(342, 239);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(250, 32);
            this.cbDepartamento.TabIndex = 11;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(185, 402);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 36);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(304, 402);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 36);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.Location = new System.Drawing.Point(425, 402);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(100, 36);
            this.btnPrestar.TabIndex = 14;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeInventario.Properties.Resources.close2;
            this.pictureBox1.Location = new System.Drawing.Point(678, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(720, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaRetorno);
            this.Controls.Add(this.lbActivo);
            this.Controls.Add(this.lbFechaRetorno);
            this.Controls.Add(this.lbDepartamento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbActivoNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPrestamo";
            this.Text = "RegistrarPrestamo";
            this.Load += new System.EventHandler(this.RegistrarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbActivoNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label lbFechaRetorno;
        private System.Windows.Forms.Label lbActivo;
        private System.Windows.Forms.MaskedTextBox txtFechaRetorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}