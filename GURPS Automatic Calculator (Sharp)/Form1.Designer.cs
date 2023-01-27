namespace GURPS_Automatic_Calculator__Sharp_
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.characterCreate = new System.Windows.Forms.Button();
            this.addCharacter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.characterDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(106, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GURPS Automated Calculator";
            // 
            // characterCreate
            // 
            this.characterCreate.Location = new System.Drawing.Point(111, 93);
            this.characterCreate.Name = "characterCreate";
            this.characterCreate.Size = new System.Drawing.Size(100, 40);
            this.characterCreate.TabIndex = 1;
            this.characterCreate.Text = "Create A New Character";
            this.characterCreate.UseVisualStyleBackColor = true;
            this.characterCreate.Click += new System.EventHandler(this.characterCreate_Click);
            // 
            // addCharacter
            // 
            this.addCharacter.Location = new System.Drawing.Point(217, 93);
            this.addCharacter.Name = "addCharacter";
            this.addCharacter.Size = new System.Drawing.Size(100, 40);
            this.addCharacter.TabIndex = 2;
            this.addCharacter.Text = "Add A Character From A Text File";
            this.addCharacter.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(323, 93);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 40);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // characterDirectory
            // 
            this.characterDirectory.Description = "Make a new folder to store your character sheet";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.addCharacter);
            this.Controls.Add(this.characterCreate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GURPS Automatic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button characterCreate;
        private System.Windows.Forms.Button addCharacter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.FolderBrowserDialog characterDirectory;
    }
}

