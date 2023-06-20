using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Tp_Integrador
{
    public partial class Catalogo : Form
    {
        private List<Articulos> listaArticulos;

        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                cargar();

                cboCampo.Items.Add("Precio");
                cboCampo.Items.Add("Nombre");       
                cboCampo.Items.Add("Descripcíon");
                cboCampo.Items.Add("Código");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            

        }
        private void cargar()
        {
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ocultarColumnas()
        {
           dgvArticulos.Columns["imagenUrl"].Visible = false;
           dgvArticulos.Columns["idMarca"].Visible = false;
           dgvArticulos.Columns["idCategoria"].Visible = false;
           dgvArticulos.Columns["id"].Visible = false;

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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);

            }
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArt alta = new frmAltaArt();
            alta.ShowDialog();
            cargar();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArt alta = new frmAltaArt(seleccionado);
            alta.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            articuloNegocio  negocio = new articuloNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta =  MessageBox.Show("¿desea eliminar el articulo?", "Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)  
        {
            List<Articulos> listaFiltrada;
            string filtro = txtFiltro.Text;
            

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros por favor...");
                    return true;
                }

            }

            return false;
        }

        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                if (validarFiltro()) 
                  return; 

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalle Detalle = new frmDetalle(seleccionado);
            Detalle.ShowDialog();
            cargar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmMarca Marca = new frmMarca();
            Marca.ShowDialog();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();

        }
    }
}
    