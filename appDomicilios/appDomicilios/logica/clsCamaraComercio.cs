﻿using appDomicilios.accesoDatos;
namespace appDomicilios.logica
{
    class clsCamaraComercio
    {

        /*creo el objeto de la clase Datos que está en la
        capa accesoDatos para comunicarme con esa capa*/
        Datos dt = new Datos();

        public int registrarCamaraComercio(int codigo, string nombre)
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

    }
}
