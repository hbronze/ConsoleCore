using GameTop.Interface;

namespace  GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
          return "Maradona estas pateando \n";  
        }

        public string Corre()
        {
          return "Maradona estas corriend \n";  
        }

        public string Passe()
        {
            return "Maradona estas pasando \n";
        }
    }
}