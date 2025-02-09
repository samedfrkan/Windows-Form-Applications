
using System.Windows.Forms;

namespace ShoeOrderingSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSelectedOrder = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.listBoxBrandModel = new System.Windows.Forms.ListBox();
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.listBoxDistrict = new System.Windows.Forms.ListBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelSizes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sizes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(43, 37);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(184, 37);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(132, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // labelSelectedOrder
            // 
            this.labelSelectedOrder.AutoSize = true;
            this.labelSelectedOrder.Location = new System.Drawing.Point(12, 100);
            this.labelSelectedOrder.Name = "labelSelectedOrder";
            this.labelSelectedOrder.Size = new System.Drawing.Size(0, 13);
            this.labelSelectedOrder.TabIndex = 9;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(325, 37);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxPhoneNumber.TabIndex = 2;
            // 
            // listBoxBrandModel
            // 
            this.listBoxBrandModel.FormattingEnabled = true;
            this.listBoxBrandModel.ItemHeight = 16;
            this.listBoxBrandModel.Location = new System.Drawing.Point(43, 95);
            this.listBoxBrandModel.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxBrandModel.Name = "listBoxBrandModel";
            this.listBoxBrandModel.Size = new System.Drawing.Size(159, 116);
            this.listBoxBrandModel.TabIndex = 3;
            this.listBoxBrandModel.SelectedIndexChanged += new System.EventHandler(this.listBoxBrandModel_SelectedIndexChanged);
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 16;
            this.listBoxCity.Location = new System.Drawing.Point(43, 233);
            this.listBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(132, 84);
            this.listBoxCity.TabIndex = 5;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // listBoxDistrict
            // 
            this.listBoxDistrict.FormattingEnabled = true;
            this.listBoxDistrict.ItemHeight = 16;
            this.listBoxDistrict.Location = new System.Drawing.Point(43, 340);
            this.listBoxDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDistrict.Name = "listBoxDistrict";
            this.listBoxDistrict.Size = new System.Drawing.Size(132, 84);
            this.listBoxDistrict.TabIndex = 6;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(42, 451);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(328, 28);
            this.btnCreateOrder.TabIndex = 7;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(417, 212);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(439, 212);
            this.listBoxOrders.TabIndex = 8;
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            // 
            // flowLayoutPanelSizes
            // 
            this.flowLayoutPanelSizes.Location = new System.Drawing.Point(211, 95);
            this.flowLayoutPanelSizes.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelSizes.Name = "flowLayoutPanelSizes";
            this.flowLayoutPanelSizes.Size = new System.Drawing.Size(159, 259);
            this.flowLayoutPanelSizes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "INFO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Brands/Models";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "District";
            // 
            // Sizes
            // 
            this.Sizes.AutoSize = true;
            this.Sizes.Location = new System.Drawing.Point(218, 74);
            this.Sizes.Name = "Sizes";
            this.Sizes.Size = new System.Drawing.Size(101, 17);
            this.Sizes.TabIndex = 18;
            this.Sizes.Text = "Available sizes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 492);
            this.Controls.Add(this.Sizes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelSizes);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.listBoxDistrict);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.listBoxBrandModel);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Shoe Ordering System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private Label labelSelectedOrder;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ListBox listBoxBrandModel;
        private System.Windows.Forms.ListBox listBoxCity;
        private System.Windows.Forms.ListBox listBoxDistrict;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSizes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label Sizes;
    }
}