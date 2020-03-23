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

        public int registrarEmpresaDomiciliaria(int nit, string nombre, DateTimePicker fecha, int camNit)
        {
            

            int result=0;
            /*PASO 1: construyo la sentencia sql para insertar*/
            string consulta;                                                                               
            string a = "('18/04/14')";
            consulta = "INSERT INTO empresaDomiciliaria(empNit, empNombre, empFechaOperando, camnit) VALUES ("+ nit +", '"+nombre+ "', TO_DATE ('18/04/14','DD/MM/RR'),"+ camNit +")";
            //consulta = "INSERT INTO empresaDomiciliaria(empNit, empNombre, empFechaOperando, camnit) VALUES (" + nit+", '" + nombre + ", TO_DATE "+ a +", "+ camnit +")";
            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            result = dt.ejecutarDML(consulta);
            return result;
        }
    }
}
