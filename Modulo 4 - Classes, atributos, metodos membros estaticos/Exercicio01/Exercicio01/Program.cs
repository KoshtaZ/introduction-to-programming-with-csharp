namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person x, y;
            x = new Person();
            y = new Person();
            
            Console.WriteLine("Enter data first person: ");
            
            x.Name = Console.ReadLine();
            x.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter data second person: ");
            y.Name = Console.ReadLine();
            y.Age = int.Parse(Console.ReadLine());
            
            if(x.Age > y.Age)
            {
                Console.WriteLine("Pessoa mais velha: {0}", x.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", y.Name);
            }
        }
    }
}