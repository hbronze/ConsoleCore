using GameTop.Lib;
using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo  = new JogoF
            (
                new Jogador1(),
                new Jogador2()
            );

            jogo.IniciarJogo();
        }
   
    }



}
