public class Program {
  public static void Main() {
    var res = KidsWithCandies([2, 3, 5, 1, 3], 3);
    foreach(var item in res)
      Console.WriteLine(item);
  }

  static IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    bool[] res = new bool[candies.Length];
    for(int i = 0; i < candies.Length; i++)
      if(candies[i] + extraCandies >= candies.Max()) res[i] = true;
    return res;
  }
}