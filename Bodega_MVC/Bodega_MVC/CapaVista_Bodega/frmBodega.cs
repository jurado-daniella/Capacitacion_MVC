using CapaControlador_Bodega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Bodega
{
    public partial class frmBodega : Form
    {
        string nombreTabla = "bodega";
        Controlador controlador = new Controlador ();
        public frmBodega()
        {
            
            InitializeComponent();
        }

        public void actualizarDataGridView()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            ConsultaTabla.DataSource = dtVista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }
    }
}
