using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaDeMoedas
{
    internal class ConversorDeMoedas
    {
        public void DolaraAmericano()
        {
            double taxaIOF = 6.38, cotacaoDolar, QuantiaDolar, totalPago;

            Console.WriteLine("\nPARA QUE VOCÊ NÃO TENHA DIFICULDADES NA SUA COMPRA DE DÓLARES,\nPREENCHA O CAMPO ABAIXO CORRETAMENTE!!\n\n");

            Console.Write("qual a cotação do dólar no exato momento da compra? ");
            cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("quantos dólares você pretende comprar? ");
            QuantiaDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("sendo a taxa IOF = 6,38%");

            totalPago = QuantiaDolar * cotacaoDolar;
            totalPago = totalPago + totalPago * taxaIOF / 100.0;
            Console.WriteLine("\nO VALOR A SER PAGO EM REAIS: R$ " + totalPago.ToString("F2"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
        }

        public void Euro()
        {
            double taxaIOF = 6.38, cotacaoEuro, QuantiaEuro, totalPago;

            Console.WriteLine("\nPARA QUE VOCÊ NÃO TENHA DIFICULDADES NA SUA COMPRA DE EUROS,\nPREENCHA O CAMPO ABAIXO CORRETAMENTE!!\n\n");

            Console.Write("qual a cotação do euro no exato momento da compra? ");
            cotacaoEuro = double.Parse(Console.ReadLine());

            Console.Write("quantos euros você pretende comprar? ");
            QuantiaEuro = double.Parse(Console.ReadLine());

            Console.WriteLine("sendo a taxa IOF = 6,38%");

            totalPago = QuantiaEuro * cotacaoEuro;
            totalPago = totalPago + totalPago * taxaIOF / 100.0;
            Console.WriteLine("\nO VALOR A SER PAGO EM REAIS: R$ " + totalPago.ToString("F2"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
        }

        public void LibraEsterlina()
        {
            double taxaIOF = 6.38, cotacaoLibra, QuantiaLibra, totalPago;

            Console.WriteLine("\nPARA QUE VOCÊ NÃO TENHA DIFICULDADES NA SUA COMPRA DE LIBRAS,\nPREENCHA O CAMPO ABAIXO CORRETAMENTE!!\n\n");

            Console.Write("qual a cotação da libra no exato momento da compra? ");
            cotacaoLibra = double.Parse(Console.ReadLine());

            Console.Write("quantas libras você pretende comprar? ");
            QuantiaLibra = double.Parse(Console.ReadLine());

            Console.WriteLine("sendo a taxa IOF = 6,38%");

            totalPago = QuantiaLibra * cotacaoLibra;
            totalPago = totalPago + totalPago * taxaIOF / 100.0;
            Console.WriteLine("\nO VALOR A SER PAGO EM REAIS: R$ " + totalPago.ToString("F2"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
        }
    }
}
