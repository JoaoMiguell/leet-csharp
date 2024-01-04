public class Program {
  public static void Main() {
    Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
  }

  static int LengthOfLongestSubstring(string s) {
    List<char> res = new();
    int sum = 0;

    foreach (char c in s) {
      if(!res.Contains(c)) res.Add(c);
      else {
        sum = Math.Max(sum, res.Count);
        res.RemoveRange(0, res.IndexOf(c)+1);
        res.Add(c);
      }
    }

    return Math.Max(sum, res.Count);
  }
}
