using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsBaseDatos
    {
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        //Establece conexion
        private OleDbConnection conexion = new OleDbConnection();
        //Ordena comandos
        private OleDbCommand comando = new OleDbCommand();
        //Adapta los datos
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Libro");
                Grilla.DataSource = null;
                Grilla.DataSource = ds.Tables["Libro"];
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
        public void Listar(DataGridView Grilla, string varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Resultado");
                Grilla.DataSource = null;
                Grilla.DataSource = ds.Tables["Resultado"];
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conexion.Close();
            }










        }



    }

  


}
