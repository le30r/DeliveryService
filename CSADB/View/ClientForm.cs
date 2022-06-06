using CSADB.Model;
using MaterialSkin;
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
        Form parent;

        Controller controller = Controller.GetInstance();
        DeliveryDetailsForm deliveryDetails = new DeliveryDetailsForm();
        CheckoutDeliveryForm checkoutDelivery = new CheckoutDeliveryForm();
        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(Users user, Form parent)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            this.user = user;
            this.parent = parent;
            client = controller.GetClientByID(user.ID);
            this.Text = client.LastName + " " + client.FirstName + " " + client.MiddleName;
            LoadTables();
        }

        private void LoadTables()
        {
            deliveryTable.Items.Clear();
           var deliveries = controller.GetDeliveryList(client);
            foreach (Delivery delivery in deliveries)
            {
                var status = controller.GetStatus(delivery.DeliveryStatus.Value);
                var tariff = controller.GetTariff(delivery.Tariff.Value);

                string[] data = new[] { delivery.DeliveryID.ToString(), status.StatusName, tariff.TariffName,
                    delivery.Price.Value + " "};
                deliveryTable.Items.Add(new ListViewItem(data));

            }

            cargoList.ContextMenuStrip = deleteMenu;
            deleteItem.Click += DeleteItem_Click;

            cargoList.Items.Clear();
            var cargos = controller.GetCargos(client.ClientID);
            foreach (Cargo cargo in cargos)
            {
                var delivery = cargo.Delivery.FirstOrDefault();
                string track = cargo.Delivery.FirstOrDefault() != null ? delivery.DeliveryID + "" : "-" ;
                var gabarites = cargo.Width + "x" + cargo.Depth + "x" + cargo.Height;
                cargoList.Items.Add(new ListViewItem(new string[] {cargo.CargoID + "",
                    cargo.CargoName, track, gabarites, cargo.CargoWeight + ""}));
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (cargoList.SelectedItems.Count > 0)
            {
                var cargoId = cargoList.SelectedItems[0].SubItems[0].Text;  
                var cargo = controller.GetCargoById(Convert.ToInt32(cargoId));
                if (cargo.Delivery.Count <= 0)
                {
                    controller.context.Cargo.Remove(cargo);
                    cargoList.Items.RemoveAt(cargoList.SelectedItems[0].Index);

                    controller.Commit();
                }
                else
                {
                    MaterialMessageBox.Show("Удаление груза, находящегося в доставке невозможно");
                }
               
                
            }
        }

        private void deliveryTable_DoubleClick(object sender, EventArgs e)
        {
            if (deliveryTable.SelectedItems.Count > 0)
            {
                ListViewItem item = deliveryTable.SelectedItems[0];

                Delivery delivery = controller.GetDeliveryById(Convert.ToInt64(item.SubItems[0].Text));
                deliveryDetails = new DeliveryDetailsForm(delivery, client, this);
                deliveryDetails.Show();
            }
        }

        

        private void ClientForm_Click(object sender, EventArgs e)
        {
            deliveryDetails.Hide();
            checkoutDelivery.Hide();
        }

        private void createDelivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkoutDelivery = new CheckoutDeliveryForm(client, this);
            if (checkoutDelivery.ShowDialog() == DialogResult.OK)
            {
                LoadTables();
            }
            
        }

        private void cargoType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            parent.Focus();
        }
    }
}
