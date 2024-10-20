using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class FormStartGame : Form
    {
        int size = 10;
        int difficulty = 1;
        public FormStartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(size, difficulty, this);
            frm.ShowDialog();
                    

        }

        private void rButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 3;
        }

        private void rButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 2;
        }

        private void rButtonEasy_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 1;
        }

        private void rButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            size = 10;
        }

        private void rButtonMSize_CheckedChanged(object sender, EventArgs e)
        {
            size = 14;
        }

        private void rButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            size = 18;
        }
        public void CreatingNewGame()
        {
            //reset all radio buttons to be unchecked
            rButtonEasy.Checked = false;
            rButtonHard.Checked = false;
            rButtonMedium.Checked = false;
            rButtonSmall.Checked = false;
            rButtonMSize.Checked = false;
            rButtonLarge.Checked = false;
        }
    }
}
