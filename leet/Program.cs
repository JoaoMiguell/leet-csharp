public class Program {
  public static void Main() {
    Console.WriteLine(LengthOfLIS([0, 1, 0, 3, 2, 3]));
  }

  static int LengthOfLIS(int[] nums) {
    int[] ints = new int[nums.Length];
    Array.Fill(ints, 1);

    for(int i = nums.Length - 1;  i >= 0; i--) {
      for(int j = i+1; j < nums.Length; j++) {
        if(nums[i] < nums[j]) ints[i] = Math.Max(ints[i], 1 + ints[j]);
      }
    }

    return ints.Max();
  }
}
