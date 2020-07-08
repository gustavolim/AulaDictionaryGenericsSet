using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDictionaryGenericsSet
{
    public class Dicionario<T>
    {
        public string Chave { get; set; }
        public T Valor { get; set; }

        public List<Dicionario<T>> Dicionarios { get; set; } = new List<Dicionario<T>>();

        public void AddItem(string chave, T valor)
        {
            Dicionarios.Add(new Dicionario<T>
            {
                Chave = chave,
                Valor = valor
            });
        }

    }
}
