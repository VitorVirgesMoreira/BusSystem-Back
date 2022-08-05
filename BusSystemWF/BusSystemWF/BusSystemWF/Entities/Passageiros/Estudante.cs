namespace BusSystemWF.Entities.Passageiros
{
    //Vitor Virges Moreira
    public class Estudante : Passageiro
    {
        public override float Tarifa { get; set; } = 3.50f;
        public string Escola { get; set; }

        public Estudante(string nome, string telefone, int idade, string escola) : base(nome, telefone, idade)
        {
            Escola = escola;
        }

        public override float GetTarifa()
        {
            return Tarifa;
        }
    }
}
