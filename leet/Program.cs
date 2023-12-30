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
    ListNode res = MergeTwoLists(
      new ListNode(1, new ListNode(2, new ListNode(4))),
      new ListNode(1, new ListNode(3, new ListNode(4)))
    );
    while(res != null) {
      Console.WriteLine(res.val);
      res = res.next;
    }
  }

  static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    if(list1 == null) return list2;
    if(list2 == null) return list1;

    List<int> values = [];
    while(list1 != null) {
      values.Add(list1.val);
      list1 = list1.next;
    }
    while(list2 != null) {
      values.Add(list2.val);
      list2 = list2.next;
    }

    values.Sort();

    ListNode result = new(values[0]);
    ListNode ptr = result;
    for(int i = 1; i < values.Count; i++) {
      ptr.next = new(values[i]);
      ptr = ptr.next;
    }
    return result;
  }
}
