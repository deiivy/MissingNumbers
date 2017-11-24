using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers
{
    class Program
    {
        // Método principal
        static void Main(string[] args)
        {
            // Declaración de variables
            int n = 0;
            int m = 0;

            try
            {
                // Se captura el valor de N (Cantidad de elementos de la primera lista)
                Console.WriteLine("Ingrese el valor de N (Tamaño de la primera lista)");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("N debe ser un número entero");
                Console.ReadKey();
                return;
            }

            // Se captura la primer lista
            var A = ProcessData.GetList();
            if (A == null) {
                Console.ReadKey();
                return;
            }

            try
            {
                // Se captura el valor de M (Cantidad de elementos de la segunda lista)
                Console.WriteLine("Ingrese el valor de M (Tamaño de la segunda lista)");
                m = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("M debe ser un número entero");
                Console.ReadKey();
                return;
            }

            // Se captura la segunda lista
            var B = ProcessData.GetList();
            if (B == null) return;

            // Se validan los datos ingresados
            string errorMessage = Utulities.ValidateData(n, m, B);
            if (errorMessage != null)
            {
                // Se muestra el error en caso de existir
                Console.WriteLine(errorMessage);
                Console.ReadKey();
                return;
            }

            // Se obtienen los números perdidos
            List<int> missingNumbers = ProcessData.GetMissingNumbers(A, B);

            if (missingNumbers == null || missingNumbers.LongCount() == 0)
            {
                Console.WriteLine("No hay de que preocuparse =), al parecer no se ha perdido ningún número");
                Console.ReadKey();
            }

            // Se agrupan y se muestran los números perdidos accendentemente
            string result = string.Join(" ", missingNumbers
                .Select(data => data));

            Console.WriteLine("Excelente! Hemos podido encontrar los números perdidos: ");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}