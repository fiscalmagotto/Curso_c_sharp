using System;

namespace ProjetoTeste_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Bom dia!" + numero*2);
        }
    }
}
