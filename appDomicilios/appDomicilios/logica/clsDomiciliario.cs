using System.Data;
using appDomicilios.accesoDatos;
namespace appDomicilios.logica
{ 
    class clsDomiciliario
    {

        Datos dt = new Datos();

        public int registrarDomiciliario(int parId, string parNombre, string parApellido, int parAnios, string parEstado)
        {
            int result;
            /*PASO 1: construyo la sentencia sql para insertar*/
            string consulta;
            consulta = "INSERT INTO domiciliario VALUES (" + parId + ", '" + parNombre + "', '" + parApellido + "'," + parAnios + ", '" + parEstado + "')";

            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            result = dt.ejecutarDML(consulta);
            return result;
        }


        public int actualizarDomiciliario(int parId, string parNombre, string parApellido, int parAnios, string parEstado)
        {
           int result;
           string consulta; 
           consulta = "UPDATE domiciliario SET domNombre = '"+parNombre+" ', domApellido = '"+parApellido+"',  domEstado = '"+parEstado+"'," +
            " domaniosexperiencia = "+parAnios+" WHERE domId = "+parId;
           result = dt.ejecutarDML(consulta);
           return result;
        }

           public int eliminarDomiciliario(int parId)
        {
           int result;
           string consulta; 
           consulta = "delete from domiciliario where domId = "+parId;
           result = dt.ejecutarDML(consulta);
           return result;
        }
       

    }
}