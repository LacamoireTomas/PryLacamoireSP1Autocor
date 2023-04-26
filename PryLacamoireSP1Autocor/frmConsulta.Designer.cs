namespace PryLacamoireSP1Autocor
{
    partial class frmConsulta
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbImportado = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(30, 197);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(345, 159);
            this.dgvLista.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 32);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.rbAmbos);
            this.mrcOrigen.Controls.Add(this.rbImportado);
            this.mrcOrigen.Controls.Add(this.rbNacional);
            this.mrcOrigen.Location = new System.Drawing.Point(33, 82);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(185, 109);
            this.mrcOrigen.TabIndex = 2;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(53, 65);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 2;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbImportado
            // 
            this.rbImportado.AutoSize = true;
            this.rbImportado.Location = new System.Drawing.Point(53, 42);
            this.rbImportado.Name = "rbImportado";
            this.rbImportado.Size = new System.Drawing.Size(72, 17);
            this.rbImportado.TabIndex = 1;
            this.rbImportado.Text = "Importado";
            this.rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Checked = true;
            this.rbNacional.Location = new System.Drawing.Point(53, 19);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(67, 17);
            this.rbNacional.TabIndex = 0;
            this.rbNacional.TabStop = true;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Marca A",
            "Marca B",
            "Marca C"});
            this.cmbMarca.Location = new System.Drawing.Point(97, 32);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 3;
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(275, 29);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 4;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(275, 82);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 380);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.mrcOrigen);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbImportado;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button cmdSalir;
    }
}