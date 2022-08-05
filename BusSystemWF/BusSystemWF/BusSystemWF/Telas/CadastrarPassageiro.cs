using BusSystemWF.Entities.Passageiros;
using BusSystemWF.Entities.Viagens;

namespace BusSystemWF
{
    //Vitor Virges Moreira
    public partial class CadastrarPassageiro : Form
    {
        private readonly Viagem _viagem;
        public CadastrarPassageiro(Viagem viagem)
        {
            _viagem = viagem;
            InitializeComponent();
        }

        public bool Validar()
        {
            int idade = 0;
            if (cmbBoxIdade.SelectedItem != null)
                idade = int.Parse(cmbBoxIdade.SelectedItem.ToString());

            if (txtNome.Text.Length < 3 || txtNome.Text.Length > 100)
            {
                txtNome.Focus();
                return false;
            }
            if (mskTxtTelefone.Text.Length < 15)
            {
                mskTxtTelefone.Focus();
                return false;
            }
            if (cmbBoxIdade.SelectedIndex <= 0 || cmbBoxIdade.SelectedIndex > 100)
            {
                cmbBoxIdade.Focus();
                return false;
            }
            if (checkIdoso.Checked && mskTxtRg.Text.Trim().Length < 12)
            {
                mskTxtRg.Focus();
                return false;
            }
            if (checkEstudante.Checked && txtEscola.Text.Length < 10)
            {
                txtEscola.Focus();
                return false;
            }
            if (checkIdoso.Checked && idade < 60)
            {
                throw new ArgumentException("Para ser um idoso é necessário ter idade acima de 60.");
            }

            return true;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Passageiro passageiro;
                    if (checkIdoso.Checked)
                        passageiro = new Idoso(txtNome.Text, mskTxtTelefone.Text, int.Parse(cmbBoxIdade.SelectedItem.ToString()), mskTxtRg.Text);
                    else if (checkEstudante.Checked)
                        passageiro = new Estudante(txtNome.Text, mskTxtTelefone.Text, int.Parse(cmbBoxIdade.SelectedItem.ToString()), txtEscola.Text);
                    else
                        passageiro = new Passageiro(txtNome.Text, mskTxtTelefone.Text, int.Parse(cmbBoxIdade.SelectedItem.ToString()));

                    _viagem.AddPassageiro(passageiro);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos solicitados.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkEstudante_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEstudante.Checked)
            {
                checkIdoso.Checked = false;
                lblAfterCheck.Text = "Escola";
                lblAfterCheck.Visible = true;
                txtEscola.Visible = true;
            }
            else
            {
                lblAfterCheck.Visible = false;
                txtEscola.Visible = false;
                txtEscola.Text = null;
            }
        }

        private void checkIdoso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIdoso.Checked)
            {
                checkEstudante.Checked = false;
                lblAfterCheck.Text = "Rg";
                lblAfterCheck.Visible = true;
                mskTxtRg.Visible = true;
            }
            else
            {
                lblAfterCheck.Visible = false;
                mskTxtRg.Visible = false;
                mskTxtRg.Text = null;
            }
        }
    }
}
