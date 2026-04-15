namespace DSAproject
{
    partial class ManageDeliveriesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cmbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.cmbRiderName = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRiderName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateDelivery = new System.Windows.Forms.Button();
            this.btnAddDelivery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculateShortestRoute = new System.Windows.Forms.Button();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(377, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 45);
            this.label2.TabIndex = 31;
            this.label2.Text = "Manage Deliveries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 55);
            this.label1.TabIndex = 29;
            this.label1.Text = "Delivery Management System";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCustomerName.Location = new System.Drawing.Point(546, 219);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(155, 29);
            this.txtCustomerName.TabIndex = 33;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.txtOrderID.Location = new System.Drawing.Point(546, 173);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(155, 29);
            this.txtOrderID.TabIndex = 34;
            // 
            // cmbDeliveryStatus
            // 
            this.cmbDeliveryStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeliveryStatus.FormattingEnabled = true;
            this.cmbDeliveryStatus.Location = new System.Drawing.Point(546, 363);
            this.cmbDeliveryStatus.Name = "cmbDeliveryStatus";
            this.cmbDeliveryStatus.Size = new System.Drawing.Size(155, 29);
            this.cmbDeliveryStatus.TabIndex = 35;
            // 
            // cmbRiderName
            // 
            this.cmbRiderName.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.cmbRiderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbRiderName.FormattingEnabled = true;
            this.cmbRiderName.Location = new System.Drawing.Point(546, 267);
            this.cmbRiderName.Name = "cmbRiderName";
            this.cmbRiderName.Size = new System.Drawing.Size(155, 29);
            this.cmbRiderName.TabIndex = 36;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(289, 317);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(90, 28);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address:";
            // 
            // lblRiderName
            // 
            this.lblRiderName.AutoSize = true;
            this.lblRiderName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRiderName.ForeColor = System.Drawing.Color.White;
            this.lblRiderName.Location = new System.Drawing.Point(289, 264);
            this.lblRiderName.Name = "lblRiderName";
            this.lblRiderName.Size = new System.Drawing.Size(124, 28);
            this.lblRiderName.TabIndex = 38;
            this.lblRiderName.Text = "Rider Name:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(289, 220);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(165, 28);
            this.lblCustomerName.TabIndex = 39;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.ForeColor = System.Drawing.Color.White;
            this.lblOrderID.Location = new System.Drawing.Point(289, 174);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(95, 28);
            this.lblOrderID.TabIndex = 40;
            this.lblOrderID.Text = "Order ID:";
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveries.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Location = new System.Drawing.Point(150, 541);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.RowHeadersWidth = 62;
            this.dgvDeliveries.RowTemplate.Height = 28;
            this.dgvDeliveries.Size = new System.Drawing.Size(822, 183);
            this.dgvDeliveries.TabIndex = 41;
            this.dgvDeliveries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(289, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "Delivery Status:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(832, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 42);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearDelivery_Click);
            // 
            // btnUpdateDelivery
            // 
            this.btnUpdateDelivery.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDelivery.Location = new System.Drawing.Point(294, 454);
            this.btnUpdateDelivery.Name = "btnUpdateDelivery";
            this.btnUpdateDelivery.Size = new System.Drawing.Size(176, 38);
            this.btnUpdateDelivery.TabIndex = 44;
            this.btnUpdateDelivery.Text = "Update Delivery";
            this.btnUpdateDelivery.UseVisualStyleBackColor = true;
            this.btnUpdateDelivery.Click += new System.EventHandler(this.btnUpdateDelivery_Click);
            // 
            // btnAddDelivery
            // 
            this.btnAddDelivery.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDelivery.Location = new System.Drawing.Point(516, 450);
            this.btnAddDelivery.Name = "btnAddDelivery";
            this.btnAddDelivery.Size = new System.Drawing.Size(145, 42);
            this.btnAddDelivery.TabIndex = 45;
            this.btnAddDelivery.Text = "Add Delivery";
            this.btnAddDelivery.UseVisualStyleBackColor = true;
            this.btnAddDelivery.Click += new System.EventHandler(this.btnAddDelivery_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(104, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete Delivery";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteDelivery_Click);
            // 
            // btnCalculateShortestRoute
            // 
            this.btnCalculateShortestRoute.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculateShortestRoute.Location = new System.Drawing.Point(765, 450);
            this.btnCalculateShortestRoute.Name = "btnCalculateShortestRoute";
            this.btnCalculateShortestRoute.Size = new System.Drawing.Size(273, 42);
            this.btnCalculateShortestRoute.TabIndex = 47;
            this.btnCalculateShortestRoute.Text = "Calculate Shortest Route";
            this.btnCalculateShortestRoute.UseVisualStyleBackColor = true;
            this.btnCalculateShortestRoute.Click += new System.EventHandler(this.btnCalculateRoute_Click);
            // 
            // cmbAddress
            // 
            this.cmbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.cmbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(546, 317);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(155, 29);
            this.cmbAddress.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::DSAproject.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = global::DSAproject.Properties.Resources.delivery_boy;
            this.pictureBox2.Location = new System.Drawing.Point(168, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // ManageDeliveriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1113, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.btnCalculateShortestRoute);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddDelivery);
            this.Controls.Add(this.btnUpdateDelivery);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblRiderName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmbRiderName);
            this.Controls.Add(this.cmbDeliveryStatus);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "ManageDeliveriesForm";
            this.Text = "ManageDeliveriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cmbDeliveryStatus;
        private System.Windows.Forms.ComboBox cmbRiderName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRiderName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateDelivery;
        private System.Windows.Forms.Button btnAddDelivery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCalculateShortestRoute;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}