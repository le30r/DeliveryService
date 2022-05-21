using CSADB.Model;
using Dadata;
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
    public partial class CheckoutDeliveryForm : MaterialForm
    {
        Controller controller = Controller.GetInstance();
        Client shipper;
        Form parent;
        List<Cargo> cargoList = new List<Cargo>();

        List<string> tariffs = new List<string>();
        public CheckoutDeliveryForm()
        {
            InitializeComponent();
         
        }

        public CheckoutDeliveryForm(Client shipper, Form parent)
        {
            InitializeComponent();
            this.shipper = shipper;
            this.parent = parent;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            FillForms();
            updateTariffState();
        }

        void FillForms()
        {
            List<string> names = new List<string>();
            foreach (Client client in controller.clients)
            {
                names.Add(client.FirstName + " " + client.MiddleName + " " + client.LastName);
            }
            clientsComboBox.Items.Clear();
            clientsComboBox.Items.AddRange(names.ToArray());

            sendAddress.Text = shipper.LastShipment != null ? shipper.LastShipment : "";

            storageComboBox.Items.Clear();
            var storages = controller.GetStorages();
            foreach (Storage storage in storages)
            {
                storageComboBox.Items.Add(storage.StorageName + " " + storage.StorageAddress);
            }

            var cities = controller.cities;
            foreach (City city in cities)
            {
                destCityComboBox.Items.Add(city.CityName);
            }
            var cargoTypes = controller.types;
            foreach (var type in cargoTypes)
            {
                cargoType.Items.Add(type.TypeName);
            }
            cargoType.SelectedIndex = 0;
            tariffs = controller.GetTariffs();



        }

        private void storageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (storageCheckBox.Checked)
            {
                storageComboBox.Show();
                sendAddress.Hide();
            }
            else
            {
                sendAddress.Show();
                storageComboBox.Hide();
            }
        }

        private void storageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void checkOut_Click(object sender, EventArgs e)
        {
            bool first = sendAddress.Text != "" || storageComboBox.SelectedIndex != -1;
            bool second = destCityComboBox.SelectedIndex != -1 && clientsComboBox.SelectedIndex != -1;
            bool third = cargoList.Count > 0;
            if (first && second && third)
            {
                Delivery delivery = new Delivery();
                delivery.DeliveryID = controller.lastDeliveryIndex++;
                delivery.DeliveryCity = destCityComboBox.SelectedIndex;
                delivery.DeliveryStatus = 0;
                delivery.Cargo = cargoList;
                delivery.Tariff = controller.GetTariffByName((string)tariffComboBox.SelectedItem).TariffID; // продолжение отвратительного кода
                delivery.Price = controller.GetTariff(delivery.Tariff.Value).Rate; // рассчет цены должен включать более сложные условия
                delivery.Client = controller.clients[clientsComboBox.SelectedIndex];

                controller.context.Delivery.Add(delivery);
                

                if (!storageCheckBox.Checked) shipper.LastShipment = sendAddress.Text;

                controller.Commit();

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MaterialMessageBox.Show("Заполните все поля формы");
            }
        }

        private void addCargoPanel_SaveClick(object sender, EventArgs e)
        { 
            if (W.Text != "" && H.Text != "" && L.Text != "" && weightTextBox.Text != "") { 
                Cargo cargo = new Cargo();
                cargo.CargoID = controller.lastCargoIndex++;
                cargo.CargoName = cargoName.Text;
                cargo.CargoType = cargoType.SelectedIndex;
                if (storageCheckBox.Checked == true)
                {
                    cargo.Storage = storageComboBox.SelectedIndex;
                    if (cargo.Storage == -1) { MaterialMessageBox.Show("Выберите офис");  return; }
                }
                cargo.ArrivalDate = DateTime.Now;
                cargo.ArrivalTime = DateTime.Now.TimeOfDay;
                cargo.CargoWeight = Convert.ToSingle(Convert.ToSingle(weightTextBox.Text.Replace('.', ',')) * 1000);
                cargo.Width = Convert.ToSingle(W.Text.Replace('.', ','));
                cargo.Height = Convert.ToSingle(H.Text.Replace('.', ','));
                cargo.Depth = Convert.ToSingle(L.Text.Replace('.', ','));
                cargo.Shipper = shipper.ClientID;
                controller.context.Cargo.Add(cargo);
                cargoList.Add(cargo);

                var type = controller.GetCargoTypeById(cargo.CargoType);
                var gabarites = cargo.Width + "x" + cargo.Depth + "x" + cargo.Height;
                cargoListView.Items.Add(new ListViewItem(new string[] { cargo.CargoName, type, gabarites,
                                                                    cargo.CargoWeight.ToString()}));

                controller.Commit();

                updateTariffState();
                clearAddCargo();
            } 
            else
            {
                MaterialMessageBox.Show("Введите параметры груза");
            }
        }

        /*Самый ужасный метод во всем коде. В будущем неплохо бы отрефакторить*/
        private void updateTariffState()
        {
            if (cargoList.Count > 0)
            {
                tariffComboBox.Enabled = true;
            }
            else
            {
                tariffComboBox.Enabled = false;
            }
            tariffComboBox.Items.Clear();
            if ((cargoList.Where(x => x.CargoType == 5).Count() > 0) ||
                ((cargoList.Where(x => x.CargoType == 6).Count() > 0)
                && (cargoList.Where(x => x.CargoType == 7).Count() > 0)))
            {
                tariffComboBox.Items.Add(tariffs[4]);
            }
            else if ((cargoList.Where(x => x.CargoType == 6).Count() > 0))
            {
                tariffComboBox.Items.Add(tariffs[3]);
                tariffComboBox.Items.Add(tariffs[4]);
            }
            else if (cargoList.Where(x => x.CargoType == 7).Count() > 0)
            {
                tariffComboBox.Items.Add(tariffs[2]);
                tariffComboBox.Items.Add(tariffs[4]);
            }
            else
            {
                tariffComboBox.Items.AddRange(tariffs.ToArray());
            }
        }

        void clearAddCargo()
        {
            cargoName.Clear();
            W.Clear();
            H.Clear();
            L.Clear();
            weightTextBox.Clear();
            weightSlider.Value = 0;
        }

        private void weightSlider_onValueChanged(object sender, int newValue)
        {
            float result;
            if (newValue < 10)
            {
                result = newValue / 10.0f;
            }
            else
            {
                result = (newValue - 9);
            }

            weightTextBox.Text = result.ToString();
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (weightTextBox.Text != "")
            {
                float newValue = Convert.ToSingle(weightTextBox.Text.Replace('.', ','));
                if (newValue < 1)
                {
                    weightSlider.Value = Convert.ToInt32(newValue * 10);
                }
                else
                {
                    weightSlider.Value = Convert.ToInt32(newValue);
                }
            }

        }

        private void addCargoPanel_CancelClick(object sender, EventArgs e)
        {
            clearAddCargo();
        }

        private void cargoListView_MouseClick(object sender, MouseEventArgs e)
        {
            cargoListView.ContextMenuStrip = itemContextMenu;
            deleteMenuItem.Click += DeleteMenuItem_Click;
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (cargoListView.SelectedItems.Count > 0)
            {
                cargoList.RemoveAt(cargoListView.SelectedItems[0].Index);
                cargoListView.Items.RemoveAt(cargoListView.SelectedItems[0].Index);
            }
        }

        private void sendAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private async void sendAddress_LeaveAsync(object sender, EventArgs e)
        {
           

            if (sendAddress.Text != "") {
                var api = new SuggestClientAsync(Controller.token);
                var text = await api.SuggestAddress(sendAddress.Text);
                sendAddress.Text = text.suggestions[0].value;
            }
        }
            

        private void sendAddress_Validating(object sender, CancelEventArgs e)
        {
            string input = sendAddress.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(sendAddress, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(sendAddress, String.Empty);
                e.Cancel = false;
            }
        }

      

        private void W_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
        }

        private void H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           
        }

        private void W_Validating(object sender, CancelEventArgs e)
        {
            string input = W.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(W, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(W, String.Empty);
                e.Cancel = false;
            }
        }

        private void L_Validating(object sender, CancelEventArgs e)
        {

            string input = L.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(L, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(L, String.Empty);
                e.Cancel = false;
            }
        }

        private void H_Validating(object sender, CancelEventArgs e)
        {

            string input = H.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(H, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(H, String.Empty);
                e.Cancel = false;
            }
        }

        private void weightTextBox_Validating(object sender, CancelEventArgs e)
        {

            string input = weightTextBox.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(weightTextBox, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(weightTextBox, String.Empty);
                e.Cancel = false;
            }
        }

        private void CheckoutDeliveryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            parent.Focus();
        }
    }
}

