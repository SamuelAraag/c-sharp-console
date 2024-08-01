namespace Estudo.Console.BuscaBinaria
{
    public class BuscaArvoreBinaria
    {
        private Node root;

        public BuscaArvoreBinaria()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }

        public bool Search(int value)
        {
            return SearchRec(root, value);
        }

        private bool SearchRec(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.Value == value)
                return true;

            else if (value < root.Value)
                return SearchRec(root.Left, value);
            else
                return SearchRec(root.Right, value);
        }
    }
}
