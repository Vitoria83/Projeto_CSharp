using System;
using System.Collections.Generic;

using CursoCSharpNovo.Fundamentos;
using CursoCSharpNovo.ClassesEMetodos;

namespace CursoCSharpNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CursoCSharpNovo.CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveiseConstantes.Executar },
                {"Inferências - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                
                //Classes e Metodos
                
                {"Membros - Classes E Métodos", Membros.Executar },
                {"Construtores - Classes E Métodos", Construtores.Executar },
                {"Metodos com Retorno - Classes E Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos- Classes E Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos- Classes E Métodos", AtributosEstaticos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}