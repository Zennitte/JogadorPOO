namespace Jogador_Exercicio.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        public int Aposentar()
        {
            int idadeAposentar = 38 - CalcularIdade();
            return idadeAposentar;
        }
    }
}