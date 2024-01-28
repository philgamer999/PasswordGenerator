using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainWindow : Form
    {
        string password;
        string characters;
        int passwordLength;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            characters = "";
            passwordLength = Convert.ToInt32(PasswordSize.Value);
            if (UUID.CheckState == CheckState.Checked)
            {
                Guid myuuid = Guid.NewGuid();
                string myuuidAsString = myuuid.ToString();

                password = myuuidAsString;
            }
            else if (Binary.CheckState == CheckState.Checked)
            {
                characters = "01";
                password = PasswordGenerator(passwordLength, characters);
            }
            else if (CustomCharactersBox.CheckState == CheckState.Checked)
            {
                characters = CustomCharacters.Text;
                password = PasswordGenerator(passwordLength, characters);
            }
            else
            {
                if (UppercaseAlphabet.CheckState == CheckState.Checked)
                {
                    characters = characters + "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }

                if (LowercaseAlphabet.CheckState == CheckState.Checked)
                {
                    characters = characters + "abcdefghijklmnopqrstuvwxyz";
                }

                if (Numbers.CheckState == CheckState.Checked)
                {
                    characters = characters + "0123456789";
                }

                if (SpecialCharacters.CheckState == CheckState.Checked)
                {
                    characters = characters + "!§$%&/()=?{}[]-_+#~*;:<>@";
                }

                password = PasswordGenerator(passwordLength, characters);
            }


            PasswordOutput.Text = password;
        }

        private static Random random = new Random();

        public static string PasswordGenerator(int length, string chars)
        {
            //const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #region Checkboxes
        private void Binary_CheckedChanged(object sender, EventArgs e)
        {
            UppercaseAlphabet.CheckState = CheckState.Unchecked;
            LowercaseAlphabet.CheckState = CheckState.Unchecked;
            Numbers.CheckState = CheckState.Unchecked;
            SpecialCharacters.CheckState = CheckState.Unchecked;
            UUID.CheckState = CheckState.Unchecked;
            CustomCharactersBox.CheckState = CheckState.Unchecked;
        }

        private void UUID_CheckedChanged(object sender, EventArgs e)
        {
            UppercaseAlphabet.CheckState = CheckState.Unchecked;
            LowercaseAlphabet.CheckState = CheckState.Unchecked;
            Numbers.CheckState = CheckState.Unchecked;
            SpecialCharacters.CheckState = CheckState.Unchecked;
            Binary.CheckState = CheckState.Unchecked;
            CustomCharactersBox.CheckState = CheckState.Unchecked;
        }

        private void UppercaseAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            Binary.CheckState = CheckState.Unchecked;
            UUID.CheckState = CheckState.Unchecked;
            CustomCharactersBox.CheckState = CheckState.Unchecked;
        }

        private void LowercaseAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            Binary.CheckState = CheckState.Unchecked;
            UUID.CheckState = CheckState.Unchecked;
            CustomCharactersBox.CheckState = CheckState.Unchecked;
        }

        private void Numbers_CheckedChanged(object sender, EventArgs e)
        {
            Binary.CheckState = CheckState.Unchecked;
            UUID.CheckState = CheckState.Unchecked;
            CustomCharactersBox.CheckState = CheckState.Unchecked;
        }

        private void SpecialCharacters_CheckedChanged(object sender, EventArgs e)
        {
            Binary.CheckState = CheckState.Unchecked;
            UUID.CheckState = CheckState.Unchecked;
            CustomCharactersBox.CheckState = CheckState.Unchecked;
        }

        private void CustomCharactersBox_CheckedChanged(object sender, EventArgs e)
        {
            UppercaseAlphabet.CheckState = CheckState.Unchecked;
            LowercaseAlphabet.CheckState = CheckState.Unchecked;
            Numbers.CheckState = CheckState.Unchecked;
            SpecialCharacters.CheckState = CheckState.Unchecked;
            Binary.CheckState = CheckState.Unchecked;
            UUID.CheckState = CheckState.Unchecked;
        }
        #endregion

    }
}
