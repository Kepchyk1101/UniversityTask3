namespace UniversityTask3;

public class Program2
{
    public static void Run()
    {
        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();

        Console.Write("Скільки слів видалити: ");
        int x = int.Parse(Console.ReadLine());

        if (x < 0)
        {
            Console.WriteLine("Невірне число");
            return;
        }

        string[] words = text.Split(
            (char[]?)null,
            StringSplitOptions.RemoveEmptyEntries
        );

        string result = "";

        for (int i = x; i < words.Length; i++)
        {
            result += words[i] + " ";
        }

        Console.WriteLine("Результат: " + result.Trim());
    }
}