namespace CSADB.View
{
    partial class CourierForm
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
            this.components = new System.ComponentModel.Container();
            this.activeDeliveryPanel = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.address = new MaterialSkin.Controls.MaterialLabel();
            this.cargoList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.addressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.weightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.clientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.infoPanel = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.partnerCompany = new MaterialSkin.Controls.MaterialComboBox();
            this.cityCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.carCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.birthdayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.deliveriesPanel = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.availableList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acceptDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.activeDeliveryPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.deliveriesPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeDeliveryPanel
            // 
            this.activeDeliveryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activeDeliveryPanel.CancelButtonText = "x";
            this.activeDeliveryPanel.Controls.Add(this.materialLabel1);
            this.activeDeliveryPanel.Controls.Add(this.address);
            this.activeDeliveryPanel.Controls.Add(this.cargoList);
            this.activeDeliveryPanel.Controls.Add(this.dateTime);
            this.activeDeliveryPanel.Controls.Add(this.materialLabel6);
            this.activeDeliveryPanel.Controls.Add(this.addressLabel);
            this.activeDeliveryPanel.Controls.Add(this.weightLabel);
            this.activeDeliveryPanel.Controls.Add(this.materialLabel7);
            this.activeDeliveryPanel.Controls.Add(this.clientLabel);
            this.activeDeliveryPanel.Controls.Add(this.materialLabel11);
            this.activeDeliveryPanel.Depth = 0;
            this.activeDeliveryPanel.Description = "Отсутствует";
            this.activeDeliveryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.activeDeliveryPanel.ExpandHeight = 344;
            this.activeDeliveryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.activeDeliveryPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activeDeliveryPanel.Location = new System.Drawing.Point(3, 112);
            this.activeDeliveryPanel.Margin = new System.Windows.Forms.Padding(16);
            this.activeDeliveryPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.activeDeliveryPanel.Name = "activeDeliveryPanel";
            this.activeDeliveryPanel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.activeDeliveryPanel.Size = new System.Drawing.Size(794, 344);
            this.activeDeliveryPanel.TabIndex = 28;
            this.activeDeliveryPanel.Title = "Текущий запрос на заставку";
            this.activeDeliveryPanel.ValidationButtonEnable = true;
            this.activeDeliveryPanel.ValidationButtonText = "Доставлено";
            this.activeDeliveryPanel.SaveClick += new System.EventHandler(this.activeDeliveryPanel_SaveClick);
            this.activeDeliveryPanel.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(27, 227);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(154, 17);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = " желаемого получения";
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.address.AutoSize = true;
            this.address.Depth = 0;
            this.address.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.address.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.address.Location = new System.Drawing.Point(208, 210);
            this.address.MouseState = MaterialSkin.MouseState.HOVER;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(108, 17);
            this.address.TabIndex = 37;
            this.address.Text = "Адрес доставки";
            // 
            // cargoList
            // 
            this.cargoList.AutoSizeTable = false;
            this.cargoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cargoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.cargoList.Depth = 0;
            this.cargoList.FullRowSelect = true;
            this.cargoList.HideSelection = false;
            this.cargoList.Location = new System.Drawing.Point(472, 58);
            this.cargoList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cargoList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cargoList.MouseState = MaterialSkin.MouseState.OUT;
            this.cargoList.Name = "cargoList";
            this.cargoList.OwnerDraw = true;
            this.cargoList.Size = new System.Drawing.Size(319, 109);
            this.cargoList.TabIndex = 33;
            this.cargoList.UseCompatibleStateImageBehavior = false;
            this.cargoList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID груза";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Склад";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Вес";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Габариты";
            this.columnHeader4.Width = 103;
            // 
            // dateTime
            // 
            this.dateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTime.AutoSize = true;
            this.dateTime.Depth = 0;
            this.dateTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTime.Location = new System.Drawing.Point(32, 244);
            this.dateTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(68, 19);
            this.dateTime.TabIndex = 29;
            this.dateTime.Text = "dateTime";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.Location = new System.Drawing.Point(208, 106);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(49, 17);
            this.materialLabel6.TabIndex = 26;
            this.materialLabel6.Text = "Клиент";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Depth = 0;
            this.addressLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addressLabel.Location = new System.Drawing.Point(208, 227);
            this.addressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(57, 19);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "address";
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.weightLabel.AutoSize = true;
            this.weightLabel.Depth = 0;
            this.weightLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.weightLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weightLabel.Location = new System.Drawing.Point(32, 123);
            this.weightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(48, 19);
            this.weightLabel.TabIndex = 34;
            this.weightLabel.Text = "weight";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel7.Location = new System.Drawing.Point(32, 210);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(92, 17);
            this.materialLabel7.TabIndex = 30;
            this.materialLabel7.Text = "Дата и время";
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientLabel.AutoSize = true;
            this.clientLabel.Depth = 0;
            this.clientLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientLabel.Location = new System.Drawing.Point(208, 123);
            this.clientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(39, 19);
            this.clientLabel.TabIndex = 25;
            this.clientLabel.Text = "client";
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel11.Location = new System.Drawing.Point(32, 106);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(73, 17);
            this.materialLabel11.TabIndex = 35;
            this.materialLabel11.Text = "Общий вес";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoPanel.Collapse = true;
            this.infoPanel.Controls.Add(this.partnerCompany);
            this.infoPanel.Controls.Add(this.cityCombobox);
            this.infoPanel.Controls.Add(this.carCheckbox);
            this.infoPanel.Controls.Add(this.birthdayLabel);
            this.infoPanel.Controls.Add(this.materialLabel2);
            this.infoPanel.Depth = 0;
            this.infoPanel.Description = "";
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoPanel.Location = new System.Drawing.Point(3, 64);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.infoPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.infoPanel.Size = new System.Drawing.Size(794, 48);
            this.infoPanel.TabIndex = 29;
            this.infoPanel.Title = "Информация о курьере";
            this.infoPanel.UseAccentColor = true;
            this.infoPanel.SaveClick += new System.EventHandler(this.infoPanel_SaveClick);
            // 
            // partnerCompany
            // 
            this.partnerCompany.AutoResize = false;
            this.partnerCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.partnerCompany.Depth = 0;
            this.partnerCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.partnerCompany.DropDownHeight = 174;
            this.partnerCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partnerCompany.DropDownWidth = 121;
            this.partnerCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.partnerCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.partnerCompany.FormattingEnabled = true;
            this.partnerCompany.Hint = "Партнерская компания";
            this.partnerCompany.IntegralHeight = false;
            this.partnerCompany.ItemHeight = 43;
            this.partnerCompany.Location = new System.Drawing.Point(541, 106);
            this.partnerCompany.MaxDropDownItems = 4;
            this.partnerCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.partnerCompany.Name = "partnerCompany";
            this.partnerCompany.Size = new System.Drawing.Size(238, 49);
            this.partnerCompany.StartIndex = 0;
            this.partnerCompany.TabIndex = 6;
            // 
            // cityCombobox
            // 
            this.cityCombobox.AutoResize = false;
            this.cityCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cityCombobox.Depth = 0;
            this.cityCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cityCombobox.DropDownHeight = 174;
            this.cityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCombobox.DropDownWidth = 121;
            this.cityCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cityCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cityCombobox.FormattingEnabled = true;
            this.cityCombobox.Hint = "Город";
            this.cityCombobox.IntegralHeight = false;
            this.cityCombobox.ItemHeight = 43;
            this.cityCombobox.Location = new System.Drawing.Point(541, 51);
            this.cityCombobox.MaxDropDownItems = 4;
            this.cityCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.cityCombobox.Name = "cityCombobox";
            this.cityCombobox.Size = new System.Drawing.Size(238, 49);
            this.cityCombobox.StartIndex = 0;
            this.cityCombobox.TabIndex = 5;
            // 
            // carCheckbox
            // 
            this.carCheckbox.AutoSize = true;
            this.carCheckbox.Depth = 0;
            this.carCheckbox.Location = new System.Drawing.Point(24, 106);
            this.carCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.carCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.carCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.carCheckbox.Name = "carCheckbox";
            this.carCheckbox.ReadOnly = false;
            this.carCheckbox.Ripple = true;
            this.carCheckbox.Size = new System.Drawing.Size(195, 37);
            this.carCheckbox.TabIndex = 4;
            this.carCheckbox.Text = "Имеется автомобиль";
            this.carCheckbox.UseVisualStyleBackColor = true;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Depth = 0;
            this.birthdayLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.birthdayLabel.Location = new System.Drawing.Point(27, 81);
            this.birthdayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(98, 19);
            this.birthdayLabel.TabIndex = 3;
            this.birthdayLabel.Text = "birthdayLabel";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(27, 64);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 17);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Дата рождения";
            // 
            // deliveriesPanel
            // 
            this.deliveriesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deliveriesPanel.CancelButtonText = "Закрыть";
            this.deliveriesPanel.Controls.Add(this.availableList);
            this.deliveriesPanel.Depth = 0;
            this.deliveriesPanel.Description = "";
            this.deliveriesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deliveriesPanel.ExpandHeight = 288;
            this.deliveriesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.deliveriesPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deliveriesPanel.Location = new System.Drawing.Point(3, 456);
            this.deliveriesPanel.Margin = new System.Windows.Forms.Padding(16);
            this.deliveriesPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.deliveriesPanel.Name = "deliveriesPanel";
            this.deliveriesPanel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.deliveriesPanel.Size = new System.Drawing.Size(794, 288);
            this.deliveriesPanel.TabIndex = 30;
            this.deliveriesPanel.Title = "Доступные запросы на доставку";
            this.deliveriesPanel.ValidationButtonText = "";
            this.deliveriesPanel.Click += new System.EventHandler(this.deliveriesPanel_Click);
            // 
            // availableList
            // 
            this.availableList.AutoSizeTable = false;
            this.availableList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availableList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader6});
            this.availableList.Depth = 0;
            this.availableList.Dock = System.Windows.Forms.DockStyle.Top;
            this.availableList.FullRowSelect = true;
            this.availableList.HideSelection = false;
            this.availableList.Location = new System.Drawing.Point(24, 64);
            this.availableList.MinimumSize = new System.Drawing.Size(200, 100);
            this.availableList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.availableList.MouseState = MaterialSkin.MouseState.OUT;
            this.availableList.Name = "availableList";
            this.availableList.OwnerDraw = true;
            this.availableList.Size = new System.Drawing.Size(746, 147);
            this.availableList.TabIndex = 2;
            this.availableList.UseCompatibleStateImageBehavior = false;
            this.availableList.View = System.Windows.Forms.View.Details;
            this.availableList.DoubleClick += new System.EventHandler(this.AcceptDelivery_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Трек";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Адрес доставки";
            this.columnHeader10.Width = 169;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Вес";
            this.columnHeader11.Width = 104;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Желаемое время";
            this.columnHeader12.Width = 167;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Желаемая дата";
            this.columnHeader13.Width = 155;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Токсичный";
            this.columnHeader14.Width = 105;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Негабаритный";
            this.columnHeader15.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Хрупкий";
            this.columnHeader6.Width = 72;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptDelivery});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(173, 26);
            // 
            // acceptDelivery
            // 
            this.acceptDelivery.Name = "acceptDelivery";
            this.acceptDelivery.Size = new System.Drawing.Size(172, 22);
            this.acceptDelivery.Text = "Принять доставку";
            // 
            // CourierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.deliveriesPanel);
            this.Controls.Add(this.activeDeliveryPanel);
            this.Controls.Add(this.infoPanel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 216);
            this.Name = "CourierForm";
            this.Sizable = false;
            this.Text = "Окно курьера. ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourierForm_FormClosed);
            this.activeDeliveryPanel.ResumeLayout(false);
            this.activeDeliveryPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.deliveriesPanel.ResumeLayout(false);
            this.deliveriesPanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialExpansionPanel activeDeliveryPanel;
        private MaterialSkin.Controls.MaterialExpansionPanel infoPanel;
        private MaterialSkin.Controls.MaterialLabel address;
        private MaterialSkin.Controls.MaterialLabel addressLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel weightLabel;
        private MaterialSkin.Controls.MaterialListView cargoList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel dateTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel clientLabel;
        private MaterialSkin.Controls.MaterialComboBox partnerCompany;
        private MaterialSkin.Controls.MaterialComboBox cityCombobox;
        private MaterialSkin.Controls.MaterialCheckbox carCheckbox;
        private MaterialSkin.Controls.MaterialLabel birthdayLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialExpansionPanel deliveriesPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView availableList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem acceptDelivery;
    }
}