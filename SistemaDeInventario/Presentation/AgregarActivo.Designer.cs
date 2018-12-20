namespace SistemaDeInventario.Presentation
{
    partial class AgregarActivo
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
            this.lbNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDescipcion = new System.Windows.Forms.Label();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbTipoActivo = new System.Windows.Forms.ComboBox();
            this.lbTipoActivo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbNumSerie
            // 
            this.lbNumSerie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumSerie.Location = new System.Drawing.Point(300, 153);
            this.lbNumSerie.Name = "lbNumSerie";
            this.lbNumSerie.Size = new System.Drawing.Size(141, 20);
            this.lbNumSerie.TabIndex = 0;
            this.lbNumSerie.Text = "Numero de serie";
            this.lbNumSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(299, 175);
            this.txtNumSerie.MaxLength = 9;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(143, 26);
            this.txtNumSerie.TabIndex = 1;
            this.txtNumSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(480, 175);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // lbNombre
            // 
            this.lbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(481, 153);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(140, 20);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(111, 241);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(143, 26);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbMarca
            // 
            this.lbMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(113, 219);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(139, 20);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "Marca";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(479, 306);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(143, 26);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lbCantidad
            // 
            this.lbCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(481, 284);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(140, 20);
            this.lbCantidad.TabIndex = 10;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCantidad.Click += new System.EventHandler(this.lbCantidad_Click);
            // 
            // lbDescipcion
            // 
            this.lbDescipcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDescipcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescipcion.Location = new System.Drawing.Point(300, 219);
            this.lbDescipcion.Name = "lbDescipcion";
            this.lbDescipcion.Size = new System.Drawing.Size(139, 20);
            this.lbDescipcion.TabIndex = 6;
            this.lbDescipcion.Text = "Descripcion";
            this.lbDescipcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(481, 219);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(139, 20);
            this.lbDepartamento.TabIndex = 14;
            this.lbDepartamento.Text = "Departamento";
            this.lbDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTipo
            // 
            this.lbTipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(111, 282);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(143, 20);
            this.lbTipo.TabIndex = 12;
            this.lbTipo.Text = "Tipo";
            this.lbTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTipo.Click += new System.EventHandler(this.lbTipo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(215, 393);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 31);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(327, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 31);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(438, 393);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 31);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Telematica"});
            this.cbDepartamento.Location = new System.Drawing.Point(480, 241);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(143, 28);
            this.cbDepartamento.TabIndex = 5;
            // 
            // cbTipoActivo
            // 
            this.cbTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoActivo.FormattingEnabled = true;
            this.cbTipoActivo.Items.AddRange(new object[] {
            "Con placa",
            "Sin placa"});
            this.cbTipoActivo.Location = new System.Drawing.Point(112, 173);
            this.cbTipoActivo.Name = "cbTipoActivo";
            this.cbTipoActivo.Size = new System.Drawing.Size(143, 28);
            this.cbTipoActivo.TabIndex = 0;
            this.cbTipoActivo.SelectedValueChanged += new System.EventHandler(this.cbTipoActivo_SelectedValueChanged);
            // 
            // lbTipoActivo
            // 
            this.lbTipoActivo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTipoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoActivo.Location = new System.Drawing.Point(115, 151);
            this.lbTipoActivo.Name = "lbTipoActivo";
            this.lbTipoActivo.Size = new System.Drawing.Size(137, 20);
            this.lbTipoActivo.TabIndex = 20;
            this.lbTipoActivo.Text = "Tipo de activo";
            this.lbTipoActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(112, 57);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(513, 37);
            this.lbTitulo.TabIndex = 24;
            this.lbTitulo.Text = "Registrar Activo";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitulo.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Electronico",
            "Mueble",
            "Cable/Accesorio",
            "Otro"});
            this.cbTipo.Location = new System.Drawing.Point(112, 304);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(143, 28);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescripcion.Location = new System.Drawing.Point(299, 246);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(140, 86);
            this.rtDescripcion.TabIndex = 4;
            this.rtDescripcion.Text = "";
            // 
            // AgregarActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(722, 478);
            this.Controls.Add(this.rtDescripcion);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.cbTipoActivo);
            this.Controls.Add(this.lbTipoActivo);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbDepartamento);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbDescipcion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lbNumSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarActivo";
            this.Text = "AgregarActivo";
            this.Load += new System.EventHandler(this.AgregarActivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDescipcion;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbTipoActivo;
        private System.Windows.Forms.Label lbTipoActivo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.RichTextBox rtDescripcion;
    }
}