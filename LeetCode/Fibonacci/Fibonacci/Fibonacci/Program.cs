public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solve_1(5));
    }

    static int Solve_1(int number)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 1; i < number; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;

    }
}