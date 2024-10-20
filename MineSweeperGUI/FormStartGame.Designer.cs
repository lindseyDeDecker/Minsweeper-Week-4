namespace MineSweeperGUI
{
    partial class FormStartGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rButtonHard = new RadioButton();
            rButtonMedium = new RadioButton();
            rButtonEasy = new RadioButton();
            button1 = new Button();
            groupBox2 = new GroupBox();
            rButtonLarge = new RadioButton();
            rButtonMSize = new RadioButton();
            rButtonSmall = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rButtonHard);
            groupBox1.Controls.Add(rButtonMedium);
            groupBox1.Controls.Add(rButtonEasy);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(190, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose the difficulty";
            // 
            // rButtonHard
            // 
            rButtonHard.AutoSize = true;
            rButtonHard.Location = new Point(14, 140);
            rButtonHard.Margin = new Padding(4);
            rButtonHard.Name = "rButtonHard";
            rButtonHard.Size = new Size(67, 26);
            rButtonHard.TabIndex = 2;
            rButtonHard.TabStop = true;
            rButtonHard.Text = "Hard";
            rButtonHard.UseVisualStyleBackColor = true;
            rButtonHard.CheckedChanged += rButtonHard_CheckedChanged;
            // 
            // rButtonMedium
            // 
            rButtonMedium.AutoSize = true;
            rButtonMedium.Location = new Point(16, 92);
            rButtonMedium.Margin = new Padding(4);
            rButtonMedium.Name = "rButtonMedium";
            rButtonMedium.Size = new Size(94, 26);
            rButtonMedium.TabIndex = 1;
            rButtonMedium.TabStop = true;
            rButtonMedium.Text = "Medium";
            rButtonMedium.UseVisualStyleBackColor = true;
            rButtonMedium.CheckedChanged += rButtonMedium_CheckedChanged;
            // 
            // rButtonEasy
            // 
            rButtonEasy.AutoSize = true;
            rButtonEasy.Location = new Point(17, 45);
            rButtonEasy.Margin = new Padding(4);
            rButtonEasy.Name = "rButtonEasy";
            rButtonEasy.Size = new Size(64, 26);
            rButtonEasy.TabIndex = 0;
            rButtonEasy.TabStop = true;
            rButtonEasy.Text = "Easy";
            rButtonEasy.UseVisualStyleBackColor = true;
            rButtonEasy.CheckedChanged += rButtonEasy_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(157, 221);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 1;
            button1.Text = "Play!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rButtonLarge);
            groupBox2.Controls.Add(rButtonMSize);
            groupBox2.Controls.Add(rButtonSmall);
            groupBox2.Location = new Point(230, 13);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(190, 191);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choose the size of board";
            // 
            // rButtonLarge
            // 
            rButtonLarge.AutoSize = true;
            rButtonLarge.Location = new Point(15, 141);
            rButtonLarge.Margin = new Padding(4);
            rButtonLarge.Name = "rButtonLarge";
            rButtonLarge.Size = new Size(72, 26);
            rButtonLarge.TabIndex = 2;
            rButtonLarge.TabStop = true;
            rButtonLarge.Text = "Large";
            rButtonLarge.UseVisualStyleBackColor = true;
            rButtonLarge.CheckedChanged += rButtonLarge_CheckedChanged;
            // 
            // rButtonMSize
            // 
            rButtonMSize.AutoSize = true;
            rButtonMSize.Location = new Point(17, 93);
            rButtonMSize.Margin = new Padding(4);
            rButtonMSize.Name = "rButtonMSize";
            rButtonMSize.Size = new Size(94, 26);
            rButtonMSize.TabIndex = 1;
            rButtonMSize.TabStop = true;
            rButtonMSize.Text = "Medium";
            rButtonMSize.UseVisualStyleBackColor = true;
            rButtonMSize.CheckedChanged += rButtonMSize_CheckedChanged;
            // 
            // rButtonSmall
            // 
            rButtonSmall.AutoSize = true;
            rButtonSmall.Location = new Point(18, 46);
            rButtonSmall.Margin = new Padding(4);
            rButtonSmall.Name = "rButtonSmall";
            rButtonSmall.Size = new Size(73, 26);
            rButtonSmall.TabIndex = 0;
            rButtonSmall.TabStop = true;
            rButtonSmall.Text = "Small";
            rButtonSmall.UseVisualStyleBackColor = true;
            rButtonSmall.CheckedChanged += rButtonSmall_CheckedChanged;
            // 
            // FormStartGame
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 301);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("Open Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormStartGame";
            Text = "FormStartGame";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rButtonHard;
        private RadioButton rButtonMedium;
        private RadioButton rButtonEasy;
        private Button button1;
        private GroupBox groupBox2;
        private RadioButton rButtonLarge;
        private RadioButton rButtonMSize;
        private RadioButton rButtonSmall;
    }
}