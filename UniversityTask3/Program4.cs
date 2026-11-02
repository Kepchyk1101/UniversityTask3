namespace UniversityTask3;

public class Program4
{
    public static void Run()
    {
        Console.Write("Введіть текст: ");
        string input = Console.ReadLine();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            int position = i + 1;

            if (position % 15 == 0)
            {
                result += "?";
            }
            else if (position % 5 == 0)
            {
                result += "9";
            }
            else if (position % 3 == 0)
            {
                result += "X";
            }
            else
            {
                result += input[i];
            }
        }

        Console.WriteLine("Результат: " + result);
    }
}