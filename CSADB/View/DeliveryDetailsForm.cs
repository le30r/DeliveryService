using CSADB.Model;
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
    public partial class DeliveryDetailsForm : MaterialForm
    {

        Controller controller = Controller.GetInstance();
        private Delivery delivery;

        public DeliveryDetailsForm()
        {
            InitializeComponent();
        }

        public DeliveryDetailsForm(Delivery delivery)
        {
            this.delivery = delivery;
        }
    }
}
