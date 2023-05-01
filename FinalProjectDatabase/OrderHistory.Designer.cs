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
            this.pnOrder = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnBgsearch = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBg1 = new System.Windows.Forms.Panel();
            this.pnBg2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnBgsearch.SuspendLayout();
            this.pnBg1.SuspendLayout();
            this.pnBg2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOrder
            // 
            this.pnOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnOrder.Controls.Add(this.button4);
            this.pnOrder.Controls.Add(this.label1);
            this.pnOrder.Location = new System.Drawing.Point(42, 34);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(1046, 47);
            this.pnOrder.TabIndex = 0;
            this.pnOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnOrder_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order History";
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Location = new System.Drawing.Point(1150, 34);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(31, 15);
            this.lblDateNow.TabIndex = 3;
            this.lblDateNow.Text = "Date";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(1150, 65);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(33, 15);
            this.lblTimeNow.TabIndex = 4;
            this.lblTimeNow.Text = "Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(43, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 444);
            this.dataGridView1.TabIndex = 5;
            // 
            // pnBgsearch
            // 
            this.pnBgsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnBgsearch.Controls.Add(this.button3);
            this.pnBgsearch.Controls.Add(this.button2);
            this.pnBgsearch.Controls.Add(this.button1);
            this.pnBgsearch.Controls.Add(this.tbSearch);
            this.pnBgsearch.Controls.Add(this.label4);
            this.pnBgsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnBgsearch.Location = new System.Drawing.Point(43, 568);
            this.pnBgsearch.Name = "pnBgsearch";
            this.pnBgsearch.Size = new System.Drawing.Size(1272, 47);
            this.pnBgsearch.TabIndex = 1;
            this.pnBgsearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBgsearch_Paint);
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
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(75, 6);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(666, 34);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search:";
            // 
            // pnBg1
            // 
            this.pnBg1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnBg1.Controls.Add(this.pnBg2);
            this.pnBg1.Location = new System.Drawing.Point(42, 632);
            this.pnBg1.Name = "pnBg1";
            this.pnBg1.Size = new System.Drawing.Size(1276, 256);
            this.pnBg1.TabIndex = 6;
            this.pnBg1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBg1_Paint);
            // 
            // pnBg2
            // 
            this.pnBg2.BackColor = System.Drawing.Color.White;
            this.pnBg2.Controls.Add(this.button5);
            this.pnBg2.Location = new System.Drawing.Point(3, 3);
            this.pnBg2.Name = "pnBg2";
            this.pnBg2.Size = new System.Drawing.Size(1270, 250);
            this.pnBg2.TabIndex = 7;
            this.pnBg2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBg2_Paint);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(1153, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1107, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1107, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "orderNumber";
            this.Column1.HeaderText = "Order Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(1354, 912);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnBg1);
            this.Controls.Add(this.pnBgsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.pnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistory";
            this.Text = "v";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnBgsearch.ResumeLayout(false);
            this.pnBgsearch.PerformLayout();
            this.pnBg1.ResumeLayout(false);
            this.pnBg2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnOrder;
        private Label label1;
        private Label lblDateNow;
        private Label lblTimeNow;
        private DataGridView dataGridView1;
        private Panel pnBgsearch;
        private Label label4;
        private TextBox tbSearch;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel pnBg1;
        private Panel pnBg2;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}