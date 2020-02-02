using FluentAssertions;
using MestreDosCodigos_POO_11.Model;
using Xunit;

namespace MestreDosCodigos_Testes_XUnit
{
    public class Exercicio11_Tests
    {
        [Fact]
        public void DeveDepositar()
        {
            double saldoInicial = 100;
            double valorDeposito = 100;
            double taxaOperacao = 10.5;

            var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
            cc.Depositar(valorDeposito);

            cc.Saldo.Should().Be(saldoInicial + valorDeposito - taxaOperacao);
        }

        [Fact]
        public void NaoDeveDepositar()
        {
            double saldoInicial = 100;
            double valorDeposito = 10;
            double taxaOperacao = 10.5;

            var cc = new ContaCorrente(taxaOperacao, saldoInicial, 5678);
            cc.Depositar(valorDeposito);

            cc.Saldo.Should().Be(saldoInicial);
        }
    }
}