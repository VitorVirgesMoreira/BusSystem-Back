using BusSystemWF.Entities.Passageiros;

namespace BusSystemWF.Entities.Viagens
{
    //Vitor Virges Moreira
    public class Viagem
    {
        public string PlacaOnibus { get; set; }
        public string NomeMotorista { get; set; }
        public DateTime Data { get; set; }
        public TimeOnly Hora { get; set; }
        public List<Passageiro> Passageiros { get; set; }
        public virtual int ContagemPassageiros { get; set; }

        public Viagem() { }

        public Viagem(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem)
        {
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            Data = dataViagem;
            Hora = horaViagem;
            Passageiros = new List<Passageiro>();
        }

        public virtual void AddPassageiro(Passageiro passageiro)
        {
            Passageiros.Add(passageiro);
        }

        public virtual float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa()).Sum();
        }
    }
}
