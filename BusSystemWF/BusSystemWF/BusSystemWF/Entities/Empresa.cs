using BusSystemWF.Entities.Passageiros;
using BusSystemWF.Entities.Viagens;

namespace BusSystemWF.Entities
{
    //Vitor Virges Moreira
    public class Empresa
    {
        public List<Viagem> Viagens { get; set; } = new List<Viagem>();

        public Empresa() { }

        public virtual List<Passageiro> GetPassageirosMaisVelho()
        {
            return Viagens.SelectMany(x => x.Passageiros.Where(x => x.Idade >= 60)).OrderBy(x => x.Nome).ToList();
        }

        public virtual void AddViagens(Viagem viagem)
        {
            Viagens.Add(viagem);
        }
    }
}
