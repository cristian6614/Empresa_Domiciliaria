using appDomicilios.accesoDatos;
using System.Data;

namespace appDomicilios.logica
{
    class clsCamaraComercio
    {
        private int codigo;
        private string nombre;
        /*creo el objeto de la clase Datos que está en la
        capa accesoDatos para comunicarme con esa capa*/
        Datos dt = new Datos();
        public clsCamaraComercio()
        {        }
        public clsCamaraComercio(int codigo, string nombre) {
            this.nombre = nombre;
            this.codigo = codigo;
        }
        public int registrarCamaraComercio()
        {
            
            int result;
            /*PASO 1: construyo la sentencia sql para insertar*/
            string consulta;
            consulta = "INSERT INTO camaraComercio(camId, camNombre) VALUES ("+codigo+", '"+nombre+"')";

            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            result = dt.ejecutarDML(consulta);
            return result;

        }

        public DataSet consultarRegistros()
        {
            /*paso 0: creo un dataset vacio*/
            DataSet miDS = new DataSet();
            /*PASO 1: construyo la sentencia sql para consultar
             todos los datos*/
            string consulta;
            consulta = "select camId, camnombre from camaracomercio";
            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public void setcodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getcodigo() {
            return codigo;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getnombre()
        {
            return nombre;
        }

    }
}
