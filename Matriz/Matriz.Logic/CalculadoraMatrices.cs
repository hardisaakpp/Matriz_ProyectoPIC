using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz.Logic
{
    public abstract class CalculadoraMatrices
    {
        public int[,] datos { get; set; }
        public int filas { get; set; }
        public int columnas { get; set; }



        // Constructor que inicializa la matriz de datos
        public CalculadoraMatrices(int filas, int columnas)
        {
            filas = filas;
            columnas = columnas;
            datos = new int[filas, columnas];
        }

        // Método ToString para proporcionar una representación en cadena de la matriz
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Matriz ({filas}x{columnas}):");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    result.Append($"{datos[i, j]}\t");
                }
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
