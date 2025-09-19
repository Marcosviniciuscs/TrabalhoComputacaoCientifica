using System;

namespace ProjetoToolkit
{
    public static class Item4_Avaliador
    {
        public static void Executar()
        {
            Console.WriteLine("Item 4 — Avaliador proposicional (P,Q,R)");
            Console.WriteLine("Escolha a fórmula:");
            Console.WriteLine("1) F1(P,Q,R) = P ∧ Q");
            Console.WriteLine("2) F2(P,Q,R) = P ∨ Q");
            Console.WriteLine("3) F3(P,Q,R) = (P ∧ Q) → R");
            int opcao = Utilitarios.LerOpcaoDoMenu(1, 3);

            Console.WriteLine("\nO que deseja fazer?");
            Console.WriteLine("1) Avaliar digitando valores de P, Q, R");
            Console.WriteLine("2) Gerar tabela-verdade completa");
            int escolha = Utilitarios.LerOpcaoDoMenu(1, 2);

            if (escolha == 1)
            {
                Console.WriteLine("\nDigite o valor de P (V/F):");
                bool P = Utilitarios.LerValorLogicoVF();

                Console.WriteLine("Digite o valor de Q (V/F):");
                bool Q = Utilitarios.LerValorLogicoVF();

                Console.WriteLine("Digite o valor de R (V/F):");
                bool R = Utilitarios.LerValorLogicoVF();

                bool resultado = AvaliarFormula(opcao, P, Q, R);
                Console.WriteLine($"\nResultado: {(resultado ? "Verdadeiro" : "Falso")}");
            }
            else
            {
                ImprimirTabelaVerdade(opcao);
            }
        }

        private static bool AvaliarFormula(int opcao, bool P, bool Q, bool R) =>
            opcao switch
            {
                1 => P && Q,
                2 => P || Q,
                _ => (!(P && Q)) || R
            };

        private static void ImprimirTabelaVerdade(int opcao)
        {
            Console.WriteLine();
            Console.WriteLine("P Q R | Resultado");
            Console.WriteLine("-------------------");

            bool[] valores = new[] { false, true };
            foreach (bool P in valores)
            {
                foreach (bool Q in valores)
                {
                    foreach (bool R in valores)
                    {
                        bool res = AvaliarFormula(opcao, P, Q, R);
                        Console.WriteLine($"{Utilitarios.VF(P)} {Utilitarios.VF(Q)} {Utilitarios.VF(R)} | {Utilitarios.VF(res)}");
                    }
                }
            }
        }
    }
}
