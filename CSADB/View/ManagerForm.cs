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
    public partial class ManagerForm : MaterialForm
    {
        string login;
        Form parent;
        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(string login, Form parent) : this()
        {
            this.login = login;
            this.parent = parent;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            Text = "Здравствуйте, " + login;
            courierListView.Columns[0].Width = 100;
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
