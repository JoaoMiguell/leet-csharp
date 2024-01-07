public class Program {
  public static void Main() {
    Console.WriteLine(IsSubsequence("ab", "baab"));
  }

  static bool IsSubsequence(string s, string t) {
    int i = 0, j = 0;
    while (i < s.Length && j < t.Length) {
      if(s[i] == t[j]) i++;
      j++;
    }
    return i == s.Length;
  }
}