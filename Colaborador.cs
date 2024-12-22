using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Heranca
{
    internal class Colaborador : Pessoa
    {

        // Atributos
        private string? _cargo;
        private double _salario;

        // Construtor
        public Colaborador(string nome, int idade, string cargo, double salario) : base(nome, idade)
        {

            _cargo = cargo;
            _salario = salario;

            ApresentarPessoa();
            ApresentarColaborador();

        }

        // Metodo para apresentar dados
        private void ApresentarColaborador()
        {
            Console.WriteLine($"Cargo: {_cargo}");
            Console.WriteLine($"Salario: {_salario}");
        }

    }
}
