public class Program {
  public static void Main() {
    Console.WriteLine(RemoveElement([3, 2, 2, 3], 3));
  }

  static int RemoveElement(int[] nums, int val) {
    List<int> list = nums.Where(num => num != val).ToList();
    for(int i = 0; i < list.Count; i++) nums[i] = list[i];
    return list.Count;
  }
}
