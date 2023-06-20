using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Negocio
{
    public class MarcasNegocio
    {
        public List<Marcas> listar() { 

        List<Marcas> lista = new List<Marcas>();
        AccesoDatos datos = new AccesoDatos();
           
        try
            {
                datos.setearConsulta("select id, descripcion from MARCAS");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
        aux.Id = (int) datos.Lector["id"];
        aux.Descripcion = (string) datos.Lector["descripcion"];

        lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

    throw ex;
}
            finally
            {
    datos.cerrarConexion();
}
          
        }
        public void agregarMarca(Marcas nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("insert into Marcas (Descripcion) values (@descripcion)");
            datos.setearParametro("Descripcion", nuevo.Descripcion);
            datos.ejecutarAccion();

            datos.cerrarConexion();


        }
    }
}
