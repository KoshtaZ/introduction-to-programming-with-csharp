namespace Recursion;

public class Fatorial
{
    
    public static int Factorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }
        else
        {
            return numero * Factorial(numero - 1);
        }
    }
}