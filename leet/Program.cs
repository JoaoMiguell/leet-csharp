namespace leet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new int[] {-1, 0, 3, 5, 9, 12}, 9));
        }

        public static int Search(int[] nums, int target)
        {
            int result = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                    result = i;
            }

            return result;
        }
    }
}