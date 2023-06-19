using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Integrador
{
    public partial class frmDetalle : Form
    {
        private Articulos articulo = new Articulos();
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle";
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
      
            txtCodigo.Text = articulo.Codigo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtMarca.Text = articulo.Marca.Descripcion;
            txtCategoria.Text=articulo.Categoria.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            cargarImagen(articulo.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbDetalle.Load(imagen);
            }
            catch (Exception)
            {

                pcbDetalle.Load("https://www.shutterstock.com/image-vector/simple-vector-icon-upload-photo-600w-2103160679.jpg");
            }
        }
    }   

}
