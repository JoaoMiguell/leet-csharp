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
    Console.WriteLine(IsAnagram("anagram", "nagaram"));
  }

  static bool IsAnagram(string s, string t) {
    char[] sc = [.. s], tc = [.. t];
    Array.Sort(sc);
    Array.Sort(tc);
    return new string(sc) == new string(tc);
  }
}
