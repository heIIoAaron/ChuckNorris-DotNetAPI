using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGenerateJoke_Click(object sender, EventArgs e)
        {
             Joke joke = await ChuckNorrisClient.GetRandomJoke();
            DisplayJoke.Text = joke.JokeText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> category = await ChuckNorrisClient.GetCategories();
            foreach(var c in category)
            {
                cboGetCategory.Items.Add(c);
            }
        }
    }
}
