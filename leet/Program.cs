public class Program {
  public static void Main() {
    var r = FindMatrix([1, 3, 4, 1, 2, 3, 1]);

    foreach(var item in r) {
      foreach(var item1 in item) {
        Console.Write($"{item1} ");
      }
      Console.WriteLine();
    }
  }

  static IList<IList<int>> FindMatrix(int[] nums) {
    List<int> lNums = [.. nums];
    IList<IList<int>> res = new List<IList<int>>();

    while(lNums.Count > 0) {
      List<int> temp = [];
      for(int j = 0; j < lNums.Count; j++) {
        if(!temp.Contains(lNums[j])) {
          temp.Add(lNums[j]);
          lNums.RemoveAt(j);
          j--;
        }
      }
      res.Add(temp);
    }

    return res;
  }
}
