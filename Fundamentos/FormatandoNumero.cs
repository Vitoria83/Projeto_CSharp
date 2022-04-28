using System;
using System.Globalization;


namespace CursoCSharpNovo.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //1 casa decimal
            Console.WriteLine(valor.ToString("C")); // Valor monetário 
            Console.WriteLine(valor.ToString("P")); // Valor percentual
            Console.WriteLine(valor.ToString("#.##")); // Formatação mais específica

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Total de 10 dígitos
          


        }
    }
}
