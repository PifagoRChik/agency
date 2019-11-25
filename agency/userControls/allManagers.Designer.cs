namespace agency.userControls
{
    partial class allManagers
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.addManager = new System.Windows.Forms.Button();
            this.managerPanel = new System.Windows.Forms.Panel();
            this.saveManager = new System.Windows.Forms.Button();
            this.managerPhoto = new System.Windows.Forms.PictureBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.secondNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPhoto = new System.Windows.Forms.Button();
            this.loginInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.managerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(115, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(853, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Имя";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(479, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Менеджеры";
            // 
            // addManager
            // 
            this.addManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(231)))));
            this.addManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addManager.FlatAppearance.BorderSize = 0;
            this.addManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addManager.ForeColor = System.Drawing.Color.White;
            this.addManager.Location = new System.Drawing.Point(762, 505);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(206, 28);
            this.addManager.TabIndex = 4;
            this.addManager.Text = "Добавить менеджера";
            this.addManager.UseVisualStyleBackColor = false;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // managerPanel
            // 
            this.managerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.managerPanel.Controls.Add(this.addPhoto);
            this.managerPanel.Controls.Add(this.label6);
            this.managerPanel.Controls.Add(this.label5);
            this.managerPanel.Controls.Add(this.loginInput);
            this.managerPanel.Controls.Add(this.numberInput);
            this.managerPanel.Controls.Add(this.label4);
            this.managerPanel.Controls.Add(this.label3);
            this.managerPanel.Controls.Add(this.label2);
            this.managerPanel.Controls.Add(this.secondNameInput);
            this.managerPanel.Controls.Add(this.nameInput);
            this.managerPanel.Controls.Add(this.surnameInput);
            this.managerPanel.Controls.Add(this.managerPhoto);
            this.managerPanel.Controls.Add(this.saveManager);
            this.managerPanel.Location = new System.Drawing.Point(115, 43);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(853, 502);
            this.managerPanel.TabIndex = 5;
            this.managerPanel.Visible = false;
            // 
            // saveManager
            // 
            this.saveManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(231)))));
            this.saveManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveManager.FlatAppearance.BorderSize = 0;
            this.saveManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveManager.ForeColor = System.Drawing.Color.White;
            this.saveManager.Location = new System.Drawing.Point(644, 471);
            this.saveManager.Name = "saveManager";
            this.saveManager.Size = new System.Drawing.Size(206, 28);
            this.saveManager.TabIndex = 4;
            this.saveManager.Text = "Сохранить";
            this.saveManager.UseVisualStyleBackColor = false;
            this.saveManager.Click += new System.EventHandler(this.saveManager_Click);
            // 
            // managerPhoto
            // 
            this.managerPhoto.Location = new System.Drawing.Point(26, 22);
            this.managerPhoto.Name = "managerPhoto";
            this.managerPhoto.Size = new System.Drawing.Size(229, 241);
            this.managerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.managerPhoto.TabIndex = 5;
            this.managerPhoto.TabStop = false;
            // 
            // surnameInput
            // 
            this.surnameInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameInput.Location = new System.Drawing.Point(568, 22);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(256, 27);
            this.surnameInput.TabIndex = 6;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInput.Location = new System.Drawing.Point(568, 106);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(256, 27);
            this.nameInput.TabIndex = 6;
            // 
            // secondNameInput
            // 
            this.secondNameInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameInput.Location = new System.Drawing.Point(568, 190);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(256, 27);
            this.secondNameInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(477, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(477, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(475, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Телефон";
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberInput.Location = new System.Drawing.Point(118, 392);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(256, 27);
            this.numberInput.TabIndex = 8;
            this.numberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Логин";
            // 
            // addPhoto
            // 
            this.addPhoto.BackColor = System.Drawing.Color.Coral;
            this.addPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhoto.FlatAppearance.BorderSize = 0;
            this.addPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhoto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addPhoto.Location = new System.Drawing.Point(26, 269);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(229, 23);
            this.addPhoto.TabIndex = 15;
            this.addPhoto.TabStop = false;
            this.addPhoto.Text = "Добавить фото";
            this.addPhoto.UseVisualStyleBackColor = false;
            this.addPhoto.Click += new System.EventHandler(this.addPhoto_Click);
            // 
            // loginInput
            // 
            this.loginInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginInput.Location = new System.Drawing.Point(118, 428);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(256, 27);
            this.loginInput.TabIndex = 8;
            // 
            // allManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managerPanel);
            this.Controls.Add(this.addManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allManagers";
            this.Size = new System.Drawing.Size(1095, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.managerPanel.ResumeLayout(false);
            this.managerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Panel managerPanel;
        private System.Windows.Forms.Button saveManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.PictureBox managerPhoto;
        private System.Windows.Forms.Button addPhoto;
        private System.Windows.Forms.TextBox loginInput;
    }
}
