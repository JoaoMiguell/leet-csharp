public class Program {
  public static void Main() {
    Console.WriteLine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));
  }

  static int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> res = new();
    for(int i = 0; i < nums.Length; i++) {
      int diff = target - nums[i];
      if(res.ContainsKey(diff)) {
        return new int[] { res[diff], i };
      }

      if(res.ContainsKey(nums[i]))
        res[nums[i]] = i;
      else
        res.Add(nums[i], i);
    }

    return null!;
  }
}
