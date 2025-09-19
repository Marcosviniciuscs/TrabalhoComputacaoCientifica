using System;

namespace ProjetoToolkit
{
    public static class Item3_Decisor
    {
        private const string SigmaDescricao = "Sigma = { a, b }";

        public static void Executar()
        {
            Console.WriteLine("Item 3 — Decisor: termina com 'b'? (" + SigmaDescricao + ")");
            Console.WriteLine("Digite a cadeia (Enter = vazia):");
            string cadeia = Utilitarios.LerTextoNaoNulo();
            if (!Utilitarios.PertenceAoAlfabeto(cadeia))
            {
                Console.WriteLine("Entrada inválida: use apenas 'a' ou 'b'.");
                return;
            }
            bool resposta = cadeia.Length > 0 && cadeia[^1] == 'b';
            Console.WriteLine(resposta ? "SIM" : "NÃO");
        }
    }
}
