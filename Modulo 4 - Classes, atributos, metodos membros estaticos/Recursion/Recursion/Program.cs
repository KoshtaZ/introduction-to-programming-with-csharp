namespace Recursion
{
    class MyProgram
    {
      
        static void Main(string[] args)
        {
           
            Fatorial fatorial = new Fatorial();
            int n = fatorial.Factorial(3);
            
            Console.WriteLine("Fatorial de 3! = " + n);
        }

      
    }
    
}

