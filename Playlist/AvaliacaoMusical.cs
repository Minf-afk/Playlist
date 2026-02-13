using System;
using System.Collections.Generic;
using System.Text;

namespace Playlist
{
    class AvaliacaoMusical
    {
        public AvaliacaoMusical(string avaliador, int nota, DateTime data, string descricao)
        {
            UsuarioAvaliador = avaliador;
            NotaAvaliadora = nota;
            DataDaAvaliacao = data;
            DescricaoAvaliacao = descricao;
        }
        public string UsuarioAvaliador { get; set; }
        public int NotaAvaliadora { get; set; }
        public DateTime DataDaAvaliacao { get; set; }
        public string DescricaoAvaliacao { get; set; }
    }
}
