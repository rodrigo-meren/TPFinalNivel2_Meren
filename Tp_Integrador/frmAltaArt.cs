using Dominio;
using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Runtime.CompilerServices;

namespace Tp_Integrador
{
    public partial class frmAltaArt : Form

    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArt()
        {
            InitializeComponent();
        }
            public frmAltaArt(Articulos articulo)
            {
                InitializeComponent();
                this.articulo = articulo;
                Text = "Modificar Articulo";
            }

            private void frmAltaArt_Load(object sender, EventArgs e)
            {
                MarcasNegocio marcaNegocio = new MarcasNegocio();
                CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
                try
                {
                    cboMarca.DataSource = marcaNegocio.listar();
                    cboMarca.ValueMember = "Id";
                    cboMarca.DisplayMember = "Descripcion";
                    cboCategoria.DataSource = categoriaNegocio.listar();
                    cboCategoria.ValueMember = "Id";
                    cboCategoria.DisplayMember = "Descripcion";

                    if (articulo != null)
                    {
                        txtCodigo.Text = articulo.Codigo;
                        txtNombre.Text = articulo.Nombre;
                        txtDescripcion.Text = articulo.Descripcion;
                        txtImagenUrl.Text = articulo.ImagenUrl;

                        cboMarca.SelectedValue = articulo.IdMarca;
                        cboCategoria.SelectedValue = articulo.IdCategoria;
                        txtPrecio.Text = articulo.Precio.ToString();
                        cargarImagen(articulo.ImagenUrl);
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            articuloNegocio negocio = new articuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;                
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;                
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");

                }
                if (archivo != null && (!txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Articulos-Img"] + archivo.SafeFileName + articulo.Codigo );


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbArticulos.Load(imagen);
            }
            catch (Exception)
            {

                pcbArticulos.Load("https://www.shutterstock.com/image-vector/simple-vector-icon-upload-photo-600w-2103160679.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName ; 
                cargarImagen(archivo.FileName);
               // File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Articulos-Img"]  + articulo.Codigo + archivo.SafeFileName);

            }
        }

        
       
    }
}
