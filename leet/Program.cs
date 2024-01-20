public class Program {
  public static void Main() {
    Console.WriteLine(MaxVowels("abciiidef", 3));
  }

  static int MaxVowels(string s, int k) {
    int max = s[..k].Count("aeiou".Contains);
    int helper = max;
    for(int i = k; i < s.Length; i++) {
      helper += ("aeiou".Contains(s[i])?1:0) - ("aeiou".Contains(s[i - k]) ? 1 : 0);
      max = Math.Max(max, helper);
    }
    return max;
  }
}