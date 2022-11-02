namespace LeastCommonAncestor
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);
            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(9);
            Console.WriteLine(LowestCommonAncestor(root, root.left.left, root.left.right.right).val);
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode first, TreeNode second)
        {
            TreeNode lowestAncestor = AncestorFinder(root, first, second);
            return lowestAncestor;
        }

        public static TreeNode AncestorFinder(TreeNode root, TreeNode first, TreeNode second)
        {
            TreeNode ancestor = new TreeNode(0);
            if ((first.val <= root.val && second.val >= root.val) || (first.val >= root.val && second.val <= root.val))
            {
                ancestor = root;
                return ancestor;
            }
            else if (root.val >= first.val && root.val >= second.val)
            {
                return AncestorFinder(root.left, first, second);
            }
            else if (root.val <= first.val && root.val <= second.val)
            {
                return AncestorFinder(root.right, first, second);
            }
            return ancestor;
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}