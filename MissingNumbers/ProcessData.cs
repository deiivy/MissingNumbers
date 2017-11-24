using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers
{
    class ProcessData
    {
        // Método para capturar las listas de números ingresadas por consola 
        public static List<int> GetList()
        {
            try
            {
                // Se captura la lista de números, se separa los espacios y se convierte a enteros
                String input = Console.ReadLine();
                return Array.ConvertAll(input.Split(' '), int.Parse).ToList();
            }
            catch (Exception e)
            {
                // Se captura exepción al parsear los números a entero
                Console.WriteLine("La lista solo puede contener elementos numéricos");
                return null;
            }
        }

        // Método para encontrar los números perdidos
        public static List<int> GetMissingNumbers(List<int> A, List<int> B)
        {
            List<int> missingNumbers = new List<int>();

            // Se recorre cada elemento de la segunda lista
            foreach (int number in B)
            {
                // Se valida si el número ya se encuentra agregado a la lista de números perdidos
                if (missingNumbers.Contains(number)) continue;

                // Se cuenta cuantas veces está el número en la primer lista
                int frequencyA = A.FindAll(x => x == number).Count();
                // Se cuenta cuantas veces está el número en la segunda lista
                int frequencyB = B.FindAll(x => x == number).Count();

                // Se valida si es un número perdido, teniendo en cuenta que la cantidad en
                // ambas listas sea diferente
                if (frequencyA != frequencyB)
                {
                    // Se agrega el número a la lista
                    missingNumbers.Add(number);
                }
            }

            // Se ordenan los elementos de la lista
            missingNumbers.Sort();

            return missingNumbers;
        }
    }
}