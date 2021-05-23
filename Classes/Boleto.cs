using System;

namespace ExemploPilaresPOO.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;        
        Random r = new Random();
        
        public void Registrar() {
            // O pagamento com boleto tem 12% de desconto
            CodigoDeBarras = r.Next(30000000).ToString();
            Console.WriteLine($"Boleto gerado com o código {CodigoDeBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de R${( this.Valor * 0.88 ).ToString("N2")}!");
        }
    }
}