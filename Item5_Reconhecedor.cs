using System;

namespace ProjetoToolkit
{
    public static class Item5_Reconhecedor
    {
        private const string SigmaDescricao = "Sigma = { a, b }";

        public static void Executar()
        {
            Console.WriteLine("Item 5 — Reconhecedor: L_par_a e L = { w | w = a b* }");
            Console.WriteLine("Antes: validação do alfabeto (" + SigmaDescricao + ")");
            Console.WriteLine("Digite a cadeia (Enter = vazia):");
            string cadeia = Utilitarios.LerTextoNaoNulo();
            if (!Utilitarios.PertenceAoAlfabeto(cadeia))
            {
                Console.WriteLine("Cadeia inválida: use apenas 'a' ou 'b'.");
                return;
            }

            Console.WriteLine("Escolha a linguagem:");
            Console.WriteLine("1) L_par_a = { w | número de 'a' par }");
            Console.WriteLine("2) L = { w | w = a b* }");
            int opcao = Utilitarios.LerOpcaoDoMenu(1, 2);

            bool aceita = (opcao == 1) ? EhParDeAs(cadeia) : EhAComBasterisco(cadeia);
            Console.WriteLine(aceita ? "ACEITA" : "REJEITA");
        }

        private static bool EhParDeAs(string cadeia)
        {
            int contador = 0;
            foreach (char c in cadeia)
            {
                if (c == 'a') contador++;
            }
            return contador % 2 == 0;
        }

        private static bool EhAComBasterisco(string cadeia)
        {
            if (cadeia.Length == 0) return false;
            if (cadeia[0] != 'a') return false;
            for (int i = 1; i < cadeia.Length; i++)
            {
                if (cadeia[i] != 'b') return false;
            }
            return true; // a, ab, abb, abbb, ...
        }
    }
}
