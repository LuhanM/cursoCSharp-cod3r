using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

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

                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else IF- Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch- Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While- Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do-While- Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For- Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach- Estruturas de Controle", EstruturaForeach.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}