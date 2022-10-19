namespace BinaryTree
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BTNode rootLeftLeft = new(30);
            BTNode rootLeftRight = new(45);
            BTNode rootRightLeft = new(55);
            BTNode rootRightRight = new(70);
            BTNode rootLeft = new(40, rootLeftLeft, rootLeftRight);
            BTNode rootRight = new(60, rootRightLeft, rootRightRight);
            BTNode root = new(50, rootLeft, rootRight);
            BTPrinter.Printer(root);
            BTPrinter.Printer(InvertBinaryTree.InvertedTree(root));
        }
    }
    public class BTNode
    {
        public int Value { get; set; }
        public BTNode? Left { get; set; }
        public BTNode? Right { get; set; }

        public BTNode(int value = 0, BTNode? left = null, BTNode? right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public static class InvertBinaryTree
    {
        public static BTNode InvertedTree(BTNode root)
        {
            if (root == null)
            {
                return null;
            }
            BTNode tempNode = new();
            tempNode = root.Left;
            root.Left = root.Right;
            root.Right = tempNode;
            InvertedTree(root.Left);
            InvertedTree(root.Right);
            return root;
        }
    }

    public static class BTPrinter
    {

        public static void Printer(BTNode root)
        {
            Console.Write(root.Value + ", ");
            if (root.Left != null)
            {
                Printer(root.Left);
            }
            if (root.Right != null)
            {
                Printer(root.Right);
            }
        }
    }
}