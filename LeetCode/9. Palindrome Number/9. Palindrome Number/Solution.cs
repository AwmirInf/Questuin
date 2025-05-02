

namespace _9._Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string input = x.ToString();
            int end = input.Length;
            if (end == 0) return false;

            for (int i = 0; i < end; i++)
            {
                if (input[i] != input[end-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
