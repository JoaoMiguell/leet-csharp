public class Program {
  public static void Main() {
    int[] a = [1, 2, 3, 0, 0, 0];
    Merge(a, 3, [2, 5, 6], 3);

    for(int i = 0; i < a.Length; i++) {
      Console.Write(a[i] + " ");
    }
  }

  static void Merge(int[] nums1, int m, int[] nums2, int n) {
    int p = 0;
    for(int i = m; i < m+n; i++) {
      nums1[i] = nums2[p];
      p++;
    }
    Array.Sort(nums1);
  }
}
