public class Program {
  public static void Main() {
    Console.WriteLine(ReverseWords("a good   example"));
  }

  static string ReverseWords(string s) {
    return string.Join(" ", s.Trim().Split(' ').Where(s => s != "").ToArray().Reverse()); 
  }
}