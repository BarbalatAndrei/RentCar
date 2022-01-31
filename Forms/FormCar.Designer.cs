
namespace RentCar.Forms
{
    partial class FormCar
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
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.listTitleLabel = new System.Windows.Forms.Label();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCar.Location = new System.Drawing.Point(650, 370);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(120, 41);
            this.btnDeleteCar.TabIndex = 0;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(505, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 41);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(360, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Select Car";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(36, 80);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(51, 17);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Brand";
            this.labelBrand.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(36, 151);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 17);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(36, 231);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(54, 17);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            // 
            // btnRent
            // 
            this.btnRent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(39, 370);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(126, 41);
            this.btnRent.TabIndex = 7;
            this.btnRent.Text = "Rent Car";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // listTitleLabel
            // 
            this.listTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listTitleLabel.AutoSize = true;
            this.listTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitleLabel.Location = new System.Drawing.Point(357, 33);
            this.listTitleLabel.Name = "listTitleLabel";
            this.listTitleLabel.Size = new System.Drawing.Size(80, 20);
            this.listTitleLabel.TabIndex = 8;
            this.listTitleLabel.Text = "Cars List";
            // 
            // textBrand
            // 
            this.textBrand.Location = new System.Drawing.Point(39, 103);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(172, 20);
            this.textBrand.TabIndex = 9;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(39, 171);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(172, 20);
            this.textPrice.TabIndex = 10;
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(39, 251);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(172, 20);
            this.textStatus.TabIndex = 11;
            // 
            // listViewCars
            // 
            this.listViewCars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnBrand,
            this.columnPrice,
            this.columnStatus,
            this.columnVin});
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.GridLines = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(359, 71);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(411, 270);
            this.listViewCars.TabIndex = 12;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewCars.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCars_MouseClick);
            // 
            // columnHeader
            // 
            this.columnHeader.DisplayIndex = 4;
            this.columnHeader.Text = "Header";
            this.columnHeader.Width = 0;
            // 
            // columnBrand
            // 
            this.columnBrand.DisplayIndex = 0;
            this.columnBrand.Text = "Brand";
            this.columnBrand.Width = 120;
            // 
            // columnPrice
            // 
            this.columnPrice.DisplayIndex = 1;
            this.columnPrice.Text = "Price";
            // 
            // columnStatus
            // 
            this.columnStatus.DisplayIndex = 2;
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 80;
            // 
            // columnVin
            // 
            this.columnVin.DisplayIndex = 3;
            this.columnVin.Text = "VIN";
            this.columnVin.Width = 120;
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.listTitleLabel);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteCar);
            this.Name = "FormCar";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.FormCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label listTitleLabel;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ColumnHeader columnBrand;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnVin;
        private System.Windows.Forms.ColumnHeader columnHeader;
    }
}