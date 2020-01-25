using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamento", Comentarios.Executar},
                {"Variáveis E Constantes - Fundamento", VariaveisEConstantes.Executar},
                {"Inferência - Fundamento", Inferencia.Executar},
                {"Interpolação - Fundamento", Interpolacao.Executar},
                {"Notação - Fundamento", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamento", LendoDados.Executar},
                {"Formatando números - Fundamento", FormatandoNumeros.Executar},
                {"Conversões - Fundamento", Conversoes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}