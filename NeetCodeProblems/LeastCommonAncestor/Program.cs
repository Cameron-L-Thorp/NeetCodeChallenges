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
            Console.WriteLine(AncestorFinder(root, root.left.left, root.left.right.right).val);
        }


        public static TreeNode AncestorFinder(TreeNode root, TreeNode first, TreeNode second)
        {
            
            //if ((first.val <= root.val && second.val >= root.val) || (first.val >= root.val && second.val <= root.val))
            //{
            //    return root;
            //}
            /*else*/ if (root.val >= first.val && root.val >= second.val)
            {
                return AncestorFinder(root.left, first, second);
            }
            else if (root.val <= first.val && root.val <= second.val)
            {
                return AncestorFinder(root.right, first, second);
            }
            return root;
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