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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblST = new System.Windows.Forms.Label();
            this.lblDX = new System.Windows.Forms.Label();
            this.lblDXST = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(251, 119);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "label1";
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(251, 96);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(35, 13);
            this.lblCharacterName.TabIndex = 1;
            this.lblCharacterName.Text = "label1";
            // 
            // lblST
            // 
            this.lblST.AutoSize = true;
            this.lblST.Location = new System.Drawing.Point(251, 143);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(35, 13);
            this.lblST.TabIndex = 2;
            this.lblST.Text = "label2";
            // 
            // lblDX
            // 
            this.lblDX.AutoSize = true;
            this.lblDX.Location = new System.Drawing.Point(251, 168);
            this.lblDX.Name = "lblDX";
            this.lblDX.Size = new System.Drawing.Size(35, 13);
            this.lblDX.TabIndex = 3;
            this.lblDX.Text = "label1";
            // 
            // lblDXST
            // 
            this.lblDXST.AutoSize = true;
            this.lblDXST.Location = new System.Drawing.Point(254, 185);
            this.lblDXST.Name = "lblDXST";
            this.lblDXST.Size = new System.Drawing.Size(35, 13);
            this.lblDXST.TabIndex = 4;
            this.lblDXST.Text = "label1";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDXST);
            this.Controls.Add(this.lblDX);
            this.Controls.Add(this.lblST);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.lblTest);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Label lblDX;
        private System.Windows.Forms.Label lblDXST;
    }
}