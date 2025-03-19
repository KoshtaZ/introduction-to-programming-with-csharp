
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
        }
    }
}

