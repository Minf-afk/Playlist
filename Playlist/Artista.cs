using System;
using System.Collections.Generic;
using System.Text;

namespace Playlist
{
    class Artista
    {
        public Artista(string nome, int idade, DateTime nasc, int rg, int cpf, string endereco)
        {
            NomeCompleto = nome;
            Idade = idade;
            DataDeNascimento = nasc;
            Rg = rg;
            Cpf = cpf;  
            Endereco = endereco;
        }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Rg { get; set; }

        public int Cpf { get; set; }

        public string Endereco { get; set; }
    }
}
