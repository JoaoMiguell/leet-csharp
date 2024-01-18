public class Program {
  public static void Main() {
    Console.WriteLine(MaxOperations([1, 2, 3, 4],5));
  }

  static int MaxOperations(int[] nums, int k) {
    int res = 0, l = 0, r = nums.Length-1;
    while(l < r) {
      int sum = nums[l] + nums[r];
      if(sum == k) {
        res++;
        l++;
        r--;
      }
      else if(sum < k)l++;
      else r--;
    }
    return res;
  }
}