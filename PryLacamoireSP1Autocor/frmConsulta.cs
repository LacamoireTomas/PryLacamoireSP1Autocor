using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PryLacamoireSP1Autocor
{
    public partial class frmConsulta : Form
    {
        
        public frmConsulta()
        {
            InitializeComponent();
            

        }

        private void Inicializar()
        {
            // carga de los items en el comboBox de Marcas
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;
            
        }
        private string PATH_ARCHIVO;

        public frmConsulta(string Path) // el constructor recibe el nombre del archivo
        {
            InitializeComponent();
            PATH_ARCHIVO = Path;
        }

      

       
        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }
        
        private void Consultar_Click(object sender, EventArgs e)
        {
            // controlar si el archivo existe
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // leer el contenido del archivo
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = PATH_ARCHIVO;
            List<claseRepuestos> repuestos = Repuestos.ObtenerRepuestosOrdenados();
            // limpiar la grilla
            dgvLista.Rows.Clear();
            // recorrer la lista de repuestos
            foreach (claseRepuestos repuesto in repuestos)
            {
                // controlar el valor de la Marca
                if (repuesto.Marca == cmbMarca.SelectedItem.ToString())
                {
                    // controlar el tipo de Origen y los botones de opción activos
                    if (rbImportado.Checked && repuesto.Origen == "Importado")
                    {
                        // agregar el repuesto a la grilla
                        dgvLista.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                        repuesto.Marca, repuesto.Origen,
                        repuesto.Precio.ToString());
                    }
                    else
                    {
                        if (rbNacional.Checked && repuesto.Origen == "Nacional")
                        {
                            // agregar el repuesto a la grilla
                            dgvLista.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                            repuesto.Marca, repuesto.Origen,
                            repuesto.Precio.ToString());
                        }
                        else
                        {
                            if (rbAmbos.Checked)
                            {
                                // agregar el repuesto a la grilla
                                dgvLista.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                                repuesto.Marca, repuesto.Origen,
                                repuesto.Precio.ToString());
                            }
                        }
                    }
                }
            }


        }
        //
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
