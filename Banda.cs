using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIEFPMusic
{
    public class Banda
    {
        public string Nome;

        //Declaração da Lista Musicas da Classe Música
        public List<Musica> musicas;

        public Banda(string nome)
        {
            this.Nome = nome;

            //Declaração do atributo "musicas" para cada banda
            musicas = new List<Musica>();
        }

        //Validação lógica (booleano) para adicionar musicas para uma banda.
        public bool adicionarMusica(Musica musica)
        {
            bool verificacao = false;

            if (!musicas.Contains(musica))
            {
                verificacao = true;
                musicas.Add(musica);
            }
            else
            {
                verificacao = false;
            }

            return verificacao;
        }

    }
}
