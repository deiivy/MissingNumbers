using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers
{
    class Utulities
    {
        private readonly static int LIMIT = 100;
        private readonly static int MULTIPLIER = 2;
        private readonly static int BASE = 5;
        private readonly static int EXPONENT = 10;

        // Método para validar las condiciones de los datos de entrada
        public static String ValidateData(int n, int m, List<int> B)
        {
            string errorMessage = "";

            // Se valida el tamaño ingresado para la primer lista
            if (n <= 1)
            {
                errorMessage = "N Debe ser mayor a 1";
                return errorMessage;
            }

            // Se valida el tamaño ingresado para la segunda lista
            Double limit = Math.Pow(BASE, EXPONENT);
            if (m > MULTIPLIER * limit)
            {
                errorMessage = "M Debe ser menor a " + limit;
                return errorMessage;
            }

            // Se valida que la cantidad de elementos de la primer lista no sea mayor a 
            // la cantidad de elementos de la segunda lista
            if (n > m)
            {
                errorMessage = "El valor de N no puede ser mayor a el valor de M";
                return errorMessage;
            }

            // Se valida el valor de la resta entre el máximo y el mínimo componente de la segunda lista
            if (B.Max() - B.Min() > LIMIT)
            {
                errorMessage = "La diferencia entre el número máximo y mínimo en B debe ser menor o igual a " + LIMIT;
                return errorMessage;
            }

            return null;
        }
    }
}