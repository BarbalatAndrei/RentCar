
namespace RentCar.Forms
{
    partial class FormOrder
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
            this.listCarListOrder = new System.Windows.Forms.ListView();
            this.columnBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEngine = new System.Windows.Forms.Label();
            this.textEngine = new System.Windows.Forms.TextBox();
            this.labelTrunk = new System.Windows.Forms.Label();
            this.labelParktroniks = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.labelSeats = new System.Windows.Forms.Label();
            this.textTrunk = new System.Windows.Forms.TextBox();
            this.textParktroniks = new System.Windows.Forms.TextBox();
            this.textSeats = new System.Windows.Forms.TextBox();
            this.textDashboard = new System.Windows.Forms.TextBox();
            this.labelAditional = new System.Windows.Forms.Label();
            this.textAutopilot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.textCurrentPrice = new System.Windows.Forms.TextBox();
            this.textNewPrice = new System.Windows.Forms.TextBox();
            this.labelAditionalLabel = new System.Windows.Forms.Label();
            this.btnAutoPilot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCarListOrder
            // 
            this.listCarListOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listCarListOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnBrand,
            this.columnPrice});
            this.listCarListOrder.FullRowSelect = true;
            this.listCarListOrder.GridLines = true;
            this.listCarListOrder.HideSelection = false;
            this.listCarListOrder.Location = new System.Drawing.Point(502, 12);
            this.listCarListOrder.Name = "listCarListOrder";
            this.listCarListOrder.Size = new System.Drawing.Size(286, 125);
            this.listCarListOrder.TabIndex = 0;
            this.listCarListOrder.UseCompatibleStateImageBehavior = false;
            this.listCarListOrder.View = System.Windows.Forms.View.Details;
            this.listCarListOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listCarListOrder_MouseClick);
            // 
            // columnBrand
            // 
            this.columnBrand.DisplayIndex = 0;
            this.columnBrand.Text = "Brand";
            this.columnBrand.Width = 160;
            // 
            // columnPrice
            // 
            this.columnPrice.DisplayIndex = 1;
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 100;
            // 
            // columnHeader
            // 
            this.columnHeader.DisplayIndex = 2;
            this.columnHeader.Text = "Header";
            this.columnHeader.Width = 0;
            // 
            // labelEngine
            // 
            this.labelEngine.AutoSize = true;
            this.labelEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngine.Location = new System.Drawing.Point(12, 9);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(58, 17);
            this.labelEngine.TabIndex = 1;
            this.labelEngine.Text = "Engine";
            // 
            // textEngine
            // 
            this.textEngine.Location = new System.Drawing.Point(15, 30);
            this.textEngine.Name = "textEngine";
            this.textEngine.Size = new System.Drawing.Size(164, 20);
            this.textEngine.TabIndex = 2;
            // 
            // labelTrunk
            // 
            this.labelTrunk.AutoSize = true;
            this.labelTrunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrunk.Location = new System.Drawing.Point(12, 62);
            this.labelTrunk.Name = "labelTrunk";
            this.labelTrunk.Size = new System.Drawing.Size(50, 17);
            this.labelTrunk.TabIndex = 3;
            this.labelTrunk.Text = "Trunk";
            // 
            // labelParktroniks
            // 
            this.labelParktroniks.AutoSize = true;
            this.labelParktroniks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParktroniks.Location = new System.Drawing.Point(12, 120);
            this.labelParktroniks.Name = "labelParktroniks";
            this.labelParktroniks.Size = new System.Drawing.Size(95, 17);
            this.labelParktroniks.TabIndex = 4;
            this.labelParktroniks.Text = "ParkTroniks";
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(12, 235);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(87, 17);
            this.labelDashboard.TabIndex = 6;
            this.labelDashboard.Text = "Dashboard";
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeats.Location = new System.Drawing.Point(12, 179);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(49, 17);
            this.labelSeats.TabIndex = 5;
            this.labelSeats.Text = "Seats";
            // 
            // textTrunk
            // 
            this.textTrunk.Location = new System.Drawing.Point(15, 82);
            this.textTrunk.Name = "textTrunk";
            this.textTrunk.Size = new System.Drawing.Size(164, 20);
            this.textTrunk.TabIndex = 7;
            // 
            // textParktroniks
            // 
            this.textParktroniks.Location = new System.Drawing.Point(15, 141);
            this.textParktroniks.Name = "textParktroniks";
            this.textParktroniks.Size = new System.Drawing.Size(164, 20);
            this.textParktroniks.TabIndex = 8;
            // 
            // textSeats
            // 
            this.textSeats.Location = new System.Drawing.Point(15, 199);
            this.textSeats.Name = "textSeats";
            this.textSeats.Size = new System.Drawing.Size(164, 20);
            this.textSeats.TabIndex = 9;
            // 
            // textDashboard
            // 
            this.textDashboard.Location = new System.Drawing.Point(13, 255);
            this.textDashboard.Name = "textDashboard";
            this.textDashboard.Size = new System.Drawing.Size(166, 20);
            this.textDashboard.TabIndex = 10;
            // 
            // labelAditional
            // 
            this.labelAditional.AutoSize = true;
            this.labelAditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAditional.Location = new System.Drawing.Point(10, 331);
            this.labelAditional.Name = "labelAditional";
            this.labelAditional.Size = new System.Drawing.Size(80, 17);
            this.labelAditional.TabIndex = 11;
            this.labelAditional.Text = "Additional";
            // 
            // textAutopilot
            // 
            this.textAutopilot.Location = new System.Drawing.Point(13, 351);
            this.textAutopilot.Name = "textAutopilot";
            this.textAutopilot.Size = new System.Drawing.Size(166, 20);
            this.textAutopilot.TabIndex = 12;
            this.textAutopilot.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPrice.Location = new System.Drawing.Point(12, 296);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(109, 17);
            this.labelCurrentPrice.TabIndex = 14;
            this.labelCurrentPrice.Text = "Current Price:";
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPrice.Location = new System.Drawing.Point(10, 397);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(85, 17);
            this.labelNewPrice.TabIndex = 15;
            this.labelNewPrice.Text = "New Price:";
            // 
            // textCurrentPrice
            // 
            this.textCurrentPrice.Location = new System.Drawing.Point(127, 296);
            this.textCurrentPrice.Name = "textCurrentPrice";
            this.textCurrentPrice.Size = new System.Drawing.Size(100, 20);
            this.textCurrentPrice.TabIndex = 16;
            // 
            // textNewPrice
            // 
            this.textNewPrice.Location = new System.Drawing.Point(12, 418);
            this.textNewPrice.Name = "textNewPrice";
            this.textNewPrice.Size = new System.Drawing.Size(100, 20);
            this.textNewPrice.TabIndex = 17;
            // 
            // labelAditionalLabel
            // 
            this.labelAditionalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAditionalLabel.AutoSize = true;
            this.labelAditionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAditionalLabel.Location = new System.Drawing.Point(499, 179);
            this.labelAditionalLabel.Name = "labelAditionalLabel";
            this.labelAditionalLabel.Size = new System.Drawing.Size(137, 17);
            this.labelAditionalLabel.TabIndex = 18;
            this.labelAditionalLabel.Text = "Aditional Options:";
            // 
            // btnAutoPilot
            // 
            this.btnAutoPilot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPilot.Location = new System.Drawing.Point(502, 219);
            this.btnAutoPilot.Name = "btnAutoPilot";
            this.btnAutoPilot.Size = new System.Drawing.Size(134, 33);
            this.btnAutoPilot.TabIndex = 19;
            this.btnAutoPilot.Text = "Add Autopilot Option";
            this.btnAutoPilot.UseVisualStyleBackColor = true;
            this.btnAutoPilot.Click += new System.EventHandler(this.btnAutoPilot_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutoPilot);
            this.Controls.Add(this.labelAditionalLabel);
            this.Controls.Add(this.textNewPrice);
            this.Controls.Add(this.textCurrentPrice);
            this.Controls.Add(this.labelNewPrice);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAutopilot);
            this.Controls.Add(this.labelAditional);
            this.Controls.Add(this.textDashboard);
            this.Controls.Add(this.textSeats);
            this.Controls.Add(this.textParktroniks);
            this.Controls.Add(this.textTrunk);
            this.Controls.Add(this.labelDashboard);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.labelParktroniks);
            this.Controls.Add(this.labelTrunk);
            this.Controls.Add(this.textEngine);
            this.Controls.Add(this.labelEngine);
            this.Controls.Add(this.listCarListOrder);
            this.Name = "FormOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCarListOrder;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnBrand;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.TextBox textEngine;
        private System.Windows.Forms.Label labelTrunk;
        private System.Windows.Forms.Label labelParktroniks;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label labelSeats;
        private System.Windows.Forms.TextBox textTrunk;
        private System.Windows.Forms.TextBox textParktroniks;
        private System.Windows.Forms.TextBox textSeats;
        private System.Windows.Forms.TextBox textDashboard;
        private System.Windows.Forms.Label labelAditional;
        private System.Windows.Forms.TextBox textAutopilot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.TextBox textCurrentPrice;
        private System.Windows.Forms.TextBox textNewPrice;
        private System.Windows.Forms.Label labelAditionalLabel;
        private System.Windows.Forms.Button btnAutoPilot;
    }
}