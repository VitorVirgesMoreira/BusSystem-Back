namespace BusSystemWF.Entities.Passageiros
{
    //Vitor Virges Moreira
    public class Passageiro
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public virtual float Tarifa { get; set; } = 6.0f;

        public Passageiro(string nome, string telefone, int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
        }

        public virtual float GetTarifa()
        {
            return Tarifa;
        }
    }
}
