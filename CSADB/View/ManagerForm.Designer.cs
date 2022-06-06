namespace CSADB.View
{
    partial class ManagerForm
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
            this.managerTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.courierListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // managerTabControl
            // 
            this.managerTabControl.Controls.Add(this.tabPage1);
            this.managerTabControl.Controls.Add(this.tabPage2);
            this.managerTabControl.Controls.Add(this.tabPage3);
            this.managerTabControl.Depth = 0;
            this.managerTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerTabControl.Location = new System.Drawing.Point(3, 112);
            this.managerTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.managerTabControl.Multiline = true;
            this.managerTabControl.Name = "managerTabControl";
            this.managerTabControl.SelectedIndex = 0;
            this.managerTabControl.Size = new System.Drawing.Size(794, 337);
            this.managerTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.courierListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Курьеры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Грузы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.managerTabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(794, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.TabIndicatorHeight = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Доставки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // courierListView
            // 
            this.courierListView.AutoSizeTable = false;
            this.courierListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.courierListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courierListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.courierListView.Depth = 0;
            this.courierListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courierListView.FullRowSelect = true;
            this.courierListView.HideSelection = false;
            this.courierListView.Location = new System.Drawing.Point(3, 3);
            this.courierListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.courierListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.courierListView.MouseState = MaterialSkin.MouseState.OUT;
            this.courierListView.Name = "courierListView";
            this.courierListView.OwnerDraw = true;
            this.courierListView.Size = new System.Drawing.Size(780, 302);
            this.courierListView.TabIndex = 0;
            this.courierListView.UseCompatibleStateImageBehavior = false;
            this.courierListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата рождения";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер телефона";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Партнерская компания";
            this.columnHeader5.Width = 206;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Город";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Имеется машина";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Текущий статус";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managerTabControl);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.managerTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl managerTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialListView courierListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}