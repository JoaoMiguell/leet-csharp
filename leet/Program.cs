public class ListNode {
  public int val;
  public ListNode next;
  public ListNode(int val = 0, ListNode next = null) {
    this.val = val;
    this.next = next;
  }
}

public class Program {
  public static void Main() {
    Console.WriteLine(ContainsDuplicate([1, 2, 3, 1]));
  }

  static bool ContainsDuplicate(int[] nums) {
    List<int> copy = [];
    foreach(int num in nums) {
      if(copy.Contains(num)) return true;
      else copy.Add(num);
    }

    return false;
  }

}
