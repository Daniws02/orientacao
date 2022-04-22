using System;

namespace orientacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa P1 = new Pessoa();
            Pessoa P2 = new Pessoa();
            
            P1.Nome = "Dan";
            P2.Nome = "Den";

            Console.WriteLine(P1.Nome);
            Console.WriteLine(P2.Nome);

        }
    }
    class Pessoa {

        public string Nome;
        public int Idade;
        public int Altura;
        public int Peso;

    }
}
