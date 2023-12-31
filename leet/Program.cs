public class Program {
  public static void Main() {
    Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
  }

  static int LengthOfLastWord(string s) {
    string[] words = s.Trim().Split(' ');
    return words[words.Length-1].Length;
  }
}
