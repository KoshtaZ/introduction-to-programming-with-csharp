namespace Produto;

public class Produto
{
   public string Nome;
   public double Preco;
   public int Quantidade;


    public double ValorEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProduto(int quantity)
    {
        
    }

    public void RemoverProduto(int quantity)
    {
        
    }

    public override string ToString()
    {
        return Nome + ", $" + Preco + ", " + Quantidade + " unidades, Total: $" + ValorEmEstoque().ToString("0.00");
    }
}