using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmConsultaBaseDatos : Form
    {
        clsBaseDatos objBD;
        public frmConsultaBaseDatos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sql = txtConsultaSql.Text;
            dgvConsulta.Rows.Clear();
            objBD.Listar(dgvConsulta, sql);
        }

        private void frmConsultaBaseDatos_Load(object sender, EventArgs e)
        {
            objBD = new clsBaseDatos();
        }
    }
}
