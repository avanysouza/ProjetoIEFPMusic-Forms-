using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjetoIEFPMusic
{
    public partial class ListarBandas : Form
    {
        //Lista a partir da lista de Bandas já existente.
        List<Banda> listaBandas;
        public ListarBandas(List<Banda> bandas) //Argumento para chamar a Lista de bandas
        {
            listaBandas = bandas;


            InitializeComponent();

            ExibirBandas();  //Método para exibir a lista de Bandas quando a Classe for inicializada
        }

        //Método para exibir as bandas
        private void ExibirBandas()
        {
     

            // Laço de repetição para percorrer a lista de bandas e apresentar na listbox os valores.
            foreach (var item in listaBandas)
            {
                listBox1.Items.Add($"{item.Nome}");
            }
        }

        private void ListarBandas_Load(object sender, EventArgs e)
        {
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
