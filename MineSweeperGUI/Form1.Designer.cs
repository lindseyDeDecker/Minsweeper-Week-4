namespace MineSweeperGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelGameBoard = new Panel();
            btnNewGame = new Button();
            label1 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            SuspendLayout();
            // 
            // panelGameBoard
            // 
            panelGameBoard.BackColor = Color.LightSteelBlue;
            panelGameBoard.Location = new Point(13, 13);
            panelGameBoard.Margin = new Padding(4);
            panelGameBoard.Name = "panelGameBoard";
            panelGameBoard.Size = new Size(700, 700);
            panelGameBoard.TabIndex = 0;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(772, 353);
            btnNewGame.Margin = new Padding(4);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(161, 62);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(754, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 22);
            label1.TabIndex = 2;
            label1.Text = "Time:";
            // 
            // timer
            // 
            timer.Interval = 750;
            timer.Tick += timer1_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(832, 124);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(55, 22);
            lblTime.TabIndex = 3;
            lblTime.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 1072);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Controls.Add(btnNewGame);
            Controls.Add(panelGameBoard);
            Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelGameBoard;
        private Button btnNewGame;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private Label lblTime;
    }
}
