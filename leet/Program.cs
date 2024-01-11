public class Program {
  public static void Main() {
    Console.WriteLine(ReverseVowels("hello"));
  }

  static string ReverseVowels(string s) {
    string res = "", comp = "aeiouAEIOU";
    Stack<char> stack = new(s.Where(x => comp.Contains(x)));

    foreach(char c in s) {
      if(comp.Contains(c)) res += stack.Pop();
      else res += c;
    }

    return res;
  }
}