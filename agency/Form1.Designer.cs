namespace agency
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.loginInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passwordInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.closeRegistration = new System.Windows.Forms.PictureBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.verificationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verificationCodeInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.newPasswordSecondInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.newPasswordInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.newLoginInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.topPanel.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(449, 355);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(93, 29);
            this.enterButton.TabIndex = 9;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(346, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Для входа в систему введите логин и пароль";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1004, 35);
            this.topPanel.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(962, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 29);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(923, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(33, 29);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // loginInput
            // 
            this.loginInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.loginInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginInput.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.loginInput.BorderThickness = 3;
            this.loginInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginInput.isPassword = false;
            this.loginInput.Location = new System.Drawing.Point(310, 233);
            this.loginInput.Margin = new System.Windows.Forms.Padding(4);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(370, 44);
            this.loginInput.TabIndex = 10;
            this.loginInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.passwordInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordInput.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.passwordInput.BorderThickness = 3;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordInput.isPassword = true;
            this.passwordInput.Location = new System.Drawing.Point(310, 285);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(370, 44);
            this.passwordInput.TabIndex = 10;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(352, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Еще не зарегистрированы?";
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.registrationLabel.Location = new System.Drawing.Point(551, 398);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(90, 17);
            this.registrationLabel.TabIndex = 8;
            this.registrationLabel.Text = "Регистрация";
            this.registrationLabel.Click += new System.EventHandler(this.registrationLabel_Click);
            // 
            // registrationPanel
            // 
            this.registrationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationPanel.Controls.Add(this.closeRegistration);
            this.registrationPanel.Controls.Add(this.registrationButton);
            this.registrationPanel.Controls.Add(this.verificationLabel);
            this.registrationPanel.Controls.Add(this.label6);
            this.registrationPanel.Controls.Add(this.label5);
            this.registrationPanel.Controls.Add(this.label4);
            this.registrationPanel.Controls.Add(this.label3);
            this.registrationPanel.Controls.Add(this.verificationCodeInput);
            this.registrationPanel.Controls.Add(this.newPasswordSecondInput);
            this.registrationPanel.Controls.Add(this.newPasswordInput);
            this.registrationPanel.Controls.Add(this.newLoginInput);
            this.registrationPanel.Location = new System.Drawing.Point(113, 71);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(767, 492);
            this.registrationPanel.TabIndex = 11;
            this.registrationPanel.Visible = false;
            // 
            // closeRegistration
            // 
            this.closeRegistration.BackColor = System.Drawing.Color.LightSalmon;
            this.closeRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRegistration.Image = ((System.Drawing.Image)(resources.GetObject("closeRegistration.Image")));
            this.closeRegistration.Location = new System.Drawing.Point(744, 1);
            this.closeRegistration.Name = "closeRegistration";
            this.closeRegistration.Size = new System.Drawing.Size(20, 20);
            this.closeRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeRegistration.TabIndex = 11;
            this.closeRegistration.TabStop = false;
            this.closeRegistration.Click += new System.EventHandler(this.closeRegistration_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(260, 308);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(250, 29);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // verificationLabel
            // 
            this.verificationLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verificationLabel.ForeColor = System.Drawing.Color.Silver;
            this.verificationLabel.Location = new System.Drawing.Point(241, 373);
            this.verificationLabel.Name = "verificationLabel";
            this.verificationLabel.Size = new System.Drawing.Size(191, 41);
            this.verificationLabel.TabIndex = 9;
            this.verificationLabel.Text = "Мы выслали вам на почту код подтверждения";
            this.verificationLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(76, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пароль еще раз";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(137, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(148, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(266, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите почту и придумайте пароль";
            // 
            // verificationCodeInput
            // 
            this.verificationCodeInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.verificationCodeInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificationCodeInput.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.verificationCodeInput.BorderThickness = 3;
            this.verificationCodeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verificationCodeInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.verificationCodeInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificationCodeInput.isPassword = false;
            this.verificationCodeInput.Location = new System.Drawing.Point(439, 370);
            this.verificationCodeInput.Margin = new System.Windows.Forms.Padding(4);
            this.verificationCodeInput.Name = "verificationCodeInput";
            this.verificationCodeInput.Size = new System.Drawing.Size(101, 44);
            this.verificationCodeInput.TabIndex = 0;
            this.verificationCodeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.verificationCodeInput.Visible = false;
            this.verificationCodeInput.OnValueChanged += new System.EventHandler(this.verificationCodeInput_OnValueChanged);
            // 
            // newPasswordSecondInput
            // 
            this.newPasswordSecondInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.newPasswordSecondInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPasswordSecondInput.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.newPasswordSecondInput.BorderThickness = 3;
            this.newPasswordSecondInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordSecondInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPasswordSecondInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPasswordSecondInput.isPassword = true;
            this.newPasswordSecondInput.Location = new System.Drawing.Point(201, 255);
            this.newPasswordSecondInput.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordSecondInput.Name = "newPasswordSecondInput";
            this.newPasswordSecondInput.Size = new System.Drawing.Size(370, 44);
            this.newPasswordSecondInput.TabIndex = 0;
            this.newPasswordSecondInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.newPasswordInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPasswordInput.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.newPasswordInput.BorderThickness = 3;
            this.newPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPasswordInput.isPassword = true;
            this.newPasswordInput.Location = new System.Drawing.Point(201, 203);
            this.newPasswordInput.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.Size = new System.Drawing.Size(370, 44);
            this.newPasswordInput.TabIndex = 0;
            this.newPasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newLoginInput
            // 
            this.newLoginInput.BorderColorFocused = System.Drawing.Color.Blue;
            this.newLoginInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newLoginInput.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.newLoginInput.BorderThickness = 3;
            this.newLoginInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newLoginInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newLoginInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newLoginInput.isPassword = false;
            this.newLoginInput.Location = new System.Drawing.Point(201, 150);
            this.newLoginInput.Margin = new System.Windows.Forms.Padding(4);
            this.newLoginInput.Name = "newLoginInput";
            this.newLoginInput.Size = new System.Drawing.Size(370, 44);
            this.newLoginInput.TabIndex = 0;
            this.newLoginInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 601);
            this.Controls.Add(this.registrationPanel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox loginInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox newPasswordInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox newLoginInput;
        private System.Windows.Forms.PictureBox closeRegistration;
        private System.Windows.Forms.Label verificationLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox verificationCodeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox newPasswordSecondInput;
    }
}

