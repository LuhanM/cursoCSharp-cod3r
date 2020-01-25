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
                {"Operadores Aritméticos - Fundamento", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamento", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamento", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamento", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamento", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamento", OperadoresTernarios.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}