using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLacamoireSP1Autocor
{
    public partial class frmAutocor : Form
    {
        List<claseRepuestos> listaRepuestos = new List<claseRepuestos>();
        void limpiarcontroles()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbMarca.SelectedIndex = -1;

        }
        public frmAutocor()
        {
            InitializeComponent();
        }

        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmAutocor_Load(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            claseRepuestos objRepuesto = new claseRepuestos();

            objRepuesto.Nombre = txtNombre.Text;

            objRepuesto.Precio = int.Parse(txtPrecio.Text);

            objRepuesto.Codigo = (txtCodigo.Text);

            objRepuesto.Marca = cmbMarca.Text;

            //s

            if (rbImportado.Checked == true)
            {
                objRepuesto.Origen = ("Importado");
            }
            else
            {
                objRepuesto.Origen = ("Nacional");
            }

            string DatosRepuesto = objRepuesto.ObtenerDatosRepuesto();

            MessageBox.Show(objRepuesto.Codigo + objRepuesto.Nombre + objRepuesto.Marca + objRepuesto.Precio + objRepuesto.Origen, "Repuesto");

            limpiarcontroles();

        }

        private void cmbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbConsultar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

