public class Program {
  public static void Main() {
    Console.WriteLine(MergeAlternately("abc", "pqr"));
  }

  static string MergeAlternately(string word1, string word2) {
    int i = 0, j = 0;
    string res = "";

    while(i < word1.Length || j < word2.Length) {
      res = i < word1.Length ? res + word1[i] : res;
      res = j < word2.Length ? res + word2[j] : res;
      i++; j++;
    }

    return res;
  }
}