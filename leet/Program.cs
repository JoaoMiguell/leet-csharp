public class Program {
  public static void Main() {
    Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));
  }

  static string GcdOfStrings(string str1, string str2) {
    int a = str1.Length, b = str2.Length;
    if(!(str1 + str2).Equals(str2 + str1)) return "";
    while(b != 0) {
      int temp = a % b;
      a = b;
      b = temp;
    }
    return str1[..a];
  }
}