using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Tp_Integrador
{
    public partial class frmCategoria : Form
    {
        private Categorias categoria = new Categorias();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            try
            {
                categoria.Descripcion = txtCategoria.Text;
                negocio.agregarCategoria(categoria);
                MessageBox.Show("Agregado Exitosamente");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Close();
        }
       
    }
}
