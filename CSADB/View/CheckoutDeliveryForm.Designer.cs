namespace CSADB.View
{
    partial class CheckoutDeliveryForm
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
            this.clientsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.destCityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.storageCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.storageComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.sendAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.cargoListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addCargoPanel = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.weightTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.cargoType = new MaterialSkin.Controls.MaterialComboBox();
            this.H = new MaterialSkin.Controls.MaterialTextBox2();
            this.L = new MaterialSkin.Controls.MaterialTextBox2();
            this.W = new MaterialSkin.Controls.MaterialTextBox2();
            this.weightSlider = new MaterialSkin.Controls.MaterialSlider();
            this.cargoName = new MaterialSkin.Controls.MaterialTextBox2();
            this.checkOut = new MaterialSkin.Controls.MaterialButton();
            this.tariffComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialExpansionPanel2.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            this.addCargoPanel.SuspendLayout();
            this.itemContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.AutoResize = false;
            this.clientsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsComboBox.Depth = 0;
            this.clientsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.clientsComboBox.DropDownHeight = 174;
            this.clientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientsComboBox.DropDownWidth = 121;
            this.clientsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.clientsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Hint = "Получатель";
            this.clientsComboBox.IntegralHeight = false;
            this.clientsComboBox.ItemHeight = 43;
            this.clientsComboBox.Location = new System.Drawing.Point(21, 122);
            this.clientsComboBox.MaxDropDownItems = 4;
            this.clientsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(382, 49);
            this.clientsComboBox.StartIndex = 0;
            this.clientsComboBox.TabIndex = 0;
            // 
            // destCityComboBox
            // 
            this.destCityComboBox.AutoResize = false;
            this.destCityComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.destCityComboBox.Depth = 0;
            this.destCityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.destCityComboBox.DropDownHeight = 174;
            this.destCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCityComboBox.DropDownWidth = 121;
            this.destCityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.destCityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.destCityComboBox.FormattingEnabled = true;
            this.destCityComboBox.Hint = "Город получения";
            this.destCityComboBox.IntegralHeight = false;
            this.destCityComboBox.ItemHeight = 43;
            this.destCityComboBox.Location = new System.Drawing.Point(21, 67);
            this.destCityComboBox.MaxDropDownItems = 4;
            this.destCityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.destCityComboBox.Name = "destCityComboBox";
            this.destCityComboBox.Size = new System.Drawing.Size(382, 49);
            this.destCityComboBox.StartIndex = 0;
            this.destCityComboBox.TabIndex = 2;
            // 
            // materialExpansionPanel2
            // 
            this.materialExpansionPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel2.CancelButtonText = "";
            this.materialExpansionPanel2.Controls.Add(this.clientsComboBox);
            this.materialExpansionPanel2.Controls.Add(this.destCityComboBox);
            this.materialExpansionPanel2.Depth = 0;
            this.materialExpansionPanel2.Description = "";
            this.materialExpansionPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialExpansionPanel2.ExpandHeight = 200;
            this.materialExpansionPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel2.Location = new System.Drawing.Point(3, 264);
            this.materialExpansionPanel2.Margin = new System.Windows.Forms.Padding(16);
            this.materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel2.Name = "materialExpansionPanel2";
            this.materialExpansionPanel2.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel2.ShowValidationButtons = false;
            this.materialExpansionPanel2.Size = new System.Drawing.Size(430, 200);
            this.materialExpansionPanel2.TabIndex = 7;
            this.materialExpansionPanel2.Title = "Получение";
            this.materialExpansionPanel2.ValidationButtonText = "";
            // 
            // storageCheckBox
            // 
            this.storageCheckBox.AutoSize = true;
            this.storageCheckBox.Depth = 0;
            this.storageCheckBox.Location = new System.Drawing.Point(24, 52);
            this.storageCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.storageCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.storageCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.storageCheckBox.Name = "storageCheckBox";
            this.storageCheckBox.ReadOnly = false;
            this.storageCheckBox.Ripple = true;
            this.storageCheckBox.Size = new System.Drawing.Size(105, 37);
            this.storageCheckBox.TabIndex = 3;
            this.storageCheckBox.Text = "Из офиса";
            this.storageCheckBox.UseVisualStyleBackColor = true;
            this.storageCheckBox.CheckedChanged += new System.EventHandler(this.storageCheckBox_CheckedChanged);
            // 
            // storageComboBox
            // 
            this.storageComboBox.AutoResize = false;
            this.storageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.storageComboBox.Depth = 0;
            this.storageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.storageComboBox.DropDownHeight = 174;
            this.storageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageComboBox.DropDownWidth = 121;
            this.storageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.storageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.storageComboBox.FormattingEnabled = true;
            this.storageComboBox.Hint = "Офис";
            this.storageComboBox.IntegralHeight = false;
            this.storageComboBox.ItemHeight = 43;
            this.storageComboBox.Location = new System.Drawing.Point(24, 91);
            this.storageComboBox.MaxDropDownItems = 4;
            this.storageComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.storageComboBox.Name = "storageComboBox";
            this.storageComboBox.Size = new System.Drawing.Size(385, 49);
            this.storageComboBox.StartIndex = 0;
            this.storageComboBox.TabIndex = 4;
            this.storageComboBox.SelectedIndexChanged += new System.EventHandler(this.storageComboBox_SelectedIndexChanged);
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "";
            this.materialExpansionPanel1.Controls.Add(this.storageCheckBox);
            this.materialExpansionPanel1.Controls.Add(this.sendAddress);
            this.materialExpansionPanel1.Controls.Add(this.storageComboBox);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "";
            this.materialExpansionPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialExpansionPanel1.ExpandHeight = 200;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(3, 64);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.ShowValidationButtons = false;
            this.materialExpansionPanel1.Size = new System.Drawing.Size(430, 200);
            this.materialExpansionPanel1.TabIndex = 6;
            this.materialExpansionPanel1.Title = "Отправка";
            this.materialExpansionPanel1.ValidationButtonText = "";
            // 
            // sendAddress
            // 
            this.sendAddress.AnimateReadOnly = false;
            this.sendAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendAddress.Depth = 0;
            this.sendAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sendAddress.Hint = "Адрес отправки";
            this.sendAddress.LeadingIcon = null;
            this.sendAddress.Location = new System.Drawing.Point(24, 92);
            this.sendAddress.MaxLength = 50;
            this.sendAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.sendAddress.Multiline = false;
            this.sendAddress.Name = "sendAddress";
            this.sendAddress.Size = new System.Drawing.Size(385, 50);
            this.sendAddress.TabIndex = 5;
            this.sendAddress.Text = "";
            this.sendAddress.TrailingIcon = null;
            this.sendAddress.TextChanged += new System.EventHandler(this.sendAddress_TextChanged);
            this.sendAddress.Leave += new System.EventHandler(this.sendAddress_LeaveAsync);
            this.sendAddress.Validating += new System.ComponentModel.CancelEventHandler(this.sendAddress_Validating);
            // 
            // cargoListView
            // 
            this.cargoListView.AutoSizeTable = false;
            this.cargoListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cargoListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.cargoListView.Depth = 0;
            this.cargoListView.FullRowSelect = true;
            this.cargoListView.HideSelection = false;
            this.cargoListView.Location = new System.Drawing.Point(24, 219);
            this.cargoListView.MaximumSize = new System.Drawing.Size(431, 200);
            this.cargoListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.cargoListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cargoListView.MouseState = MaterialSkin.MouseState.OUT;
            this.cargoListView.Name = "cargoListView";
            this.cargoListView.OwnerDraw = true;
            this.cargoListView.Size = new System.Drawing.Size(388, 100);
            this.cargoListView.TabIndex = 8;
            this.cargoListView.UseCompatibleStateImageBehavior = false;
            this.cargoListView.View = System.Windows.Forms.View.Details;
            this.cargoListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cargoListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тип груза";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Габариты";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Масса";
            this.columnHeader4.Width = 103;
            // 
            // addCargoPanel
            // 
            this.addCargoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCargoPanel.CancelButtonText = "Очистить";
            this.addCargoPanel.Controls.Add(this.weightTextBox);
            this.addCargoPanel.Controls.Add(this.cargoListView);
            this.addCargoPanel.Controls.Add(this.cargoType);
            this.addCargoPanel.Controls.Add(this.H);
            this.addCargoPanel.Controls.Add(this.L);
            this.addCargoPanel.Controls.Add(this.W);
            this.addCargoPanel.Controls.Add(this.weightSlider);
            this.addCargoPanel.Controls.Add(this.cargoName);
            this.addCargoPanel.Depth = 0;
            this.addCargoPanel.Description = "Добавить груз";
            this.addCargoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCargoPanel.ExpandHeight = 378;
            this.addCargoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addCargoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addCargoPanel.Location = new System.Drawing.Point(3, 464);
            this.addCargoPanel.Margin = new System.Windows.Forms.Padding(16);
            this.addCargoPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCargoPanel.Name = "addCargoPanel";
            this.addCargoPanel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.addCargoPanel.Size = new System.Drawing.Size(430, 378);
            this.addCargoPanel.TabIndex = 9;
            this.addCargoPanel.Title = "Грузы";
            this.addCargoPanel.ValidationButtonEnable = true;
            this.addCargoPanel.ValidationButtonText = "Добавить";
            this.addCargoPanel.SaveClick += new System.EventHandler(this.addCargoPanel_SaveClick);
            this.addCargoPanel.CancelClick += new System.EventHandler(this.addCargoPanel_CancelClick);
            // 
            // weightTextBox
            // 
            this.weightTextBox.AnimateReadOnly = false;
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightTextBox.Depth = 0;
            this.weightTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.weightTextBox.Hint = "кг.";
            this.weightTextBox.LeadingIcon = null;
            this.weightTextBox.Location = new System.Drawing.Point(346, 166);
            this.weightTextBox.MaxLength = 50;
            this.weightTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.weightTextBox.Multiline = false;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(57, 50);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.Text = "";
            this.weightTextBox.TrailingIcon = null;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            this.weightTextBox.Leave += new System.EventHandler(this.weightTextBox_TextChanged);
            this.weightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.weightTextBox_Validating);
            // 
            // cargoType
            // 
            this.cargoType.AutoResize = false;
            this.cargoType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cargoType.Depth = 0;
            this.cargoType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cargoType.DropDownHeight = 174;
            this.cargoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoType.DropDownWidth = 121;
            this.cargoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cargoType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cargoType.FormattingEnabled = true;
            this.cargoType.Hint = "Тип груза";
            this.cargoType.IntegralHeight = false;
            this.cargoType.ItemHeight = 43;
            this.cargoType.Location = new System.Drawing.Point(21, 110);
            this.cargoType.MaxDropDownItems = 4;
            this.cargoType.MouseState = MaterialSkin.MouseState.OUT;
            this.cargoType.Name = "cargoType";
            this.cargoType.Size = new System.Drawing.Size(382, 49);
            this.cargoType.StartIndex = 0;
            this.cargoType.TabIndex = 7;
            // 
            // H
            // 
            this.H.AnimateReadOnly = false;
            this.H.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.H.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.H.Depth = 0;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.H.HideSelection = true;
            this.H.Hint = "В";
            this.H.LeadingIcon = null;
            this.H.Location = new System.Drawing.Point(131, 165);
            this.H.MaxLength = 32767;
            this.H.MouseState = MaterialSkin.MouseState.OUT;
            this.H.Name = "H";
            this.H.PasswordChar = '\0';
            this.H.PrefixSuffixText = null;
            this.H.ReadOnly = false;
            this.H.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.H.SelectedText = "";
            this.H.SelectionLength = 0;
            this.H.SelectionStart = 0;
            this.H.ShortcutsEnabled = true;
            this.H.Size = new System.Drawing.Size(49, 48);
            this.H.TabIndex = 6;
            this.H.TabStop = false;
            this.H.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.H.TrailingIcon = null;
            this.H.UseSystemPasswordChar = false;
            this.H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.H_KeyPress);
            this.H.Validating += new System.ComponentModel.CancelEventHandler(this.H_Validating);
            // 
            // L
            // 
            this.L.AnimateReadOnly = false;
            this.L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.L.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.L.Depth = 0;
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.L.HideSelection = true;
            this.L.Hint = "Д";
            this.L.LeadingIcon = null;
            this.L.Location = new System.Drawing.Point(76, 166);
            this.L.MaxLength = 32767;
            this.L.MouseState = MaterialSkin.MouseState.OUT;
            this.L.Name = "L";
            this.L.PasswordChar = '\0';
            this.L.PrefixSuffixText = null;
            this.L.ReadOnly = false;
            this.L.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.L.SelectedText = "";
            this.L.SelectionLength = 0;
            this.L.SelectionStart = 0;
            this.L.ShortcutsEnabled = true;
            this.L.Size = new System.Drawing.Size(49, 48);
            this.L.TabIndex = 5;
            this.L.TabStop = false;
            this.L.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.L.TrailingIcon = null;
            this.L.UseSystemPasswordChar = false;
            this.L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.L_KeyPress);
            this.L.Validating += new System.ComponentModel.CancelEventHandler(this.L_Validating);
            // 
            // W
            // 
            this.W.AnimateReadOnly = false;
            this.W.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.W.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.W.Depth = 0;
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.W.HideSelection = true;
            this.W.Hint = "Ш";
            this.W.LeadingIcon = null;
            this.W.Location = new System.Drawing.Point(21, 166);
            this.W.MaxLength = 32767;
            this.W.MouseState = MaterialSkin.MouseState.OUT;
            this.W.Name = "W";
            this.W.PasswordChar = '\0';
            this.W.PrefixSuffixText = null;
            this.W.ReadOnly = false;
            this.W.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.W.SelectedText = "";
            this.W.SelectionLength = 0;
            this.W.SelectionStart = 0;
            this.W.ShortcutsEnabled = true;
            this.W.Size = new System.Drawing.Size(49, 48);
            this.W.TabIndex = 4;
            this.W.TabStop = false;
            this.W.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.W.TrailingIcon = null;
            this.W.UseSystemPasswordChar = false;
            this.W.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.W_KeyPress);
            this.W.Validating += new System.ComponentModel.CancelEventHandler(this.W_Validating);
            // 
            // weightSlider
            // 
            this.weightSlider.Depth = 0;
            this.weightSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.weightSlider.Location = new System.Drawing.Point(186, 173);
            this.weightSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.weightSlider.Name = "weightSlider";
            this.weightSlider.RangeMax = 70;
            this.weightSlider.ShowValue = false;
            this.weightSlider.Size = new System.Drawing.Size(172, 40);
            this.weightSlider.TabIndex = 3;
            this.weightSlider.Text = "Вес";
            this.weightSlider.Value = 0;
            this.weightSlider.ValueMax = 70;
            this.weightSlider.ValueSuffix = " кг.";
            this.weightSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.weightSlider_onValueChanged);
            // 
            // cargoName
            // 
            this.cargoName.AnimateReadOnly = false;
            this.cargoName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cargoName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cargoName.Depth = 0;
            this.cargoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cargoName.HideSelection = true;
            this.cargoName.Hint = "Наименование";
            this.cargoName.LeadingIcon = null;
            this.cargoName.Location = new System.Drawing.Point(21, 56);
            this.cargoName.MaxLength = 32767;
            this.cargoName.MouseState = MaterialSkin.MouseState.OUT;
            this.cargoName.Name = "cargoName";
            this.cargoName.PasswordChar = '\0';
            this.cargoName.PrefixSuffixText = null;
            this.cargoName.ReadOnly = false;
            this.cargoName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cargoName.SelectedText = "";
            this.cargoName.SelectionLength = 0;
            this.cargoName.SelectionStart = 0;
            this.cargoName.ShortcutsEnabled = true;
            this.cargoName.Size = new System.Drawing.Size(382, 48);
            this.cargoName.TabIndex = 2;
            this.cargoName.TabStop = false;
            this.cargoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cargoName.TrailingIcon = null;
            this.cargoName.UseSystemPasswordChar = false;
            // 
            // checkOut
            // 
            this.checkOut.AutoSize = false;
            this.checkOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.checkOut.Depth = 0;
            this.checkOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkOut.HighEmphasis = true;
            this.checkOut.Icon = null;
            this.checkOut.Location = new System.Drawing.Point(3, 891);
            this.checkOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkOut.Name = "checkOut";
            this.checkOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.checkOut.Size = new System.Drawing.Size(430, 36);
            this.checkOut.TabIndex = 10;
            this.checkOut.Text = "Оформить";
            this.checkOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.checkOut.UseAccentColor = false;
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            // 
            // tariffComboBox
            // 
            this.tariffComboBox.AutoResize = false;
            this.tariffComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tariffComboBox.Depth = 0;
            this.tariffComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tariffComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tariffComboBox.DropDownHeight = 174;
            this.tariffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tariffComboBox.DropDownWidth = 121;
            this.tariffComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tariffComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tariffComboBox.FormattingEnabled = true;
            this.tariffComboBox.Hint = "Тариф";
            this.tariffComboBox.IntegralHeight = false;
            this.tariffComboBox.ItemHeight = 43;
            this.tariffComboBox.Location = new System.Drawing.Point(3, 842);
            this.tariffComboBox.MaxDropDownItems = 4;
            this.tariffComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.tariffComboBox.Name = "tariffComboBox";
            this.tariffComboBox.Size = new System.Drawing.Size(430, 49);
            this.tariffComboBox.StartIndex = 0;
            this.tariffComboBox.TabIndex = 11;
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem});
            this.itemContextMenu.Name = "itemContextMenu";
            this.itemContextMenu.Size = new System.Drawing.Size(119, 26);
            this.itemContextMenu.Text = "Удалить";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteMenuItem.Text = "Удалить";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CheckoutDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(436, 929);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.tariffComboBox);
            this.Controls.Add(this.addCargoPanel);
            this.Controls.Add(this.materialExpansionPanel2);
            this.Controls.Add(this.materialExpansionPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 246);
            this.Name = "CheckoutDeliveryForm";
            this.Sizable = false;
            this.Text = "Оформить доставку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckoutDeliveryForm_FormClosing);
            this.materialExpansionPanel2.ResumeLayout(false);
            this.materialExpansionPanel2.PerformLayout();
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            this.addCargoPanel.ResumeLayout(false);
            this.addCargoPanel.PerformLayout();
            this.itemContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox clientsComboBox;
        private MaterialSkin.Controls.MaterialComboBox destCityComboBox;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private MaterialSkin.Controls.MaterialCheckbox storageCheckBox;
        private MaterialSkin.Controls.MaterialComboBox storageComboBox;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialListView cargoListView;
        private MaterialSkin.Controls.MaterialExpansionPanel addCargoPanel;
        private MaterialSkin.Controls.MaterialTextBox2 H;
        private MaterialSkin.Controls.MaterialTextBox2 L;
        private MaterialSkin.Controls.MaterialTextBox2 W;
        private MaterialSkin.Controls.MaterialSlider weightSlider;
        private MaterialSkin.Controls.MaterialTextBox2 cargoName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialComboBox cargoType;
        private MaterialSkin.Controls.MaterialButton checkOut;
        private MaterialSkin.Controls.MaterialComboBox tariffComboBox;
        private MaterialSkin.Controls.MaterialTextBox weightTextBox;
        private System.Windows.Forms.ContextMenuStrip itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private MaterialSkin.Controls.MaterialTextBox sendAddress;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}