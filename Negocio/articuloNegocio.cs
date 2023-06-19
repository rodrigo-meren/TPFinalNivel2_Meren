using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Dominio;
using System.Xml.Linq;

namespace Negocio
{
    public class articuloNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.id, codigo, nombre, a.descripcion,imagenUrl, m.descripcion marca, c.Descripcion categoria, precio, c.Id Idcategoria, m.Id Idmarca from articulos a , marcas m, categorias c where m.id = a.idmarca and c.id = a.idCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["id"];
                    aux.Codigo = (string)lector["codigo"];
                    aux.Nombre = (string)lector["nombre"];
                    aux.Descripcion = (string)lector["descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["precio"];
                    aux.Marca = new Marcas();
                    aux.IdMarca = (int)lector["idMarca"];
                    aux.Marca.Descripcion = (string)lector["marca"];
                    aux.Categoria = new Categorias();
                    aux.IdCategoria = (int)lector["idCategoria"];
                    aux.Categoria.Descripcion = (string)lector["categoria"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, ImagenUrl, IdMarca, IdCategoria,Precio ) values(@Codigo,@Nombre,@Descripcion, @Imagenurl, @IdMarca,@IdCategoria,@Precio)");
                datos.setearParametro("Codigo", nuevo.Codigo);
                datos.setearParametro("Nombre", nuevo.Nombre);
                datos.setearParametro("Descripcion", nuevo.Descripcion);
                datos.setearParametro("ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("IdMarca", nuevo.Marca.Id);
                datos.setearParametro("IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("Precio", nuevo.Precio);

                datos.ejecutarAccion();


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
        public void modificar(Articulos Articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Imagenurl = @ImagenUrl, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id ");
            datos.setearParametro("Codigo", Articulo.Codigo);
            datos.setearParametro("Nombre", Articulo.Nombre);
            datos.setearParametro("Descripcion", Articulo.Descripcion);
            datos.setearParametro("ImagenUrl", Articulo.ImagenUrl);
            datos.setearParametro("IdMarca", Articulo.Marca.Id);
            datos.setearParametro("IdCategoria", Articulo.Categoria.Id);
            datos.setearParametro("Precio", Articulo.Precio);
            datos.setearParametro("Id", Articulo.Id);

            datos.ejecutarAccion();

        }
        public void eliminarFisico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete Articulos where Id = @id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select a.id, codigo, nombre, a.descripcion,imagenUrl, m.descripcion marca, c.Descripcion categoria, precio, c.Id Idcategoria, m.Id Idmarca from articulos a , marcas m, categorias c where m.id = a.idmarca and c.id = a.idCategoria And ";
                switch (campo)
                {
                    case "Precio":
                        {
                            switch (criterio)
                            {
                                case "Mayor a":
                                    consulta += "Precio > " + filtro;
                                    break;
                                case "Menor a":
                                    consulta += "Precio < " + filtro;
                                    break;
                                default:
                                    consulta += "Precio = " + filtro;
                                    break;
                            }

                        }
                        break;
                
                    case"Nombre":
                        {
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += "Nombre like '" + filtro + "%' ";
                                    break;
                                case "Termina con":
                                    consulta += "Nombre like '%" + filtro + "'";
                                    break;
                                default:
                                    consulta += "Nombre like '%" + filtro + "%'";
                                    break;
                            }
                        }
                        break;
                    case "Descripcíon":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "a.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "a.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "a.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Código":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "a.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "a.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "a.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                        

                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                
                while(datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["precio"];
                    aux.Marca = new Marcas();
                    aux.IdMarca = (int)datos.Lector["idMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["marca"];
                    aux.Categoria = new Categorias();
                    aux.IdCategoria = (int)datos.Lector["idCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["categoria"];

                    lista.Add(aux);
                }

                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }   



    }
            
}
