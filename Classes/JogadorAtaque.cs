namespace Jogador_Exercicio.Classes
{
    public class JogadorAtaque : Jogador
    {
        public int Aposentar()
        {
            int idadeAposentar = 35 - CalcularIdade();
            return idadeAposentar;
        }
    }
}