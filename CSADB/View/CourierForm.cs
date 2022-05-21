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
    public partial class CourierForm : MaterialForm
    {
        Controller controller = Controller.GetInstance();
        Form parent;

        ToolTip toolTip = new ToolTip();

        Users user;
        Courier courier;
        Delivery currentDelivery;
        public CourierForm()
        {
            InitializeComponent();
        }

        public CourierForm(Users user, Form parent)
        {
            InitializeComponent();
            this.parent = parent; 
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            this.user = user;
            FillForm();
        }

        public void FillForm()
        {
            FillInfo();
            FillDelivery();
            FillAvailable();
        }

        private void FillAvailable()
        {
            availableList.ContextMenuStrip = contextMenu;
            acceptDelivery.Click += AcceptDelivery_Click;
            
            var city = courier.City;
            var deliveries = controller.GetFreeDeliveriesyByCity(city);
            availableList.Items.Clear();

            foreach (var delivery in deliveries)
            {
               
                var address = delivery.DeliveryAddress != null ? delivery.DeliveryAddress.ToString() : "";
                var time = delivery.DeliveryTime != null ? delivery.DeliveryTime.ToString() : "";
                var date = delivery.DeliveryDate != null ? delivery.DeliveryDate.ToString() : "";
                bool toxic = delivery.Cargo.Where(x => x.CargoType == 6).Count() > 0;
                bool fragile = delivery.Cargo.Where(x => x.CargoType == 7).Count() > 0;
                bool big = delivery.Cargo.Where(x => x.CargoType == 5).Count() > 0;
                int weight = (int)delivery.Cargo.Sum(x => x.CargoWeight) / 1000;
                availableList.Items.Add(new ListViewItem(new string[]
                {delivery.DeliveryID +"",
                address,
                weight + "",
                time,
                date,
                toxic ? "✓": "✖",
                big ? "✓": "✖",
                fragile ? "✓": "✖"
                }));
            }
        }

        private void AcceptDelivery_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FillDelivery()
        {
            currentDelivery = controller.GetActiveDelivery(courier);
            if (currentDelivery == null)
            {
                activeDeliveryPanel.Enabled = false;
                activeDeliveryPanel.Collapse = true;
                activeDeliveryPanel.Description = "Отсутствует";
                activeDeliveryPanel.ValidationButtonEnable = false;
                carCheckbox.Enabled = true;
                cityCombobox.Enabled = true;
                partnerCompany.Enabled = true;
                infoPanel.ValidationButtonEnable = true;
                deliveriesPanel.Enabled = true;
                deliveriesPanel.Collapse = false;
            }
            else
            {
                activeDeliveryPanel.ValidationButtonEnable = true;
                activeDeliveryPanel.Enabled = true;
                activeDeliveryPanel.Collapse = false;
                carCheckbox.Enabled = false;
                cityCombobox.Enabled = false;
                partnerCompany.Enabled = false;
                infoPanel.ValidationButtonEnable = false;
                deliveriesPanel.Enabled = false;
                deliveriesPanel.Collapse = true;
                FillDeliveryData();

            }
        }

        private void FillDeliveryData()
        {
            cargoList.Clear();
            var cargos = currentDelivery.Cargo;
            float s = 0;
            foreach (Cargo cargo in cargos)
            {
                s += cargo.CargoWeight;

                var storage = cargo.Storage != null ? cargo.Storage + "" : "-";
                var gabarites = cargo.Width + "x" + cargo.Depth + "x" + cargo.Height;
                cargoList.Items.Add(new ListViewItem(new string[]
                {
                        cargo.CargoID + "",
                        storage,
                        cargo.CargoWeight / 1000 + " кг.",
                        gabarites
                }));
            }
            activeDeliveryPanel.Description = "Трек-номер: " + currentDelivery.DeliveryID.ToString();
            weightLabel.Text = (s / 1000).ToString() + " кг.";
            clientLabel.Text = currentDelivery.Client.FirstName + " " + currentDelivery.Client.MiddleName + " " + currentDelivery.Client.LastName;

            if (currentDelivery.DeliveryDate != null)
            {
                dateTime.Text = currentDelivery.DeliveryDate.Value.ToShortDateString() + " " + currentDelivery.DeliveryTime.Value;
            }
            else
            {
                dateTime.Text = "не указано";
            }
            if (currentDelivery.DeliveryAddress != null)
            {
                addressLabel.Text = currentDelivery.DeliveryAddress.ToString();
            }
            else
            {
                addressLabel.Text = "не указан";
            }
        }

        private void FillInfo()
        {
            courier = controller.GetCourierById(user.ID);
            this.Text = "Добро пожаловать, " + courier.FirstName + " "
                                   + courier.MiddleName + " "
                                   + courier.LastName;

            birthdayLabel.Text = courier.Birthday.ToShortDateString() + "г.";
            carCheckbox.Checked = courier.Car;

            cityCombobox.Items.Clear();

            foreach (City city in controller.cities)
            {
                cityCombobox.Items.Add(city.CityName);
            }

            partnerCompany.Items.Clear();
            partnerCompany.Items.AddRange(controller.GetPartnerCompanies().ToArray());

            partnerCompany.SelectedIndex = courier.PartnerCompany != null ? courier.PartnerCompany.Value : -1;
            cityCombobox.SelectedIndex = courier.City;
        }

       

        private void activeDeliveryPanel_SaveClick(object sender, EventArgs e)
        {
            currentDelivery.DeliveryStatus = 5;
            controller.Commit();
            currentDelivery = null;
            FillForm();
        }

        private void infoPanel_SaveClick(object sender, EventArgs e)
        {
            courier.Car = carCheckbox.Checked;
            if (partnerCompany.SelectedIndex != -1)
            {
                courier.PartnerCompany = partnerCompany.SelectedIndex;
            }
            else
            {
                courier.PartnerCompany = null;
            }
           
            courier.City = cityCombobox.SelectedIndex;
            controller.Commit();
            FillForm();

        }

        private void AcceptDelivery_Click(object sender, EventArgs e)
        {
            if (availableList.SelectedItems.Count > 0)
            {
                if (!courier.Car && (Convert.ToInt32(availableList.SelectedItems[0].SubItems[2].Text) > 15 || availableList.SelectedItems[0].SubItems[6].Text == "✓"))
                {
                    MaterialMessageBox.Show("Вы выбрали слишком тяжелый или большой груз, доставить его без автомобиля невозомжно");
                }
                else
                {
                    var delivery = controller.GetDeliveryById(Convert.ToInt64(availableList.SelectedItems[0].SubItems[0].Text));
                    delivery.DeliveryStatus = 4;
                    controller.AddCourierDelivery(courier, delivery);
                    currentDelivery = delivery;
                    FillForm();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            FillDeliveryData();
        }

        private void deliveriesPanel_Click(object sender, EventArgs e)
        {
            FillAvailable();
        }

        private void CourierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            parent.Focus();
        }
    }
}
