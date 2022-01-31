
namespace RentCar.Forms
{
    partial class FormCustomer
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
            this.listView = new System.Windows.Forms.ListView();
            this.holder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.holder,
            this.customerId,
            this.customerFirstName,
            this.customerLastName,
            this.customerPhone,
            this.customerAddress});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(95, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(600, 351);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // holder
            // 
            this.holder.DisplayIndex = 5;
            this.holder.Text = "Holder";
            this.holder.Width = 0;
            // 
            // customerId
            // 
            this.customerId.DisplayIndex = 0;
            this.customerId.Text = "Id";
            this.customerId.Width = 40;
            // 
            // customerFirstName
            // 
            this.customerFirstName.DisplayIndex = 1;
            this.customerFirstName.Text = "FirstName";
            this.customerFirstName.Width = 100;
            // 
            // customerLastName
            // 
            this.customerLastName.DisplayIndex = 2;
            this.customerLastName.Text = "LastName";
            this.customerLastName.Width = 100;
            // 
            // customerPhone
            // 
            this.customerPhone.DisplayIndex = 3;
            this.customerPhone.Text = "Phone";
            this.customerPhone.Width = 100;
            // 
            // customerAddress
            // 
            this.customerAddress.DisplayIndex = 4;
            this.customerAddress.Text = "Address";
            this.customerAddress.Width = 100;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Name = "FormCustomer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader customerId;
        private System.Windows.Forms.ColumnHeader customerFirstName;
        private System.Windows.Forms.ColumnHeader customerLastName;
        private System.Windows.Forms.ColumnHeader customerPhone;
        private System.Windows.Forms.ColumnHeader customerAddress;
        private System.Windows.Forms.ColumnHeader holder;
    }
}