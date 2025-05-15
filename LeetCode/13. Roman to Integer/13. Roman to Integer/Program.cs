using System.Linq.Expressions;

public class Program
{
    public static void Main(string[] args)
    {
        string romanInt = "MMMCMXCIX";
        romanInt.ToUpper();

        Console.WriteLine(RomanToInt(romanInt));

    }
    public static int RomanToInt(string RomanInt)
    {
        Dictionary<char, int> map = new()
    {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
        {'C', 100}, {'D', 500}, {'M', 1000}
    };

        int sum = 0;
        int prev = 0;
        int end = RomanInt.Length - 1;
        for (int i = end; i >= 0; i--)
        {
            int val = map[RomanInt[i]];
            sum += val < prev ? -val : val;
            prev = val;
        }
        return sum;
    }


}

