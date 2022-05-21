namespace CSADB.View
{
    partial class ClientForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.deliveryTable = new MaterialSkin.Controls.MaterialListView();
            this.track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cargoList = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.deleteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeliveryButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.updateButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.deleteMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ваши доставки";
            // 
            // deliveryTable
            // 
            this.deliveryTable.AutoSizeTable = false;
            this.deliveryTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deliveryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.track,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.deliveryTable.Depth = 0;
            this.deliveryTable.FullRowSelect = true;
            this.deliveryTable.HideSelection = false;
            this.deliveryTable.Location = new System.Drawing.Point(9, 113);
            this.deliveryTable.MinimumSize = new System.Drawing.Size(200, 100);
            this.deliveryTable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.deliveryTable.MouseState = MaterialSkin.MouseState.OUT;
            this.deliveryTable.Name = "deliveryTable";
            this.deliveryTable.OwnerDraw = true;
            this.deliveryTable.Size = new System.Drawing.Size(700, 153);
            this.deliveryTable.TabIndex = 2;
            this.deliveryTable.UseCompatibleStateImageBehavior = false;
            this.deliveryTable.View = System.Windows.Forms.View.Details;
            this.deliveryTable.DoubleClick += new System.EventHandler(this.deliveryTable_DoubleClick);
            // 
            // track
            // 
            this.track.Text = "Трек";
            this.track.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Статус";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Тариф";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            this.columnHeader3.Width = 110;
            // 
            // cargoList
            // 
            this.cargoList.AutoSizeTable = false;
            this.cargoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cargoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader8});
            this.cargoList.Depth = 0;
            this.cargoList.FullRowSelect = true;
            this.cargoList.HideSelection = false;
            this.cargoList.Location = new System.Drawing.Point(6, 291);
            this.cargoList.MinimumSize = new System.Drawing.Size(200, 100);
            this.cargoList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cargoList.MouseState = MaterialSkin.MouseState.OUT;
            this.cargoList.Name = "cargoList";
            this.cargoList.OwnerDraw = true;
            this.cargoList.Size = new System.Drawing.Size(703, 153);
            this.cargoList.TabIndex = 3;
            this.cargoList.UseCompatibleStateImageBehavior = false;
            this.cargoList.View = System.Windows.Forms.View.Details;
            this.cargoList.SelectedIndexChanged += new System.EventHandler(this.cargoType_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Наименование";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 178;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Трек-номер";
            this.columnHeader7.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Габариты";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Вес, г.";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 269);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Отправленный груз";
            // 
            // deleteMenu
            // 
            this.deleteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItem});
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(119, 26);
            // 
            // deleteItem
            // 
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(118, 22);
            this.deleteItem.Text = "Удалить";
            // 
            // addDeliveryButton
            // 
            this.addDeliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDeliveryButton.Depth = 0;
            this.addDeliveryButton.Icon = global::CSADB.Properties.Resources.PLUS;
            this.addDeliveryButton.Location = new System.Drawing.Point(731, 326);
            this.addDeliveryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addDeliveryButton.Name = "addDeliveryButton";
            this.addDeliveryButton.Size = new System.Drawing.Size(56, 56);
            this.addDeliveryButton.TabIndex = 7;
            this.addDeliveryButton.UseVisualStyleBackColor = true;
            this.addDeliveryButton.Click += new System.EventHandler(this.createDelivery_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Depth = 0;
            this.updateButton.Icon = global::CSADB.Properties.Resources.update1;
            this.updateButton.Location = new System.Drawing.Point(731, 388);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(56, 56);
            this.updateButton.TabIndex = 6;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 455);
            this.Controls.Add(this.addDeliveryButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cargoList);
            this.Controls.Add(this.deliveryTable);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Sizable = false;
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.Click += new System.EventHandler(this.ClientForm_Click);
            this.deleteMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView deliveryTable;
        private System.Windows.Forms.ColumnHeader track;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialListView cargoList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ContextMenuStrip deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private MaterialSkin.Controls.MaterialFloatingActionButton updateButton;
        private MaterialSkin.Controls.MaterialFloatingActionButton addDeliveryButton;
    }
}