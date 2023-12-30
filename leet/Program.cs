public class Program {
  public static void Main() {
    Console.WriteLine(IsValid("]"));
  }

  static bool IsValid(string s) {
    Dictionary<char, char> map = new() { {'}', '{'}, {')', '('}, {']', '['} };
    Stack<char> stack = new();
    foreach(char c in s) {
      if(map.ContainsKey(c) && stack.Count > 0 && map[c] == stack.Peek()) stack.Pop();
      else stack.Push(c);
    }
    return stack.Count == 0;
  }
}
