namespace agency.userControls
{
    partial class allTasks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allTasks));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.panelTask = new System.Windows.Forms.Panel();
            this.panelManagerAll = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addManager = new System.Windows.Forms.Button();
            this.squareLabel = new System.Windows.Forms.Label();
            this.typeTask = new System.Windows.Forms.Label();
            this.captchaText = new System.Windows.Forms.Label();
            this.buildPhoto = new System.Windows.Forms.PictureBox();
            this.closePanelTask = new System.Windows.Forms.PictureBox();
            this.panelManagerClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTask.SuspendLayout();
            this.panelManagerAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePanelTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelManagerClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(121, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(853, 419);
            this.dataGridView1.TabIndex = 0;
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
            this.Column2.HeaderText = "Описание";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 550;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Тип";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(231)))));
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(808, 498);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(166, 28);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Показать/обновить";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panelTask
            // 
            this.panelTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTask.Controls.Add(this.closePanelTask);
            this.panelTask.Controls.Add(this.panelManagerAll);
            this.panelTask.Controls.Add(this.addManager);
            this.panelTask.Controls.Add(this.squareLabel);
            this.panelTask.Controls.Add(this.typeTask);
            this.panelTask.Controls.Add(this.captchaText);
            this.panelTask.Controls.Add(this.buildPhoto);
            this.panelTask.Location = new System.Drawing.Point(82, 36);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(926, 534);
            this.panelTask.TabIndex = 3;
            this.panelTask.Visible = false;
            // 
            // panelManagerAll
            // 
            this.panelManagerAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManagerAll.Controls.Add(this.panelManagerClose);
            this.panelManagerAll.Controls.Add(this.dataGridView2);
            this.panelManagerAll.Location = new System.Drawing.Point(139, 88);
            this.panelManagerAll.Name = "panelManagerAll";
            this.panelManagerAll.Size = new System.Drawing.Size(652, 371);
            this.panelManagerAll.TabIndex = 4;
            this.panelManagerAll.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(72, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(504, 220);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Телефон";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // addManager
            // 
            this.addManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(231)))));
            this.addManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addManager.FlatAppearance.BorderSize = 0;
            this.addManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addManager.ForeColor = System.Drawing.Color.White;
            this.addManager.Location = new System.Drawing.Point(717, 503);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(206, 28);
            this.addManager.TabIndex = 3;
            this.addManager.Text = "Назначить менеджера";
            this.addManager.UseVisualStyleBackColor = false;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareLabel.Location = new System.Drawing.Point(549, 210);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(78, 20);
            this.squareLabel.TabIndex = 1;
            this.squareLabel.Text = "Площадь";
            // 
            // typeTask
            // 
            this.typeTask.AutoSize = true;
            this.typeTask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTask.Location = new System.Drawing.Point(549, 26);
            this.typeTask.Name = "typeTask";
            this.typeTask.Size = new System.Drawing.Size(121, 20);
            this.typeTask.TabIndex = 1;
            this.typeTask.Text = "Тип объявления";
            // 
            // captchaText
            // 
            this.captchaText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captchaText.Location = new System.Drawing.Point(45, 247);
            this.captchaText.Name = "captchaText";
            this.captchaText.Size = new System.Drawing.Size(837, 212);
            this.captchaText.TabIndex = 1;
            this.captchaText.Text = "Описание";
            // 
            // buildPhoto
            // 
            this.buildPhoto.Location = new System.Drawing.Point(106, 17);
            this.buildPhoto.Name = "buildPhoto";
            this.buildPhoto.Size = new System.Drawing.Size(390, 213);
            this.buildPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buildPhoto.TabIndex = 0;
            this.buildPhoto.TabStop = false;
            // 
            // closePanelTask
            // 
            this.closePanelTask.BackColor = System.Drawing.Color.LightSalmon;
            this.closePanelTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanelTask.Image = ((System.Drawing.Image)(resources.GetObject("closePanelTask.Image")));
            this.closePanelTask.Location = new System.Drawing.Point(901, 3);
            this.closePanelTask.Name = "closePanelTask";
            this.closePanelTask.Size = new System.Drawing.Size(20, 20);
            this.closePanelTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePanelTask.TabIndex = 5;
            this.closePanelTask.TabStop = false;
            this.closePanelTask.Click += new System.EventHandler(this.closePanelTask_Click);
            // 
            // panelManagerClose
            // 
            this.panelManagerClose.BackColor = System.Drawing.Color.LightSalmon;
            this.panelManagerClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelManagerClose.Image = ((System.Drawing.Image)(resources.GetObject("panelManagerClose.Image")));
            this.panelManagerClose.Location = new System.Drawing.Point(627, 3);
            this.panelManagerClose.Name = "panelManagerClose";
            this.panelManagerClose.Size = new System.Drawing.Size(20, 20);
            this.panelManagerClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelManagerClose.TabIndex = 5;
            this.panelManagerClose.TabStop = false;
            this.panelManagerClose.Click += new System.EventHandler(this.panelManagerClose_Click);
            // 
            // allTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allTasks";
            this.Size = new System.Drawing.Size(1095, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.panelManagerAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePanelTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelManagerClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Label typeTask;
        private System.Windows.Forms.Label captchaText;
        private System.Windows.Forms.PictureBox buildPhoto;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.Panel panelManagerAll;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox closePanelTask;
        private System.Windows.Forms.PictureBox panelManagerClose;
    }
}
