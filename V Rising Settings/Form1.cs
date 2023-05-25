using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Rising_Settings
{
    public partial class Form1 : Form
    {
        readonly Form aboutBox;

        public Form1()
        {
            InitializeComponent();
            aboutBox = new AboutBox1();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            RepaintSettings();
        }

        private void RepaintSettings()
        {
            tabSettings.Width = Form1.ActiveForm.Width / 2 - 10;
            tabSettings.Height = Form1.ActiveForm.Height - (45 + menuStrip1.Height);
            tabSettings.Location = new Point(Form1.ActiveForm.Width / 2 - 10, menuStrip1.Height);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Ask to save before exiting.
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             *  TODO
             *  Find default save location (probably Appdata)
             *  Parse JSON
            */
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * TODO
             * Validate JSON
             * backup exiting JSON before overwrite
            */
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox.Show();
        }
    }
}
