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

        private void Calculator_Load(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.defaultSheet;
            Dictionary<string, string> dic = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(path));
            lblTest.Text = dic["User's Name"];
            lblCharacterName.Text = dic["Character Name"];
            lblST.Text = dic["ST"];
            lblDX.Text = dic["DX"];
            lblDXST.Text = lblST.Text + lblDX.Text;

        }
    }
}
