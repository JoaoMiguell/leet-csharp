public class Program {
  public static void Main() {
    Console.WriteLine(Compress(['a', 'a', 'a', 'b', 'b', 'a', 'a']));
  }

  static int Compress(char[] chars) {
    int i = 0, res = 0;
    while(i < chars.Length) {
      int sameLength = 1;
      while(i + sameLength < chars.Length && chars[i + sameLength] == chars[i])
        sameLength++;

      chars[res++] = chars[i];
      if(sameLength > 1) {
        foreach(var c in sameLength.ToString())
          chars[res++] = c;
      }

      i += sameLength;
    }

    return res;
  }
}