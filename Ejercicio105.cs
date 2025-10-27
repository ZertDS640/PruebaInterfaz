using System;

class Ejercicio105
{
    static void Main()
    {
        string[] dias = { "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };

        while (true)
        {
            double[] ventas = new double[6];
            string entrada = Console.ReadLine();

            if (entrada == null || entrada.Trim() == "") continue;

            ventas[0] = double.Parse(entrada, CultureInfo.InvariantCulture);
            if (ventas[0] == -1) break;

            for (int i = 1; i < 6; i++)
            {
                ventas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Buscar máximo y mínimo
            double max = ventas[0], min = ventas[0];
            int maxIndex = 0, minIndex = 0;
            bool empateMax = false, empateMin = false;

            for (int i = 1; i < 6; i++)
            {
                if (ventas[i] > max)
                {
                    max = ventas[i];
                    maxIndex = i;
                    empateMax = false;
                }
                else if (ventas[i] == max)
                {
                    empateMax = true;
                }

                if (ventas[i] < min)
                {
                    min = ventas[i];
                    minIndex = i;
                    empateMin = false;
                }
                else if (ventas[i] == min)
                {
                    empateMin = true;
                }
            }

            // Calcular media
            double suma = 0;
            for (int i = 0; i < 6; i++) suma += ventas[i];
            double media = suma / 6;

            string resultadoMax = empateMax ? "EMPATE" : dias[maxIndex];
            string resultadoMin = empateMin ? "EMPATE" : dias[minIndex];
            string domingoVsMedia = ventas[5] > media ? "SI" : "NO";

            Console.WriteLine($"{resultadoMax} {resultadoMin} {domingoVsMedia}");
        }
    }
}
