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
    public partial class Form1 : Form
    {

        //Método construtor
        List<Banda> bandas = new List<Banda>();
        List<Musica> musicas = new List<Musica>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
       
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        //Método construtor para o Form de Cadastro das Bandas
        private void btnAddBanda_Click(object sender, EventArgs e)
        {
            CadastrarBanda cadastrarBanda = new CadastrarBanda(bandas);
            cadastrarBanda.ShowDialog();
        }

        //Método construtor para o Form de Cadastro das Musicas
        private void btnAddMusica_Click(object sender, EventArgs e)
        {
            CadastrarMusica cadastrarMusica = new CadastrarMusica(musicas,bandas);
            cadastrarMusica.ShowDialog();
        }

        private void btnListarBanda_TextChanged(object sender, EventArgs e)
        {

        }

        //Método construtor para o Form de Listagem das Bandas
        private void btnListarBanda_Click(object sender, EventArgs e)
        {


            ListarBandas listarBandas = new ListarBandas(bandas);
            listarBandas.ShowDialog();
        }

        //Método construtor para o Form de Listagem das Musicas

        private void btnListarMusicas_Click(object sender, EventArgs e)
        {
           ListarMusicas listarMusicas = new ListarMusicas(musicas, bandas);
           listarMusicas.ShowDialog();
        }
    }
}
