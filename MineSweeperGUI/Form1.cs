using Microsoft.VisualBasic.ApplicationServices;
using MinesweeperClasses;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace MineSweeperGUI
{
    public partial class Form1 : Form
    {
        //instance of the Baord class used to manage the game data
        Board board;
        //2D array of buttons used to represent the game board in the GUI
        Button[,] buttons;
        //reference to FormStartGame
        private FormStartGame formStartGame;

        public Form1(int size, int difficulty, FormStartGame formStartGame = null)
        {
            board = new Board(size, difficulty);
            InitializeComponent();
            //initialize the button array
            buttons = new Button[board.Size, board.Size];

            this.formStartGame = formStartGame;
            SetUpButtons();
        }

        private void SetUpButtons()
        {
            //setting up the game boards grid of buttons based on the size of the board
            int buttonSize = panelGameBoard.Width / board.Size;
            //Making it be square
            panelGameBoard.Height = panelGameBoard.Width;

            //Creating buttons to fill the board
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    //creates the button and immediately places it
                    buttons[row, col] = new Button();
                    //Making it square
                    buttons[row, col].Width = buttonSize;
                    buttons[row, col].Height = buttonSize;
                    buttons[row, col].Left = col * buttonSize;
                    buttons[row, col].Top = row * buttonSize;
                    //creating an event for a button click
                    buttons[row, col].MouseDown += GridButtons_MouseDown;

                    //Tag will store the row and column of the button (can store any property)
                    buttons[row, col].Tag = new Point(row, col);
                    //add the button to the panel
                    buttons[row, col].BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Start.png");
                    buttons[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    panelGameBoard.Controls.Add(buttons[row, col]);

                }
            }
        }

        private void GridButtons_MouseDown(object sender, MouseEventArgs e)
        {

            Button clickedButton = sender as Button;
            Point position = (Point)clickedButton.Tag;
            int row = position.X;
            int col = position.Y;
            Cell cell = board.Cells[row, col];

            if (e.Button == MouseButtons.Right)
            {
                cell.IsVisited = true;
                //take away flag if it was already flagged
                if (cell.IsFlag)
                {
                    cell.IsFlag = false;
                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Start.png");
                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (cell.IsBomb)
                {
                    cell.IsFlag = true;
                    cell.IsVisited = false;
                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Flag.png");
                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    cell.IsFlag = true;
                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Flag.png");
                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                }

            }
            else
            {
                if (clickedButton != null)
                {
                    if (!cell.IsVisited)
                    {
                        if (cell.IsBomb)
                        {
                            clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Skull.png");
                            clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                            MessageBox.Show("Boom! You lost.");
                        }
                        else
                        {
                            if (cell.AdjacentBombs == 0)
                            {
                                board.FloodFill(row, col);
                                PrintFloodFill();
                            }
                            else
                            {
                                cell.IsVisited = true;
                                if (cell.AdjacentBombs == 1)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\1.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                else if (cell.AdjacentBombs == 2)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\2.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                else if (cell.AdjacentBombs == 3)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\3.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                                else if (cell.AdjacentBombs == 4)
                                {
                                    clickedButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\4.png");
                                    clickedButton.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                            }

                            // Check if the game is won
                            if (board.DetermineGameStatus(board, row, col) == 3)
                            {
                                MessageBox.Show("Congratulations, you won!");
                            }
                        }
                    }
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            formStartGame.CreatingNewGame();

            this.Close();
        }
        private void PrintFloodFill()
        {

            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    Cell cell = board.Cells[row, col];
                    if (cell.IsVisited && cell.AdjacentBombs == 0)
                    {
                        buttons[row, col].BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\Images\\Tile .png");
                        buttons[row, col].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }
        System.Timers.Timer Timer;
        int m, s;


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }
    }

}

