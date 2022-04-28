using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpNovo.Fundamentos
{
    class VariaveiseConstantes
    {
        public static void Executar()
        {
            //Área da circunferência
            double raio = 4.5; //Tipo e nome
            const double PI = 3.14;

            raio = 5.5; //Variável permite mudanças de valores
            //PI = 3.1415; Uma constante não permite alteração de valor

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            //Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("idade " + idade); // Byte tem 8 bits

            sbyte saldoDeGols = sbyte.MinValue; //Sbyte aceita sinal
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; //Mais usados nos inteiros!
            Console.WriteLine("Menor Int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; //uint, valor sem sinal;_(underline) usado para separação
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor de Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais
            Console.WriteLine("Valor de mercado da Apple " + valorMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " + letra);
            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
