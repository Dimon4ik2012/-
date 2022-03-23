using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carat
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCase showCase = new ShowCase();
            showCase.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WareHouse wareHouse = new WareHouse();
            wareHouse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListOfProducts listOfProducts = new ListOfProducts();
            listOfProducts.Show();
        }
    }
}
