using System.ComponentModel.Design;
using System.Data;

namespace MinesweeperClasses
{
    public class Board
    {
        public int Size {  get; set; }
        public int Difficulty {  get; set; }  
        public int NumberOfBombs { get; set; } 
        public Cell[,] Cells { get; set; }
       // public DateTime StartTime { get; set; }
        //public DateTime EndTime { get; set; }
        //public enum GameStatus { InProgress, Won, Lost }

        Random random = new Random();

        public Board(int size, int difficulty)
        {
            Size = size;
            Difficulty = difficulty;
            Cells = new Cell[size, size];
            InitializeBoard(difficulty);
        }

        private void InitializeBoard(int difficulty)
        {
            CalculateNumberOfBombs(difficulty);
            SetupCells();
            SetUpBombs();
            FindAdjacentBombs();
          //  StartTime = DateTime.Now;
        }

        private void SetupCells()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
        }

        private void SetUpBombs()
        {
            int BombsPlaced = 0;

            while (BombsPlaced < NumberOfBombs)
            {
                int row = random.Next(Size);
                int column = random.Next(Size);

                if (!Cells[row, column].IsBomb)
                {
                    Cells[row, column].IsBomb = true;
                    BombsPlaced++;
                }
            }
        }

        private int CalculateNumberOfBombs(int difficulty)
        {
            
            //These if statements will set the number of bombs based on the difficulty selected by the player and return it as an int
            if (difficulty == 1)
            {
                NumberOfBombs = 8;
            }
            else if (difficulty == 2)
            {
                NumberOfBombs = 16;
            }
            else if (difficulty == 3)
            {
                NumberOfBombs = 24;
            }
            return NumberOfBombs;
        }

        private void FindAdjacentBombs()
        {
            for (int i = 0; i < Size;i++)
            {
                for (int j = 0;j < Size;j++)
                {
                    if (Cells[i,j].IsBomb)
                    {
                        CountAdjacentBombs(i, j);                   
                    }
                }
            }
        }

        private void CountAdjacentBombs(int i, int j)
        {
            //i-1 goes left 1 cell
            //i+1 goes right 1 cell
            //j-1 goes up 1 cell
            //j+1 goes down 1 cell
            if (i - 1 >= 0)
            {
                var cell = this.Cells[(i - 1), j];
                cell.AdjacentBombs++;
            }
            if (i + 1 < Size)
            {
                var cell = this.Cells[(i + 1), j];
                cell.AdjacentBombs++;
            }
            if (j - 1 >= 0)
            {
                var cell = this.Cells[i, (j-1)];
                cell.AdjacentBombs++;
            }
            if (j + 1 < Size)
            {
                var cell = this.Cells[i, (j +1)];
                cell.AdjacentBombs++;
            }

        }
        public int DetermineGameStatus(Board board, int row, int col)
        {
            int gameStatus = 2;
            //is the game won, still playing or lost
            if (Cells[row, col].IsBomb)
            {
               return 1;
            }
            else
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        // If a non visited cell
                        if (!Cells[i, j].IsVisited)
                        {
                            //if non visited is a bomb continue
                            if (Cells[i, j].IsBomb)
                            {
                               
                            }
                            //if it is not a bomb, the game continues
                            else
                            {
                                return 2;
                            }
                            
                        }                     
                    }                  
                }
              
            }
            return 3;
        }

        public void FloodFill(int row, int col)
        {
            if (row  < 0 || row >= Size || col < 0 || col >= Size)
            {
                return;
            }

            Cell cell = Cells[row, col];

            if (cell.IsBomb)
            {
                return;
            }
            if (cell.AdjacentBombs > 0)
            {
                return;
            }
            if (cell.IsVisited)
            {
                return;
            }
        
            cell.IsVisited = true;
            

            //up
            FloodFill(row - 1, col);
            //down
            FloodFill(row + 1, col);
            //right
            FloodFill(row, col + 1);
            //left
            FloodFill(row, col - 1);
        }
    }
}
