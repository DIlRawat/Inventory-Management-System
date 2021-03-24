namespace Inventory_Management_SystemsForm
{
    partial class HomePage
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HomePageSidePanel = new System.Windows.Forms.Panel();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.SuppliesButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.InventoryAlertsGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.ScheduledDeliveriesGroupBox = new System.Windows.Forms.GroupBox();
            this.HomePageSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HomePageSidePanel
            // 
            this.HomePageSidePanel.BackColor = System.Drawing.Color.SlateGray;
            this.HomePageSidePanel.Controls.Add(this.SettingsButton);
            this.HomePageSidePanel.Controls.Add(this.SuppliesButton);
            this.HomePageSidePanel.Controls.Add(this.CustomersButton);
            this.HomePageSidePanel.Controls.Add(this.SalesButton);
            this.HomePageSidePanel.Controls.Add(this.InventoryButton);
            this.HomePageSidePanel.Controls.Add(this.ProfilePictureBox);
            this.HomePageSidePanel.Controls.Add(this.UserNameTextBox);
            this.HomePageSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomePageSidePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePageSidePanel.Name = "HomePageSidePanel";
            this.HomePageSidePanel.Size = new System.Drawing.Size(220, 684);
            this.HomePageSidePanel.TabIndex = 1;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(12, 185);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.ReadOnly = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(191, 30);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.Text = "Test Company";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.BackColor = System.Drawing.Color.White;
            this.ProfilePictureBox.Location = new System.Drawing.Point(42, 35);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(112, 114);
            this.ProfilePictureBox.TabIndex = 1;
            this.ProfilePictureBox.TabStop = false;
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(12, 260);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(191, 38);
            this.InventoryButton.TabIndex = 2;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(12, 340);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(191, 38);
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(12, 421);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(191, 38);
            this.CustomersButton.TabIndex = 4;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            // 
            // SuppliesButton
            // 
            this.SuppliesButton.Location = new System.Drawing.Point(12, 508);
            this.SuppliesButton.Name = "SuppliesButton";
            this.SuppliesButton.Size = new System.Drawing.Size(191, 38);
            this.SuppliesButton.TabIndex = 5;
            this.SuppliesButton.Text = "Suppliers";
            this.SuppliesButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 592);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(191, 38);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // InventoryAlertsGroupBox
            // 
            this.InventoryAlertsGroupBox.Location = new System.Drawing.Point(245, 35);
            this.InventoryAlertsGroupBox.Name = "InventoryAlertsGroupBox";
            this.InventoryAlertsGroupBox.Size = new System.Drawing.Size(252, 263);
            this.InventoryAlertsGroupBox.TabIndex = 2;
            this.InventoryAlertsGroupBox.TabStop = false;
            this.InventoryAlertsGroupBox.Text = "Inventory Alerts";
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Location = new System.Drawing.Point(579, 35);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(252, 263);
            this.SalesGroupBox.TabIndex = 3;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Sales";
            // 
            // ScheduledDeliveriesGroupBox
            // 
            this.ScheduledDeliveriesGroupBox.Location = new System.Drawing.Point(245, 363);
            this.ScheduledDeliveriesGroupBox.Name = "ScheduledDeliveriesGroupBox";
            this.ScheduledDeliveriesGroupBox.Size = new System.Drawing.Size(586, 267);
            this.ScheduledDeliveriesGroupBox.TabIndex = 4;
            this.ScheduledDeliveriesGroupBox.TabStop = false;
            this.ScheduledDeliveriesGroupBox.Text = "Scheduled Deliveries";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 684);
            this.Controls.Add(this.ScheduledDeliveriesGroupBox);
            this.Controls.Add(this.SalesGroupBox);
            this.Controls.Add(this.InventoryAlertsGroupBox);
            this.Controls.Add(this.HomePageSidePanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "Inventory Management Systems";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.HomePageSidePanel.ResumeLayout(false);
            this.HomePageSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel HomePageSidePanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button SuppliesButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.GroupBox InventoryAlertsGroupBox;
        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.GroupBox ScheduledDeliveriesGroupBox;
    }
}

