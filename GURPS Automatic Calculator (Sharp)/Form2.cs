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
using System.Text.Json;
using Newtonsoft.Json;

namespace GURPS_Automatic_Calculator__Sharp_
{
    public partial class GACnewCharacter : Form
    {
       
        
        bool saved = false;
       

        public GACnewCharacter()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();
        }
            
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            characterSheet.FileName = txtCharacterName.Text;
            characterSheet.Filter = "Json files | .json";
            characterSheet.Title = " Save Your Sheet ";
            characterSheet.ShowDialog();


            if (characterSheet.ShowDialog() == DialogResult.OK)
            {
                
                
                
                saved = true;
                string path = Path.GetFullPath(characterSheet.FileName);
                Dictionary<string, object> charactersheet = new Dictionary<string, object>()
                {
                    {"Character Name", txtCharacterName.Text},
                    {"User's Name", txtuserName.Text },
                    {"ST", numST.Value},
                    {"DX", numDX.Value}

                };
                
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(charactersheet);
                File.WriteAllText(path, jsonString);
               

            }


        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (saved != false)
            {
                this.Hide();
                Calculator calculator = new Calculator();
                calculator.Show();
            }
            else
            {
                MessageBox.Show("Error!\n Save Something Fucker!");
            }
        }
    }
}
