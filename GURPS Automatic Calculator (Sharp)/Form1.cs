using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GURPS_Automatic_Calculator__Sharp_
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void characterCreate_Click(object sender, EventArgs e)
        {
            if (characterDirectory.ShowDialog() == DialogResult.OK && characterDirectory.SelectedPath != null)
            {

                Properties.Settings.Default.currentCharDirctory = characterDirectory.SelectedPath;
                this.Hide();
                GACnewCharacter f2 = new GACnewCharacter();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error!\nDid you pick a folder Fuckface?");
            }
                
            }


        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
