using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}

