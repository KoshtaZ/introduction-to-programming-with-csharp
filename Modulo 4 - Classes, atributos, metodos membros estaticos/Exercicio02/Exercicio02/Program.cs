namespace Exercicio02
{
    class MyProgram
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Dados do primeiro funcionario:");
           Person p1 = new Person();
           Person p2 = new Person();

           Console.WriteLine("Nome: ");
           p1.Name = Console.ReadLine();
           Console.WriteLine("Salary: ");
           p1.salary = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Nome: ");
           p2.Name = Console.ReadLine();
           Console.WriteLine("Salary: ");
           p2.salary = double.Parse(Console.ReadLine());
           
           double media = (p1.salary + p2.salary)/2.0;
           Console.WriteLine("Media : " + media.ToString("F2"));
           
        }
    }
}

