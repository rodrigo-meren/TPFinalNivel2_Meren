using Dominio;
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


namespace Tp_Integrador
{
    public partial class frmMarca : Form
    {
        private Marcas marca = new Marcas();
        public frmMarca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            try
            {
                marca.Descripcion = txtMaarca.Text;
                negocio.agregarMarca(marca);
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
