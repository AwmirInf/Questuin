class Program
{
    public static void Main()
    {
        var NumberList = (new int[] { -1, 0, 1, 2, -1, -4 });
        var uniqueLists = Solution(NumberList);
        foreach (var list in uniqueLists)
        {
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
    }

    public static List<List<int>> Solution(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        int end = nums.Length;
        for (int i = 0; i < end; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                for (int w = 0; w <= j; w++)
                {
                    if (nums[i] + nums[j] + nums[w] == 0)
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]);
                        temp.Add(nums[w]);
                        result.Add(temp);
                    }
                }
            }
        }
        var uniqueLists = result
            .Select(list => list.OrderBy(x => x).ToList())  // Sort each list
            .Distinct(new ListComparer()) // Remove Duplicates 
            .ToList();
        return uniqueLists;
    }

}
class ListComparer : IEqualityComparer<List<int>>
{
    public bool Equals(List<int> x, List<int> y)
    {
        return x.SequenceEqual(y);  
    }

    public int GetHashCode(List<int> obj)
    {
        return obj.Aggregate(17, (hash, item) => hash * 31 + item.GetHashCode());  // تولید Hash یکتا
    }
}