namespace leet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new int[] {2, 7, 11, 15}, 9));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        if(nums[i] + nums[j] == target)
                        {
                            res[0] = i;
                            res[1] = j;
                        }
                    }
                }
            }

            return res;
        }
    }
}