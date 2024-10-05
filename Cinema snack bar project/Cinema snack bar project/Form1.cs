using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_snack_bar_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            int corn, water, coke, ticket, total;


            corn = Convert.ToInt16(textcorn.Text);

            water = Convert.ToInt16(textwater.Text);

            ticket = Convert.ToInt16(textticket.Text);

            coke = Convert.ToInt16(textcoke.Text);

            total = corn * 5 + water * 1 + ticket * 12 + coke * 3;

            lbltoplam.Text ="Total : " + total.ToString();

            kasatutar = kasatutar + total;

            lblkasatop.Text = " Total Cash : " + kasatutar.ToString();


            // kasatoplamında çok düşündüm.


        }

        private void Clean_Click(object sender, EventArgs e)
        {


            textcoke.Text = " ";

            textcorn.Text = " ";

            textwater.Text = " ";

            textticket.Text = " ";

            textcorn.Focus();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
