using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjetoIEFPMusic
{
    public partial class ListarMusicas : Form
    {
        //Lista a partir da lista de Bandas e Musicas já existentes.

        List<Banda> listaBandas;
        List<Musica> listaMusicas;
        public ListarMusicas(List<Musica> musicas, List<Banda> bandas) //Argumento para chamar a Lista de bandas e de musicas
        {
            InitializeComponent();

            listaBandas = bandas;
            listaMusicas = musicas;

        }

        //Método para exibir as músicas
        private void ExibirMusicas()
        {
            string nome = Convert.ToString(nomeBanda.Text);

            //Localizar na lista apenas os artistas com o nome igua ao valor inserido pelo utilizador
            Banda banda = listaBandas.Find(b => b.Nome == nome);

            //Condição para consultar apenas as musicas da banda conforme o valor inserido na TextBox

            if (banda != null)
            {
                if (banda.musicas.Count > 0)
                {
                    foreach (var musica in banda.musicas)
                    {
                        listBox1.Items.Add($"{musica.Nome}");
                    }
                }
                else
                {
                    MessageBox.Show($"Artista sem musica no sistema!");

                }
            } else {
                        MessageBox.Show($"Artista não cadastrado no sistema!");
                    }

        }
       
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ExibirMusicas();

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpar o campo de nome da banda e do listbox
            nomeBanda.Clear();
            listBox1.Items.Clear();
        }

        private void nomeBanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListarMusicas_Load(object sender, EventArgs e)
        {

        }
    }
}
