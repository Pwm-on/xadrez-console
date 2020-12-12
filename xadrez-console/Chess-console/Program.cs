using System;
using Chess_console.Board;

namespace Chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);
            Console.WriteLine("Posicao" + p);
        }
    }
}
