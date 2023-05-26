namespace FinalProjectDatabase
{
    partial class NewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(208, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "NEW ORDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = " Order Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Payment Method";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(245, 125);
            this.txtStudent.Multiline = true;
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(155, 31);
            this.txtStudent.TabIndex = 13;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(245, 86);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(155, 32);
            this.txtOrder.TabIndex = 17;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(245, 313);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(155, 32);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(246, 356);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(155, 32);
            this.txtCost.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(466, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbList
            // 
            this.cbList.FormattingEnabled = true;
            this.cbList.Items.AddRange(new object[] {
            "Gcash",
            "Pay maya",
            "Cash"});
            this.cbList.Location = new System.Drawing.Point(247, 408);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(153, 23);
            this.cbList.TabIndex = 21;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(247, 449);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 23);
            this.time.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBox
            // 
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Items.AddRange(new object[] {
            "UNI000",
            "CWS350",
            "CCS420",
            "CAS123",
            "CTE023",
            "CIT911",
            "COE333"});
            this.cbBox.Location = new System.Drawing.Point(245, 165);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(153, 23);
            this.cbBox.TabIndex = 25;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 582);
            this.Controls.Add(this.cbBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time);
            this.Controls.Add(this.cbList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStudent;
        private TextBox txtOrder;
        private TextBox txtQuantity;
        private TextBox txtCost;
        private Button btnAdd;
        private ComboBox cbList;
        private DateTimePicker time;
        private Label label9;
        private Button button1;
        private ComboBox cbBox;
    }
}