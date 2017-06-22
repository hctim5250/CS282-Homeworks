using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Example03
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemons;

        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
        }

        private void createPokemonButton_Click(object sender, EventArgs e)
        {
            string selectedItem = pokemonSelector.Items[pokemonSelector.SelectedIndex].ToString();

            PokemonPanel panel = new PokemonPanel();
            Pokemon pokemon = PokemonFactory.Create(selectedItem);
            pokemons.Add(pokemon);
            int count = pokemons.Count;
            panel.Location = new Point(13 + 202 * (count - 1), 77);
            panel.SetPokemon(pokemon);
            this.Controls.Add(panel);
        }
    }
}