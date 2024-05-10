using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addPplButton_Click(object sender, EventArgs e)
        {
            if (isValidPeople())
            {

            }
            else
            {
                MessageBox.Show("People is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private People CreatePeople()
        {
            People people = new People()
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Phone = maskedTextBoxPhone.Text,
                Birthday = dateTimePickerBirthDay.Value


            };
        }
        private bool isValidPeople()
        {
            if (String.IsNullOrEmpty(this.textBoxName.Text) || String.IsNullOrWhiteSpace(this.textBoxName.Text))
            {
                textBoxName.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(this.textBoxLastName.Text) || String.IsNullOrWhiteSpace(this.textBoxLastName.Text))
            {
                textBoxLastName.Focus();
                return false;
            }
            if (this.maskedTextBoxPhone.Text.Length < 19 )
            {
                maskedTextBoxPhone.Focus();
                return false;
            }
            if (this.dateTimePickerBirthDay.Value.Date >= DateTime.Now.Date || this.dateTimePickerBirthDay.Value == null)
            {
                dateTimePickerBirthDay.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(this.comboBoxGender.Text) || String.IsNullOrWhiteSpace(this.comboBoxGender.Text))
            {
                comboBoxGender.Focus();
                return false;
            }
            return true;
        }
    }
}
