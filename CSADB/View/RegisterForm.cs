using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSADB.View
{
    public partial class RegisterForm : MaterialForm
    {
        Controller controller = Controller.GetInstance();

        bool pwdCorrect = false;
        public RegisterForm()
        {
            InitializeComponent();
           birthdayPicker.MinDate = DateTime.Now.AddYears(-100);
          birthdayPicker.MaxDate = DateTime.Now.AddYears(-16);
        }

      

        private void CourierSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (CourierSwitch.Checked)
            {
                emailTextBox.Visible = false;
                birthdayPicker.Visible = true;
                birthdayLabel.Visible = true;
                carCheckbox.Visible = true;
                cityCombobox.Visible = true;

            } else { 
                emailTextBox.Visible = true;
                birthdayPicker.Visible = false;
                birthdayLabel.Visible = false;
                carCheckbox.Visible = false;
                cityCombobox.Visible = false;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if  (true)
            {
                bool isCourier = CourierSwitch.Checked;
                controller.Register(lastNameTextBox.Text, nameTextBox.Text, middleNameTextBox.Text,
                  phoneTextBox.Text, emailTextBox.Text, loginTextBox.Text, passwordTextBox.Text, isCourier, 
                   cityCombobox.SelectedIndex, birthdayPicker.Value, carCheckbox.Checked);
            } else
            {
                MaterialMessageBox.Show("Форма заполнена неверно");
            }
              
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != repeatTextBox.Text)
            {
                errorProvider.SetError(repeatTextBox, "Пароли не совпадают");
                pwdCorrect = false;
            }
            else
            {
                errorProvider.Clear();
                pwdCorrect = true;
            }
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = lastNameTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(lastNameTextBox, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(lastNameTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = nameTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(nameTextBox, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(nameTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void carCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = nameTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(middleNameTextBox, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(middleNameTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = nameTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(phoneTextBox, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(phoneTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = nameTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(emailTextBox, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(emailTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (controller.isLoginExists(loginTextBox.Text))
            {
                errorProvider.SetError(loginTextBox, "Логин уже существует!");
                e.Cancel = true;
            } 
            else
            {
                errorProvider.SetError(loginTextBox, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
