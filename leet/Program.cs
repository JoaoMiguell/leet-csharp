public class Program {
  public static void Main() {
    Console.WriteLine(DivideArray([1, 3, 4, 8, 7, 9, 3, 5, 1], 2));
  }

  static int[][] DivideArray(int[] nums, int k) {
    Array.Sort(nums);
    List<int[]> res = [];

    for(int i = 0; i < nums.Length; i += 3) {
      if(nums[i + 2] - nums[i] > k) return [];
      res.Add(nums[i..(i + 3)]);
    }

    return [.. res];
  }
}