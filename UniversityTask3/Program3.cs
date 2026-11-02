using System.Globalization;

namespace UniversityTask3;

public class Program3
{
    public static void Run()
    {
        Console.WriteLine("Оберіть фігуру:");
        Console.WriteLine("1. Квадрат");
        Console.WriteLine("2. Круг");
        Console.WriteLine("3. Прямокутник");
        Console.WriteLine("4. Трикутник");

        Console.Write("Ваш вибір: ");
        int choice = int.Parse(Console.ReadLine());

        double area;

        switch (choice)
        {
            case 1:
                double side = ReadNumber("Введіть сторону: ");
                area = side * side;
                break;

            case 2:
                double radius = ReadNumber("Введіть радіус: ");
                area = Math.PI * radius * radius;
                break;

            case 3:
                double a = ReadNumber("Перша сторона: ");
                double b = ReadNumber("Друга сторона: ");
                area = a * b;
                break;

            case 4:
                double basis = ReadNumber("Введіть основу: ");
                double height = ReadNumber("Введіть висоту: ");
                area = basis * height / 2;
                break;

            default:
                Console.WriteLine("Невірний вибір");
                return;
        }

        Console.WriteLine("Площа: " + area);
    }

    static double ReadNumber(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine().Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out double number)
                && number > 0 && double.IsFinite(number))
            {
                return number;
            }

            Console.WriteLine("Введіть додатне число!");
        }
    }
}