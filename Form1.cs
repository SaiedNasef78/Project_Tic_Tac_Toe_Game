using Project_Tic_Tac_Toe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
           
                                
        }
        
        enum enPlayer
        {
            Player1,
            Player2
                , GameInProgress,
            Draw
        }
        enPlayer PlayerTurn=enPlayer.Player1;
        struct stGameStatus
        {
          public short PlayCount;
            public bool GameOver;
            public enPlayer Winner;

        };
        stGameStatus GameStatus;
       
     
        
      
       private void ResetButton(Button btn)
        {
            btn.Tag = "?";
            btn.Image = Resources.Question2;
            btn.BackColor= Color.Transparent;


        }
        void RestartGame(object sender)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            PlayerTurn=enPlayer.Player1;
            lblTurn.Text = "Player 1";
            LblWinner.Text = "In Progress";
            GameStatus.Winner = enPlayer.GameInProgress;

            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
                



        }
    
       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 15;
            // whitepen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap= System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 400, 300,1200, 300);//Horizonta
            e.Graphics.DrawLine(pen, 400, 500, 1200, 500);//Horizonta

            e.Graphics.DrawLine(pen, 950, 100,950, 700);//Vertical
            e.Graphics.DrawLine(pen, 650, 100, 650, 700);//Vertical





        }
        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch(GameStatus.Winner){

                case enPlayer.Player1:
                    LblWinner.Text = "Player 1";

                    break;
                case enPlayer.Player2:
                    LblWinner.Text = "Player 2";

                    break;

                default:
                    LblWinner.Text = "Draw";
                    break;
            }


            MessageBox.Show("Game Over ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
       public bool CheckValues(Button btn1,Button btn2,Button btn3) 
        {
if (btn1.Tag.ToString()!="?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn2.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
               
                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enPlayer.Player1; 
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;

                }
                else
                {
                   
                    GameStatus.Winner = enPlayer.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;


                }
                GameStatus.GameOver = false;
                return true;
            }

            else
            {
                GameStatus.GameOver = true;
                return false;
            }



                    
        }
      public void CheckWinner()
        {
            //Checked Rows
            //Check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //Check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //Check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //Checked Colums
            //Check Col1
            if (CheckValues(button1, button4, button7))
                return;

            //Check Col2
            if (CheckValues(button2, button5, button8))
                return;

            //Check Col3
            if (CheckValues(button3, button6, button9))
                return;

            //Checked Daionals
            //Check Daigonal 1
            if (CheckValues(button1, button5, button9))
                return;

            //Check Daigonal 2
            if (CheckValues(button3, button5, button7))
                return;

        }
        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:

                        btn.Image = Resources.x;
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        CheckWinner();

                        break;
                    case enPlayer.Player2:

                        GameStatus.PlayCount++;
                        btn.Image = Resources.o;
                        PlayerTurn= enPlayer.Player1;
                        btn.Tag = "O";
                      lblTurn.Text = "Player 1";
                        CheckWinner();
                        break;







                }
                btn.FlatStyle = FlatStyle.Flat;
                if (GameStatus.PlayCount == 9)
                {
                    GameStatus.Winner = enPlayer.Draw;
                    GameStatus.GameOver = true;
                    EndGame();


                }
               

            }
            else
            {
                MessageBox.Show("Wrong Choise", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }











        }
        private void button_Click(object sender, EventArgs e)
        {
            
         ChangeImage((Button)sender);
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button1);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabDraw_Click(object sender, EventArgs e)
        {

        }

        private void LabGameOver_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {

        }

            
        private void BT_Restart_Game_Click(object sender, EventArgs e)
        {
            RestartGame(sender);

        }
    }
}
