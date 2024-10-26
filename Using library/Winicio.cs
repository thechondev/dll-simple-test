using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using matrisReposi;
using static matrisReposi.matrix;

//Codigo Carlos Andres Londoño Restrepo
//Libreria Samuel Echeverry Gomez

namespace Using_library
{
    public partial class Winicio : Form
    {
        MatrixLibrary matrixLibrary = new MatrixLibrary(); // Instancia de la librería

        public Winicio()
        {
            InitializeComponent();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int columnas = int.Parse(txtcolumnas.Text);
                int filas = int.Parse(txtfilas.Text);

                int[,] matriz = matrixLibrary.CrearMatriz(columnas, filas);

                dtgvmatriz.Columns.Clear();
                dtgvmatriz.Rows.Clear();

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    dtgvmatriz.Columns.Add("Columna" + j, "Columna " + j);
                }

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    string[] fila = new string[matriz.GetLength(1)];
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        fila[j] = matriz[i, j].ToString();
                    }
                    dtgvmatriz.Rows.Add(fila);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
