public class Program {
  public static void Main() {
    Console.WriteLine(FindMaxAverage([1, 12, -5, -6, 50, 3], 4));
  }

  static double FindMaxAverage(int[] nums, int k) {
    //double sum = (double)nums.Take(k).Sum();
    //int skip = 1;
    //for(int i = k; i < nums.Length; i++) {
    //  double temp = (double)nums.Skip(skip).Take(k).Sum();
    //  sum = Math.Max(sum, temp);
    //  skip++;
    //}
    //return sum/k;
    double sum = 0;
    for(int i = 0; i < k; i++) sum += nums[i];
    double curr = sum;
    for(int i = k; i < nums.Length; i++) {
      curr += nums[i] - nums[i - k];
      sum = Math.Max(sum, curr);
    }
    return sum/k;
  }
}