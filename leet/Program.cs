public class Program {
  public static void Main() {
    Console.WriteLine(MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
  }

  static int MaxArea(int[] height) {
    int res = 0, l = 0, r = height.Length - 1;
    while(l < r) {
      int area = (r-l) * Math.Min(height[l], height[r]);
      res = Math.Max(res, area);
      if(height[l] < height[r]) l++;
      else r--;
    }
    return res;
  }
}