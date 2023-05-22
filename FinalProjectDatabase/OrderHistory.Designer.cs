namespace FinalProjectDatabase
{
    partial class OrderHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistory));
            this.resId = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.resProduct = new System.Windows.Forms.Label();
            this.resQuan = new System.Windows.Forms.Label();
            this.resTotal = new System.Windows.Forms.Label();
            this.resStudent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resPayment = new System.Windows.Forms.Label();
            this.resDate = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBg2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.resOrder = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnBgsearch = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.pnOrder = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgOrderHistory = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBg2.SuspendLayout();
            this.pnBgsearch.SuspendLayout();
            this.pnOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // resId
            // 
            this.resId.AutoSize = true;
            this.resId.Location = new System.Drawing.Point(184, 41);
            this.resId.Name = "resId";
            this.resId.Size = new System.Drawing.Size(17, 15);
            this.resId.TabIndex = 3;
            this.resId.Text = "Id";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(77, 9);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(670, 31);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // resProduct
            // 
            this.resProduct.AutoSize = true;
            this.resProduct.Location = new System.Drawing.Point(184, 117);
            this.resProduct.Name = "resProduct";
            this.resProduct.Size = new System.Drawing.Size(62, 15);
            this.resProduct.TabIndex = 21;
            this.resProduct.Text = "Product Id";
            // 
            // resQuan
            // 
            this.resQuan.AutoSize = true;
            this.resQuan.Location = new System.Drawing.Point(184, 142);
            this.resQuan.Name = "resQuan";
            this.resQuan.Size = new System.Drawing.Size(53, 15);
            this.resQuan.TabIndex = 22;
            this.resQuan.Text = "Quantity";
            // 
            // resTotal
            // 
            this.resTotal.AutoSize = true;
            this.resTotal.Location = new System.Drawing.Point(184, 168);
            this.resTotal.Name = "resTotal";
            this.resTotal.Size = new System.Drawing.Size(59, 15);
            this.resTotal.TabIndex = 23;
            this.resTotal.Text = "Total Cost";
            // 
            // resStudent
            // 
            this.resStudent.AutoSize = true;
            this.resStudent.Location = new System.Drawing.Point(184, 91);
            this.resStudent.Name = "resStudent";
            this.resStudent.Size = new System.Drawing.Size(95, 15);
            this.resStudent.TabIndex = 24;
            this.resStudent.Text = "Student Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search Result:";
            // 
            // resPayment
            // 
            this.resPayment.AutoSize = true;
            this.resPayment.Location = new System.Drawing.Point(184, 195);
            this.resPayment.Name = "resPayment";
            this.resPayment.Size = new System.Drawing.Size(99, 15);
            this.resPayment.TabIndex = 33;
            this.resPayment.Text = "Payment Method";
            // 
            // resDate
            // 
            this.resDate.AutoSize = true;
            this.resDate.Location = new System.Drawing.Point(184, 221);
            this.resDate.Name = "resDate";
            this.resDate.Size = new System.Drawing.Size(31, 15);
            this.resDate.TabIndex = 32;
            this.resDate.Text = "Date";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Order Number";
            this.Column1.Name = "Column1";
            this.Column1.Width = 1111;
            // 
            // pnBg2
            // 
            this.pnBg2.BackColor = System.Drawing.Color.White;
            this.pnBg2.Controls.Add(this.label1);
            this.pnBg2.Controls.Add(this.label8);
            this.pnBg2.Controls.Add(this.label9);
            this.pnBg2.Controls.Add(this.label10);
            this.pnBg2.Controls.Add(this.label11);
            this.pnBg2.Controls.Add(this.label12);
            this.pnBg2.Controls.Add(this.label13);
            this.pnBg2.Controls.Add(this.label18);
            this.pnBg2.Controls.Add(this.resOrder);
            this.pnBg2.Controls.Add(this.btnEdit);
            this.pnBg2.Controls.Add(this.resPayment);
            this.pnBg2.Controls.Add(this.resId);
            this.pnBg2.Controls.Add(this.resDate);
            this.pnBg2.Controls.Add(this.label7);
            this.pnBg2.Controls.Add(this.resStudent);
            this.pnBg2.Controls.Add(this.resTotal);
            this.pnBg2.Controls.Add(this.resQuan);
            this.pnBg2.Controls.Add(this.resProduct);
            this.pnBg2.Location = new System.Drawing.Point(39, 627);
            this.pnBg2.Name = "pnBg2";
            this.pnBg2.Size = new System.Drawing.Size(1270, 273);
            this.pnBg2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Order Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Payment Method";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Student Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Total Cost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "Product Id";
            // 
            // resOrder
            // 
            this.resOrder.AutoSize = true;
            this.resOrder.Location = new System.Drawing.Point(184, 66);
            this.resOrder.Name = "resOrder";
            this.resOrder.Size = new System.Drawing.Size(84, 15);
            this.resOrder.TabIndex = 34;
            this.resOrder.Text = "Order Number";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(1153, 196);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 34);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnBgsearch
            // 
            this.pnBgsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnBgsearch.Controls.Add(this.button3);
            this.pnBgsearch.Controls.Add(this.button2);
            this.pnBgsearch.Controls.Add(this.button1);
            this.pnBgsearch.Controls.Add(this.label14);
            this.pnBgsearch.Controls.Add(this.txtSearch);
            this.pnBgsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnBgsearch.Location = new System.Drawing.Point(39, 560);
            this.pnBgsearch.Name = "pnBgsearch";
            this.pnBgsearch.Size = new System.Drawing.Size(1272, 47);
            this.pnBgsearch.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(859, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(968, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Product List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(753, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(13, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Search:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1104, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Time:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1104, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Date:";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(1147, 66);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(33, 15);
            this.lblTimeNow.TabIndex = 37;
            this.lblTimeNow.Text = "Time";
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Location = new System.Drawing.Point(1147, 35);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(31, 15);
            this.lblDateNow.TabIndex = 36;
            this.lblDateNow.Text = "Date";
            this.lblDateNow.Click += new System.EventHandler(this.lblDateNow_Click);
            // 
            // pnOrder
            // 
            this.pnOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnOrder.Controls.Add(this.button4);
            this.pnOrder.Controls.Add(this.label17);
            this.pnOrder.Location = new System.Drawing.Point(39, 35);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(1046, 47);
            this.pnOrder.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(974, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 36);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(13, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Order History";
            // 
            // dgOrderHistory
            // 
            this.dgOrderHistory.AllowUserToAddRows = false;
            this.dgOrderHistory.AllowUserToDeleteRows = false;
            this.dgOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgOrderHistory.Location = new System.Drawing.Point(39, 110);
            this.dgOrderHistory.Name = "dgOrderHistory";
            this.dgOrderHistory.ReadOnly = true;
            this.dgOrderHistory.RowTemplate.Height = 25;
            this.dgOrderHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderHistory.Size = new System.Drawing.Size(1275, 444);
            this.dgOrderHistory.TabIndex = 40;
            this.dgOrderHistory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrderHistory_CellMouseClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "orderNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "studentNumber";
            this.Column2.HeaderText = "Student Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "productId";
            this.Column3.HeaderText = "Product Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "quantity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "totalCost";
            this.Column5.HeaderText = "Total Cost";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "paymentMethod";
            this.Column6.HeaderText = "Payment Method";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "orderDate";
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 912);
            this.Controls.Add(this.dgOrderHistory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnBgsearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pnBg2);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.pnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.myList_Load);
            this.pnBg2.ResumeLayout(false);
            this.pnBg2.PerformLayout();
            this.pnBgsearch.ResumeLayout(false);
            this.pnBgsearch.PerformLayout();
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label resId;
        private TextBox txtSearch;
        private Label resProduct;
        private Label resQuan;
        private Label resTotal;
        private Label resStudent;
        private Label label7;
        private Label resPayment;
        private Label resDate;
        private DataGridViewTextBoxColumn Column1;
        private Panel pnBg2;
        private Button btnEdit;
        private Panel pnBgsearch;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lblTimeNow;
        private Label lblDateNow;
        private Panel pnOrder;
        private Button button4;
        private Label label17;
        private DataGridView dgOrderHistory;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label resOrder;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label18;
    }
}