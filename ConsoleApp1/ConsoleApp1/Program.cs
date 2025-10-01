using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetMatrixSize();
            Console.WriteLine(GenerateRandomNumber());
        }

        //TODO: Implementar menú para determinar el tamaño de la matriz.
        #region
        static void SetMatrixSize()
        {
            int filas;
            int columnas;

            Console.Write("Número de filas de la matiz: ");
            filas = int.Parse(Console.ReadLine()!);

            Console.Write("Número de columnas de la matriz: ");
            columnas = int.Parse(Console.ReadLine()!);

            FillMatrix(filas, columnas);
        }
        #endregion

        //TODO: Implementar el método para la generación de números aleatorios.
        #region
        static int GenerateRandomNumber()
        {
            int randomNumber;

            Random number = new Random();
            randomNumber = number.Next(0, 9);
            return randomNumber;
        }
        #endregion

        //TODO: Pasar los datos generados a la matriz.
        #region
        static int[,] FillMatrix(int filas, int columnas)
        {
            int[,] userMatrix = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    userMatrix[i, j] = GenerateRandomNumber();
                }
            }
            return userMatrix;
        }
        #endregion

        //TODO: Mostrar el arreglo completo con los datos generados.
        static void ShowMatrix(int[,] matrix)
        {

        }

        //TODO: Realizar el calculo con los datos ubicados en la esquina de la matriz.
    }
}