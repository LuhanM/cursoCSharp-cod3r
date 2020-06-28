using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

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

                {"Herança -  OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfirsmo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                { "Lambda - Métodos e Funções", ExemploLambda.Executar},
                { "Lambda Delegate - Métodos e Funções", LambdaDelegate.Executar},
                { "Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                { "Delegate com Func Anônima- Métodos e Funções", DelegateFuncAnonima.Executar},
                { "Delegate como Parâmetro- Métodos e Funções", DelegateComoParametro.Executar},
                { "Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                { " Exceção Personalizada - Exceções", ExcecoesPersonalizadas.Executar},

                { "Primeiro Arquivos - API", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - API", LendoArquivos.Executar},
                { "Diretorios - API", Diretorios.Executar},
                { "Exemplo Path - API", ExemploPath.Executar},
                { "Exemplo DateTime - API", ExemploDateTime.Executar},
                { "Exemplo TimeSpan - API", ExemploTimeSpan.Executar},

                { "LINQ 01 - Tópicos avançados", LINQ1.Executar},
                { "LINQ 02 - Tópicos avançados", LINQ2.Executar},
                { "Nullables - Tópicos avançados", Nullables.Executar},
                { "Dynamics - Tópicos avançados", Dynamics.Executar},
                { "Genéricos - Tópicos avançados", Genericos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}