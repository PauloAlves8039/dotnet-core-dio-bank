using src.DIO.Bank.Classes;
using src.DIO.Bank.Enum;
using Xunit;

namespace src.DIO.Bank.Test.ContaTests
{
    public class ContaTest
    {
        [Fact(DisplayName = "É possível realizar saque de R$ 50.00")]
        public void Sacar_Deve_Retornar_Verdadeiro_Saque()
        {
            var conta = new Conta(TipoConta.PessoaFisica, 500.00, 100.00, "Paulo");

            var valorRecebido = conta.Sacar(50.00);

            var valorEsperado = conta.Sacar(50.00);

            Assert.Equal(valorEsperado, valorRecebido);
        }

        [Fact(DisplayName = "Não é possível realizar saque de R$ 600.00")]
        public void Sacar_Deve_Retornar_Falso_Saque()
        {
            var conta = new Conta(TipoConta.PessoaFisica, 500.00, 100.00, "Paulo");

            var valorRecebido = conta.Sacar(600.00);

            var valorEsperado = conta.Sacar(500.00);

            Assert.NotEqual(valorEsperado, valorRecebido);
        }

        [Fact(DisplayName = "É possível realizar o depósito de R$ 50.00")]
        public void Depositar_Deve_Retornar_Verdadeiro_Deposito()
        {
            var conta = new Conta(TipoConta.PessoaFisica, 500.00, 100.00, "Paulo");

            var valorRecebido = 50.00;
            conta.Depositar(valorRecebido);

            var valorEsperado = 50.00;

            Assert.Equal(valorEsperado, valorRecebido);
        }

        [Fact(DisplayName = "Não é possível realizar o depósito de R$ 50.00")]
        public void Depositar_Deve_Retornar_Falso_Deposito()
        {
            var conta = new Conta(TipoConta.PessoaFisica, 500.00, 100.00, "Paulo");

            var valorRecebido = 00.00;
            conta.Depositar(valorRecebido);

            var valorEsperado = 50.00;

            Assert.NotEqual(valorEsperado, valorRecebido);
        }

        [Fact(DisplayName = "É possível Realizar a transferência de R$ 100.00")]
        public void Transferir_Deve_Retornar_Verdadeiro_Transferencia()
        {
            var conta1 = new Conta(TipoConta.PessoaFisica, 500.00, 100.00, "Paulo");
            var conta2 = new Conta(TipoConta.PessoaJuridica, 500.00, 100.00, "Isadora");

            var valorDaTranferencia = 100.00;

            conta1.Transferir(valorDaTranferencia, conta2);

            var valorEsperado = 100.00;

            Assert.Equal(valorEsperado, valorDaTranferencia);
        }

        [Fact(DisplayName = "Não é possível Realizar a transferência de R$ 100.00")]
        public void Transferir_Deve_Retornar_Falso_Transferencia()
        {
            var conta1 = new Conta(TipoConta.PessoaFisica, 500.00, 100.00, "Paulo");
            var conta2 = new Conta(TipoConta.PessoaJuridica, 500.00, 100.00, "Isadora");

            var valorDaTranferencia = 50.00;

            conta1.Transferir(valorDaTranferencia, conta2);

            var valorEsperado = 100.00;

            Assert.NotEqual(valorEsperado, valorDaTranferencia);
        }
    }
}
