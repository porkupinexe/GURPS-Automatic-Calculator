using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GURPS_Automatic_Calculator__Sharp_
{
    public partial class AttackCalculator : Form
    {


        public AttackCalculator()
        {
            InitializeComponent();
        }
        
       

        private void chkAim_CheckedChanged(object sender, EventArgs e)
        {
            if (numAim.Enabled == false)
            {
                numAim.Enabled = true;
            }
            else
            {
                numAim.Enabled = false;
            }
        }

        private void chkIntervningFigure_CheckedChanged(object sender, EventArgs e)
        {
            if (numInterveningFigures.Enabled == false)
            {
                numInterveningFigures.Enabled = true;
            }
            else
            {
                numInterveningFigures.Enabled = false;
            }
        }

        private void chkRapidFire_CheckedChanged(object sender, EventArgs e)
        {
            if (numRapidFire.Enabled == false)
            {
                numRapidFire.Enabled = true;
            }
            else
            {
                numRapidFire.Enabled = false;
            }
        }

        private void AttackCalculator_Load(object sender, EventArgs e)
        {
            
            numRapidFire.Maximum = 99999999;
            string gunPath = Properties.Settings.Default.currentGunPath;
            string[] fileNames = Directory.GetFiles(gunPath);
            foreach (string fileName in fileNames)
            {
                cmbGunPicker.Items.Add(Path.GetFileNameWithoutExtension(fileName));
                
            }
            cmbGunPicker.Text = Properties.Settings.Default.equippedGun;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rboxBreakDown.ResetText();
            string gunPath = Properties.Settings.Default.currentGunPath;
            string charPath = Properties.Settings.Default.defaultSheet;
            string fileName = cmbGunPicker.Text;
            string filePath = Path.Combine(gunPath, fileName + ".json");
            Dictionary<string, object> dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(filePath));
            Dictionary<string, object> charSheet = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(charPath));
            int characterST = Convert.ToInt32(charSheet["ST"]);
            int requiredST = Convert.ToInt32(dic["Required ST"]);
            int Acc = Convert.ToInt32(dic["Acc"]);
            bool isCloseRanged = Convert.ToBoolean(dic["Is Close Range"]);
            double saveRange = Convert.ToDouble(numRange.Value) + Convert.ToDouble(numSpeed.Value);
            double rangeMod = Math.Log(saveRange, 10);
            double multiplcation = rangeMod * 6;
            double subtraction = multiplcation - 2;
            double rounded = Math.Round(subtraction, MidpointRounding.ToEven) * -1;
            rboxBreakDown.AppendText(Environment.NewLine + $"Speed/Range Modifier is: -{rounded}");
            double accBonus = 0;
            if(numSM.Value > 0)
            {
                accBonus = accBonus + (double) numSM.Value;
                rboxBreakDown.AppendText(Environment.NewLine+$"The target has a SM of +{numSM.Value}. +{numSM.Value} Accuracy. Accurary Bonus: +{accBonus}");
            }
            else
            {
                rounded = rounded + (double) (numSM.Value*-1);
                rboxBreakDown.AppendText(Environment.NewLine + $"The target has a SM of -{numSM.Value}. -{numSM.Value} Accuracy. Accurary Mod: -{rounded}");
            }
            if (chkisDetermined.Checked)
            {
                accBonus++;
                rboxBreakDown.AppendText(Environment.NewLine + $"You are making an All-out Attack! +1 Accuracy. Accuracy Bonus: +{accBonus}");
            }
            if (chkMoveAndAttack.Checked)
            {
                int Bulk = Convert.ToInt32(dic["Bulk"]);
                if (Bulk > 2)
                {
                    rounded = rounded + (Bulk * -1);
                    rboxBreakDown.AppendText(Environment.NewLine + $"Bulk is {Bulk}! Accuracy Mod: -{rounded}");
                }
                else
                {
                    rounded--;
                    rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"Bulk is less than 2! Accuracy Mod: -{rounded}");
                }
                if (chkBadFooting.Checked)
                {
                    rounded--;
                    rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"You have Bad Footing! -2 Penalty. Accuracy Mod: -{rounded}");
                }
                if ((numRange.Value >= 1) &&( numRange.Value <=2) && isCloseRanged == false)
                {
                    rounded = rounded + (Bulk * -1);
                    rboxBreakDown.AppendText(Environment.NewLine + $"You're too Close! -{Bulk} Penalty. Accuracy Mod: -{rounded}");

                }
                if (chkMajorDistraction.Checked)
                {
                    rounded--;
                    rounded--;
                    rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"You're really disctracted! -3 Penalty. Accuracy Mod: -{rounded}");
                }
                if (chkMinorDistraction.Checked)
                {
                    rounded--;
                    rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"You're a little disctracted! -2 Penalty. Accuracy Mod: -{rounded}");
                }
                if (requiredST >= characterST)
                {
                    rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"You're too puny! -1 Penalty. Accuracy Mod: -{rounded}");

                }
                if (chkBraced.Checked)
                {
                    accBonus++;
                    rboxBreakDown.AppendText(Environment.NewLine + $"Your weapon is Braced! +1 Accuracy. Accuracy Bonus: -{accBonus}");
                }
                if (chkAim.Checked)
                {
                    accBonus = accBonus + Acc;
                    rboxBreakDown.AppendText(Environment.NewLine + $"You Aimed last round! Add your guns Accuracy +{Acc}. Accuracy Bonus: +{accBonus}");
                    if (numAim.Value >= 2)
                    {
                        accBonus++;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You Aimed for at least 2 seconds. +1 Accuracy. Accuracy Bonus: +{accBonus}");
                        
                    }
                    if (numAim.Value >= 3)
                    {
                        accBonus++;
                        accBonus++;
                        rboxBreakDown.AppendText(Environment.NewLine+$"You Aimed For At Least 3 Seconds! +2 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                }
                if (chkRapidFire.Checked)
                {
                    if ((numRapidFire.Value <= 8) && (numRapidFire.Value >= 5))
                    {
                        accBonus++;
                        rboxBreakDown.AppendText(Environment.NewLine+$"You fired {numRapidFire.Value} shots! +1 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                    if ((numRapidFire.Value <= 12) && (numRapidFire.Value >= 9))
                    {
                        accBonus = accBonus + 2;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You fired {numRapidFire.Value} shots! +2 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                    if ((numRapidFire.Value <= 16) && (numRapidFire.Value >= 13))
                    {
                        accBonus = accBonus + 3;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You fired {numRapidFire.Value} shots! +3 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                    if ((numRapidFire.Value <= 24) && (numRapidFire.Value >= 17))
                    {
                        accBonus = accBonus + 4;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You fired {numRapidFire.Value} shots! +4 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                    if ((numRapidFire.Value <= 49) && (numRapidFire.Value >= 25))
                    {
                        accBonus = accBonus + 5;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You fired {numRapidFire.Value} shot! +5 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                    if ((numRapidFire.Value <= 99) && (numRapidFire.Value >= 50))
                    {
                        accBonus = accBonus + 6;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You fired{numRapidFire.Value} shots! +6 Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                    if (numRapidFire.Value >= 100)
                    {
                        accBonus = accBonus + (Math.Round(Convert.ToDouble(numRapidFire.Value / 200), MidpointRounding.ToEven) + 6);
                        int rofBonus = (int)(numRapidFire.Value / 200) + 6;
                        rboxBreakDown.AppendText(Environment.NewLine + $"You fired {numRapidFire.Value} Shots. + {rofBonus} Accuracy. Accuracy Bonus: +{accBonus}");
                    }
                }
                if (chkPosture.Checked)
                {
                    rounded--;
                    rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"The Target is uh... not standing? -2 Penalty. Accuracy Mod: -{rounded}");
                }
                if (chklightCover.Checked)
                {
                    rounded--; rounded--;
                    rboxBreakDown.AppendText(Environment.NewLine + $"Target is behind something thin! -2 Penalty. Accuracy Mod: -{rounded}");
                }
                if (chkConcealment.Checked)
                {
                    rounded--; rounded--; rboxBreakDown.AppendText(Environment.NewLine + $"Target is hiding! -2 Penalty. Accuracy Mod: -{rounded}");
                }
                if (chkIntervningFigure.Checked)
                {
                    rounded = rounded + (double)((numInterveningFigures.Value * 4) * -1);
                    double interveningFigures = (double)(numInterveningFigures.Value * 4) * -1;
                    rboxBreakDown.AppendText(Environment.NewLine + $"There {numInterveningFigures.Value} people between you and the target. -{interveningFigures} Penalty. Accuracy Mod: -{rounded}");
                }
                if( accBonus >= Acc)
                {
                    accBonus = Acc;
                    rboxBreakDown.AppendText(Environment.NewLine + $"Accuracy Bonus exceed selected weapons Base Accuracy! Accuracy Bonus is: {Acc}");
                }
                double finalModifier = rounded + accBonus;
                rboxBreakDown.AppendText(Environment.NewLine + $"Final Modifier: {finalModifier}");

            }


        }
    }
}
