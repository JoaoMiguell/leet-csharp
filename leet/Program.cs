public class Program {
  public static void Main() {
    Console.WriteLine(MySqrt(8));
  }

  static int MySqrt(int x) {
    int left = 0, right = x;
    int res = 0;

    while(left <= right) {
      int mid = left + ((right - left) / 2);
      if(Math.Pow(mid, 2) > x)
        right = mid - 1;
      else if(Math.Pow(mid, 2) < x) {
        left = mid + 1;
        res = mid;
      }
      else
        return mid;
    }
    return res;
  }
}
