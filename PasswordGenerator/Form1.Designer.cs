
namespace PasswordGenerator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GenerationButton = new System.Windows.Forms.Button();
            this.PasswordOutput = new System.Windows.Forms.TextBox();
            this.UppercaseAlphabet = new System.Windows.Forms.CheckBox();
            this.LowercaseAlphabet = new System.Windows.Forms.CheckBox();
            this.Numbers = new System.Windows.Forms.CheckBox();
            this.SpecialCharacters = new System.Windows.Forms.CheckBox();
            this.Binary = new System.Windows.Forms.CheckBox();
            this.UUID = new System.Windows.Forms.CheckBox();
            this.PasswordSize = new System.Windows.Forms.NumericUpDown();
            this.CustomCharactersBox = new System.Windows.Forms.CheckBox();
            this.CustomCharacters = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSize)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerationButton
            // 
            this.GenerationButton.Location = new System.Drawing.Point(156, 156);
            this.GenerationButton.Name = "GenerationButton";
            this.GenerationButton.Size = new System.Drawing.Size(75, 23);
            this.GenerationButton.TabIndex = 0;
            this.GenerationButton.Text = "Generate";
            this.GenerationButton.UseVisualStyleBackColor = true;
            this.GenerationButton.Click += new System.EventHandler(this.GenerationButton_Click);
            // 
            // PasswordOutput
            // 
            this.PasswordOutput.Location = new System.Drawing.Point(90, 203);
            this.PasswordOutput.Name = "PasswordOutput";
            this.PasswordOutput.Size = new System.Drawing.Size(202, 20);
            this.PasswordOutput.TabIndex = 1;
            // 
            // UppercaseAlphabet
            // 
            this.UppercaseAlphabet.AutoSize = true;
            this.UppercaseAlphabet.Location = new System.Drawing.Point(48, 52);
            this.UppercaseAlphabet.Name = "UppercaseAlphabet";
            this.UppercaseAlphabet.Size = new System.Drawing.Size(47, 17);
            this.UppercaseAlphabet.TabIndex = 2;
            this.UppercaseAlphabet.Text = "ABC";
            this.UppercaseAlphabet.UseVisualStyleBackColor = true;
            this.UppercaseAlphabet.CheckedChanged += new System.EventHandler(this.UppercaseAlphabet_CheckedChanged);
            // 
            // LowercaseAlphabet
            // 
            this.LowercaseAlphabet.AutoSize = true;
            this.LowercaseAlphabet.Location = new System.Drawing.Point(48, 75);
            this.LowercaseAlphabet.Name = "LowercaseAlphabet";
            this.LowercaseAlphabet.Size = new System.Drawing.Size(44, 17);
            this.LowercaseAlphabet.TabIndex = 3;
            this.LowercaseAlphabet.Text = "abc";
            this.LowercaseAlphabet.UseVisualStyleBackColor = true;
            this.LowercaseAlphabet.CheckedChanged += new System.EventHandler(this.LowercaseAlphabet_CheckedChanged);
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Location = new System.Drawing.Point(48, 98);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(44, 17);
            this.Numbers.TabIndex = 4;
            this.Numbers.Text = "123";
            this.Numbers.UseVisualStyleBackColor = true;
            this.Numbers.CheckedChanged += new System.EventHandler(this.Numbers_CheckedChanged);
            // 
            // SpecialCharacters
            // 
            this.SpecialCharacters.AutoSize = true;
            this.SpecialCharacters.Location = new System.Drawing.Point(48, 121);
            this.SpecialCharacters.Name = "SpecialCharacters";
            this.SpecialCharacters.Size = new System.Drawing.Size(41, 17);
            this.SpecialCharacters.TabIndex = 5;
            this.SpecialCharacters.Text = "!§$";
            this.SpecialCharacters.UseVisualStyleBackColor = true;
            this.SpecialCharacters.CheckedChanged += new System.EventHandler(this.SpecialCharacters_CheckedChanged);
            // 
            // Binary
            // 
            this.Binary.AutoSize = true;
            this.Binary.Location = new System.Drawing.Point(156, 52);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(44, 17);
            this.Binary.TabIndex = 6;
            this.Binary.Text = "010";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.CheckedChanged += new System.EventHandler(this.Binary_CheckedChanged);
            // 
            // UUID
            // 
            this.UUID.AutoSize = true;
            this.UUID.Location = new System.Drawing.Point(156, 75);
            this.UUID.Name = "UUID";
            this.UUID.Size = new System.Drawing.Size(41, 17);
            this.UUID.TabIndex = 7;
            this.UUID.Text = "2-e";
            this.UUID.UseVisualStyleBackColor = true;
            this.UUID.CheckedChanged += new System.EventHandler(this.UUID_CheckedChanged);
            // 
            // PasswordSize
            // 
            this.PasswordSize.Location = new System.Drawing.Point(48, 26);
            this.PasswordSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PasswordSize.Name = "PasswordSize";
            this.PasswordSize.Size = new System.Drawing.Size(47, 20);
            this.PasswordSize.TabIndex = 9;
            // 
            // CustomCharactersBox
            // 
            this.CustomCharactersBox.AutoSize = true;
            this.CustomCharactersBox.Location = new System.Drawing.Point(251, 53);
            this.CustomCharactersBox.Name = "CustomCharactersBox";
            this.CustomCharactersBox.Size = new System.Drawing.Size(15, 14);
            this.CustomCharactersBox.TabIndex = 10;
            this.CustomCharactersBox.UseVisualStyleBackColor = true;
            this.CustomCharactersBox.CheckedChanged += new System.EventHandler(this.CustomCharactersBox_CheckedChanged);
            // 
            // CustomCharacters
            // 
            this.CustomCharacters.Location = new System.Drawing.Point(272, 50);
            this.CustomCharacters.Name = "CustomCharacters";
            this.CustomCharacters.Size = new System.Drawing.Size(100, 20);
            this.CustomCharacters.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.CustomCharacters);
            this.Controls.Add(this.CustomCharactersBox);
            this.Controls.Add(this.PasswordSize);
            this.Controls.Add(this.UUID);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.SpecialCharacters);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.LowercaseAlphabet);
            this.Controls.Add(this.UppercaseAlphabet);
            this.Controls.Add(this.PasswordOutput);
            this.Controls.Add(this.GenerationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainWindow";
            this.Text = "PasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerationButton;
        private System.Windows.Forms.TextBox PasswordOutput;
        private System.Windows.Forms.CheckBox UppercaseAlphabet;
        private System.Windows.Forms.CheckBox LowercaseAlphabet;
        private System.Windows.Forms.CheckBox Numbers;
        private System.Windows.Forms.CheckBox SpecialCharacters;
        private System.Windows.Forms.CheckBox Binary;
        private System.Windows.Forms.CheckBox UUID;
        private System.Windows.Forms.NumericUpDown PasswordSize;
        private System.Windows.Forms.CheckBox CustomCharactersBox;
        private System.Windows.Forms.TextBox CustomCharacters;
    }
}

