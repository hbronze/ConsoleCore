using GameTop.Interface;
using System;

namespace GameTop
{
    public class JogoF
    {
        public readonly IJogador _jogador1;

        public readonly IJogador _jogador2;

        public JogoF(IJogador jogador1, IJogador jogador2 )
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            Console.Write(_jogador1.Chuta());
            Console.Write(_jogador1.Passe());
            Console.Write(_jogador1.Corre());

            Console.Write("\n Próximo Jogador \n");

            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Passe());
            
        }
        
    }
}