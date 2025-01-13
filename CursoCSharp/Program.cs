using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ControlStatement;
using CursoCSharp.ClassMethod;
using static CursoCSharp.ClassMethod.calculadoraCadeia;
using static CursoCSharp.ClassMethod.Prod;
using static CursoCSharp.ClassMethod.Client;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"First Program - Fundamentos", FirstProgram.Execute},
                {"Coments - Fundamentos", Coments.Execute},
                {"Variables and Constants - Fundamentos", VariableEConstants.Execute},
                {"Inferencia - Fundamentos", Inferencia.Execute},
                {"Interpolação - Fundamentos", Interpolacao.Execute},
                {"Notação ponto - Fundamentos", NotacaoPonto.Execute},
                {"Lendo dados - Fundamentos", LendoDados.Execute},
                {"Formatando números - Fundamentos", FormatandoNumero.Execute},
                {"Convertendo - Fundamentos", Conversoes.Execute},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Execute},
                {"Operadores Relacionais - Fundamentos", OperadorRelacional.Execute},
                {"Operadores Lógicos - Fundamentos", OperadorLogico.Execute},
                {"Operadores de Atribuição - Fundamentos", OperadorAtribuicao.Execute},
                {"Operadores Unários  - Fundamentos", OperadorUnario.Execute},
                {"Operadores Ternário  - Fundamentos", OperadorTernario.Execute},
                //Control statement
                {"Structure IF  - Control statement", StructureIF.Execute},
                {"Structure IF/ELse  - Control statement", StructureIfElse.Execute},
                {"Structure IF/ELse/IF  - Control statement", StructureIfElseIf.Execute},
                {"Structure Switch  - Control statement", StructureSwitch.Execute},
                {"Structure While  - Control statement", StructureWhile.Execute},
                {"Structure Do While  - Control statement", StructureDoWhile.Execute},
                {"Structure For - Control statement", StructureFor.Execute},
                {"Structure For Each - Control statement", StructureForEach.Execute},
                //Class and Method
                {"Members - Class and Method", Members.Execute},
                {"Contructors - Class and Method", Constructors.Execute},
                {"Method With Return - Class and Method", WithReturn.Execute},
                {"Methods Static - Class and Method", Static.Execute},
                {"Atrib Static - Class and Method", AtribStatic.Execute},
                {"Challenge Atrib  - Class and Method", ChallengeAtrib.Execute},
                {"Params  - Class and Method", Params.Execute},
                {"named arguments  - Class and Method", ParamsNom.Execute},
                {"Getters and Setters  - Class and Method", GettersSetters.Execute},
                {"Props  - Class and Method", Props.Execute},
                {"Readyonly  - Class and Method", Readyonly.Execute},
                {"Example Enum  - Class and Method", ExampEnum.Execute},
                {"Struct  - Class and Method", Struct.Execute},
                {"Struct & Class  - Class and Method", StructClass.Execute},
                {"Value & Reference  - Class and Method", ValueRef.Execute},
                {"Params for Ref  - Class and Method", ParamsRef.Execute},
                {"Defalut Value - Class and Method", DefaultValue.Execute},

            });

            central.SelecionarEExecutar();
        }
    }
}