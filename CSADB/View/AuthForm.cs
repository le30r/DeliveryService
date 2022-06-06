using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSADB.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CSADB.View
{
    public partial class AuthForm : MaterialForm
    {

        Controller controller = Controller.GetInstance();

        public AuthForm()
        {
            InitializeComponent();
            InitializeMaterial();
            
        }

        private void InitializeMaterial()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            var regForm = new RegisterForm(this);
            regForm.Show(this);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Users user = controller.Auth(loginTextBox.Text, passwordTextBox.Text);
            
            
            Form form;
            if (user != null)
            {
                switch (user.AccessLevel.Value)
                {
                    case 0:
                        form = new ClientForm(user, this);
                        this.Hide();
                        form.Show(this);
                        form.Focus();
                        break;
                    case 1:
                        form = new CourierForm(user, this);
                        this.Hide();
                        form.Show(this);
                        form.Focus();
                        break;
                    case 2:
                        form = new ManagerForm(loginTextBox.Text, this);
                        this.Hide();
                        form.Show(this);
                        form.Focus();
                        break;
                    default:
                        break;
                }
            }
            
        }

       

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.DestroyContext();
        }
    }
}
