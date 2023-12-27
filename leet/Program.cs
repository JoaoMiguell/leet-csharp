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
    Console.WriteLine(IsPalindrome(10));
  }

  static bool IsPalindrome(int x) {
    int iNum = 0;
    int cX = x;
    while(cX > 0) {
      iNum = (iNum*10) + (cX % 10);
      cX /= 10;
    }
    return x == iNum;
  }
}
