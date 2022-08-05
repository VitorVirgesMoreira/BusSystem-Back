using BusSystemWF.Entities;
using BusSystemWF.Entities.Passageiros;
using BusSystemWF.Entities.Viagens;
using System.Globalization;
using System.Text;

namespace BusSystemWF
{
    //Vitor Virges Moreira
    public partial class InfoViagens : Form
    {
        private readonly Empresa _empresa;
        private Viagem _viagem;
        private List<Passageiro> listCsv;

        public InfoViagens(Empresa empresa)
        {
            _empresa = empresa;
            _viagem = new Viagem();
            listCsv = new List<Passageiro>();
            InitializeComponent();
        }

        private void AtualizarCsv(Passageiro passageiro)
        {
            listCsv.Clear();
            listCsv.Add(passageiro);
        }

        private void AtualizarDados()
        {
            try
            {
                lblPreco.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", _viagem.GetValorTotal());
                lblOciosas.Visible = true;
                lblOciosas.Text = (_viagem.ContagemPassageiros - _viagem.Passageiros.Count).ToString();

                ListViewCSV.Items.Clear();
                cbxPlaca.SelectedItem = null;
                cbxData.SelectedItem = null;
                cbxHora.SelectedItem = null;

                var passageirosOrdenados = _viagem.Passageiros.OrderBy(x => x.Nome);
                foreach (var passageiro in passageirosOrdenados)
                {
                    var item = new ListViewItem(passageiro.Nome);
                    item.SubItems.Add(passageiro.Idade.ToString());
                    item.SubItems.Add(passageiro.Telefone.ToString());
                    item.SubItems.Add($"R${passageiro.GetTarifa()}");
                    ListViewCSV.Items.Add(item);
                    AtualizarCsv(passageiro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxPlaca.SelectedItem != null)
                _viagem = _empresa.Viagens.Where(x => x.PlacaOnibus == cbxPlaca.SelectedItem.ToString()).First();
            if (cbxData.SelectedItem != null)
                _viagem = _empresa.Viagens.Where(x => x.Data.ToString() == cbxData.SelectedItem.ToString()).First();
            if (cbxHora.SelectedItem != null)
                _viagem = _empresa.Viagens.Where(x => x.Hora.ToString() == cbxHora.SelectedItem.ToString()).First();

            AtualizarDados();
        }

        private void cbxPlaca_MouseClick(object sender, MouseEventArgs e)
        {
            cbxPlaca.Items.Clear();
            object[] items = new object[_empresa.Viagens.Count];
            var i = _empresa.Viagens.Count - 1;
            foreach (Viagem item in _empresa.Viagens)
            {
                items[i] = new string(item.PlacaOnibus.ToString());
                i--;
            }
            cbxPlaca.Items.AddRange(items);
        }

        private void cbxData_MouseClick(object sender, MouseEventArgs e)
        {
            cbxData.Items.Clear();
            object[] items = new object[_empresa.Viagens.Count];
            var i = _empresa.Viagens.Count - 1;
            foreach (Viagem item in _empresa.Viagens)
            {
                items[i] = new string(item.Data.ToString());
                i--;
            }
            cbxData.Items.AddRange(items);
        }

        private void cbxHora_MouseClick(object sender, MouseEventArgs e)
        {
            cbxHora.Items.Clear();
            object[] items = new object[_empresa.Viagens.Count];
            var i = _empresa.Viagens.Count - 1;
            foreach (Viagem item in _empresa.Viagens)
            {
                items[i] = new string(item.Hora.ToString());
                i--;
            }
            cbxHora.Items.AddRange(items);
        }

        private async void btnExportarCsv_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV| *.csv", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine($"{_viagem.Data.ToString("d") ?? string.Empty};{_viagem.Hora.ToString() ?? string.Empty};{_viagem.PlacaOnibus};{_viagem.NomeMotorista};");
                            foreach (var item in listCsv)
                            {
                                sb.AppendLine(string.Format($"{item.GetType().Name.Substring(0, 1)};{item.Nome};{item.Telefone};{item.Idade};"));
                            }
                            await sw.WriteLineAsync(sb.ToString());
                            MessageBox.Show("Arquivo salvo com sucesso", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarMaisVelhos_Click(object sender, EventArgs e)
        {
            ListViewCSV.Items.Clear();
            lblPreco.Text = "R$ 00,00";
            lblOciosas.Visible = false;

            var todosPassageirosMaisVelhos = _empresa.GetPassageirosMaisVelho();
            foreach (var passageiro in todosPassageirosMaisVelhos)
            {
                var item = new ListViewItem(passageiro.Nome);
                item.SubItems.Add(passageiro.Idade.ToString());
                item.SubItems.Add(passageiro.Telefone.ToString());
                item.SubItems.Add($"R${passageiro.GetTarifa()}");
                ListViewCSV.Items.Add(item);
                AtualizarCsv(passageiro);
            }
        }
    }
}
