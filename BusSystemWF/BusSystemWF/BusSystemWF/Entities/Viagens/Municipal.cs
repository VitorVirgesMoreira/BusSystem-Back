using BusSystemWF.Entities.Passageiros;

namespace BusSystemWF.Entities.Viagens
{
    //Vitor Virges Moreira
    public class Municipal : Viagem
    {
        public override int ContagemPassageiros { get; set; } = 35;

        public Municipal(string placaOnibus, string nomeMotorista, DateTime dataViagem, TimeOnly horaViagem) 
            : base(placaOnibus, nomeMotorista, dataViagem, horaViagem)
        {
        }

        public override void AddPassageiro(Passageiro passageiro)
        {
            if (Passageiros.Count == 35)
            {
                throw new ArgumentException($"Limite máximo de {ContagemPassageiros} passageiros foi atingido.");
            }
            base.AddPassageiro(passageiro);
        }
    }
}
