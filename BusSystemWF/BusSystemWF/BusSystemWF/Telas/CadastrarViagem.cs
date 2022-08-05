using BusSystemWF.Entities;
using BusSystemWF.Entities.Viagens;

namespace BusSystemWF
{
    //Vitor Virges Moreira
    public partial class CadastrarViagem : Form
    {
        private readonly Empresa _empresa;
        public CadastrarViagem(Empresa empresa)
        {
            _empresa = empresa;
            InitializeComponent();
        }

        private bool Validar()
        {
            if (txtNomeMotorista.Text.Length < 2 || txtNomeMotorista.Text.Length > 100)
            {
                txtNomeMotorista.Focus();
                MessageBox.Show("Informe o nome do motorista corretamente.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mskTxtPlaca.Text.Length < 8)
            {
                mskTxtPlaca.Focus();
                MessageBox.Show("Informe a placa corretamente.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mskDataViagem.Text.Length < 10)
            {
                mskTxtPlaca.Focus();
                MessageBox.Show("Informe a data corretamente.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mskHoraViagem.Text.Length < 5)
            {
                mskTxtPlaca.Focus();
                MessageBox.Show("Informe a hora corretamente.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnInfoViagens_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (CheckInterMunicipal.Checked)
                {
                    var viagem = new Intermunicipal(mskTxtPlaca.Text, txtNomeMotorista.Text, FormatarData(mskDataViagem.Text), FormatarHoras(mskHoraViagem.Text));
                    _empresa.AddViagens(viagem);
                    this.Close();
                }
                else if (CheckMunicipal.Checked)
                {
                    var viagem = new Municipal(mskTxtPlaca.Text, txtNomeMotorista.Text, FormatarData(mskDataViagem.Text), FormatarHoras(mskHoraViagem.Text));
                    _empresa.AddViagens(viagem);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Informe o tipo da viagem");
                }
            }
        }

        private void CheckMunicipal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMunicipal.Checked)
            {
                CheckInterMunicipal.Checked = false;
            }
        }

        private void CheckInterMunicipal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckInterMunicipal.Checked)
            {
                CheckMunicipal.Checked = false;
            }
        }

        private DateTime FormatarData(string date)
        {
            var dia = int.Parse(date.Substring(0, 2));
            var mes = int.Parse(date.Substring(3, 2));
            var ano = int.Parse(date.Substring(6, 4));
            return new DateTime(ano, mes, dia);
        }

        private TimeOnly FormatarHoras(string time)
        {
            var hours = int.Parse(time.Substring(0, 2));
            var minutes = int.Parse(time.Substring(3, 2));
            return new TimeOnly(hours, minutes);
        }
    }
}
