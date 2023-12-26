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
    ListNode res = AddTwoNumbers(
          new ListNode(2, new ListNode(4, new ListNode(3))),
          new ListNode(5, new ListNode(6, new ListNode(4)))
        );

    while(res != null) {
      Console.WriteLine(res.val);
      res = res.next;
    }
  }

  static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    ListNode res = new();
    ListNode currPtr = res;

    int leak = 0;
    while(l1 != null || l2 != null || leak != 0) {
      int value1 = l1 == null ? 0 : l1.val;
      int value2 = l2 == null ? 0 : l2.val;

      int valRes = value1 + value2 + leak;
      leak = valRes / 10;
      valRes %= 10;
      currPtr.next = new(valRes);

      currPtr = currPtr.next;
      l1 = l1 == null ? null : l1.next;
      l2 = l2 == null ? null : l2.next;
    }

    return res.next;
  }

}
