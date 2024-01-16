public class Program {
  public static void Main() {
    int[] a = [0, 0, 1];
    MoveZeroes(a);
    Console.WriteLine(string.Join(",", a));
  }

  static void MoveZeroes(int[] nums) {
    int gap = 0;
    for(int i = 0; i < nums.Length - gap; i++) {
      if(nums[i] == 0) {
        for(int j = i; j < nums.Length-1; j++) {
          nums[j] = nums[j + 1];
          nums[j + 1] = 0;
        }
        i--;
        gap++;
      }
    }
  }
}