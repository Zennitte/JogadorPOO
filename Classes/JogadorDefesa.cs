namespace Jogador_Exercicio.Classes
{
    public class JogadorDefesa : Jogador
    {
        public override int Aposentar()
        {
            int idadeAposentar = 40 - CalcularIdade();
            return idadeAposentar;
        }
    }
}