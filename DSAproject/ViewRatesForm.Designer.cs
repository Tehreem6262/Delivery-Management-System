namespace DSAproject
{
    partial class ViewRatesForm
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
            this.btnSaveRate = new System.Windows.Forms.Button();
            this.dgvRates = new System.Windows.Forms.DataGridView();
            this.btnCalculateRate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDeliveryType = new System.Windows.Forms.Label();
            this.cmbDeliveryType = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRates)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(467, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 45);
            this.label2.TabIndex = 40;
            this.label2.Text = "View Rates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 55);
            this.label1.TabIndex = 38;
            this.label1.Text = "Delivery Management System";
            // 
            // btnSaveRate
            // 
            this.btnSaveRate.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveRate.Location = new System.Drawing.Point(502, 283);
            this.btnSaveRate.Name = "btnSaveRate";
            this.btnSaveRate.Size = new System.Drawing.Size(153, 45);
            this.btnSaveRate.TabIndex = 47;
            this.btnSaveRate.Text = "Save Rate";
            this.btnSaveRate.UseVisualStyleBackColor = true;
            this.btnSaveRate.Click += new System.EventHandler(this.btnSaveRate_Click);
            // 
            // dgvRates
            // 
            this.dgvRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRates.Location = new System.Drawing.Point(138, 510);
            this.dgvRates.Name = "dgvRates";
            this.dgvRates.RowHeadersWidth = 62;
            this.dgvRates.RowTemplate.Height = 28;
            this.dgvRates.Size = new System.Drawing.Size(855, 176);
            this.dgvRates.TabIndex = 48;
            this.dgvRates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRates_CellClick);
            // 
            // btnCalculateRate
            // 
            this.btnCalculateRate.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnCalculateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCalculateRate.Location = new System.Drawing.Point(183, 207);
            this.btnCalculateRate.Name = "btnCalculateRate";
            this.btnCalculateRate.Size = new System.Drawing.Size(213, 48);
            this.btnCalculateRate.TabIndex = 55;
            this.btnCalculateRate.Text = "Calculate Rate";
            this.btnCalculateRate.UseVisualStyleBackColor = true;
            this.btnCalculateRate.Click += new System.EventHandler(this.btnCalculateRate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(547, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 50);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearRate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.txtDistance);
            this.panel1.Controls.Add(this.btnCalculateRate);
            this.panel1.Controls.Add(this.btnSaveRate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.lblRate);
            this.panel1.Controls.Add(this.lblDistance);
            this.panel1.Controls.Add(this.lblWeight);
            this.panel1.Controls.Add(this.lblDeliveryType);
            this.panel1.Controls.Add(this.cmbDeliveryType);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(246, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 328);
            this.panel1.TabIndex = 57;
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtDistance.Location = new System.Drawing.Point(282, 151);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(152, 34);
            this.txtDistance.TabIndex = 63;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtRate.Location = new System.Drawing.Point(282, 284);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(152, 34);
            this.txtRate.TabIndex = 62;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(33, 274);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(157, 38);
            this.lblRate.TabIndex = 61;
            this.lblRate.Text = "Rate (PKR):";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblDistance.ForeColor = System.Drawing.Color.White;
            this.lblDistance.Location = new System.Drawing.Point(33, 151);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(198, 38);
            this.lblDistance.TabIndex = 60;
            this.lblDistance.Text = "Distance (km):";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(33, 87);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(173, 38);
            this.lblWeight.TabIndex = 59;
            this.lblWeight.Text = "Weight (kg):";
            // 
            // lblDeliveryType
            // 
            this.lblDeliveryType.AutoSize = true;
            this.lblDeliveryType.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryType.ForeColor = System.Drawing.Color.White;
            this.lblDeliveryType.Location = new System.Drawing.Point(33, 18);
            this.lblDeliveryType.Name = "lblDeliveryType";
            this.lblDeliveryType.Size = new System.Drawing.Size(195, 38);
            this.lblDeliveryType.TabIndex = 58;
            this.lblDeliveryType.Text = "Delivery Type:";
            // 
            // cmbDeliveryType
            // 
            this.cmbDeliveryType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmbDeliveryType.FormattingEnabled = true;
            this.cmbDeliveryType.Location = new System.Drawing.Point(282, 23);
            this.cmbDeliveryType.Name = "cmbDeliveryType";
            this.cmbDeliveryType.Size = new System.Drawing.Size(152, 36);
            this.cmbDeliveryType.TabIndex = 57;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtWeight.Location = new System.Drawing.Point(282, 87);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(152, 34);
            this.txtWeight.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::DSAproject.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = global::DSAproject.Properties.Resources.delivery_boy;
            this.pictureBox2.Location = new System.Drawing.Point(172, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ViewRatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1113, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "ViewRatesForm";
            this.Text = "ViewRatesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRates)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveRate;
        private System.Windows.Forms.DataGridView dgvRates;
        private System.Windows.Forms.Button btnCalculateRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDeliveryType;
        private System.Windows.Forms.ComboBox cmbDeliveryType;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}