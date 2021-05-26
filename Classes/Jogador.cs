using System;

namespace Jogador_Exercicio.Classes
{
    public abstract class Jogador
    {
        public string Nome
        {
            get; set;
        }
        public int DataNasc
        {
            get; set;
        }
        public string Nacionalidade
        {
            get; set;
        }
        public string Altura
        {
            get; set;
        }
        public string Peso
        {
            get; set;
        }

        public int CalcularIdade()
        {
            int idade = DateTime.Now.Year - DataNasc;

            return idade;
        }        
    }
}