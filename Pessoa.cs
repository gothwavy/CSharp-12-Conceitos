using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Heranca
{
    internal class Pessoa
    {

        // Atributos
        private string? _nome;
        private int _idade;

        // Construtor
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        // Metodo para apresentar os dados
        protected void ApresentarPessoa()
        {
            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"Idade: {_idade}");
        }

    }
}
