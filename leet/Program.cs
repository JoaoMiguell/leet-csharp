public class Program {
  public static void Main() {
    Console.WriteLine(RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));
  }

  static int RemoveDuplicates(int[] nums) {
    List<int> list = nums.Distinct().ToList();
    for(int i = 0; i < list.Count; i++) nums[i] = list[i];
    return list.Count;
  }
}
