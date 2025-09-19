using System;

namespace ProjetoToolkit
{
    public static class Utilitarios
    {
        public static int LerOpcaoDoMenu(int valorMinimo, int valorMaximo)
        {
            while (true)
            {
                Console.Write("Opção: ");
                string? textoDigitado = Console.ReadLine();
                if (int.TryParse(textoDigitado, out int valorLido))
                {
                    if (valorLido >= valorMinimo && valorLido <= valorMaximo)
                    {
                        return valorLido;
                    }
                }
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }

        public static char LerSimboloAB()
        {
            while (true)
            {
                string? texto = Console.ReadLine();
                if (!string.IsNullOrEmpty(texto) && texto.Length == 1 && (texto[0] == 'a' || texto[0] == 'b'))
                    return texto[0];
                Console.WriteLine("Símbolo inválido. Digite apenas 'a' ou 'b'.");
            }
        }

        public static string LerTextoNaoNulo()
        {
            string? entrada = Console.ReadLine();
            return entrada ?? string.Empty;
        }

        public static bool PertenceAoAlfabeto(string cadeia)
        {
            foreach (char c in cadeia)
            {
                if (c != 'a' && c != 'b') return false;
            }
            return true;
        }

        public static bool LerValorLogicoVF()
        {
            while (true)
            {
                Console.Write("Valor (V/F): ");
                string? t = Console.ReadLine()?.Trim().ToUpperInvariant();
                if (t == "V") return true;
                if (t == "F") return false;
                Console.WriteLine("Digite V ou F.");
            }
        }

        public static string VF(bool v) => v ? "V" : "F";
    }
}
