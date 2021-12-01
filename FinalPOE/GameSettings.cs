using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalPOE
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        GameEngine engine;

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();

            gameWindow.FormClosed += GameWindow_FormClosed;

            gameWindow.Text = lblTitle.Text + "(POE) : Game";

            //iV = initial Values.
            try
            {
                int[] iV = new int[]
                {
                int.Parse(txtMinHeight.Text),//0
                int.Parse(txtMinWidth.Text),//1
                int.Parse(txtMaxHeight.Text),//2
                int.Parse(txtMaxWidth.Text),//3
                int.Parse(txtNumEnemies.Text),//4
                int.Parse(txtNumGold.Text)//5
                };

                //int minH, int minW, int maxH, int maxW, int nEnemy
                gameWindow.InitialiseGame(iV[0], iV[1], iV[2], iV[3], iV[4], iV[5]);

                Hide();

                gameWindow.Show();
            }
            catch(Exception)
            {
                lblError.Text = "Please review your entries, there should only be numbers, no decimals, no blanks.";
            }
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e){Close();}

        private void btnLoad_Click(object sender, EventArgs e)
        {
            engine = new GameEngine();

            try
            {
                engine.Load();
            }
            catch (System.IO.FileNotFoundException)
            {
                lblError.Text = "Could not find any save game files";
                return;
            }

            GameWindow gameWindow = new GameWindow();

            gameWindow.FormClosed += GameWindow_FormClosed;

            gameWindow.Text = lblTitle.Text + "(POE) : Game";

            gameWindow.InitialiseGame(engine);

            Hide();

            gameWindow.Show();
        }
    }
}
