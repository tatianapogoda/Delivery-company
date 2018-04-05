using System;

namespace DeliveryCompanyCQG
{
    partial class MainForm
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
            this.itemsList = new System.Windows.Forms.CheckedListBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.suppliers = new System.Windows.Forms.RichTextBox();
            this.combinedOrderLabel = new System.Windows.Forms.Label();
            this.clients = new System.Windows.Forms.RichTextBox();
            this.customerOrdersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.itemsList.Location = new System.Drawing.Point(240, 39);
            this.itemsList.Margin = new System.Windows.Forms.Padding(4);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(225, 109);
            this.itemsList.TabIndex = 0;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(590, 39);
            this.orderButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(95, 65);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // supplierBox
            // 
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.supplierBox.Location = new System.Drawing.Point(18, 127);
            this.supplierBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(180, 27);
            this.supplierBox.TabIndex = 2;
            // 
            // clientBox
            // 
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Items.AddRange(new object[] {
            "Client1",
            "Client2",
            "Client3"});
            this.clientBox.Location = new System.Drawing.Point(18, 39);
            this.clientBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(180, 27);
            this.clientBox.TabIndex = 3;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(18, 13);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(44, 19);
            this.clientLabel.TabIndex = 4;
            this.clientLabel.Text = "Client";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(18, 104);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(59, 19);
            this.supplierLabel.TabIndex = 5;
            this.supplierLabel.Text = "Supplier";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(333, 13);
            this.itemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(42, 19);
            this.itemsLabel.TabIndex = 6;
            this.itemsLabel.Text = "Items";
            // 
            // suppliers
            // 
            this.suppliers.Location = new System.Drawing.Point(18, 232);
            this.suppliers.Margin = new System.Windows.Forms.Padding(4);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(321, 138);
            this.suppliers.TabIndex = 7;
            this.suppliers.Text = "";
            // 
            // combinedOrderLabel
            // 
            this.combinedOrderLabel.AutoSize = true;
            this.combinedOrderLabel.Location = new System.Drawing.Point(74, 195);
            this.combinedOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combinedOrderLabel.Name = "combinedOrderLabel";
            this.combinedOrderLabel.Size = new System.Drawing.Size(176, 19);
            this.combinedOrderLabel.TabIndex = 9;
            this.combinedOrderLabel.Text = "Combined order to supplier";
            // 
            // clients
            // 
            this.clients.Location = new System.Drawing.Point(357, 232);
            this.clients.Margin = new System.Windows.Forms.Padding(4);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(328, 138);
            this.clients.TabIndex = 10;
            this.clients.Text = "";
            // 
            // customerOrdersLabel
            // 
            this.customerOrdersLabel.AutoSize = true;
            this.customerOrdersLabel.Location = new System.Drawing.Point(470, 195);
            this.customerOrdersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerOrdersLabel.Name = "customerOrdersLabel";
            this.customerOrdersLabel.Size = new System.Drawing.Size(111, 19);
            this.customerOrdersLabel.TabIndex = 11;
            this.customerOrdersLabel.Text = "Customer orders";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(705, 388);
            this.Controls.Add(this.customerOrdersLabel);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.combinedOrderLabel);
            this.Controls.Add(this.suppliers);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.supplierBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.itemsList);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.CheckedListBox itemsList;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.RichTextBox suppliers;
        private System.Windows.Forms.Label combinedOrderLabel;
        private System.Windows.Forms.RichTextBox clients;
        private System.Windows.Forms.Label customerOrdersLabel;
    }
}

