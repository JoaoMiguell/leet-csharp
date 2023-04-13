namespace leet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }

        public static bool IsPalindrome(int x)
        {
            char[] reverse = x.ToString().ToCharArray();
            Array.Reverse(reverse);

            if(new string(reverse) == x.ToString())
                return true;
            else
                return false;
        }
    }
}