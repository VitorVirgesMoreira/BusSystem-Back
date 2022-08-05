namespace BusSystemWF.Entities.Passageiros
{
    //Vitor Virges Moreira
    public class Idoso : Passageiro
    {
        public override float Tarifa { get; set; } = 0.0f;
        public string Rg { get; set; }

        public Idoso(string nome, string telefone, int idade, string rg) : base(nome, telefone, idade)
        {
            Rg = rg;
        }

        public override float GetTarifa()
        {
            return Tarifa;
        }
    }
}
