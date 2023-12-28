using System;
using System.Collections.Generic;
using xadrez;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;
using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
              
            }



        }
    }
}
