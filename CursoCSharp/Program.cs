using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
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

            });

            central.SelecionarEExecutar();
        }
    }
}