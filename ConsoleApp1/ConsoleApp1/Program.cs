using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Obtener dimensiones
            var (rows, columns) = GetMatrixDimensions(); //Se revisa el concepto de tuplas para implementar una variable que tome los dos valores

            //Llenar la matriz
            int[,] matrix = FillMatrix(rows, columns);

            //Mostrar la matriz
            ShowMatix(matrix);

            //Mostrar resultados de la suma
            SumCorners(matrix);
        }

        //TODO: Deinir tamaño de la matriz.
        #region
        static (byte rows, byte columns) GetMatrixDimensions()
        {
            byte rows;
            byte columns;

            Console.WriteLine("DEFINA EL TAMAÑO DE LA MATRIZ");

            Console.Write("Cantidad de filas: ");
            rows = byte.Parse(Console.ReadLine()!);

            Console.Write("Cantidad de columnas: ");
            columns = byte.Parse(Console.ReadLine()!);

            return(rows, columns);
        }
        #endregion

        //TODO: Generar números aleatorios para llenar la matriz.
        #region
        static byte GenerateRandomNumber()
        {
            byte randomNumber;

            Random generator = new Random();

            randomNumber = (byte)generator.Next(0, 9); //Se descubre como funciona la conversión automática, explicita y parsing

            return randomNumber;
        }
        #endregion

        //TODO: Llenar la matriz con los datos aleatorios.
        #region
        static int[,] FillMatrix(byte rows, byte columns)
        {
            int[,] userMatrix = new int[rows, columns];

            for (int i = 0; i < userMatrix.GetLength(0); i++) //Se aprende como funciona el GetLenght(x) y los valores del paréntesis
            {
                for (int j = 0; j < userMatrix.GetLength(1); j++)
                {
                    userMatrix[i, j] = GenerateRandomNumber();
                }
            }
            return userMatrix;
        }
        #endregion

        //TODO: Mostrar la matriz generada.
        #region
        static void ShowMatix(int[,] matrix)
        {
            Console.WriteLine("\nMATRIZ GENERADA");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        //TODO: Mostrar el resultado de la suma de las esquinas.
        static void SumCorners(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numColumns = matrix.GetLength(1);

            int topLeft = matrix[0, 0];
            int topRight = matrix[0, numColumns -1];
            int botLeft = matrix[numRows -1, 0];
            int botRight = matrix[numRows -1, numColumns -1];

            int totalSum = topLeft + topRight + botLeft + botRight;

            Console.WriteLine("\nSUMA DE LAS ESQUINAS");
            Console.WriteLine($"Valores: {topLeft} + {topRight} + {botLeft} + {botRight}");
            Console.WriteLine($"La suma de las esquinas es: {totalSum}");
        }
    }
}

/* RESUMEN DE APRENDIZAJE
 * Var:
 * Es una forma en la que C# almacena datos, pero requiere que la variable sea inicializada y asignada
 * ya que toma el tipo de dato que se asigna. Además es importante entender que toma el mismo espacio en memoria
 * que tomaría una variable para la que se le declara su tipo de dato específico.
 * 
 * GetLenght(X):
 * En este caso "GetLenght" obtiene la cantidad de elementos o longitud de una fila o columna.
 * (X) se usa para cambiar entre filas o columnas. Es decir getLenght(0) significa que estamos trabajando en filas
 * y getLenght(1) significa que estamos trabajando en columnas. Además si tuvieramos un cubo con getLenght(2)
 * indicamos que estamos trabajando en capas.
 * 
 * Conversiones:
 * 1. Conversión automática, es cuando se usa un dato pequeño y se convierte automáticamente en uno más grande;
 * como no hay pérdida de datos el sistema asume la responsabilidad de convertirlo sin mayor problema.
 * 
 * 2. Conversión explicita (casting), en este aspecto es cuando se trata de convertir un dato obtenido en una variable a un
 * tipo de dato que requiere menos memoria; en este caso como hay riesgo de pérdida da datos el sistema deja a criterio
 * del programador la implementación del casting la sintaxis es básicamente tomar la variable y anteponerle
 * el tipo de dato al que se pasará encerrado en paréntesis 
 * 
 * Ejemplo:
 * int numeroGrande = 1000000;
 * numeroPequeño = (byte)numeroGrande;
 * 
 * 3. Parsing
 * Es muy útil cuando al capturar datos con Console.ReadLine se requiere trabajar con otros valores diferentes al que
 * obtiene, ya que por defecto retorna siempre strings, entonces el parse convierte los datos obtenidos
 * en otro tipo de datos.
 * 
 */