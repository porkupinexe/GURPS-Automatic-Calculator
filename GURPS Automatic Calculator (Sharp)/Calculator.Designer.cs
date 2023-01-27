namespace GURPS_Automatic_Calculator__Sharp_
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rboxCharacterSheet = new System.Windows.Forms.RichTextBox();
            this.cmbGunPicker = new System.Windows.Forms.ComboBox();
            this.lblGunPicker = new System.Windows.Forms.Label();
            this.rboxGunStats = new System.Windows.Forms.RichTextBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rboxCharacterSheet
            // 
            this.rboxCharacterSheet.Location = new System.Drawing.Point(12, 12);
            this.rboxCharacterSheet.Name = "rboxCharacterSheet";
            this.rboxCharacterSheet.ReadOnly = true;
            this.rboxCharacterSheet.Size = new System.Drawing.Size(184, 271);
            this.rboxCharacterSheet.TabIndex = 0;
            this.rboxCharacterSheet.Text = "";
            // 
            // cmbGunPicker
            // 
            this.cmbGunPicker.AllowDrop = true;
            this.cmbGunPicker.FormattingEnabled = true;
            this.cmbGunPicker.Location = new System.Drawing.Point(202, 31);
            this.cmbGunPicker.Name = "cmbGunPicker";
            this.cmbGunPicker.Size = new System.Drawing.Size(121, 21);
            this.cmbGunPicker.TabIndex = 1;
            this.cmbGunPicker.Text = "What to Shoot...";
            this.cmbGunPicker.SelectedIndexChanged += new System.EventHandler(this.cmbGunPicker_SelectedIndexChanged);
            // 
            // lblGunPicker
            // 
            this.lblGunPicker.AutoSize = true;
            this.lblGunPicker.Location = new System.Drawing.Point(202, 12);
            this.lblGunPicker.Name = "lblGunPicker";
            this.lblGunPicker.Size = new System.Drawing.Size(78, 13);
            this.lblGunPicker.TabIndex = 2;
            this.lblGunPicker.Text = "Current Firearm";
            // 
            // rboxGunStats
            // 
            this.rboxGunStats.Location = new System.Drawing.Point(202, 58);
            this.rboxGunStats.Name = "rboxGunStats";
            this.rboxGunStats.Size = new System.Drawing.Size(253, 225);
            this.rboxGunStats.TabIndex = 3;
            this.rboxGunStats.Text = "";
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(462, 58);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(326, 225);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Fucking Shoot Something!!!!!!!!!";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(205, 318);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 576);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.rboxGunStats);
            this.Controls.Add(this.lblGunPicker);
            this.Controls.Add(this.cmbGunPicker);
            this.Controls.Add(this.rboxCharacterSheet);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rboxCharacterSheet;
        private System.Windows.Forms.ComboBox cmbGunPicker;
        private System.Windows.Forms.Label lblGunPicker;
        private System.Windows.Forms.RichTextBox rboxGunStats;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}