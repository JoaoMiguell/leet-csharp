public class Program {
  public static void Main() {
    Console.WriteLine(StrStr("sadbutsad", "sad"));
  }

  static int StrStr(string haystack, string needle) {
    return haystack.IndexOf(needle);
  }
}
