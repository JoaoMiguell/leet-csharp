public class Program {
  public static void Main() {
    Console.WriteLine(IncreasingTriplet([5, 4, 3, 2, 1]));
  }

  static bool IncreasingTriplet(int[] nums) {
    int val1 = int.MaxValue, val2 = int.MaxValue;
    for(int i = 0; i < nums.Length; i++) {
      if(nums[i] <= val1)
        val1 = nums[i];
      else if(nums[i] <= val2)
        val2 = nums[i];
      else
        return true;
    }
    return false;
  }
}