public class Program {
  public static void Main() {
    Console.WriteLine(NumberOfBeams(["011001", "000000", "010100", "001000"]));
  }

  static int NumberOfBeams(string[] bank) {
    int prev = bank[0].Where(l => l != '0').Select(n => int.Parse(n.ToString())).Sum();
    int sum = 0;

    for(int i = 1; i < bank.Length; i++) {
      int cur = bank[i].Where(l => l != '0').Select(n => int.Parse(n.ToString())).Sum();
      if(cur > 0) {
        sum += prev * cur;
        prev = cur;
      }
    }

    return sum;
  }
}
