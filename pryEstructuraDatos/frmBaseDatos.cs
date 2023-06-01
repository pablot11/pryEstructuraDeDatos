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
    public partial class frmBaseDatos : Form
    {
        clsBaseDatos objBD = new clsBaseDatos();
        public frmBaseDatos()
        {
            InitializeComponent();
        }
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TITULO FROM LIBRO";
            objBD.Listar(dgvConsulta, sql);
        }

        private void btnProyeccionMulti_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TITULO, AÑO FROM LIBRO";
            objBD.Listar(dgvConsulta, sql);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LIBRO WHERE IdIdioma = 2";
            objBD.Listar(dgvConsulta, sql);
        }

        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LIBRO WHERE IdIdioma = 2 AND IdAutor > 1";
            objBD.Listar(dgvConsulta, sql);
        }

        private void btnSeleccionConvulsion_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * " +
                "FROM LIBRO " +
                "WHERE IdIdioma = 2 AND IdAutor > 1 union " +
                "SELECT * FROM LIBRO WHERE IdIdioma = 3";
            objBD.Listar(dgvConsulta, sql);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LIBRO WHERE IdAutor =5 " +
                "AND EXISTS " +
                " (SELECT * FROM LIBRO WHERE IdIdioma =3) ";
            objBD.Listar(dgvConsulta, sql);
        }
    }
}
