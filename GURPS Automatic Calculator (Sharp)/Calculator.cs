using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GURPS_Automatic_Calculator__Sharp_
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        string gunPath = Properties.Settings.Default.currentGunPath;

        private void Calculator_Load(object sender, EventArgs e)
        {
            string[] ammoEntries = Directory.GetFiles(Properties.Settings.Default.ammPath);
            foreach (string ammoEntry in ammoEntries)
            {

            }
            string[] fileEntries = Directory.GetFiles(gunPath);
            foreach (string fileName in fileEntries)
            {
                cmbGunPicker.Items.Add(Path.GetFileNameWithoutExtension(fileName));
            }
            
            string path = Properties.Settings.Default.defaultSheet;
            Dictionary<string, object> dic = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(path));
            foreach (KeyValuePair<string, object> kvp in dic)
            {
                rboxCharacterSheet.AppendText(Environment.NewLine + $"{kvp.Key}: {kvp.Value}");

            }



        }

        private void cmbGunPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.equippedGun = cmbGunPicker.Text;
            string fileName = cmbGunPicker.SelectedItem.ToString();
            string filePath = Path.Combine(gunPath, fileName + ".json");
            Dictionary<string, object> dic = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(filePath));
            foreach (KeyValuePair<string, object> kvp in dic)
            {
                rboxGunStats.AppendText(Environment.NewLine + $"{kvp.Key}: {kvp.Value}");
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if(cmbGunPicker.SelectedIndex != -1) 
            {
                AttackCalculator attackCalculator = new AttackCalculator();
                attackCalculator.Show();
            }
            else
            {
                MessageBox.Show("Error!\n What are you gonna shoot with numbskull?");
            }
        }
    }
}
