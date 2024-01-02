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
    Console.WriteLine(DeleteDuplicates(new ListNode(1,new ListNode(1, new ListNode(2)))));
  }

  static ListNode DeleteDuplicates(ListNode head) {
    HashSet<int> ints = new();
    while(head != null) {
      if(!ints.Contains(head.val)) ints.Add(head.val);
      head = head.next;
    }

    ListNode res = new();
    ListNode ptrRes = res;
    foreach(int i in ints) {
      res.next = new ListNode(i);
      res = res.next;
    }

    return ptrRes.next;
  }
}
