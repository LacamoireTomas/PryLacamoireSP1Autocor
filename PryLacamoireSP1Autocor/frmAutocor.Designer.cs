namespace PryLacamoireSP1Autocor
{
    partial class frmAutocor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstRepuestos = new System.Windows.Forms.ListBox();
            this.mrcRepuestos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.rbImportado = new System.Windows.Forms.RadioButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmbCancelar = new System.Windows.Forms.Button();
            this.cmbConsultar = new System.Windows.Forms.Button();
            this.cmbSalir = new System.Windows.Forms.Button();
            this.mrcRepuestos.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRepuestos
            // 
            this.lstRepuestos.FormattingEnabled = true;
            this.lstRepuestos.Location = new System.Drawing.Point(12, 248);
            this.lstRepuestos.Name = "lstRepuestos";
            this.lstRepuestos.Size = new System.Drawing.Size(360, 121);
            this.lstRepuestos.TabIndex = 1;
            // 
            // mrcRepuestos
            // 
            this.mrcRepuestos.Controls.Add(this.txtPrecio);
            this.mrcRepuestos.Controls.Add(this.txtNombre);
            this.mrcRepuestos.Controls.Add(this.txtCodigo);
            this.mrcRepuestos.Controls.Add(this.cmbMarca);
            this.mrcRepuestos.Controls.Add(this.mrcOrigen);
            this.mrcRepuestos.Controls.Add(this.lblPrecio);
            this.mrcRepuestos.Controls.Add(this.lblMarca);
            this.mrcRepuestos.Controls.Add(this.lblNombre);
            this.mrcRepuestos.Controls.Add(this.lblCodigo);
            this.mrcRepuestos.Location = new System.Drawing.Point(13, 13);
            this.mrcRepuestos.Name = "mrcRepuestos";
            this.mrcRepuestos.Size = new System.Drawing.Size(227, 229);
            this.mrcRepuestos.TabIndex = 2;
            this.mrcRepuestos.TabStop = false;
            this.mrcRepuestos.Text = "Repuesto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 98);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 128);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.rbImportado);
            this.mrcOrigen.Controls.Add(this.rbNacional);
            this.mrcOrigen.Location = new System.Drawing.Point(9, 156);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(212, 44);
            this.mrcOrigen.TabIndex = 4;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Checked = true;
            this.rbNacional.Location = new System.Drawing.Point(21, 19);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(67, 17);
            this.rbNacional.TabIndex = 0;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            this.rbNacional.CheckedChanged += new System.EventHandler(this.rbNacional_CheckedChanged);
            // 
            // rbImportado
            // 
            this.rbImportado.AutoSize = true;
            this.rbImportado.Location = new System.Drawing.Point(94, 19);
            this.rbImportado.Name = "rbImportado";
            this.rbImportado.Size = new System.Drawing.Size(72, 17);
            this.rbImportado.TabIndex = 1;
            this.rbImportado.Text = "Importado";
            this.rbImportado.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(65, 95);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(297, 47);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 3;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmbCancelar
            // 
            this.cmbCancelar.Location = new System.Drawing.Point(297, 90);
            this.cmbCancelar.Name = "cmbCancelar";
            this.cmbCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmbCancelar.TabIndex = 4;
            this.cmbCancelar.Text = "Cancelar";
            this.cmbCancelar.UseVisualStyleBackColor = true;
            this.cmbCancelar.Click += new System.EventHandler(this.cmbCancelar_Click);
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.Location = new System.Drawing.Point(297, 131);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmbConsultar.TabIndex = 5;
            this.cmbConsultar.Text = "Consultar";
            this.cmbConsultar.UseVisualStyleBackColor = true;
            this.cmbConsultar.Click += new System.EventHandler(this.cmbConsultar_Click);
            // 
            // cmbSalir
            // 
            this.cmbSalir.Location = new System.Drawing.Point(297, 169);
            this.cmbSalir.Name = "cmbSalir";
            this.cmbSalir.Size = new System.Drawing.Size(75, 23);
            this.cmbSalir.TabIndex = 6;
            this.cmbSalir.Text = "Salir";
            this.cmbSalir.UseVisualStyleBackColor = true;
            // 
            // frmAutocor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 383);
            this.Controls.Add(this.cmbSalir);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.cmbCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcRepuestos);
            this.Controls.Add(this.lstRepuestos);
            this.Name = "frmAutocor";
            this.Text = "AUTOCOR-REPUESTOS";
            this.Load += new System.EventHandler(this.frmAutocor_Load);
            this.mrcRepuestos.ResumeLayout(false);
            this.mrcRepuestos.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRepuestos;
        private System.Windows.Forms.GroupBox mrcRepuestos;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton rbImportado;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmbCancelar;
        private System.Windows.Forms.Button cmbConsultar;
        private System.Windows.Forms.Button cmbSalir;
    }
}

