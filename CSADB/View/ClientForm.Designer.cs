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
            this.createDelivery = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.deliveryTable = new MaterialSkin.Controls.MaterialListView();
            this.track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // createDelivery
            // 
            this.createDelivery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createDelivery.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createDelivery.Depth = 0;
            this.createDelivery.HighEmphasis = true;
            this.createDelivery.Icon = null;
            this.createDelivery.Location = new System.Drawing.Point(635, 70);
            this.createDelivery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createDelivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.createDelivery.Name = "createDelivery";
            this.createDelivery.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createDelivery.Size = new System.Drawing.Size(158, 36);
            this.createDelivery.TabIndex = 0;
            this.createDelivery.Text = "Отправить заказ";
            this.createDelivery.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createDelivery.UseAccentColor = false;
            this.createDelivery.UseVisualStyleBackColor = true;
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
            this.deliveryTable.Location = new System.Drawing.Point(9, 102);
            this.deliveryTable.MinimumSize = new System.Drawing.Size(200, 100);
            this.deliveryTable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.deliveryTable.MouseState = MaterialSkin.MouseState.OUT;
            this.deliveryTable.Name = "deliveryTable";
            this.deliveryTable.OwnerDraw = true;
            this.deliveryTable.Size = new System.Drawing.Size(538, 153);
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
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deliveryTable);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.createDelivery);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton createDelivery;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView deliveryTable;
        private System.Windows.Forms.ColumnHeader track;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}