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
    Console.WriteLine(LeafSimilar(
      new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(9), new TreeNode(8))),
      new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(9), new TreeNode(8)))
      ));
  }

  static bool LeafSimilar(TreeNode root1, TreeNode root2) {
    List<int> leaf1 = new(), leaf2 = new();
    Dfs(root1, leaf1);
    Dfs(root2, leaf2);
    return leaf1.SequenceEqual(leaf2);
  }

  static void Dfs(TreeNode root, List<int> leaf) {
    if(root == null) return;
    if(root.left == null && root.right == null) {
      leaf.Add(root.val);
      return;
    }
    Dfs(root.left, leaf);
    Dfs(root.right, leaf);
  }
}