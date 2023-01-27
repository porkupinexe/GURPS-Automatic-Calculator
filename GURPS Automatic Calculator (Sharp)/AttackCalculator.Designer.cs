namespace GURPS_Automatic_Calculator__Sharp_
{
    partial class AttackCalculator
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
            this.lblRange = new System.Windows.Forms.Label();
            this.numRange = new System.Windows.Forms.NumericUpDown();
            this.chkAim = new System.Windows.Forms.CheckBox();
            this.lblAim = new System.Windows.Forms.Label();
            this.numAim = new System.Windows.Forms.NumericUpDown();
            this.lblSM = new System.Windows.Forms.Label();
            this.numSM = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.chkSuppression = new System.Windows.Forms.CheckBox();
            this.chkMoveAndAttack = new System.Windows.Forms.CheckBox();
            this.chkRapidFire = new System.Windows.Forms.CheckBox();
            this.numRapidFire = new System.Windows.Forms.NumericUpDown();
            this.lblRapidFire = new System.Windows.Forms.Label();
            this.chkEuphoric = new System.Windows.Forms.CheckBox();
            this.chkNausea = new System.Windows.Forms.CheckBox();
            this.cmbPain = new System.Windows.Forms.ComboBox();
            this.chkTipsy = new System.Windows.Forms.CheckBox();
            this.chkHallucinating = new System.Windows.Forms.CheckBox();
            this.chkRetching = new System.Windows.Forms.CheckBox();
            this.chkBadFooting = new System.Windows.Forms.CheckBox();
            this.chkBraced = new System.Windows.Forms.CheckBox();
            this.chkStabilized = new System.Windows.Forms.CheckBox();
            this.chkMajorDistraction = new System.Windows.Forms.CheckBox();
            this.chkMinorDistraction = new System.Windows.Forms.CheckBox();
            this.chkConcealment = new System.Windows.Forms.CheckBox();
            this.cmbVisibility = new System.Windows.Forms.ComboBox();
            this.cmbTargetLocation = new System.Windows.Forms.ComboBox();
            this.chkPosture = new System.Windows.Forms.CheckBox();
            this.chkIntervningFigure = new System.Windows.Forms.CheckBox();
            this.numInterveningFigures = new System.Windows.Forms.NumericUpDown();
            this.lblSelectedGun = new System.Windows.Forms.Label();
            this.cmbGunPicker = new System.Windows.Forms.ComboBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.lblTN = new System.Windows.Forms.Label();
            this.chkisDetermined = new System.Windows.Forms.CheckBox();
            this.chklightCover = new System.Windows.Forms.CheckBox();
            this.rboxBreakDown = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRapidFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterveningFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(9, 69);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(121, 13);
            this.lblRange.TabIndex = 0;
            this.lblRange.Text = "How Far is The Fucker?";
            // 
            // numRange
            // 
            this.numRange.DecimalPlaces = 1;
            this.numRange.Location = new System.Drawing.Point(12, 85);
            this.numRange.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numRange.Name = "numRange";
            this.numRange.Size = new System.Drawing.Size(120, 20);
            this.numRange.TabIndex = 1;
            // 
            // chkAim
            // 
            this.chkAim.AutoSize = true;
            this.chkAim.Location = new System.Drawing.Point(12, 111);
            this.chkAim.Name = "chkAim";
            this.chkAim.Size = new System.Drawing.Size(178, 17);
            this.chkAim.TabIndex = 2;
            this.chkAim.Text = "Are You Aiming At That Fucker?";
            this.chkAim.UseVisualStyleBackColor = true;
            this.chkAim.CheckedChanged += new System.EventHandler(this.chkAim_CheckedChanged);
            // 
            // lblAim
            // 
            this.lblAim.AutoSize = true;
            this.lblAim.Location = new System.Drawing.Point(9, 131);
            this.lblAim.Name = "lblAim";
            this.lblAim.Size = new System.Drawing.Size(80, 13);
            this.lblAim.TabIndex = 4;
            this.lblAim.Text = "For How Long?";
            // 
            // numAim
            // 
            this.numAim.Enabled = false;
            this.numAim.Location = new System.Drawing.Point(12, 148);
            this.numAim.Name = "numAim";
            this.numAim.Size = new System.Drawing.Size(120, 20);
            this.numAim.TabIndex = 5;
            // 
            // lblSM
            // 
            this.lblSM.AutoSize = true;
            this.lblSM.Location = new System.Drawing.Point(9, 171);
            this.lblSM.Name = "lblSM";
            this.lblSM.Size = new System.Drawing.Size(125, 13);
            this.lblSM.TabIndex = 6;
            this.lblSM.Text = "How Big Is That Fucker?";
            // 
            // numSM
            // 
            this.numSM.Location = new System.Drawing.Point(12, 187);
            this.numSM.Name = "numSM";
            this.numSM.Size = new System.Drawing.Size(120, 20);
            this.numSM.TabIndex = 7;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(9, 210);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(130, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "How Fast Is That Fucker?";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(12, 226);
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(120, 20);
            this.numSpeed.TabIndex = 9;
            // 
            // chkSuppression
            // 
            this.chkSuppression.AutoSize = true;
            this.chkSuppression.Location = new System.Drawing.Point(12, 276);
            this.chkSuppression.Name = "chkSuppression";
            this.chkSuppression.Size = new System.Drawing.Size(257, 17);
            this.chkSuppression.TabIndex = 11;
            this.chkSuppression.Text = "I Want Those Fuckers To Stay Low (Suppresion)";
            this.chkSuppression.UseVisualStyleBackColor = true;
            // 
            // chkMoveAndAttack
            // 
            this.chkMoveAndAttack.AutoSize = true;
            this.chkMoveAndAttack.Location = new System.Drawing.Point(12, 299);
            this.chkMoveAndAttack.Name = "chkMoveAndAttack";
            this.chkMoveAndAttack.Size = new System.Drawing.Size(266, 17);
            this.chkMoveAndAttack.TabIndex = 12;
            this.chkMoveAndAttack.Text = "I Want To Go Over There And Shoot Those Fucks";
            this.chkMoveAndAttack.UseVisualStyleBackColor = true;
            // 
            // chkRapidFire
            // 
            this.chkRapidFire.AutoSize = true;
            this.chkRapidFire.Location = new System.Drawing.Point(12, 323);
            this.chkRapidFire.Name = "chkRapidFire";
            this.chkRapidFire.Size = new System.Drawing.Size(300, 17);
            this.chkRapidFire.TabIndex = 13;
            this.chkRapidFire.Text = "One Of These Has Your Name On it. Probably (Rapid Fire)";
            this.chkRapidFire.UseVisualStyleBackColor = true;
            this.chkRapidFire.CheckedChanged += new System.EventHandler(this.chkRapidFire_CheckedChanged);
            // 
            // numRapidFire
            // 
            this.numRapidFire.Enabled = false;
            this.numRapidFire.Location = new System.Drawing.Point(12, 359);
            this.numRapidFire.Name = "numRapidFire";
            this.numRapidFire.Size = new System.Drawing.Size(120, 20);
            this.numRapidFire.TabIndex = 14;
            // 
            // lblRapidFire
            // 
            this.lblRapidFire.AutoSize = true;
            this.lblRapidFire.Location = new System.Drawing.Point(9, 343);
            this.lblRapidFire.Name = "lblRapidFire";
            this.lblRapidFire.Size = new System.Drawing.Size(271, 13);
            this.lblRapidFire.TabIndex = 15;
            this.lblRapidFire.Text = "How Many Times Do You Want To Shoot That Fucker?";
            // 
            // chkEuphoric
            // 
            this.chkEuphoric.AutoSize = true;
            this.chkEuphoric.Location = new System.Drawing.Point(12, 386);
            this.chkEuphoric.Name = "chkEuphoric";
            this.chkEuphoric.Size = new System.Drawing.Size(74, 17);
            this.chkEuphoric.TabIndex = 16;
            this.chkEuphoric.Text = "Euphoria?";
            this.chkEuphoric.UseVisualStyleBackColor = true;
            // 
            // chkNausea
            // 
            this.chkNausea.AutoSize = true;
            this.chkNausea.Location = new System.Drawing.Point(93, 386);
            this.chkNausea.Name = "chkNausea";
            this.chkNausea.Size = new System.Drawing.Size(84, 17);
            this.chkNausea.TabIndex = 17;
            this.chkNausea.Text = "Nauseated?";
            this.chkNausea.UseVisualStyleBackColor = true;
            // 
            // cmbPain
            // 
            this.cmbPain.FormattingEnabled = true;
            this.cmbPain.Location = new System.Drawing.Point(12, 410);
            this.cmbPain.Name = "cmbPain";
            this.cmbPain.Size = new System.Drawing.Size(150, 21);
            this.cmbPain.TabIndex = 18;
            this.cmbPain.Text = "Tell Me Where It Hurts";
            // 
            // chkTipsy
            // 
            this.chkTipsy.AutoSize = true;
            this.chkTipsy.Location = new System.Drawing.Point(184, 386);
            this.chkTipsy.Name = "chkTipsy";
            this.chkTipsy.Size = new System.Drawing.Size(57, 17);
            this.chkTipsy.TabIndex = 19;
            this.chkTipsy.Text = "Tipsy?";
            this.chkTipsy.UseVisualStyleBackColor = true;
            // 
            // chkHallucinating
            // 
            this.chkHallucinating.AutoSize = true;
            this.chkHallucinating.Location = new System.Drawing.Point(12, 438);
            this.chkHallucinating.Name = "chkHallucinating";
            this.chkHallucinating.Size = new System.Drawing.Size(93, 17);
            this.chkHallucinating.TabIndex = 20;
            this.chkHallucinating.Text = "Hallucinating?";
            this.chkHallucinating.UseVisualStyleBackColor = true;
            // 
            // chkRetching
            // 
            this.chkRetching.AutoSize = true;
            this.chkRetching.Location = new System.Drawing.Point(112, 438);
            this.chkRetching.Name = "chkRetching";
            this.chkRetching.Size = new System.Drawing.Size(75, 17);
            this.chkRetching.TabIndex = 21;
            this.chkRetching.Text = "Retching?";
            this.chkRetching.UseVisualStyleBackColor = true;
            // 
            // chkBadFooting
            // 
            this.chkBadFooting.AutoSize = true;
            this.chkBadFooting.Location = new System.Drawing.Point(12, 461);
            this.chkBadFooting.Name = "chkBadFooting";
            this.chkBadFooting.Size = new System.Drawing.Size(89, 17);
            this.chkBadFooting.TabIndex = 22;
            this.chkBadFooting.Text = "Bad Footing?";
            this.chkBadFooting.UseVisualStyleBackColor = true;
            // 
            // chkBraced
            // 
            this.chkBraced.AutoSize = true;
            this.chkBraced.Location = new System.Drawing.Point(112, 461);
            this.chkBraced.Name = "chkBraced";
            this.chkBraced.Size = new System.Drawing.Size(66, 17);
            this.chkBraced.TabIndex = 23;
            this.chkBraced.Text = "Braced?";
            this.chkBraced.UseVisualStyleBackColor = true;
            // 
            // chkStabilized
            // 
            this.chkStabilized.AutoSize = true;
            this.chkStabilized.Location = new System.Drawing.Point(193, 438);
            this.chkStabilized.Name = "chkStabilized";
            this.chkStabilized.Size = new System.Drawing.Size(77, 17);
            this.chkStabilized.TabIndex = 24;
            this.chkStabilized.Text = "Stabilized?";
            this.chkStabilized.UseVisualStyleBackColor = true;
            // 
            // chkMajorDistraction
            // 
            this.chkMajorDistraction.AutoSize = true;
            this.chkMajorDistraction.Location = new System.Drawing.Point(193, 461);
            this.chkMajorDistraction.Name = "chkMajorDistraction";
            this.chkMajorDistraction.Size = new System.Drawing.Size(111, 17);
            this.chkMajorDistraction.TabIndex = 25;
            this.chkMajorDistraction.Text = "Major Distraction?";
            this.chkMajorDistraction.UseVisualStyleBackColor = true;
            // 
            // chkMinorDistraction
            // 
            this.chkMinorDistraction.AutoSize = true;
            this.chkMinorDistraction.Location = new System.Drawing.Point(12, 484);
            this.chkMinorDistraction.Name = "chkMinorDistraction";
            this.chkMinorDistraction.Size = new System.Drawing.Size(111, 17);
            this.chkMinorDistraction.TabIndex = 26;
            this.chkMinorDistraction.Text = "Minor Distraction?";
            this.chkMinorDistraction.UseVisualStyleBackColor = true;
            // 
            // chkConcealment
            // 
            this.chkConcealment.AutoSize = true;
            this.chkConcealment.Location = new System.Drawing.Point(129, 484);
            this.chkConcealment.Name = "chkConcealment";
            this.chkConcealment.Size = new System.Drawing.Size(128, 17);
            this.chkConcealment.TabIndex = 27;
            this.chkConcealment.Text = "Target Is Concealed?";
            this.chkConcealment.UseVisualStyleBackColor = true;
            // 
            // cmbVisibility
            // 
            this.cmbVisibility.FormattingEnabled = true;
            this.cmbVisibility.Location = new System.Drawing.Point(13, 507);
            this.cmbVisibility.Name = "cmbVisibility";
            this.cmbVisibility.Size = new System.Drawing.Size(121, 21);
            this.cmbVisibility.TabIndex = 28;
            this.cmbVisibility.Text = "Visibility Level";
            // 
            // cmbTargetLocation
            // 
            this.cmbTargetLocation.FormattingEnabled = true;
            this.cmbTargetLocation.Location = new System.Drawing.Point(141, 507);
            this.cmbTargetLocation.Name = "cmbTargetLocation";
            this.cmbTargetLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbTargetLocation.TabIndex = 29;
            this.cmbTargetLocation.Text = "Target Limb";
            // 
            // chkPosture
            // 
            this.chkPosture.AutoSize = true;
            this.chkPosture.Location = new System.Drawing.Point(12, 534);
            this.chkPosture.Name = "chkPosture";
            this.chkPosture.Size = new System.Drawing.Size(255, 17);
            this.chkPosture.TabIndex = 30;
            this.chkPosture.Text = "Target Sitting/Crouching/Kneeling/Layin Down?";
            this.chkPosture.UseVisualStyleBackColor = true;
            // 
            // chkIntervningFigure
            // 
            this.chkIntervningFigure.AutoSize = true;
            this.chkIntervningFigure.Location = new System.Drawing.Point(12, 558);
            this.chkIntervningFigure.Name = "chkIntervningFigure";
            this.chkIntervningFigure.Size = new System.Drawing.Size(302, 17);
            this.chkIntervningFigure.TabIndex = 31;
            this.chkIntervningFigure.Text = "Fucks Between You and The Shitlord You Want To Blast?";
            this.chkIntervningFigure.UseVisualStyleBackColor = true;
            this.chkIntervningFigure.CheckedChanged += new System.EventHandler(this.chkIntervningFigure_CheckedChanged);
            // 
            // numInterveningFigures
            // 
            this.numInterveningFigures.Enabled = false;
            this.numInterveningFigures.Location = new System.Drawing.Point(13, 582);
            this.numInterveningFigures.Name = "numInterveningFigures";
            this.numInterveningFigures.Size = new System.Drawing.Size(120, 20);
            this.numInterveningFigures.TabIndex = 32;
            // 
            // lblSelectedGun
            // 
            this.lblSelectedGun.AutoSize = true;
            this.lblSelectedGun.Location = new System.Drawing.Point(9, 29);
            this.lblSelectedGun.Name = "lblSelectedGun";
            this.lblSelectedGun.Size = new System.Drawing.Size(85, 13);
            this.lblSelectedGun.TabIndex = 33;
            this.lblSelectedGun.Text = "Primary Weapon";
            // 
            // cmbGunPicker
            // 
            this.cmbGunPicker.FormattingEnabled = true;
            this.cmbGunPicker.Location = new System.Drawing.Point(13, 45);
            this.cmbGunPicker.Name = "cmbGunPicker";
            this.cmbGunPicker.Size = new System.Drawing.Size(121, 21);
            this.cmbGunPicker.TabIndex = 34;
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(141, 579);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 35;
            this.btnShoot.Text = "Shoot Pls";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(245, 584);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(0, 13);
            this.lblTN.TabIndex = 36;
            // 
            // chkisDetermined
            // 
            this.chkisDetermined.AutoSize = true;
            this.chkisDetermined.Location = new System.Drawing.Point(12, 252);
            this.chkisDetermined.Name = "chkisDetermined";
            this.chkisDetermined.Size = new System.Drawing.Size(237, 17);
            this.chkisDetermined.TabIndex = 37;
            this.chkisDetermined.Text = "I Really Want To Kill That Fuck (Determined)";
            this.chkisDetermined.UseVisualStyleBackColor = true;
            // 
            // chklightCover
            // 
            this.chklightCover.AutoSize = true;
            this.chklightCover.Location = new System.Drawing.Point(274, 534);
            this.chklightCover.Name = "chklightCover";
            this.chklightCover.Size = new System.Drawing.Size(133, 17);
            this.chklightCover.TabIndex = 38;
            this.chklightCover.Text = "Is Behind Light Cover?";
            this.chklightCover.UseVisualStyleBackColor = true;
            // 
            // rboxBreakDown
            // 
            this.rboxBreakDown.Location = new System.Drawing.Point(447, 29);
            this.rboxBreakDown.Name = "rboxBreakDown";
            this.rboxBreakDown.Size = new System.Drawing.Size(434, 499);
            this.rboxBreakDown.TabIndex = 39;
            this.rboxBreakDown.Text = "";
            // 
            // AttackCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 658);
            this.Controls.Add(this.rboxBreakDown);
            this.Controls.Add(this.chklightCover);
            this.Controls.Add(this.chkisDetermined);
            this.Controls.Add(this.lblTN);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.cmbGunPicker);
            this.Controls.Add(this.lblSelectedGun);
            this.Controls.Add(this.numInterveningFigures);
            this.Controls.Add(this.chkIntervningFigure);
            this.Controls.Add(this.chkPosture);
            this.Controls.Add(this.cmbTargetLocation);
            this.Controls.Add(this.cmbVisibility);
            this.Controls.Add(this.chkConcealment);
            this.Controls.Add(this.chkMinorDistraction);
            this.Controls.Add(this.chkMajorDistraction);
            this.Controls.Add(this.chkStabilized);
            this.Controls.Add(this.chkBraced);
            this.Controls.Add(this.chkBadFooting);
            this.Controls.Add(this.chkRetching);
            this.Controls.Add(this.chkHallucinating);
            this.Controls.Add(this.chkTipsy);
            this.Controls.Add(this.cmbPain);
            this.Controls.Add(this.chkNausea);
            this.Controls.Add(this.chkEuphoric);
            this.Controls.Add(this.lblRapidFire);
            this.Controls.Add(this.numRapidFire);
            this.Controls.Add(this.chkRapidFire);
            this.Controls.Add(this.chkMoveAndAttack);
            this.Controls.Add(this.chkSuppression);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.numSM);
            this.Controls.Add(this.lblSM);
            this.Controls.Add(this.numAim);
            this.Controls.Add(this.lblAim);
            this.Controls.Add(this.chkAim);
            this.Controls.Add(this.numRange);
            this.Controls.Add(this.lblRange);
            this.Name = "AttackCalculator";
            this.Text = "AttackCalculator";
            this.Load += new System.EventHandler(this.AttackCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRapidFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterveningFigures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.NumericUpDown numRange;
        private System.Windows.Forms.CheckBox chkAim;
        private System.Windows.Forms.Label lblAim;
        private System.Windows.Forms.NumericUpDown numAim;
        private System.Windows.Forms.Label lblSM;
        private System.Windows.Forms.NumericUpDown numSM;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.CheckBox chkSuppression;
        private System.Windows.Forms.CheckBox chkMoveAndAttack;
        private System.Windows.Forms.CheckBox chkRapidFire;
        private System.Windows.Forms.NumericUpDown numRapidFire;
        private System.Windows.Forms.Label lblRapidFire;
        private System.Windows.Forms.CheckBox chkEuphoric;
        private System.Windows.Forms.CheckBox chkNausea;
        private System.Windows.Forms.ComboBox cmbPain;
        private System.Windows.Forms.CheckBox chkTipsy;
        private System.Windows.Forms.CheckBox chkHallucinating;
        private System.Windows.Forms.CheckBox chkRetching;
        private System.Windows.Forms.CheckBox chkBadFooting;
        private System.Windows.Forms.CheckBox chkBraced;
        private System.Windows.Forms.CheckBox chkStabilized;
        private System.Windows.Forms.CheckBox chkMajorDistraction;
        private System.Windows.Forms.CheckBox chkMinorDistraction;
        private System.Windows.Forms.CheckBox chkConcealment;
        private System.Windows.Forms.ComboBox cmbVisibility;
        private System.Windows.Forms.ComboBox cmbTargetLocation;
        private System.Windows.Forms.CheckBox chkPosture;
        private System.Windows.Forms.CheckBox chkIntervningFigure;
        private System.Windows.Forms.NumericUpDown numInterveningFigures;
        private System.Windows.Forms.Label lblSelectedGun;
        private System.Windows.Forms.ComboBox cmbGunPicker;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.CheckBox chkisDetermined;
        private System.Windows.Forms.CheckBox chklightCover;
        private System.Windows.Forms.RichTextBox rboxBreakDown;
    }
}