public class TreeNode {
  public int val;
  public TreeNode left;
  public TreeNode right;
  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
    this.val = val;
    this.left = left;
    this.right = right;
  }
}

public class Program {
  public static void Main() {
    Console.WriteLine(RangeSumBST(
      new TreeNode(
        10,
        new TreeNode(5, new TreeNode(3), new TreeNode(7)),
        new TreeNode(15, new TreeNode(18))), 7, 15));
  }

  static int RangeSumBST(TreeNode root, int low, int high) {
    if(root == null)
      return 0;
    if(root.val > high)
      return RangeSumBST(root.left, low, high);
    if(root.val < low)
      return RangeSumBST(root.right, low, high);

    return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
  }
}