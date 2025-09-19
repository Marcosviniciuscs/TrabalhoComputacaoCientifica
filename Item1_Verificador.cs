using System;

namespace ProjetoToolkit
{
    public static class Item1_Verificador
    {
        private const string SigmaDescricao = "Sigma = { a, b }";

        public static void Executar()
        {
            Console.WriteLine("Item 1 — Verificar alfabeto e cadeia (" + SigmaDescricao + ")");
            Console.WriteLine("Digite um símbolo (apenas 'a' ou 'b'):");
            char simbolo = Utilitarios.LerSimboloAB();
            Console.WriteLine("Símbolo válido em Sigma.");

            Console.WriteLine();
            Console.WriteLine("Agora digite uma cadeia (Enter = vazia):");
            string cadeia = Utilitarios.LerTextoNaoNulo();
            bool cadeiaValida = Utilitarios.PertenceAoAlfabeto(cadeia);
            Console.WriteLine(cadeiaValida ? "Cadeia válida em Sigma*." : "Cadeia inválida: use apenas 'a' ou 'b'.");
        }
    }
}
