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
    public partial class DeliveryDetailsForm : MaterialForm
    {

        Controller controller = Controller.GetInstance();
        private Delivery delivery;
        private Client client;
        Form parent;

        bool dateTimeChanged = false;
  

        public DeliveryDetailsForm()
        {
            InitializeComponent();
        }

        public DeliveryDetailsForm(Delivery delivery, Client client, Form parent)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            this.parent = parent;
            this.delivery = delivery;
            this.client = client;
            FillFields();

        }

        private void FillFields()
        {

            string postamatAddress = delivery.Postamat != null ? controller.GetPostamatAddress(delivery.Postamat.Value) : "";

            deliveryID.Text = delivery.DeliveryID + "";
            status.Text = controller.GetStatus(delivery.DeliveryStatus.Value).StatusName;

            addressTextBox.Text = client.LastDelivery != null ? client.LastDelivery : "";
            if (delivery.DeliveryStatus.Value < 5)
            {
                parametersExpansion.Visible = true;
            }
            else
            {
                parametersExpansion.Visible = false;
            }


            tariffLabel.Text = controller.GetTariff(delivery.Tariff.Value).TariffName ;
            price.Text = delivery.Price + "";

            parametersExpansion.ValidationButtonEnable = delivery.DeliveryStatus != 5;
            cargosList.Items.Clear();
            var cargos = controller.GetCargos(delivery);
            foreach (var c in cargos)
            {
                var shipper = controller.GetClientByID(c.Shipper).FirstName + " " + controller.GetClientByID(c.Shipper).LastName;
                var gabarites = c.Width + "x" + c.Depth + "x" + c.Height;
                var type = controller.GetCargoTypeById(c.CargoType);
                cargosList.Items.Add(new ListViewItem(new String[] {c.CargoID.ToString(), c.CargoName,
                                                                     shipper, c.CargoWeight + " г.", gabarites, type}));
            }

            cityLabel.Text = delivery.City.CityName;
            
            FillParameters();


        }

        private void FillParameters()
        {
            postamatComboBox.Items.Clear();
            postamatComboBox.Items.AddRange(controller.GetPostamats().ToArray());


            postamatComboBox.Enabled = delivery.Postamat == null;
            postamatCheckBox.Enabled = delivery.Postamat == null && delivery.DeliveryAddress == null;
            postamatCheckBox.Checked = delivery.Postamat != null;
            postamatComboBox.SelectedIndex = delivery.Postamat == null ? -1 : delivery.Postamat.Value;
            deliveryPicker.Enabled = delivery.DeliveryDate == null;

            addressTextBox.Enabled = delivery.DeliveryAddress == null;
            if (delivery.DeliveryAddress != null) addressTextBox.Text = delivery.DeliveryAddress.ToString();


            if (delivery.DeliveryDate != null)
            {
                deliveryPicker.Value = delivery.DeliveryDate.Value + delivery.DeliveryTime.Value;
            }

        }
        

        private void postamatTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if (postamatCheckBox.Checked)
            {
                postamatComboBox.Visible = true;
                addressTextBox.Visible = false;
            }
            else
            {
                postamatComboBox.Visible = false;
                addressTextBox.Visible = true;
            }
        }

        private void parametersExpansion_SaveClick(object sender, EventArgs e)
        {
            if (postamatCheckBox.Checked == true && postamatComboBox.SelectedIndex != -1)
            {
                delivery.Postamat = postamatComboBox.SelectedIndex;
            }
            if (addressTextBox.Text != "") 
            {
                delivery.DeliveryAddress = addressTextBox.Text;
            }
            if (dateTimeChanged)
            {
                delivery.DeliveryTime = deliveryPicker.Value.TimeOfDay;
                delivery.DeliveryDate = deliveryPicker.Value.Date;

            }

            controller.Commit();
        }

        private void deliveryPicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimeChanged = true;
        }

        private void parametersExpansion_PanelExpand(object sender, EventArgs e)
        {
            FillFields();
        }

        private void DeliveryDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Focus();
        }
    }
}
