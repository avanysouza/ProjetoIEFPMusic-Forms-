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
    public partial class CadastrarBanda : Form
    {
        //Lista a partir da lista de Bandas já existente.
        List<Banda> listaBandas;
        public CadastrarBanda(List<Banda> bandas) //Argumento para chamar a Lista de bandas
        {
            InitializeComponent();

            listaBandas = bandas; 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeBanda_TextChanged(object sender, EventArgs e)
        {

        }

       
        public void adicionarBanda_click(object sender, EventArgs e)
        {
            //Instanciar a partir do valor inserido pelo utilizador no campo "nomeBanda.Text"
            Banda b1 = new Banda(nomeBanda.Text);
            
            nomeBanda.Text = b1.Nome;

            //Variável booleana para verificar se a banda já está cadastrada
            bool validarBanda = true;
           
            //Laço de repetição para percorrer a Lista de bandas e identificar
            //se o valor já está armanenado na lista

            for (int i = 0; i < listaBandas.Count; i++)
            {
                if (listaBandas[i].Nome == b1.Nome)
                {
                    MessageBox.Show($"O artista {b1.Nome} já está adicionado!");

                   validarBanda = false; 
                }
            }

            // Após percorrer a lista de bandas, se não houve alteração no valor da variável booleana,
            // será adicionado um novo item na lista de bandas.

            if(validarBanda == true)
            {
                listaBandas.Add(b1);
            }
          



            nomeBanda.Clear();
            nomeBanda.Focus();
        } 

        private void CadastrarBanda_Load(object sender, EventArgs e)
        {

        }
    }
}
