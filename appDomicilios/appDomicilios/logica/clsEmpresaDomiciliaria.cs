using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appDomicilios.accesoDatos;

namespace appDomicilios.logica
{
    class clsEmpresaDomiciliaria
    {
        /*creo el objeto de la clase Datos que está en la
        capa accesoDatos para comunicarme con esa capa*/
        Datos dt = new Datos();

        public int registrarEmpresaDomiciliaria(int nit, string nombre, DateTimePicker fecha)
        {
            int result;
            /*PASO 1: construyo la sentencia sql para insertar*/
            string consulta;
            consulta = "INSERT INTO empresaDomiciliaria(empNit, empNombre, empFechaOperando) VALUES (" + nit + ", '" + nombre + ", '" + fecha + "')";

            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            result = dt.ejecutarDML(consulta);
            return result;
        }
    }
}
