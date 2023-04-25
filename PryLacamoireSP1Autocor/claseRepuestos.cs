using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryLacamoireSP1Autocor
{
    public class claseRepuestos
    {
        //propiedades
        public string Codigo { get; set; }
        public String Nombre { get; set; }

        public String Marca { get; set; }

        public decimal Precio { get; set; }

        public String Origen { get; set; }

        public List<claseRepuestos> Listado { get; set; }

        //metodos

        public string ObtenerDatosRepuesto()
        {
            return  Codigo +  Nombre +  Marca +  Precio +  Origen;
        }
    }
}
