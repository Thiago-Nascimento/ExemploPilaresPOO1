using System;

namespace ExemploPilaresPOO.Classes
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;

        public void Pagar() {
            int vezes;
            float valor = this.Valor;
            
            // O pagamento em cartão de crédito tem juros de 5% até 6 parcelas e 8% de 7 à 12 parcelas, não deve ser possível aceitar mais que 12 parcelas
            if (valor > Limite) {
                Console.WriteLine("O seu limite não é suficiente para pagar esse valor!");
            } else {                
                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor R${valor}? (De 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes <= 6 && vezes >= 0) {
                        Console.WriteLine($"Voce optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% no valor total");
                        Console.WriteLine($"Voce pagará R${(valor * 1.05).ToString("N2")}");                        
                    } else if (vezes >= 7 && vezes <= 12) {
                        Console.WriteLine($"Voce optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% no valor total");
                        Console.WriteLine($"Voce pagará R${(valor * 1.08).ToString("N2")}");
                    } else {
                        Console.WriteLine("Impossível parcelar em mais de 12x, escolha um numero de vezes menor que 12");
                    }                    
                } while (vezes > 12);                
            }
        }
    }
}