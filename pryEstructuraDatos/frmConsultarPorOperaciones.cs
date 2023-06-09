﻿using System;
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
    
    public partial class frmConsultarPorOperaciones : Form
    {
        clsBaseDatos objBD;
        public frmConsultarPorOperaciones()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string varSql = "";
            switch (lstSentencias.SelectedIndex)
            {
                //Diferencia
                case 0:
                    varSql = "SELECT * " +
                        "FROM Libro " +
                        "WHERE IdAutor " +
                        "NOT IN " +
                        "(SELECT IdAutor " +
                        "FROM Libro " +
                        "WHERE IdAutor = 9)";
                    lblSql.Text = "Muestra todos los libros menos los que tiene el ID de autor 9";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Interseccion
                case 1:
                    varSql = "SELECT Titulo " +
                        "FROM Libro WHERE " +
                        "Titulo IN " +
                        "(SELECT Titulo FROM Libro " +
                        "WHERE Cantidad >= 2)";
                    lblSql.Text = @"Muestra los titulos de los libros de los que se repitan en las 2 tablas";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Juntar
                case 2:
                    varSql = varSql = "SELECT Libro.Titulo, Autor.Nombre " +
                        "FROM Libro " +
                        "INNER JOIN Autor " +
                        "ON Libro.IdAutor = Autor.IdAutor";
                    lblSql.Text = "Muestra los titulos de los libros de la tabla Libros con sus respectivos Autores de la tabla Autor";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Proyeccion Simple
                case 3:
                    varSql = varSql = "SELECT Nombre " +
                        "FROM Idioma";
                    lblSql.Text = "Muestra los idiomas que pueden tener los libros";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Proyeccion Multiatributo
                case 4:
                    varSql = varSql = "SELECT Titulo, Año " +
                        "FROM Libro";
                    lblSql.Text = "Muestra los titulos de los libros y sus respectivos años de lanzamiento";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Seleccion MultiAtributo con operador AND
                case 5:
                    varSql = varSql = "SELECT Titulo, Precio " +
                        "FROM Libro " +
                        "WHERE IdPais > 2 " +
                        "AND IdIdioma > 4";
                    lblSql.Text = "Muestra los titulos de los libros y los precios donde el IdPais sea mayor a 2" +
                        "y al mismo tiempo el IdIdioma mayor a 4";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Seleecion MultiAtributo con operador OR
                case 6:
                    varSql = varSql = "SELECT Titulo, Precio " +
                        "FROM Libro " +
                        "WHERE IdPais = 2 " +
                        "OR IdPais = 4";
                    lblSql.Text = "Muestra los titulos de los libros donde el IdPais sea igual a 2 " +
                        "o el idpais sea igual a 4";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Seleccion por Convolucion
                case 7:
                    varSql = varSql = "SELECT * " +
                        "FROM (SELECT Cantidad, Titulo, idIdioma, Precio FROM Libro WHERE Precio < 500) as X " +
                        "WHERE idIdioma = 2";
                    lblSql.Text = "Muestra los libros que cuestan menos de $500 y que estan escritos en ruso";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Seleccion simple
                case 8:
                    varSql = varSql = "SELECT Titulo " +
                        "FROM Libro " +
                        "WHERE IdPais = 2 ";
                    lblSql.Text = "Muestra los titulos de los libros donde el IdPais sea igual a 2 (Ucrania)";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
                //Union
                case 9:
                    varSql = varSql = "SELECT * " +
                        "FROM Libro " +
                        "WHERE Precio > 500 " +
                        "UNION " +
                        "SELECT * FROM Libro Where IdIdioma =2";
                    lblSql.Text = "Muestra todos los campos donde el precio sea mayor a 500 y lo une con aquellos que" +
                        " el idioma sea igual a 2";
                    objBD.Listar(dgvConsulta, varSql);
                    break;
            }
        }

        private void frmConsultarPorOperaciones_Load(object sender, EventArgs e)
        {
            objBD = new clsBaseDatos();
            btnListar.Enabled = false;
        }

        private void lstSentencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSentencias.SelectedIndex != -1)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled=false;
            }
        }
    }
}
