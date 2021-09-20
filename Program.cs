using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b2, soma;
            
            Console.WriteLine("Seja bem vindo");
    

            Console.WriteLine("Digite um numero:  ");
            a1 = int.Parse(Console.ReadLine());  

             Console.WriteLine("Digite um numero:  ");
            b2 = int.Parse(Console.ReadLine());

             soma = a1 + b2;

             Console.WriteLine(" Soma:" +soma);  

            Console.ReadKey();     
        }
    }
}
