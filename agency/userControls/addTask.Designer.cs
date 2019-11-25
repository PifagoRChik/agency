namespace agency.userControls
{
    partial class addTask
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
            this.label6 = new System.Windows.Forms.Label();
            this.typeTask = new System.Windows.Forms.ComboBox();
            this.aboutTask = new System.Windows.Forms.RichTextBox();
            this.squareTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPhoto = new System.Windows.Forms.Button();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип объявления";
            // 
            // typeTask
            // 
            this.typeTask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTask.FormattingEnabled = true;
            this.typeTask.Items.AddRange(new object[] {
            "Продажа",
            "Снятие"});
            this.typeTask.Location = new System.Drawing.Point(171, 119);
            this.typeTask.Name = "typeTask";
            this.typeTask.Size = new System.Drawing.Size(206, 28);
            this.typeTask.TabIndex = 11;
            // 
            // aboutTask
            // 
            this.aboutTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutTask.Location = new System.Drawing.Point(48, 171);
            this.aboutTask.Name = "aboutTask";
            this.aboutTask.Size = new System.Drawing.Size(746, 272);
            this.aboutTask.TabIndex = 12;
            this.aboutTask.Text = "";
            // 
            // squareTextbox
            // 
            this.squareTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareTextbox.Location = new System.Drawing.Point(612, 118);
            this.squareTextbox.Name = "squareTextbox";
            this.squareTextbox.Size = new System.Drawing.Size(182, 27);
            this.squareTextbox.TabIndex = 13;
            this.squareTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(499, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Площадь, м2";
            // 
            // addPhoto
            // 
            this.addPhoto.BackColor = System.Drawing.Color.Coral;
            this.addPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhoto.FlatAppearance.BorderSize = 0;
            this.addPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhoto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addPhoto.Location = new System.Drawing.Point(817, 363);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(259, 23);
            this.addPhoto.TabIndex = 14;
            this.addPhoto.TabStop = false;
            this.addPhoto.Text = "Добавить фото";
            this.addPhoto.UseVisualStyleBackColor = false;
            this.addPhoto.Click += new System.EventHandler(this.addPhoto_Click);
            // 
            // photoBox
            // 
            this.photoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoBox.Location = new System.Drawing.Point(817, 171);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(259, 172);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 15;
            this.photoBox.TabStop = false;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.Coral;
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTaskButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addTaskButton.Location = new System.Drawing.Point(940, 557);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(136, 36);
            this.addTaskButton.TabIndex = 14;
            this.addTaskButton.TabStop = false;
            this.addTaskButton.Text = "Добавить объявление";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(474, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Добавление";
            // 
            // addTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.addPhoto);
            this.Controls.Add(this.squareTextbox);
            this.Controls.Add(this.aboutTask);
            this.Controls.Add(this.typeTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "addTask";
            this.Size = new System.Drawing.Size(1095, 610);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeTask;
        private System.Windows.Forms.RichTextBox aboutTask;
        private System.Windows.Forms.TextBox squareTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPhoto;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label label2;
    }
}
