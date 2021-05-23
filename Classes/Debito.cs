using System;

namespace ExemploPilaresPOO.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void Pagar() {
            float valor = this.Valor;
            
            if (valor > Saldo) {
                Console.WriteLine("Você não possui saldo suficiente para pagar esse valor!");
            } else {
                Console.WriteLine($"O valor de R${valor.ToString("N2")} foi pago com sucesso!");
            }
        }
    }
}