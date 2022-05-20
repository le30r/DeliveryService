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
    public partial class ClientForm : MaterialForm
    {
        Users user;
        Client client;

        Controller controller = Controller.GetInstance();
        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(Users user)
        {
            InitializeComponent();
            this.user = user;
            client = controller.GetClientByID(user.ID);
            this.Text = client.LastName + " " + client.FirstName + " " + client.MiddleName;
            LoadTables();
        }

        private void LoadTables()
        {
           var deliveries = controller.GetDeliveryList(client);
           foreach (Delivery delivery in deliveries)
            {
                var status = controller.GetStatus(delivery.DeliveryStatus.Value);
                var tariff = controller.GetTariff(delivery.Tariff.Value);

                string[] data = new[] { delivery.DeliveryID.ToString(), status.StatusName, tariff.TariffName, 
                    tariff.Rate.ToString()};
                deliveryTable.Items.Add(new ListViewItem(data));
                
            }
        }

        private void deliveryTable_DoubleClick(object sender, EventArgs e)
        {
            if (deliveryTable.SelectedItems.Count > 0)
            {
                ListViewItem item = deliveryTable.SelectedItems[0];

                Delivery delivery = controller.GetDeliveryById(Convert.ToInt64(item.SubItems[0].Text));
                var form = new DeliveryDetailsForm(delivery);
                form.Show();
            }
        }
    }
}
