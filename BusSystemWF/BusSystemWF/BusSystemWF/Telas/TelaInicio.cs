using BusSystemWF.Entities;
using BusSystemWF.Entities.Viagens;

namespace BusSystemWF
{
    //Vitor Virges Moreira
    public partial class TelaInicio : Form
    {
        private Empresa _empresa;
        private Viagem viagem;

        public TelaInicio()
        {
            _empresa = new Empresa();
            InitializeComponent();
        }

        private void btnCadViagem_Click(object sender, EventArgs e)
        {
            new CadastrarViagem(_empresa).Show();
        }

        private void btnCadPassageiro_Click(object sender, EventArgs e)
        {
            if (cmbBoxViagens.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma viagem para cadastrar um passageiro.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new CadastrarPassageiro(viagem).Show();
        }

        private void btnInfoViagens_Click(object sender, EventArgs e)
        {
            new InfoViagens(_empresa).Show();
        }

        private void cmbBoxViagens_MouseClick(object sender, MouseEventArgs e)
        {
            cmbBoxViagens.Items.Clear();
            cmbBoxViagens.Items.AddRange(ListarViagens(_empresa.Viagens));
        }

        private object[] ListarViagens(List<Viagem> listaViagens)
        {
            object[] items = new object[listaViagens.Count];
            var i = listaViagens.Count - 1;
            foreach (Viagem item in listaViagens)
            {
                items[i] = new string(item.PlacaOnibus.ToString());
                i--;
            }
            return items;
        }

        private void cmbBoxViagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_empresa.Viagens.Count != 0)
            {
                viagem = _empresa.Viagens.First(x => x.PlacaOnibus == cmbBoxViagens.SelectedItem.ToString());
            }
        }
    }
}
