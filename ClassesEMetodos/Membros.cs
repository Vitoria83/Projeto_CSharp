using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpNovo.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            var nomeDigitado = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa: ");
            var idadeDigitado = Console.ReadLine();
            

            //int.TryParse(myStr, out a);

            Pessoa sicrano = new Pessoa();
            sicrano.Nome = nomeDigitado;
            int.TryParse(idadeDigitado, out sicrano.Idade);
                
            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "William";
            fulano.Idade = 27;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
           
        }
    }
}
