using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tictactoe;
namespace tictactoe
{
    public partial class welcome : Form
    {

        string tak = "gadzina";
        public String value
        {
            get
            {
                return tak;
            }
        }
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
          
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           

            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {

           


            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
