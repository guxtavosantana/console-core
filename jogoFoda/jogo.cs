using System;
using jogoFoda.Interface;

namespace jogoFoda
{
    class jogo
    {
        private interfaceJogador jogador1;
        private interfaceJogador jogador2;

        public jogo(interfaceJogador jogador1, interfaceJogador jogador2)
        {
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
        }

        public void iniciarJogo()
        {
            Console.Write(jogador1.Chuta());
            Console.Write(jogador1.Corre());
            Console.Write(jogador1.Passa());

            Console.Write("---------------------\n");

            Console.Write(jogador2.Chuta());
            Console.Write(jogador2.Corre());
            Console.Write(jogador2.Passa());
        }
    }
}