namespace SistemaDeInventario.Presentation
{
    partial class AgregarPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbActivo = new System.Windows.Forms.Label();
            this.cbDepartaPrestamo = new System.Windows.Forms.ComboBox();
            this.txtFechaRetorno = new System.Windows.Forms.MaskedTextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar prestamo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(309, 186);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(266, 29);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNombre
            // 
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(119, 131);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(170, 23);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(119, 187);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(170, 23);
            this.lbCantidad.TabIndex = 3;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(119, 247);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(170, 23);
            this.lbDepartamento.TabIndex = 5;
            this.lbDepartamento.Text = "Nombre";
            this.lbDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de retorno";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbActivo
            // 
            this.lbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivo.Location = new System.Drawing.Point(314, 132);
            this.lbActivo.Name = "lbActivo";
            this.lbActivo.Size = new System.Drawing.Size(261, 23);
            this.lbActivo.TabIndex = 8;
            this.lbActivo.Text = "Activo";
            this.lbActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDepartaPrestamo
            // 
            this.cbDepartaPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartaPrestamo.FormattingEnabled = true;
            this.cbDepartaPrestamo.Location = new System.Drawing.Point(309, 243);
            this.cbDepartaPrestamo.Name = "cbDepartaPrestamo";
            this.cbDepartaPrestamo.Size = new System.Drawing.Size(266, 32);
            this.cbDepartaPrestamo.TabIndex = 9;
            // 
            // txtFechaRetorno
            // 
            this.txtFechaRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRetorno.Location = new System.Drawing.Point(309, 301);
            this.txtFechaRetorno.Mask = "00/00/0000";
            this.txtFechaRetorno.Name = "txtFechaRetorno";
            this.txtFechaRetorno.Size = new System.Drawing.Size(266, 29);
            this.txtFechaRetorno.TabIndex = 10;
            this.txtFechaRetorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(166, 402);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(105, 37);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(297, 402);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 37);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListo
            // 
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Location = new System.Drawing.Point(430, 402);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(105, 37);
            this.btnListo.TabIndex = 13;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // AgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtFechaRetorno);
            this.Controls.Add(this.cbDepartaPrestamo);
            this.Controls.Add(this.lbActivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDepartamento);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPrestamo";
            this.Text = "AgregarPrestamo";
            this.Load += new System.EventHandler(this.AgregarPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbActivo;
        private System.Windows.Forms.ComboBox cbDepartaPrestamo;
        private System.Windows.Forms.MaskedTextBox txtFechaRetorno;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListo;
    }
}