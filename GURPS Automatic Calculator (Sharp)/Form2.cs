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
        bool gunPath = false;
        bool ammoPath = false;
        public GACnewCharacter()
        {
            InitializeComponent();
        }

        private void btnAddGun_Click(object sender, EventArgs e)
        {
            {
                if (gunPath == false)
                {
                    gunPath = true;

                    if (gunFolder.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.currentGunPath = gunFolder.SelectedPath;
                    }
                }
                Dictionary<string, object> savedgun = new Dictionary<string, object>()
                    {
                    {"Ranged Weapon", txtRangedWeapon.Text },
                    {"Skill", numSkill.Value},
                    {"Acc", numAcc.Value},
                    {"1/2D Range", numHalfD.Value},
                    {"Max Range", numMaxRange.Value},
                    {"RoF", numRoF.Value},
                    {"Magazine", numMagazine.Value},
                    {"Reload", numReload.Value},
                    {"Bulk", numBulk.Value},
                    {"Recoil", numRecoil.Value},
                    {"Required ST", numSTReq.Value},
                    {"Dice Damage", numDiceDamage.Value},
                    {"Damage Modifier", numDamageMod.Value},
                    {"Armor Divisor", numAD.Value},
                    {"Explosion Dice", numExpDice.Value},
                    {"Explosion Damage Modifier", numExpMod.Value},
                    {"Explosion Armor Divisor", numExpAD.Value},
                    {"Is Explosive", checkExplosive.CheckState},
                    {"Is Burning", checkBurn.CheckState},
                    {"Is Cutting", checkCutting.CheckState},
                    {"Is Corrosive", checkCorrosion.CheckState},
                    {"Is Crushing", checkCrushing.CheckState},
                    {"Effects Fatigue", checkFatigue.CheckState},
                    {"Is Impaling", checkImpaling.CheckState},
                    {"Is Small Piercing", checkSmallPiercing.CheckState},
                    {"Is Normal Piercing", checkNormalPiercing.CheckState},
                    {"Is Large Piercing", checkLargePiercing.CheckState},
                    {"Is Huge Piercing", checkHugePiercing.CheckState},
                    {"Is Toxic", checkToxic.CheckState},
                    {"Is Close Range", chkCloseRange.CheckState }
                    };

                gunSave.FileName = txtRangedWeapon.Text;
                gunSave.InitialDirectory = Properties.Settings.Default.currentGunPath;
                gunSave.Filter = "Json files | .json";
                gunSave.Title = "Save the Gun";
                if (gunSave.ShowDialog() == DialogResult.OK)
                {
                    listGuns.Items.Clear();
                    string path = Path.GetFullPath(gunSave.FileName);
                    string json = JsonConvert.SerializeObject(savedgun);
                    File.WriteAllText(path, json);
                }

                string[] fileEntries = Directory.GetFiles(Properties.Settings.Default.currentGunPath);
                foreach (string fileName in fileEntries)
                {
                    listGuns.Items.Add(Path.GetFileNameWithoutExtension(fileName));
                }

            }
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
            characterSheet.InitialDirectory = Properties.Settings.Default.currentCharDirctory;

            if (characterSheet.ShowDialog() == DialogResult.OK)
            {
                
                
                
                saved = true;
                string path = Path.GetFullPath(characterSheet.FileName);
                Properties.Settings.Default.defaultSheet = path;
                Dictionary<string, object> charactersheet = new Dictionary<string, object>()
                {
                    {"Character Name", txtCharacterName.Text},
                    {"User's Name", txtuserName.Text },
                    {"ST", numST.Value},
                    {"DX", numDX.Value},
                    {"IQ", numIQ.Value},
                    {"HT", numHT.Value },
                    {"HP Total", numHPTotal.Value},
                    {"FP Total", numFPTotal.Value},
                    {"Will", numWill.Value},
                    {"Fight Check", numFright.Value},
                    {"Perception" , numPer.Value},
                    {"Vision", numVision.Value},
                    {"Hearing", numHearing.Value},
                    {"Taste", numTaste.Value},
                    {"Smell", numSmell.Value},
                    {"Touch", numTouch.Value},
                    {"Basic Speed", numBasicSpeed.Value},
                    {"Basic Move", numbasicMove.Value}


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

        private void btnAmmoAdderer_Click(object sender, EventArgs e)
        {
            if ( ammoPath != true)
            {
                ammoPath = true;
            }
            if (ammoFolder.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ammPath = ammoFolder.SelectedPath;
            }
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"Ammunition", txtAmmoName.Text},
                {"Ammo Count", numAmmo.Value }
            };
            ammoCounter.InitialDirectory = ammoFolder.SelectedPath;
            ammoCounter.FileName = txtAmmoName.Text;
            ammoCounter.Title = "Save Your Ammo!";
            if (ammoCounter.ShowDialog() == DialogResult.OK)
            {
                listAmmo.Items.Clear();
                string path = Path.GetFullPath(ammoCounter.FileName);
                Properties.Settings.Default.ammoUPath= path;
                string ammoString = JsonConvert.SerializeObject(data);
                File.WriteAllText(path, ammoString);
            }
            string[] fileNames = Directory.GetFiles(Properties.Settings.Default.ammPath);
            foreach ( string fileName in fileNames )
            {
                listAmmo.Items.Add(Path.GetFileNameWithoutExtension(fileName));
            }
        }

        private void GACnewCharacter_Load(object sender, EventArgs e)
        {
            lblTom.Text = "Hello";
        }
    }
}
