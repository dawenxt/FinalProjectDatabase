namespace FinalProjectDatabase
{
    partial class EditOrderHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.addPayment = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dgOrderHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDateEdit = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(43, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 45);
            this.panel1.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(147, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 51;
            this.label11.Text = "Edit Order History ";
            // 
            // addPayment
            // 
            this.addPayment.FormattingEnabled = true;
            this.addPayment.Items.AddRange(new object[] {
            "Gcash",
            "Pay Maya"});
            this.addPayment.Location = new System.Drawing.Point(178, 349);
            this.addPayment.Name = "addPayment";
            this.addPayment.Size = new System.Drawing.Size(272, 23);
            this.addPayment.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(70, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 67;
            this.label10.Text = "Edited by: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(70, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "Date Edited:";
            // 
            // addTotal
            // 
            this.addTotal.Location = new System.Drawing.Point(178, 310);
            this.addTotal.Multiline = true;
            this.addTotal.Name = "addTotal";
            this.addTotal.Size = new System.Drawing.Size(271, 27);
            this.addTotal.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Total Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Time Process:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(71, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 62;
            this.label8.Text = "Payment Method";
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(178, 195);
            this.addStudent.Multiline = true;
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(271, 27);
            this.addStudent.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Student No";
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(178, 158);
            this.addOrder.Multiline = true;
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(271, 27);
            this.addOrder.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Order Number";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(1330, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1017, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 31);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(137, 464);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(78, 15);
            this.lblAdmin.TabIndex = 55;
            this.lblAdmin.Text = "Admin Name";
            // 
            // addQuantity
            // 
            this.addQuantity.Location = new System.Drawing.Point(178, 271);
            this.addQuantity.Multiline = true;
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(271, 27);
            this.addQuantity.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Quantity";
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(178, 232);
            this.addProduct.Multiline = true;
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(271, 27);
            this.addProduct.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Product ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(1119, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 31);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1223, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 31);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(179, 382);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(271, 23);
            this.dtTime.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(71, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 73;
            this.label12.Text = "Date Process:";
            // 
            // dgOrderHistory
            // 
            this.dgOrderHistory.AllowUserToAddRows = false;
            this.dgOrderHistory.AllowUserToDeleteRows = false;
            this.dgOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgOrderHistory.Location = new System.Drawing.Point(547, 35);
            this.dgOrderHistory.Name = "dgOrderHistory";
            this.dgOrderHistory.ReadOnly = true;
            this.dgOrderHistory.RowTemplate.Height = 25;
            this.dgOrderHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderHistory.Size = new System.Drawing.Size(875, 458);
            this.dgOrderHistory.TabIndex = 74;
            this.dgOrderHistory.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderHistory_CellEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(73, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 76;
            this.label13.Text = "Number in List";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(212, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 31);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Add New Item";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDateEdit
            // 
            this.lblDateEdit.AutoSize = true;
            this.lblDateEdit.ForeColor = System.Drawing.Color.White;
            this.lblDateEdit.Location = new System.Drawing.Point(146, 441);
            this.lblDateEdit.Name = "lblDateEdit";
            this.lblDateEdit.Size = new System.Drawing.Size(78, 15);
            this.lblDateEdit.TabIndex = 78;
            this.lblDateEdit.Text = "Admin Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(152, 419);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 15);
            this.lblTime.TabIndex = 79;
            this.lblTime.Text = "Admin Name";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.ForeColor = System.Drawing.Color.White;
            this.lblShow.Location = new System.Drawing.Point(253, 82);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(49, 15);
            this.lblShow.TabIndex = 80;
            this.lblShow.Text = "..............";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(176, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 81;
            this.lblID.Text = "ID";
            // 
            // EditOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1455, 570);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDateEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgOrderHistory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addPayment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.addQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditOrderHistory";
            this.Load += new System.EventHandler(this.EditOrderHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label11;
        private ComboBox addPayment;
        private Label label10;
        private Label label9;
        private TextBox addTotal;
        private Label label1;
        private Label label7;
        private Label label8;
        private TextBox addStudent;
        private Label label6;
        private TextBox addOrder;
        private Label label5;
        private Button btnCancel;
        private Button btnSave;
        private Label lblAdmin;
        private TextBox addQuantity;
        private Label label3;
        private TextBox addProduct;
        private Label label2;
        private Button btnUpdate;
        private Button btnDelete;
        private DateTimePicker dtTime;
        private Label label12;
        private DataGridView dgOrderHistory;
        private Label label13;
        private Button btnClear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label lblDateEdit;
        private Label lblTime;
        private Label lblShow;
        private Label lblID;
    }
}