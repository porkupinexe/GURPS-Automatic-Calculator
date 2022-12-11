using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace GURPS_Automatic_Calculator__Sharp_
{

    public partial class GACnewCharacter : Form
    {
       
        public Stream s;
        public object sw;

        public GACnewCharacter()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1= new mainMenu();
            f1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            characterSheet.FileName = txtCharacterName.Text;
            characterSheet.Filter = "Text Files (*.txt|*.txt";
            characterSheet.Title = "Save Your Sheet";
            characterSheet.ShowDialog();


            if (characterSheet.ShowDialog() == DialogResult.OK) 
            {
                string path = Path.GetFullPath(characterSheet.FileName);
                TextWriter txt = new StreamWriter(path);
                txt.Write("Character Name: " + txtCharacterName.Text);
                txt.Write('\n');
                txt.Write("User's name: " + txtuserName.Text);
                txt.Write('\n' + "Primary Attributes");
                txt.Write('\n');
                txt.Write("ST: " + numST.Value);
                txt.Write("\n");
                txt.Write("DX: " + numDX.Value);
                txt.Write("\n");
                txt.Write("IQ: " + numIQ.Value);
                txt.Write("\n");
                txt.Write("HT: " + numHT.Value);
                txt.Write("\n");
                txt.Write("HP Total: " + numHPTotal.Value);
                txt.Write("\n");
                txt.Write("Fatigue Point Total: " + numHPTotal.Value);
                txt.Write("\n");
                txt.Write("Will: " + numWill.Value);
                txt.Write("\n");
                txt.Write("Fright Check: " + numFright.Value);
                txt.Write("\n");
                txt.Write("Perception: " + numPer.Value);
                txt.Write("\n");
                txt.Write("Vision: " + numVision.Value);
                txt.Write("\n");
                txt.Write("Hearing: " + numHearing.Value);
                txt.Write("\n");
                txt.Write("Taste: " + numTaste.Value);
                txt.Write("\n");
                txt.Write("Smell: " + numSmell.Value);
                txt.Write("\n");
                txt.Write("Touch: " + numTouch.Value);
                txt.Write("\n");
                txt.Write("Basic Speed: " + numBasicSpeed.Value);
                txt.Write('\n');
                txt.Write("Basic Move: " + numbasicMove.Value);
                txt.Write("\n");
                txt.Write("Made With The GAC!");
                txt.Close();
                
            }
            
 
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
