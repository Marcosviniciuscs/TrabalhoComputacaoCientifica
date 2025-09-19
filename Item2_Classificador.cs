using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ProjetoToolkit
{
    public static class Item2_Classificador
    {
        public static void Executar()
        {
            Console.WriteLine("Item 2 — Classificador T/I/N por JSON");
            Console.WriteLine("T=tratável, I=intrátavel, N=não_computável\n");

            string json = ObterJsonProblemasExemplo();
            List<Problema>? problemas = JsonSerializer.Deserialize<List<Problema>>(json);
            if (problemas is null || problemas.Count == 0)
            {
                Console.WriteLine("Falha ao carregar dados.");
                return;
            }

            int acertos = 0, erros = 0;
            int tUsuario = 0, iUsuario = 0, nUsuario = 0;

            foreach (var p in problemas)
            {
                Console.WriteLine($"[{p.Identificador}] {p.Enunciado}");
                string resposta = LerRespostaTIouN();
                if (resposta == "T") tUsuario++;
                else if (resposta == "I") iUsuario++;
                else nUsuario++;

                string categoriaUsuario = ConverterRespostaParaCategoria(resposta);
                bool correto = string.Equals(categoriaUsuario, p.CategoriaCorreta, StringComparison.OrdinalIgnoreCase);
                if (correto)
                {
                    acertos++;
                    Console.WriteLine("Correto\n");
                }
                else
                {
                    erros++;
                    Console.WriteLine($"Incorreto. Correto: {p.CategoriaCorreta}\n");
                }
            }

            Console.WriteLine("Resumo");
            Console.WriteLine($"Acertos: {acertos}");
            Console.WriteLine($"Erros: {erros}");
            Console.WriteLine($"Marcações feitas — T: {tUsuario}, I: {iUsuario}, N: {nUsuario}");
        }

        private static string LerRespostaTIouN()
        {
            while (true)
            {
                Console.Write("Sua resposta (T/I/N): ");
                string? texto = Console.ReadLine();
                if (texto is null) continue;
                texto = texto.Trim().ToUpperInvariant();
                if (texto == "T" || texto == "I" || texto == "N") return texto;
                Console.WriteLine("Digite T, I ou N.");
            }
        }

        private static string ConverterRespostaParaCategoria(string resposta) =>
            resposta switch
            {
                "T" => "tratavel",
                "I" => "intratavel",
                _ => "nao_computavel"
            };

        private static string ObterJsonProblemasExemplo() => @"[
  { ""Identificador"": ""P1"", ""Enunciado"": ""Ordenar n números"", ""CategoriaCorreta"": ""tratavel"" },
  { ""Identificador"": ""P2"", ""Enunciado"": ""Verificar se cadeia contém 'a'"", ""CategoriaCorreta"": ""tratavel"" },
  { ""Identificador"": ""P3"", ""Enunciado"": ""Satisfatibilidade booleana (SAT)"", ""CategoriaCorreta"": ""intratavel"" },
  { ""Identificador"": ""P4"", ""Enunciado"": ""Caixeiro viajante exato"", ""CategoriaCorreta"": ""intratavel"" },
  { ""Identificador"": ""P5"", ""Enunciado"": ""Problema da parada"", ""CategoriaCorreta"": ""nao_computavel"" },
  { ""Identificador"": ""P6"", ""Enunciado"": ""Testar se número é primo"", ""CategoriaCorreta"": ""tratavel"" },
  { ""Identificador"": ""P7"", ""Enunciado"": ""Cobertura por vértices mínima"", ""CategoriaCorreta"": ""intratavel"" },
  { ""Identificador"": ""P8"", ""Enunciado"": ""Decidir se dois programas sempre produzem a mesma saída"", ""CategoriaCorreta"": ""nao_computavel"" }
]";

        private sealed class Problema
        {
            public string Identificador { get; set; } = string.Empty;
            public string Enunciado { get; set; } = string.Empty;
            public string CategoriaCorreta { get; set; } = string.Empty;
        }
    }
}
