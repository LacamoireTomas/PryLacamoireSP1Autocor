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

        private void Inicializar()
        {
            // carga de los items en el comboBox de Marcas
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;

        }

        private const string PATH_ARCHIVO = "Repuestos.txt";

        private bool ValidarDatos()
        {
            // devuelve falso si no se cumplen todas las condiciones
            bool resultado = false;
            if (txtCodigo.Text != "") // controla el valor del código
            {
                if (txtNombre.Text != "") // controla el nombre
                {
                    if (txtPrecio.Text != "") // controla el precio
                    {
                        Archivo Repuestos = new Archivo();
                        Repuestos.NombreArchivo = PATH_ARCHIVO;
                        // controla que no se repita el codigo del repuesto
                        if (Repuestos.BuscarCodigoRepuesto(txtCodigo.Text) == false)
                        {
                            resultado = true; // devuelve verdadero sólo si todas
                                              // las condiciones se cumplieron
                        }
                    }
                }
            }
            return resultado;
        }
        private claseRepuestos CrearRepuesto()
        {
            // se crea un nuevo objeto de tipo Repuesto
            claseRepuestos nuevoRep = new claseRepuestos();
            // se asignan los valores a todas sus propiedades
            nuevoRep.Codigo = txtCodigo.Text;
            nuevoRep.Nombre = txtNombre.Text;
            nuevoRep.Marca = cmbMarca.SelectedItem.ToString();
            nuevoRep.Precio = decimal.Parse(txtPrecio.Text);
            if (rbNacional.Checked)
            {
                nuevoRep.Origen = "Nacional";
            }
            else
            {
                nuevoRep.Origen = "Importado";
            }
            return nuevoRep; // devuelve el objeto creado con sus valores
        }   
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
            if (ValidarDatos()) // si los datos son correctos
            {
                // crear un nuevo repuesto
                claseRepuestos nuevoRep = CrearRepuesto();
                // grabar en el archivo
                Archivo Repuestos = new Archivo();
                Repuestos.NombreArchivo = PATH_ARCHIVO;
                Repuestos.GrabarRepuesto(nuevoRep);
                limpiarcontroles();
                MessageBox.Show(lblCodigo.Text + nuevoRep.Codigo + lblNombre.Text + nuevoRep.Nombre + lblMarca.Text + nuevoRep.Marca + lblPrecio.Text + nuevoRep.Precio + mrcOrigen.Text + nuevoRep.Origen, "Repuesto");
            }
            else // si hay algún error
            {
                MessageBox.Show("Datos incorrectos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCancelar_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void cmbConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta abrirConsulta = new frmConsulta (PATH_ARCHIVO);
            abrirConsulta.ShowDialog();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aceptar solo expresiones numéricas con decimales
            if (!Char.IsNumber(e.KeyChar) &&
            e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }




           // private void cmdRegistrar_Click(object sender, EventArgs e)
          //  {
          //   claseRepuestos objRepuesto = new claseRepuestos();
          
            //    objRepuesto.Nombre = txtNombre.Text;

             //   objRepuesto.Precio = int.Parse(txtPrecio.Text);

               // objRepuesto.Codigo = (txtCodigo.Text);

               // objRepuesto.Marca = cmbMarca.Text;

               

               // if (rbImportado.Checked == true)
               // {
               //     objRepuesto.Origen = ("Importado");
              //  }
             //   else
              //  {
             //       objRepuesto.Origen = ("Nacional");
              //  }

              //  string DatosRepuesto = objRepuesto.ObtenerDatosRepuesto();

                //MessageBox.Show(objRepuesto.Codigo + objRepuesto.Nombre + objRepuesto.Marca + objRepuesto.Precio + objRepuesto.Origen, "Repuesto");

               // limpiarcontroles();

            //}

        }

        private void cmbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

