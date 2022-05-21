namespace CSADB.View
{
    partial class DeliveryDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deliveryID = new MaterialSkin.Controls.MaterialLabel();
            this.status = new MaterialSkin.Controls.MaterialLabel();
            this.tariffLabel = new MaterialSkin.Controls.MaterialLabel();
            this.price = new MaterialSkin.Controls.MaterialLabel();
            this.cargosList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.parametersExpansion = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.deliveryPicker = new System.Windows.Forms.DateTimePicker();
            this.postamatCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.postamatComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.addressTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.parametersExpansion.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryID
            // 
            this.deliveryID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deliveryID.AutoSize = true;
            this.deliveryID.Depth = 0;
            this.deliveryID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deliveryID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deliveryID.Location = new System.Drawing.Point(21, 84);
            this.deliveryID.MouseState = MaterialSkin.MouseState.HOVER;
            this.deliveryID.Name = "deliveryID";
            this.deliveryID.Size = new System.Drawing.Size(95, 19);
            this.deliveryID.TabIndex = 0;
            this.deliveryID.Text = "deliveryTrack";
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.status.AutoSize = true;
            this.status.Depth = 0;
            this.status.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status.Location = new System.Drawing.Point(21, 132);
            this.status.MouseState = MaterialSkin.MouseState.HOVER;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(45, 19);
            this.status.TabIndex = 1;
            this.status.Text = "status";
            // 
            // tariffLabel
            // 
            this.tariffLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tariffLabel.AutoSize = true;
            this.tariffLabel.Depth = 0;
            this.tariffLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tariffLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tariffLabel.Location = new System.Drawing.Point(21, 180);
            this.tariffLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tariffLabel.Name = "tariffLabel";
            this.tariffLabel.Size = new System.Drawing.Size(36, 19);
            this.tariffLabel.TabIndex = 3;
            this.tariffLabel.Text = "tariff";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.price.AutoSize = true;
            this.price.Depth = 0;
            this.price.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.price.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.price.Location = new System.Drawing.Point(21, 227);
            this.price.MouseState = MaterialSkin.MouseState.HOVER;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 19);
            this.price.TabIndex = 5;
            this.price.Text = "price";
            // 
            // cargosList
            // 
            this.cargosList.AutoSizeTable = false;
            this.cargosList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cargosList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.cargosList.Depth = 0;
            this.cargosList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cargosList.FullRowSelect = true;
            this.cargosList.HideSelection = false;
            this.cargosList.Location = new System.Drawing.Point(3, 354);
            this.cargosList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cargosList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cargosList.MouseState = MaterialSkin.MouseState.OUT;
            this.cargosList.Name = "cargosList";
            this.cargosList.OwnerDraw = true;
            this.cargosList.Size = new System.Drawing.Size(799, 196);
            this.cargosList.TabIndex = 6;
            this.cargosList.UseCompatibleStateImageBehavior = false;
            this.cargosList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID груза";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Наименование";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Отправитель";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Вес";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Габариты";
            this.columnHeader5.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип груза";
            this.columnHeader6.Width = 216;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(3, 335);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(216, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Грузы, входящие в доставку";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(23, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 17);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Трек-номер";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.Location = new System.Drawing.Point(23, 115);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 17);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Статус";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.Location = new System.Drawing.Point(23, 163);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(44, 17);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Тариф";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel7.Location = new System.Drawing.Point(23, 210);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(35, 17);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Цена";
            // 
            // parametersExpansion
            // 
            this.parametersExpansion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.parametersExpansion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.parametersExpansion.CancelButtonText = "Отмена";
            this.parametersExpansion.Controls.Add(this.materialLabel4);
            this.parametersExpansion.Controls.Add(this.deliveryPicker);
            this.parametersExpansion.Controls.Add(this.postamatCheckBox);
            this.parametersExpansion.Controls.Add(this.postamatComboBox);
            this.parametersExpansion.Controls.Add(this.addressTextBox);
            this.parametersExpansion.Depth = 0;
            this.parametersExpansion.Description = "";
            this.parametersExpansion.ExpandHeight = 267;
            this.parametersExpansion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.parametersExpansion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.parametersExpansion.Location = new System.Drawing.Point(208, 40);
            this.parametersExpansion.Margin = new System.Windows.Forms.Padding(16);
            this.parametersExpansion.MouseState = MaterialSkin.MouseState.HOVER;
            this.parametersExpansion.Name = "parametersExpansion";
            this.parametersExpansion.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.parametersExpansion.Size = new System.Drawing.Size(591, 267);
            this.parametersExpansion.TabIndex = 15;
            this.parametersExpansion.Title = "Параметры доставки";
            this.parametersExpansion.ValidationButtonEnable = true;
            this.parametersExpansion.ValidationButtonText = "Сохранить";
            this.parametersExpansion.SaveClick += new System.EventHandler(this.parametersExpansion_SaveClick);
            this.parametersExpansion.PanelExpand += new System.EventHandler(this.parametersExpansion_PanelExpand);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(58, 156);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(315, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Ориентировочная дата и время доставки";
            // 
            // deliveryPicker
            // 
            this.deliveryPicker.CustomFormat = "d.MM.yyyy HH:mm";
            this.deliveryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliveryPicker.Location = new System.Drawing.Point(379, 154);
            this.deliveryPicker.Name = "deliveryPicker";
            this.deliveryPicker.Size = new System.Drawing.Size(200, 23);
            this.deliveryPicker.TabIndex = 5;
            this.deliveryPicker.ValueChanged += new System.EventHandler(this.deliveryPicker_ValueChanged);
            // 
            // postamatCheckBox
            // 
            this.postamatCheckBox.AutoSize = true;
            this.postamatCheckBox.Depth = 0;
            this.postamatCheckBox.Location = new System.Drawing.Point(24, 56);
            this.postamatCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.postamatCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.postamatCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.postamatCheckBox.Name = "postamatCheckBox";
            this.postamatCheckBox.ReadOnly = false;
            this.postamatCheckBox.Ripple = true;
            this.postamatCheckBox.Size = new System.Drawing.Size(121, 37);
            this.postamatCheckBox.TabIndex = 2;
            this.postamatCheckBox.Text = "В постамат";
            this.postamatCheckBox.UseVisualStyleBackColor = true;
            this.postamatCheckBox.CheckedChanged += new System.EventHandler(this.postamatTextBox_CheckedChanged);
            // 
            // postamatComboBox
            // 
            this.postamatComboBox.AutoResize = false;
            this.postamatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.postamatComboBox.Depth = 0;
            this.postamatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.postamatComboBox.DropDownHeight = 174;
            this.postamatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postamatComboBox.DropDownWidth = 121;
            this.postamatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.postamatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.postamatComboBox.FormattingEnabled = true;
            this.postamatComboBox.Hint = "Постамат";
            this.postamatComboBox.IntegralHeight = false;
            this.postamatComboBox.ItemHeight = 43;
            this.postamatComboBox.Location = new System.Drawing.Point(27, 96);
            this.postamatComboBox.MaxDropDownItems = 4;
            this.postamatComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.postamatComboBox.Name = "postamatComboBox";
            this.postamatComboBox.Size = new System.Drawing.Size(552, 49);
            this.postamatComboBox.StartIndex = 0;
            this.postamatComboBox.TabIndex = 4;
            this.postamatComboBox.Visible = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.AnimateReadOnly = false;
            this.addressTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addressTextBox.Depth = 0;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressTextBox.HideSelection = true;
            this.addressTextBox.Hint = "Адрес";
            this.addressTextBox.LeadingIcon = null;
            this.addressTextBox.Location = new System.Drawing.Point(27, 96);
            this.addressTextBox.MaxLength = 32767;
            this.addressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PrefixSuffixText = null;
            this.addressTextBox.ReadOnly = false;
            this.addressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.SelectionLength = 0;
            this.addressTextBox.SelectionStart = 0;
            this.addressTextBox.ShortcutsEnabled = true;
            this.addressTextBox.Size = new System.Drawing.Size(552, 48);
            this.addressTextBox.TabIndex = 3;
            this.addressTextBox.TabStop = false;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTextBox.TrailingIcon = null;
            this.addressTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.Location = new System.Drawing.Point(23, 258);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(42, 17);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Город";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cityLabel.AutoSize = true;
            this.cityLabel.Depth = 0;
            this.cityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cityLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cityLabel.Location = new System.Drawing.Point(21, 275);
            this.cityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(26, 19);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "city";
            // 
            // DeliveryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 553);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.parametersExpansion);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.tariffLabel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.deliveryID);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cargosList);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "DeliveryDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "DeliveryDetailsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeliveryDetailsForm_FormClosed);
            this.parametersExpansion.ResumeLayout(false);
            this.parametersExpansion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel deliveryID;
        private MaterialSkin.Controls.MaterialLabel status;
        private MaterialSkin.Controls.MaterialLabel tariffLabel;
        private MaterialSkin.Controls.MaterialLabel price;
        private MaterialSkin.Controls.MaterialListView cargosList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialExpansionPanel parametersExpansion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker deliveryPicker;
        private MaterialSkin.Controls.MaterialComboBox postamatComboBox;
        private MaterialSkin.Controls.MaterialTextBox2 addressTextBox;
        private MaterialSkin.Controls.MaterialCheckbox postamatCheckBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel cityLabel;
    }
}