using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ControlStatement;

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

            });

            central.SelecionarEExecutar();
        }
    }
}