using System;
using System.Collections.Generic;
using System.Text;

namespace Playlist
{
    class Album
    {
        public Album(string nome, Artista nomeArtista, DateTime min, string genero, string label)
        {
            NomeAlbum = nome;
            Artista = nomeArtista;
            DataDeLancamento = min;
            Genero = genero;
            Label = label;
        }
        public string NomeAlbum { get; set; }
        public Artista Artista { get; set; }
        public DateTime DataDeLancamento { get; set; }
        public int Duracao { get; set; }
        public string Genero { get; set; }
        public string Label { get; set; }
    }
}
