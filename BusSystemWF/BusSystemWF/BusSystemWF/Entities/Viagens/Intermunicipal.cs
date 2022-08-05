using BusSystemWF.Entities.Passageiros;

namespace BusSystemWF.Entities.Viagens
{
    //Vitor Virges Moreira
    public class Intermunicipal : Viagem
    {
        public override int ContagemPassageiros { get; set; } = 28;

        public Intermunicipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem)
            : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        {
        }

        public override void AddPassageiro(Passageiro passageiro)
        {
            if (Passageiros.Count == 28)
            {
                throw new ArgumentException($"Limite máximo de {ContagemPassageiros} passageiros foi atingido.");
            }

            base.AddPassageiro(passageiro);
        }

        public override float GetValorTotal()
        {
            return Passageiros.Select(x => x.GetTarifa() + 3.95f).Sum();
        }
    }
}
