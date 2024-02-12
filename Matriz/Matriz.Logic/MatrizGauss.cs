using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace Matriz.Logic
{
    public class MatrizGauss
    {
        static void Main()
        {
            // Definir una matriz de coeficientes ampliada (A|B)
            double[,] matriz = {
            {2, 1, -1, 8},
            {-3, -1, 2, -11},
            {-2, 1, 2, -3}
        };

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Imprimir la matriz original
            Console.WriteLine("Matriz Original:");
            ImprimirMatriz(matriz);

            // Convertir la matriz a forma escalonada
            for (int i = 0; i < filas; i++)
            {
                // Pivote actual
                double pivot = matriz[i, i];

                // Hacer el pivote igual a 1
                for (int j = i; j < columnas; j++)
                {
                    matriz[i, j] /= pivot;
                }

                // Hacer ceros en otras filas
                for (int k = 0; k < filas; k++)
                {
                    if (k != i)
                    {
                        double factor = matriz[k, i];
                        for (int j = i; j < columnas; j++)
                        {
                            matriz[k, j] -= factor * matriz[i, j];
                        }
                    }
                }
            }

            // Imprimir la matriz en forma escalonada reducida
            Console.WriteLine("Matriz Escalonada Reducida:");
            ImprimirMatriz(matriz);

            // Imprimir las soluciones
            Console.WriteLine("Soluciones:");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("x{0} = {1}", i + 1, matriz[i, columnas - 1]);
            }
        }

        // Método para imprimir una matriz
        static void ImprimirMatriz(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

