using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

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

                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodoEstatico.Executar},
                {"Atributo Estático - Classes e Métodos", AtributoEstatico.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Getters e Setter -  Classes e Métodos", GetSet.Executar},
                {"Propriedades -  Classes e Métodos", Propriedades.Executar},
                {"Readonly -  Classes e Métodos", Readonly.Executar},
                {"Enumerados -  Classes e Métodos", ExemploEnum.Executar},
                {"Struct -  Classes e Métodos", Struct.Executar},
                {"Struct vs Classe -  Classes e Métodos", StructVsClasse.Executar},
                {"Parâmetros Por Referência -  Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com valor padrão -  Classes e Métodos", ParametroPadrao.Executar},

                {"Array -  Coleções", Colecoes.Array.Executar},
                {"List -  Coleções", Listas.Executar},
                {"ArrayList -  Coleções", ColecoeArrayList.Executar},
                {"Set -  Coleções", ColecoesSet.Executar},
                {"Queue -  Coleções", ColecoesQueue.Executar},
                {"Igualdade -  Coleções", Igualdade.Executar},
                {"Stack -  Coleções", ColecoesStack.Executar},
                {"Dictionary -  Coleções", ColecoesDictionary.Executar},





            });

            central.SelecionarEExecutar();
        }
    }
}