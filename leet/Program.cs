public class Program {
  public static void Main() {
    Console.WriteLine(LongestCommonPrefix(["flower", "flower", "flower", "flower"]));
  }

  static string LongestCommonPrefix(string[] strs) {
    string res = "";

    for(int i = 0; i < strs[0].Length; i++) {
      for(int s = 0; s < strs.Length; s++) {
        if(i == strs[s].Length || strs[s][i] != strs[0][i]) return res;
      }
      res += strs[0][i];
    }

    return res;
  }
}
