namespace UniversityTask3;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1. Перевернути число");
        Console.WriteLine("2. Видалити слова");
        Console.WriteLine("3. Площа фігури");
        Console.WriteLine("4. Замінити символи");

        Console.Write("Ваш вибір: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Run();
                break;
            case "2":
                Program2.Run();
                break;
            case "3":
                Program3.Run();
                break;
            case "4":
                Program4.Run();
                break;
            default:
                Console.WriteLine("Невірний вибір");
                break;
        }
    }

    public static void Run()
    {
        Console.Write("Введіть ціле число: ");
        long number = long.Parse(Console.ReadLine());

        long result = 0;

        while (number != 0)
        {
            long digit = number % 10;
            result = result * 10 + digit;
            number /= 10;
        }

        Console.WriteLine("Результат: " + result);
    }
}