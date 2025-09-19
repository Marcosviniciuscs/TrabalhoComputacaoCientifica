using System;

namespace ProjetoToolkit
{
    public static class MenuPrincipal
    {
        public static void ImprimirMenu()
        {
            Console.WriteLine("Projeto Toolkit (.NET 9) — versão modular");
            Console.WriteLine("---- AV1 ----");
            Console.WriteLine("1) Verificar alfabeto e cadeia (Sigma={a,b})");
            Console.WriteLine("2) Classificador T/I/N por JSON");
            Console.WriteLine("3) Decisor: termina com 'b'?");
            Console.WriteLine("4) Avaliador proposicional (P,Q,R)");
            Console.WriteLine("5) Reconhecedor: L_par_a e a b*");
            Console.WriteLine("0) Sair");
        }
    }
}
