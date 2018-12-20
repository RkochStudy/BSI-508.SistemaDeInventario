namespace SistemaDeInventario.Presentation
{
    partial class AgregarDepartamento
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
            this.lbSubEncargado = new System.Windows.Forms.Label();
            this.lbEncargado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbEncargado = new System.Windows.Forms.ComboBox();
            this.cbSubEncargado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbSubEncargado
            // 
            this.lbSubEncargado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSubEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubEncargado.Location = new System.Drawing.Point(473, 212);
            this.lbSubEncargado.Name = "lbSubEncargado";
            this.lbSubEncargado.Size = new System.Drawing.Size(139, 20);
            this.lbSubEncargado.TabIndex = 14;
            this.lbSubEncargado.Text = "Subencargado";
            this.lbSubEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEncargado
            // 
            this.lbEncargado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncargado.Location = new System.Drawing.Point(291, 215);
            this.lbEncargado.Name = "lbEncargado";
            this.lbEncargado.Size = new System.Drawing.Size(139, 20);
            this.lbEncargado.TabIndex = 12;
            this.lbEncargado.Text = "Encargado";
            this.lbEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(103, 238);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 26);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNombre
            // 
            this.lbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(106, 215);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(140, 20);
            this.lbNombre.TabIndex = 10;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(424, 377);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 31);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(313, 377);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 31);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(201, 377);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 31);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(103, 75);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(509, 37);
            this.lbTitulo.TabIndex = 23;
            this.lbTitulo.Text = "Registrar Departamento";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEncargado
            // 
            this.cbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEncargado.FormattingEnabled = true;
            this.cbEncargado.Location = new System.Drawing.Point(287, 238);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(143, 28);
            this.cbEncargado.TabIndex = 24;
            // 
            // cbSubEncargado
            // 
            this.cbSubEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubEncargado.FormattingEnabled = true;
            this.cbSubEncargado.Location = new System.Drawing.Point(469, 238);
            this.cbSubEncargado.Name = "cbSubEncargado";
            this.cbSubEncargado.Size = new System.Drawing.Size(143, 28);
            this.cbSubEncargado.TabIndex = 25;
            // 
            // AgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(723, 479);
            this.Controls.Add(this.cbSubEncargado);
            this.Controls.Add(this.cbEncargado);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbSubEncargado);
            this.Controls.Add(this.lbEncargado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarDepartamento";
            this.Text = "AgregarDepartamento";
            this.Load += new System.EventHandler(this.AgregarDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSubEncargado;
        private System.Windows.Forms.Label lbEncargado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbEncargado;
        private System.Windows.Forms.ComboBox cbSubEncargado;
    }
}