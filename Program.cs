using System;
using System.Collections.Generic;

namespace AulaDictionaryGenericsSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genericos
            Dicionario<string> estados = new Dicionario<string>();
            estados.AddItem("SC", "Santa Catarina");
            estados.AddItem("SP", "São Paulo");
            estados.AddItem("SE", "Sergipe");

            Dicionario<decimal> tarifas = new Dicionario<decimal>();
            tarifas.AddItem("metrô", 4.50m);
            tarifas.AddItem("ônibus", 4.00m);
            tarifas.AddItem("trem", 3.00m);

            Dicionario<bool> configuracoes = new Dicionario<bool>();
            configuracoes.AddItem("freio ABS", true);
            configuracoes.AddItem("ar condicionado", false);
            configuracoes.AddItem("vidro elétrico", true);

            // AULA GetHashCode e Equals

            string nome1 = "Gustavo";
            string nome2 = "Gustavo";

            Console.WriteLine(nome1.Equals(nome2));
            Console.WriteLine(nome1.GetHashCode());
            Console.WriteLine(nome2.GetHashCode());


            // AULA SORTset hasset

            HashSet<string> hs = new HashSet<string>();

            hs.Add("Arroz");
            hs.Add("Feijão");
            hs.Add("Ovo");

            Console.WriteLine(hs.Contains("OvO"));

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }

            SortedSet<string> nomes = new SortedSet<string>();

            nomes.Add("Hugo");
            nomes.Add("Ettore");
            nomes.Add("Osni");
            nomes.Add("Alberto");
            nomes.Add("Victor");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //UNION

            SortedSet<int> a1 = new SortedSet<int>(a);
            a1.UnionWith(b);
            ExibirColecao(a1);


            //intersection
            SortedSet<int> a2 = new SortedSet<int>(a);

            a2.IntersectWith(b);
            ExibirColecao(a2);

            // difference

            SortedSet<int> a3 = new SortedSet<int>(a);
            a3.ExceptWith(b);

            ExibirColecao(a3);

        }

        static void ExibirColecao<T>(IEnumerable<T> colecao)
        {
            foreach (T item in colecao)
            {
                Console.Write(item + " ");
            }
        }
    }
}
