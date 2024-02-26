using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjetoIEFPMusic
{
    public partial class CadastrarMusica : Form
    {
        //Listas a partir das listas de Bandas e Músicas já existente.

        List<Banda> listaBandas;
        List<Musica> listaMusicas;

        public CadastrarMusica(List<Musica> musicas, List<Banda> bandas) //Argumento para chamar as Listas de bandas e musicas
        {
            InitializeComponent();

            listaBandas = bandas;
            listaMusicas = musicas;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            //Instanciar a partir do valor inserido pelo utilizador no campo "nomeMusica.Text"
            Musica m1 = new Musica(nomeMusica.Text);

            nomeMusica.Text = m1.Nome;

            //Localizar o nome da Banda a partir do valor inserido pelo utilizador
            //no campo "nomeBanda.Text"

            Banda musicaDaBanda = listaBandas.Find(listaBandas => listaBandas.Nome == nomeBanda.Text);

            //Variável booleana para verificar se a música já está cadastrada
            bool validarMusica = true;


            //Laço de repetição para percorrer a Lista de musicas e identificar
            //se o valor já está armanenado na lista

            for (int i = 0; i < listaMusicas.Count; i++)
            {
                if (listaMusicas[i].Nome == m1.Nome)
                {
                    MessageBox.Show($"A música {m1.Nome} já está adicionada para o artista !");

                    validarMusica = false;
                }
            }

            // Se não houver alteração da variável booleana após percorrer a lista de musicas,
            // a música é adicionada para a banda que foi declarada na variável "musicaDaBanda"

            if (validarMusica == true)
                {
                if (musicaDaBanda.adicionarMusica(m1))
                {

                    listaMusicas.Add(m1);
                    MessageBox.Show($"A musica {m1.Nome} foi adicionada com sucesso para o artista!");
                }
                }
            

            nomeBanda.Clear();
            nomeMusica.Clear();
            nomeBanda.Focus(); 

          

        }

        private void nomeMusica_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarMusica_Load(object sender, EventArgs e)
        {

        }
    }
}
