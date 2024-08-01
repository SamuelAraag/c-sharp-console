
namespace Estudo.Console.BuscaBinaria
{
    public class BuscaArvoreBinaria
    {
        private Node? root = null;

        public void Inserir(int valor)
        {
            InserirRecursivo(root, valor);
        }

        private static Node InserirRecursivo(Node? no, int valor)
        {
            no ??= new Node(valor);

            return valor < no.Value
                ? InserirRecursivo(no.Left, valor)
                : InserirRecursivo(no.Right, valor);
        }

        public bool Buscar(int valor)
        {
            return BuscarRecursivo(root, valor);
        }

        private static bool BuscarRecursivo(Node? root, int valor)
        {
            if (root is null) return false;

            if (valor == root.Value) return true;

            if (valor < root.Value)
                return BuscarRecursivo(root.Left, valor);
            else
                return BuscarRecursivo(root.Right, valor);
        }
    }
}
