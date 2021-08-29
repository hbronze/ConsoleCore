using GameTop.Interface;

namespace  GameTop.Lib
{
    public class Jogador1 : IJogador
    {

        public readonly string  _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
           _Nome = nome;
        }
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }

        public string Corre()
        {
            return $"{_Nome} esta corendo \n";
        }
        public string Passe()
        {
            return $"{_Nome} esta passando \n";
        }
    }}