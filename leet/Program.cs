public class Program {
  public static void Main() {
    Console.WriteLine(SearchInsert([-1, 3, 5, 6], 0));
  }

  static int SearchInsert(int[] nums, int target) {
    if(target == 0 && nums[0] > 0) return 0;
    if(target < nums[0]) return 0;
    for(int i = 0; i < nums.Length; i++) {
      int diff = target - nums[i];
      if(diff == 0) return i;
      if(diff == 1) return i + 1;
      if(diff ==-1) return i;
    }

    return nums.Length;
  }
}
