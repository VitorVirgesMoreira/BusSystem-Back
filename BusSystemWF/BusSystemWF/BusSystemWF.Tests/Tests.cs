using BusSystemWF.Entities.Passageiros;
using BusSystemWF.Entities.Viagens;
using FluentAssertions;

namespace BusSystemWF.Tests
{
    //Vitor Virges Moreira
    public class Tests
    {
        public class Test
        {
            [Fact]
            public void ValidarCampos_Should_Throw_Excetion()
            {
                //Arrange
                var municipal = new Municipal("AAA-7777", "Motorista", DateTime.MinValue, TimeOnly.MinValue);
                var cadastro = new CadastrarPassageiro(municipal);
                cadastro.txtNome.Text = "Antonio";
                cadastro.mskTxtRg.Text = "555.555.555-5";
                cadastro.mskTxtTelefone.Text = "47 99999-9999";
                cadastro.checkIdoso.Checked = true;
                cadastro.cmbBoxIdade.SelectedItem = "59";

                //Act
                var result = Record.Exception(() => cadastro.Validar());

                //Assert
                result.Should().BeOfType<ArgumentException>();
                result.Message.Should().Be("Para ser um idoso é necessário ter idade acima de 60.");
            }

            [Fact]
            public void ValidarCampos_Should_Not_Throw_Exception()
            {
                //Arrange
                var municipal = new Municipal("AAA-7777", "Motorista", DateTime.MinValue, TimeOnly.MinValue);
                var cadastro = new CadastrarPassageiro(municipal);
                cadastro.txtNome.Text = "Antonio";
                cadastro.mskTxtRg.Text = "555.555.555-5";
                cadastro.mskTxtTelefone.Text = "47 99999-9999";
                cadastro.checkIdoso.Checked = true;
                cadastro.cmbBoxIdade.SelectedItem = "70";

                //Act
                var result = Record.Exception(() => cadastro.Validar());

                //Assert
                result.Should().BeNull();
            }

            [Fact]
            public void Municipal_Should_Throw_Exception()
            {
                //Arrange
                var municipal = new Municipal("AAA-7777", "Motorista", DateTime.MinValue, TimeOnly.MinValue);
                List<Passageiro> listPassageiro = new List<Passageiro>();
                while (listPassageiro.Count < 37)
                {
                    listPassageiro.Add(new Passageiro("Vitor", "47 99999-9999", 19));
                }

                Exception result = null;

                //Act
                foreach (var item in listPassageiro)
                    result = Record.Exception(() => municipal.AddPassageiro(item));


                //Assert
                result.Should().BeOfType<ArgumentException>();
                result.Message.Should().Be("Limite máximo de 35 passageiros foi atingido.");
            }

            [Fact]
            public void Intermunicipal_Should_Throw_Exception()
            {
                //Arrange
                var interMunicipal = new Intermunicipal("AAA-7777", "Motorista", DateTime.MinValue, TimeOnly.MinValue);
                List<Passageiro> listPassageiro = new List<Passageiro>();
                listPassageiro.Add(new Passageiro("Vitor", "47 99999-9999", 19));
                listPassageiro.Add(new Idoso("Samara", "47 99999-9999", 60, "555.555.555-5"));
                listPassageiro.Add(new Estudante("Gustavo", "47 99999-9999", 14, "Escola Teste"));

                //Act
                foreach (var item in listPassageiro)
                    interMunicipal.AddPassageiro(item);

                var result = interMunicipal.GetValorTotal();

                //Assert
                result.Should().BeGreaterThan(20.00f);
                result.Should().BeLessThan(22f);
            }
        }
    }
}