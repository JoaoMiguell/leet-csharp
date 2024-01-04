public class Program {
  public static void Main() {
    Console.WriteLine(MinOperations([2, 3, 3, 2, 2, 4, 2, 3, 4]));
  }

  static int MinOperations(int[] nums) {
    Dictionary<int, int> map = new();
    foreach(int num in nums) {
      if(map.ContainsKey(num))
        map[num]++;
      else
        map.Add(num, 1);
    }

    int res = 0;
    foreach(var item in map) {
      if(item.Value == 1)
        return -1;
      res += (int)Math.Ceiling((double)item.Key / 3);
    }

    return res;
  }
}
