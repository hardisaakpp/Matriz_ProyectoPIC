using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace Matriz.Logic
{
    public class MatrizBase
    {
        private int filas;
        private int columnas;
        private int[,] datos;

        // Constructor para inicializar la matriz
        public MatrizBase(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.datos = new int[filas, columnas];
        }

        // Método público para mostrar la matriz utilizando la matriz de la clase
        public void MostrarMatriz()
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(datos[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Método público para mostrar una matriz específica
        public void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
