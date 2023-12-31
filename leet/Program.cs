public class Program {
  public static void Main() {
    Console.WriteLine(PlusOne([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]));
  }

  static int[] PlusOne(int[] digits) {
    for(int i = digits.Length - 1; i >= 0; i--) {
      if(digits[i] < 9) {
        digits[i]++;
        return digits;
      }
      digits[i] = 0;
    }
    int[] res = new int[digits.Length+1];
    res[0] = 1;
    return res;
  }
}
