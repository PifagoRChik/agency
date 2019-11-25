namespace agency
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.managersButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.addTask1 = new agency.userControls.addTask();
            this.allTasks1 = new agency.userControls.allTasks();
            this.allManagers1 = new agency.userControls.allManagers();
            this.helpForm1 = new agency.userControls.helpForm();
            this.topPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.topPanel.Controls.Add(this.menuButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.bunifuTransition1.SetDecoration(this.topPanel, BunifuAnimatorNS.DecorationType.None);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1095, 35);
            this.topPanel.TabIndex = 8;
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuButton.BackgroundImage")));
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Location = new System.Drawing.Point(3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 29);
            this.menuButton.TabIndex = 7;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.exitButton, BunifuAnimatorNS.DecorationType.None);
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1054, 3);
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
            this.bunifuTransition1.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1015, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(33, 29);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(95)))), ((int)(((byte)(92)))));
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.sidePanel);
            this.menuPanel.Controls.Add(this.managersButton);
            this.menuPanel.Controls.Add(this.addButton);
            this.menuPanel.Controls.Add(this.allButton);
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 35);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(237, 610);
            this.menuPanel.TabIndex = 9;
            this.menuPanel.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.helpButton, BunifuAnimatorNS.DecorationType.None);
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(15, 554);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(219, 44);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "               Помощь";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTransition1.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.sidePanel.Location = new System.Drawing.Point(3, 50);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 44);
            this.sidePanel.TabIndex = 3;
            // 
            // managersButton
            // 
            this.managersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.managersButton, BunifuAnimatorNS.DecorationType.None);
            this.managersButton.FlatAppearance.BorderSize = 0;
            this.managersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managersButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managersButton.ForeColor = System.Drawing.Color.White;
            this.managersButton.Image = ((System.Drawing.Image)(resources.GetObject("managersButton.Image")));
            this.managersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managersButton.Location = new System.Drawing.Point(15, 150);
            this.managersButton.Name = "managersButton";
            this.managersButton.Size = new System.Drawing.Size(219, 44);
            this.managersButton.TabIndex = 2;
            this.managersButton.Text = " Менеджеры";
            this.managersButton.UseVisualStyleBackColor = true;
            this.managersButton.Click += new System.EventHandler(this.managersButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.addButton, BunifuAnimatorNS.DecorationType.None);
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(15, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(219, 44);
            this.addButton.TabIndex = 2;
            this.addButton.Text = " Добавление";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // allButton
            // 
            this.allButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.allButton, BunifuAnimatorNS.DecorationType.None);
            this.allButton.FlatAppearance.BorderSize = 0;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allButton.ForeColor = System.Drawing.Color.White;
            this.allButton.Image = ((System.Drawing.Image)(resources.GetObject("allButton.Image")));
            this.allButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allButton.Location = new System.Drawing.Point(15, 50);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(222, 44);
            this.allButton.TabIndex = 1;
            this.allButton.Text = "      Все объявления";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // addTask1
            // 
            this.bunifuTransition1.SetDecoration(this.addTask1, BunifuAnimatorNS.DecorationType.None);
            this.addTask1.Location = new System.Drawing.Point(0, 35);
            this.addTask1.Name = "addTask1";
            this.addTask1.Size = new System.Drawing.Size(1095, 610);
            this.addTask1.TabIndex = 11;
            this.addTask1.Visible = false;
            // 
            // allTasks1
            // 
            this.bunifuTransition1.SetDecoration(this.allTasks1, BunifuAnimatorNS.DecorationType.None);
            this.allTasks1.Location = new System.Drawing.Point(0, 35);
            this.allTasks1.Name = "allTasks1";
            this.allTasks1.Size = new System.Drawing.Size(1095, 610);
            this.allTasks1.TabIndex = 10;
            // 
            // allManagers1
            // 
            this.bunifuTransition1.SetDecoration(this.allManagers1, BunifuAnimatorNS.DecorationType.None);
            this.allManagers1.Location = new System.Drawing.Point(0, 35);
            this.allManagers1.Name = "allManagers1";
            this.allManagers1.Size = new System.Drawing.Size(1095, 610);
            this.allManagers1.TabIndex = 12;
            this.allManagers1.Visible = false;
            // 
            // helpForm1
            // 
            this.bunifuTransition1.SetDecoration(this.helpForm1, BunifuAnimatorNS.DecorationType.None);
            this.helpForm1.Location = new System.Drawing.Point(0, 35);
            this.helpForm1.Name = "helpForm1";
            this.helpForm1.Size = new System.Drawing.Size(1095, 610);
            this.helpForm1.TabIndex = 13;
            this.helpForm1.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 645);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.helpForm1);
            this.Controls.Add(this.allManagers1);
            this.Controls.Add(this.addTask1);
            this.Controls.Add(this.allTasks1);
            this.Controls.Add(this.topPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.topPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button menuButton;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel menuPanel;
        private userControls.allTasks allTasks1;
        private userControls.addTask addTask1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button allButton;
        private userControls.allManagers allManagers1;
        private System.Windows.Forms.Button managersButton;
        private System.Windows.Forms.Button helpButton;
        private userControls.helpForm helpForm1;
    }
}