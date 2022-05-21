namespace CSADB.View
{
    partial class RegisterForm
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
            this.loginTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lastNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.middleNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.emailTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.repeatTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.CourierSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cityCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.carCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.phoneTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.AnimateReadOnly = false;
            this.loginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginTextBox.Depth = 0;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTextBox.HideSelection = true;
            this.loginTextBox.Hint = "Логин*";
            this.loginTextBox.LeadingIcon = null;
            this.loginTextBox.Location = new System.Drawing.Point(20, 99);
            this.loginTextBox.MaxLength = 32767;
            this.loginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PrefixSuffixText = null;
            this.loginTextBox.ReadOnly = false;
            this.loginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.SelectionLength = 0;
            this.loginTextBox.SelectionStart = 0;
            this.loginTextBox.ShortcutsEnabled = true;
            this.loginTextBox.Size = new System.Drawing.Size(312, 48);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.TabStop = false;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTextBox.TrailingIcon = null;
            this.loginTextBox.UseSystemPasswordChar = false;
            this.loginTextBox.Click += new System.EventHandler(this.loginTextBox_Click);
            this.loginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loginTextBox_Validating);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.Hint = "Пароль*";
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(20, 153);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(312, 48);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.HideSelection = true;
            this.nameTextBox.Hint = "Имя*";
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(377, 153);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PrefixSuffixText = null;
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(409, 48);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TabStop = false;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextBox.TrailingIcon = null;
            this.nameTextBox.UseSystemPasswordChar = false;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(374, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(176, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Информация о клиенте";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 77);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(161, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Данные авторизации";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AnimateReadOnly = false;
            this.lastNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastNameTextBox.Depth = 0;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastNameTextBox.HideSelection = true;
            this.lastNameTextBox.Hint = "Фамилия*";
            this.lastNameTextBox.LeadingIcon = null;
            this.lastNameTextBox.Location = new System.Drawing.Point(377, 99);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PrefixSuffixText = null;
            this.lastNameTextBox.ReadOnly = false;
            this.lastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.SelectionLength = 0;
            this.lastNameTextBox.SelectionStart = 0;
            this.lastNameTextBox.ShortcutsEnabled = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(409, 48);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TabStop = false;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastNameTextBox.TrailingIcon = null;
            this.lastNameTextBox.UseSystemPasswordChar = false;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTextBox_Validating);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.AnimateReadOnly = false;
            this.middleNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middleNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.middleNameTextBox.Depth = 0;
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.middleNameTextBox.HideSelection = true;
            this.middleNameTextBox.Hint = "Отчество";
            this.middleNameTextBox.LeadingIcon = null;
            this.middleNameTextBox.Location = new System.Drawing.Point(377, 207);
            this.middleNameTextBox.MaxLength = 32767;
            this.middleNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.PasswordChar = '\0';
            this.middleNameTextBox.PrefixSuffixText = null;
            this.middleNameTextBox.ReadOnly = false;
            this.middleNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.middleNameTextBox.SelectedText = "";
            this.middleNameTextBox.SelectionLength = 0;
            this.middleNameTextBox.SelectionStart = 0;
            this.middleNameTextBox.ShortcutsEnabled = true;
            this.middleNameTextBox.Size = new System.Drawing.Size(409, 48);
            this.middleNameTextBox.TabIndex = 6;
            this.middleNameTextBox.TabStop = false;
            this.middleNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.middleNameTextBox.TrailingIcon = null;
            this.middleNameTextBox.UseSystemPasswordChar = false;
            this.middleNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.middleNameTextBox_Validating);
            // 
            // emailTextBox
            // 
            this.emailTextBox.AnimateReadOnly = false;
            this.emailTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTextBox.Depth = 0;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailTextBox.HideSelection = true;
            this.emailTextBox.Hint = "E-mail";
            this.emailTextBox.LeadingIcon = null;
            this.emailTextBox.Location = new System.Drawing.Point(377, 322);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PrefixSuffixText = null;
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(409, 48);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TabStop = false;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTextBox.TrailingIcon = null;
            this.emailTextBox.UseSystemPasswordChar = false;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(660, 424);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerButton.Size = new System.Drawing.Size(126, 36);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Регистрация";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.AnimateReadOnly = false;
            this.repeatTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.repeatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.repeatTextBox.Depth = 0;
            this.repeatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.repeatTextBox.HideSelection = true;
            this.repeatTextBox.Hint = "Повторите пароль*";
            this.repeatTextBox.LeadingIcon = null;
            this.repeatTextBox.Location = new System.Drawing.Point(20, 207);
            this.repeatTextBox.MaxLength = 32767;
            this.repeatTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.PasswordChar = '*';
            this.repeatTextBox.PrefixSuffixText = null;
            this.repeatTextBox.ReadOnly = false;
            this.repeatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.repeatTextBox.SelectedText = "";
            this.repeatTextBox.SelectionLength = 0;
            this.repeatTextBox.SelectionStart = 0;
            this.repeatTextBox.ShortcutsEnabled = true;
            this.repeatTextBox.Size = new System.Drawing.Size(312, 48);
            this.repeatTextBox.TabIndex = 2;
            this.repeatTextBox.TabStop = false;
            this.repeatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.repeatTextBox.TrailingIcon = null;
            this.repeatTextBox.UseSystemPasswordChar = false;
            this.repeatTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // CourierSwitch
            // 
            this.CourierSwitch.AutoSize = true;
            this.CourierSwitch.Depth = 0;
            this.CourierSwitch.Location = new System.Drawing.Point(20, 266);
            this.CourierSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.CourierSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CourierSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.CourierSwitch.Name = "CourierSwitch";
            this.CourierSwitch.Ripple = true;
            this.CourierSwitch.Size = new System.Drawing.Size(111, 37);
            this.CourierSwitch.TabIndex = 3;
            this.CourierSwitch.Text = "Курьер";
            this.CourierSwitch.UseVisualStyleBackColor = true;
            this.CourierSwitch.CheckedChanged += new System.EventHandler(this.CourierSwitch_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(150, 320);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(182, 20);
            this.birthdayPicker.TabIndex = 13;
            this.birthdayPicker.Visible = false;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Depth = 0;
            this.birthdayLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.birthdayLabel.Location = new System.Drawing.Point(19, 320);
            this.birthdayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(125, 19);
            this.birthdayLabel.TabIndex = 14;
            this.birthdayLabel.Text = "Дата рождения*";
            this.birthdayLabel.Visible = false;
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
            this.cityCombobox.Items.AddRange(new object[] {
            "Рязань",
            "Рыбное",
            "Москва"});
            this.cityCombobox.Location = new System.Drawing.Point(377, 321);
            this.cityCombobox.MaxDropDownItems = 4;
            this.cityCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.cityCombobox.Name = "cityCombobox";
            this.cityCombobox.Size = new System.Drawing.Size(409, 49);
            this.cityCombobox.StartIndex = 0;
            this.cityCombobox.TabIndex = 9;
            this.cityCombobox.Visible = false;
            // 
            // carCheckbox
            // 
            this.carCheckbox.AutoSize = true;
            this.carCheckbox.Depth = 0;
            this.carCheckbox.Location = new System.Drawing.Point(377, 385);
            this.carCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.carCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.carCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.carCheckbox.Name = "carCheckbox";
            this.carCheckbox.ReadOnly = false;
            this.carCheckbox.Ripple = true;
            this.carCheckbox.Size = new System.Drawing.Size(165, 37);
            this.carCheckbox.TabIndex = 10;
            this.carCheckbox.Text = "Есть автомобиль";
            this.carCheckbox.UseVisualStyleBackColor = true;
            this.carCheckbox.Visible = false;
            this.carCheckbox.CheckedChanged += new System.EventHandler(this.carCheckbox_CheckedChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.AllowPromptAsInput = true;
            this.phoneTextBox.AnimateReadOnly = false;
            this.phoneTextBox.AsciiOnly = false;
            this.phoneTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.phoneTextBox.BeepOnError = false;
            this.phoneTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.phoneTextBox.Depth = 0;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneTextBox.HidePromptOnLeave = false;
            this.phoneTextBox.HideSelection = true;
            this.phoneTextBox.Hint = "Номер телефона*";
            this.phoneTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.phoneTextBox.LeadingIcon = null;
            this.phoneTextBox.Location = new System.Drawing.Point(377, 267);
            this.phoneTextBox.Mask = "+7(000) 000 00-00";
            this.phoneTextBox.MaxLength = 32767;
            this.phoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PrefixSuffixText = null;
            this.phoneTextBox.PromptChar = '_';
            this.phoneTextBox.ReadOnly = false;
            this.phoneTextBox.RejectInputOnFirstFailure = false;
            this.phoneTextBox.ResetOnPrompt = true;
            this.phoneTextBox.ResetOnSpace = true;
            this.phoneTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.SelectionLength = 0;
            this.phoneTextBox.SelectionStart = 0;
            this.phoneTextBox.ShortcutsEnabled = true;
            this.phoneTextBox.Size = new System.Drawing.Size(409, 48);
            this.phoneTextBox.SkipLiterals = true;
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.TabStop = false;
            this.phoneTextBox.Text = "+7(   )       -";
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.phoneTextBox.TrailingIcon = null;
            this.phoneTextBox.UseSystemPasswordChar = false;
            this.phoneTextBox.ValidatingType = null;
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 471);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.carCheckbox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.CourierSwitch);
            this.Controls.Add(this.repeatTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.cityCombobox);
            this.Controls.Add(this.emailTextBox);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Sizable = false;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 loginTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 nameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 lastNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 middleNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 emailTextBox;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialTextBox2 repeatTextBox;
        private MaterialSkin.Controls.MaterialSwitch CourierSwitch;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialComboBox cityCombobox;
        private MaterialSkin.Controls.MaterialLabel birthdayLabel;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private MaterialSkin.Controls.MaterialCheckbox carCheckbox;
        private MaterialSkin.Controls.MaterialMaskedTextBox phoneTextBox;
    }
}