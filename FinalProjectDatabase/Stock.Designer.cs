namespace FinalProjectDatabase
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.pnOrder = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBgsearch = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBg1 = new System.Windows.Forms.Panel();
            this.pnBg2 = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblReorder = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblproduct = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Inventory";
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Location = new System.Drawing.Point(1150, 34);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(31, 15);
            this.lblDateNow.TabIndex = 3;
            this.lblDateNow.Text = "Date";
            this.lblDateNow.Click += new System.EventHandler(this.lblDateNow_Click);
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
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(43, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 444);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Column1.DataPropertyName = "ProductNum";
            this.Column1.HeaderText = "Product Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "description";
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "openingStock";
            this.Column3.HeaderText = "Opening Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "stockValue";
            this.Column4.HeaderText = "Stock Value";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "out";
            this.Column5.HeaderText = "Out";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "costItem";
            this.Column6.HeaderText = "Cost Per Item";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "sales";
            this.Column7.HeaderText = "Sales";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "status";
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "storageNumber";
            this.Column10.HeaderText = "Storage No.";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "reorder";
            this.Column11.HeaderText = "Reorder";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
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
            this.pnBgsearch.Size = new System.Drawing.Size(1275, 47);
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
            this.pnBg2.Controls.Add(this.Status);
            this.pnBg2.Controls.Add(this.lblOn);
            this.pnBg2.Controls.Add(this.lblid);
            this.pnBg2.Controls.Add(this.lblNext);
            this.pnBg2.Controls.Add(this.lblReorder);
            this.pnBg2.Controls.Add(this.lblLast);
            this.pnBg2.Controls.Add(this.lblStorage);
            this.pnBg2.Controls.Add(this.lblSales);
            this.pnBg2.Controls.Add(this.lblOut);
            this.pnBg2.Controls.Add(this.lblValue);
            this.pnBg2.Controls.Add(this.lblStock);
            this.pnBg2.Controls.Add(this.lblDes);
            this.pnBg2.Controls.Add(this.lblproduct);
            this.pnBg2.Controls.Add(this.label14);
            this.pnBg2.Controls.Add(this.label13);
            this.pnBg2.Controls.Add(this.label12);
            this.pnBg2.Controls.Add(this.label11);
            this.pnBg2.Controls.Add(this.label10);
            this.pnBg2.Controls.Add(this.label9);
            this.pnBg2.Controls.Add(this.label8);
            this.pnBg2.Controls.Add(this.label7);
            this.pnBg2.Controls.Add(this.label6);
            this.pnBg2.Controls.Add(this.label5);
            this.pnBg2.Controls.Add(this.lblDate);
            this.pnBg2.Controls.Add(this.orderNum);
            this.pnBg2.Controls.Add(this.button5);
            this.pnBg2.Location = new System.Drawing.Point(3, 3);
            this.pnBg2.Name = "pnBg2";
            this.pnBg2.Size = new System.Drawing.Size(1270, 250);
            this.pnBg2.TabIndex = 7;
            this.pnBg2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBg2_Paint);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Status.Location = new System.Drawing.Point(23, 223);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(50, 20);
            this.Status.TabIndex = 59;
            this.Status.Text = "Status";
            // 
            // lblOn
            // 
            this.lblOn.AutoSize = true;
            this.lblOn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOn.Location = new System.Drawing.Point(186, 224);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(60, 20);
            this.lblOn.TabIndex = 58;
            this.lblOn.Text = "Process";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(24, 10);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 20);
            this.lblid.TabIndex = 57;
            this.lblid.Text = "ID";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNext.Location = new System.Drawing.Point(898, 159);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(83, 20);
            this.lblNext.TabIndex = 56;
            this.lblNext.Text = "Next Stock";
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReorder.Location = new System.Drawing.Point(898, 121);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(64, 20);
            this.lblReorder.TabIndex = 55;
            this.lblReorder.Text = "Reorder";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLast.Location = new System.Drawing.Point(898, 80);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(89, 20);
            this.lblLast.TabIndex = 54;
            this.lblLast.Text = "Last Update";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorage.Location = new System.Drawing.Point(898, 42);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(123, 20);
            this.lblStorage.TabIndex = 53;
            this.lblStorage.Text = "Storage Number";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSales.Location = new System.Drawing.Point(186, 194);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(43, 20);
            this.lblSales.TabIndex = 52;
            this.lblSales.Text = "Sales";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOut.Location = new System.Drawing.Point(186, 164);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(34, 20);
            this.lblOut.TabIndex = 51;
            this.lblOut.Text = "Out";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue.Location = new System.Drawing.Point(186, 133);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(88, 20);
            this.lblValue.TabIndex = 50;
            this.lblValue.Text = "Stock Value";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(186, 100);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(109, 20);
            this.lblStock.TabIndex = 49;
            this.lblStock.Text = "Opening Stock";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDes.Location = new System.Drawing.Point(186, 70);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(87, 20);
            this.lblDes.TabIndex = 48;
            this.lblDes.Text = "Description";
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblproduct.Location = new System.Drawing.Point(187, 39);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(124, 20);
            this.lblproduct.TabIndex = 47;
            this.lblproduct.Text = "Product Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(751, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Next Stock";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(751, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Reorder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(751, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Last Update";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(751, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Storage Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Sales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Out";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Stock Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Opening Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Product Number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(559, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date";
            // 
            // orderNum
            // 
            this.orderNum.AutoSize = true;
            this.orderNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderNum.Location = new System.Drawing.Point(475, 10);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(82, 20);
            this.orderNum.TabIndex = 35;
            this.orderNum.Text = "Stock as of";
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
            // Stock
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
            this.Name = "Stock";
            this.Text = "v";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnBgsearch.ResumeLayout(false);
            this.pnBgsearch.PerformLayout();
            this.pnBg1.ResumeLayout(false);
            this.pnBg2.ResumeLayout(false);
            this.pnBg2.PerformLayout();
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
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label lblDate;
        private Label orderNum;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label lblSales;
        private Label lblOut;
        private Label lblValue;
        private Label lblStock;
        private Label lblDes;
        private Label lblproduct;
        private Label lblNext;
        private Label lblReorder;
        private Label lblLast;
        private Label lblStorage;
        private Label lblid;
        private Label lblOn;
        private Label Status;
    }
}