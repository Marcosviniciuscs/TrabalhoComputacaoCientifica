using System;
using System.Text;

namespace ProjetoToolkit
{
    public static class Programa
    {
        public static void Main(string[] argumentos)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                MenuPrincipal.ImprimirMenu();
                int opcaoEscolhida = Utilitarios.LerOpcaoDoMenu(0, 5);
                Console.WriteLine();

                if (opcaoEscolhida == 0) return;

                if (opcaoEscolhida == 1) Item1_Verificador.Executar();
                if (opcaoEscolhida == 2) Item2_Classificador.Executar();
                if (opcaoEscolhida == 3) Item3_Decisor.Executar();
                if (opcaoEscolhida == 4) Item4_Avaliador.Executar();
                if (opcaoEscolhida == 5) Item5_Reconhecedor.Executar();

                Console.WriteLine();
                Console.WriteLine("Pressione Enter para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
}
