
namespace Produto
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
           
            Console.Write("Preco: ");
            produto.Preco = double.Parse(Console.ReadLine());
           
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados do produto: " + produto);
            
            
            Console.Write("Digite o numero de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qte);
            
            Console.WriteLine("Dados atualizados: " + produto);
            
            Console.Write("Digite o numero de produtos a ser removido: ");
             qte = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qte);
            
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}

