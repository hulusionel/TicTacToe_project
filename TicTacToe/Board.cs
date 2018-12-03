using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Board : Form
    {      
        bool turn = true;
        int turn_cound=0;
        bool against_computer = false;
        bool sayac = true;
        
        
        public Board()
        {
            InitializeComponent();            
        }

        private void Board_Load(object sender, EventArgs e)
        {           
            pnlButton.Enabled = false;      
        }

        private void button_click(object sender, EventArgs e) //tüm butonların ortak event'i
        {            
            Button b = (Button)sender;
           

            if (turn)
            {
                b.Text = "X";
                sayac = false;
            }
              
            else
            {
                b.Text = "O";
                sayac = true;
            }
                        
            turn = !turn;
            b.Enabled = false;
            if (turn_cound == 0 && b.Enabled==false && against_computer!=true)//ilk karşılıklı oyunda tıklamada süre başlar
                timer.Start();

            turn_cound++;
            checkForWinner();
            

            if ((!turn) && (against_computer)) //"o" ve bilgisayara karşı kontrolleri sağlandığında                 
                computer_make_move(b);            
        }

        private void computer_make_move(Button move)
        {   
            move = ihtimalBak("O"); //kazanma ihtimallerine bak
            if (move == null)
            {
                move = ihtimalBak("X"); //karşı takımı engelleme ihtimallerine bak
                if (move == null)
                {
                    move = koseler(); //engelleme yok ise köşelerden birine koy
                    if (move == null)
                    {
                        move = look_for_open_space();//köşeler doluysa ortaya koy
                    }
                    else { move.PerformClick(); }
                }
                else { move.PerformClick(); }
            }
            else { move.PerformClick(); }

           // move.PerformClick();   //hata kaynağım !!!!!!
           
        }

        private Button look_for_open_space()
        {          
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private Button koseler()
        {            
            if (a1.Text == "O")
            {
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (a3.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (c3.Text == "O")
            {
                if (a1.Text == "")
                    return a3;
                if (a3.Text == "")
                    return a3;
                if (c1.Text == "")
                    return c1;
            }

            if (c1.Text == "O")
            {
                if (a1.Text == "")
                    return a3;
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
            }

            if (a1.Text == "")
                return a1;
            if (a3.Text == "")
                return a3;
            if (c1.Text == "")
                return c1;
            if (c3.Text == "")
                return c3;

            return null;
        }

        private Button ihtimalBak(string mark)
        {
           
            //HORIZONTAL TESTS
            if ((a1.Text == mark) && (a2.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a2.Text == mark) && (a3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (a3.Text == mark) && (a2.Text == ""))
                return a2;

            if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b2.Text == mark) && (b3.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((c1.Text == mark) && (c2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((c2.Text == mark) && (c3.Text == mark) && (c1.Text == ""))
                return c1;
            if ((c1.Text == mark) && (c3.Text == mark) && (c2.Text == ""))
                return c2;

            //VERTICAL TESTS
            if ((a1.Text == mark) && (b1.Text == mark) && (c1.Text == ""))
                return c1;
            if ((b1.Text == mark) && (c1.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (c1.Text == mark) && (b1.Text == ""))
                return b1;

            if ((a2.Text == mark) && (b2.Text == mark) && (c2.Text == ""))
                return c2;
            if ((b2.Text == mark) && (c2.Text == mark) && (a2.Text == ""))
                return a2;
            if ((a2.Text == mark) && (c2.Text == mark) && (b2.Text == ""))
                return b2;

            if ((a3.Text == mark) && (b3.Text == mark) && (c3.Text == ""))
                return c3;
            if ((b3.Text == mark) && (c3.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (c3.Text == mark) && (b3.Text == ""))
                return b3;

            //DIAGONAL TESTS
            if ((a1.Text == mark) && (b2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((b2.Text == mark) && (c3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (c3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((a3.Text == mark) && (b2.Text == mark) && (c1.Text == ""))
                return c1;
            if ((b2.Text == mark) && (c1.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (c1.Text == mark) && (b2.Text == ""))
                return b2;

            return null;
        }

        private void checkForWinner()
        {
            bool isWinner = false;

            //horizontal
            if ((a1.Text == a2.Text) && (a1.Text == a3.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((b1.Text == b2.Text) && (b1.Text == b3.Text) && (!b1.Enabled))
                isWinner = true;
            else if ((c1.Text == c2.Text) && (c1.Text == c3.Text) && (!c1.Enabled))
                isWinner = true;

            //vertical
            else if ((a1.Text == b1.Text) && (a1.Text == c1.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((a2.Text == b2.Text) && (a2.Text == c2.Text) && (!a2.Enabled))
                isWinner = true;
            else if ((a3.Text == b3.Text) && (a3.Text == c3.Text) && (!a3.Enabled))
                isWinner = true;

            //diagonal
            else if ((a1.Text == b2.Text) && (a1.Text == c3.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((a3.Text == b2.Text) && (a3.Text == c1.Text) && (!c1.Enabled))
                isWinner = true;

            if (isWinner)
            {
                disableButtons();
                String winner="";
                if (turn)
                {
                    winner = "O";
                    oCount.Text =(Int32.Parse(oCount.Text) + 1).ToString();
                    timer.Stop();
                }

                else
                {
                    winner = "X";
                    xCount.Text = (Int32.Parse(xCount.Text) + 1).ToString();
                    timer.Stop();
                }
                    

                MessageBox.Show(winner+" Wins!");
            }
            else
            {
                if (turn_cound == 9)
                {
                    MessageBox.Show("Draw!");
                    drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString();
                    timer.Stop();
                }
                    
            }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
        }

        private void refresh() //sahneyi tekrar başlangıca getir
        {
            turn_cound = 0;
            turn = true;
            prBar1.Value = 50;
            sayac = true;   
            
                foreach (Control item in pnlButton.Controls)
                {
                try
                {
                    if (item is Button)
                    {
                        Button b = (Button)item;
                        b.Text = "";
                        b.Enabled = true;
                    }
                }
                catch { }
                }
            timer.Stop();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            refresh();           
            pnlButton.Enabled = true;           
        }
     
        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
            timer.Stop();
            pnlButton.Enabled = true;
            against_computer = true;
        }
       
        private void playerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            refresh();
            pnlButton.Enabled = true;
            against_computer = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sayac == true && prBar1.Value>0)           
                prBar1.Value -= 10;
            
            if(sayac==false && prBar1.Value < 100)
                prBar1.Value += 10;

            if (prBar1.Value == 100)
            {
                timer.Stop();
                pnlButton.Enabled = false;
                xCount.Text = (Int32.Parse(xCount.Text) + 1).ToString();
                MessageBox.Show("Time Out!!! X Win!");
                
            }
            if (prBar1.Value == 0)
            {
                timer.Stop();
                pnlButton.Enabled = false;
                oCount.Text = (Int32.Parse(oCount.Text) + 1).ToString();
                MessageBox.Show("Time Out!!! O Win!");               
            }

        }

       
    }
}
 