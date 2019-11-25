namespace agency.userControls
{
    partial class helpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(492, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Помощь";
            // 
            // messageInput
            // 
            this.messageInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageInput.Location = new System.Drawing.Point(99, 176);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(879, 301);
            this.messageInput.TabIndex = 18;
            this.messageInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Если у вас остались вопросы или обнаружены неисправности, опишите, пожалуйста, по" +
    "дробно свою проблему";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(423, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Почта для обратной связи";
            // 
            // mailInput
            // 
            this.mailInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailInput.Location = new System.Drawing.Point(99, 127);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(318, 27);
            this.mailInput.TabIndex = 20;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Coral;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sendButton.Location = new System.Drawing.Point(981, 564);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(111, 35);
            this.sendButton.TabIndex = 22;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.BackColor = System.Drawing.Color.Coral;
            this.addFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFileButton.FlatAppearance.BorderSize = 0;
            this.addFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFileButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFileButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addFileButton.Location = new System.Drawing.Point(784, 483);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(194, 25);
            this.addFileButton.TabIndex = 22;
            this.addFileButton.TabStop = false;
            this.addFileButton.Text = "Прикрепить файл";
            this.addFileButton.UseVisualStyleBackColor = false;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.label2);
            this.Name = "helpForm";
            this.Size = new System.Drawing.Size(1095, 610);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox messageInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button addFileButton;
    }
}
