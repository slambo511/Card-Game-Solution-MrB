using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Game_Solution_MrB
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        string[] cardNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        string[] cardColours = { "red", "black", "yellow" };

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.Control && e.KeyCode == Keys.X)

            {
                Application.Exit();
            }

        }
    }
}
