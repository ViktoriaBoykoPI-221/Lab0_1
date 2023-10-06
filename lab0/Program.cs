//Из куба с ребром а был выточен шар радиуса (R <= a/2). Вычислить объёмы куба и шара (Vш = 4/3piR^3), а так же процент материала, ушедшего в расходы.
using System;

class Program
{
    static void Main()
    {
        double a, r;

        while (true)
        {
            Console.WriteLine("Введите размер ребра куба в метрах (a):");
            if (double.TryParse(Console.ReadLine(), out a) && a > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: размера ребра куба не может быть отрицательным.");
            }
        }

        while (true)
        {
            Console.WriteLine("Введите радиус шара в метрах (r <= a/2):");
            if (double.TryParse(Console.ReadLine(), out r) && r > 0 && r <= a / 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введите положительное число, которое не превышает половину длины ребра куба.");
            }
        }

        // Вычисление объема куба
        double cubeVolume = Math.Pow(a, 3);

        // Вычисление объема шара
        double sphereVolume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        // Округление результатов до трех знаков после запятой
        cubeVolume = Math.Round(cubeVolume, 3);
        sphereVolume = Math.Round(sphereVolume, 3);

        // Вычисление процента материала, ушедшего в отходы
        double wastePercentage = Math.Round(((cubeVolume - sphereVolume) / cubeVolume) * 100.0, 3);

        Console.WriteLine($"Объем куба: {cubeVolume} м^3");
        Console.WriteLine($"Объем шара: {sphereVolume}м^3");
        Console.WriteLine($"Процент материала, ушедшего в отходы: {wastePercentage}%");
    }
}
