namespace Recursion
{
    class MyProgram
    {
      
        static void Main(string[] args)
        {

            Console.Write("Digite numero: ");
            int num = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Fatorial de = " + num + "! é: " + Fatorial.Factorial(num));
        }

      
    }
    
}

