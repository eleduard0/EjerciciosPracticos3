using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos3
{
    internal class Metodos
    {
        public void MatrizTresPorTres()
        {
            int[,] enteros = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            ImprimirMatriz(enteros);
        }

        public void MatrizColores()
        {
            string[,] colores = { { "Verde", "Amarillo" }, { "Azul", "Rojo" } };

            ImprimirMatriz(colores);
        }

        public void SumaMatrizDecimal()
        {
            double[,] numerosReales = {
            { 3.6, 2.4, 2.8 },
            { 4.5, 1.7, 3.4 },
            { 9.9, 12.2, 8.1 },
            { 6.8, 14.6, 21.4 }
        };

            ImprimirMatrizConSuma(numerosReales);
        }

        public void MatrizEnTabla()
        {
            char[,] alfabeto = { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' } };

            ImprimirMatriz(alfabeto);
        }

        private void ImprimirMatriz<T>(T[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    Console.Write(matriz[x, y].ToString().PadRight(2).Insert(1,"|"));
                }
                Console.WriteLine();
            }
        }

        private void ImprimirMatrizConSuma(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double suma = 0;

            for (int x = 0; x < filas; x++)
            {
                for (int z = 0; z < columnas; z++)
                {
                    Console.WriteLine("Los valores de los elementos en la matriz bidimensional son:");
                    Console.WriteLine(matriz[x, z]);
                    suma += matriz[x, z];
                }
            }

            Console.WriteLine($"Y la suma de cada elemento de la matriz da un total de: {suma}");
        }
    }

}
