using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{


    public partial class Form1 : Form
    {
        char currentPlayer = 'X';
        PictureBox[,] plansza;
        bool wygrany = false;
        bool gracz = true;
        int rundy = 0;

        public Form1()
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            plansza = new PictureBox[3, 3] {
                { a1, a2, a3 },
                { b1, b2, b3 },
                { c1, c2, c3 }
            };
        }



        private void Form1_Load(object sender, EventArgs e)
        {
         

            welcome welcome = new welcome();
            welcome.StartPosition = FormStartPosition.CenterScreen;
            DialogResult result = welcome.ShowDialog();
            if (result == DialogResult.OK)
            {
                //label2.Text = welcome.value;
                gracz = true;
                pictureBox10.Image = Properties.Resources.untildet1;
            }
            else
            {
                pictureBox10.Image = Properties.Resources.untilted3;
                gracz = false;
            }



        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            rundy++;
       

            if (b.Image == null)
            {
                if (gracz == true)
                {
                    
                    pictureBox10.Image = Properties.Resources.untilted3;
                    b.Image = Properties.Resources.Untitled;
                    b.Name = "x";

                }
                else
                {

                    pictureBox10.Image = Properties.Resources.untildet1;
                    b.Image = Properties.Resources.untilted2;
                    b.Name = "o";
                }

                if (wygrana())
                {
                    if (gracz)
                    {
                        MessageBox.Show("wygral krzyzyk");
                        blokada();
                    }
                    else
                    {
                        blokada();
                        MessageBox.Show("wygral kolko");
                    }
                }
                else if (rundy >= 9)
                {
                    MessageBox.Show("draw");
                }
                else
                {
                    gracz = !gracz;
                }

            }



            b.Enabled = false;


            


            //b = plansza[1, 1];


        }




        void blokada()
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    plansza[i, j].Enabled = false;
                }
            }
        }

            bool wygrana()
            {
                for (int i = 0; i < 3; i++)
                {

                    if (plansza[i, 0].Name != null &&
                        plansza[i, 0].Name == plansza[i, 1].Name &&
                        plansza[i, 0].Name == plansza[i, 2].Name)
                    {
                        return true;
                    }
                }


                for (int j = 0; j < 3; j++)
                {
                    if (plansza[0, j].Name != null &&
                        plansza[0, j].Name == plansza[1, j].Name &&
                        plansza[0, j].Name == plansza[2, j].Name)
                    {
                        return true;
                    }
                }


                if (plansza[0, 0].Name != null &&
                    plansza[0, 0].Name == plansza[1, 1].Name &&
                    plansza[0, 0].Name == plansza[2, 2].Name)
                {
                    return true;
                }

                if (plansza[0, 2].Name != null &&
                    plansza[0, 2].Name == plansza[1, 1].Name &&
                    plansza[0, 2].Name == plansza[2, 0].Name)
                {
                    return true;
                }

                return false;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void a1_MouseHover(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            if (a.Image == null)
            {
                a.Cursor = Cursors.Hand;
            }
            else
            {
                a.Cursor = Cursors.Default;
            }
        }
    }
    }
