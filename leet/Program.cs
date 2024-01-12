public class Program {
  public static void Main() {
    Console.WriteLine(string.Join(",", ProductExceptSelf([1, 2, 3, 4])));
  }

  static int[] ProductExceptSelf(int[] nums) {
    List<int> res = [];
    int carry = 1;
    for(int i = 0; i < nums.Length; i++) {
      res.Add(carry);
      carry *= nums[i];
    }
    carry = 1;
    for(int i = nums.Length - 1; i >= 0; i--) {
      res[i] *= carry;
      carry *= nums[i];
    }
    return [.. res];
  }
}