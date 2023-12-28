using System;
using System.Collections.Generic;
using System.Linq;
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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 4));

                Tela.ImprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
