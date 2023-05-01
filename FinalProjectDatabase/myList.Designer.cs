namespace FinalProjectDatabase
{
    partial class myList
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
            this.dgList = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultId = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrgy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.resultName = new System.Windows.Forms.Label();
            this.resultBrgy = new System.Windows.Forms.Label();
            this.resultDate = new System.Windows.Forms.Label();
            this.resultNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgList.Location = new System.Drawing.Point(12, 12);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 25;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(863, 419);
            this.dgList.TabIndex = 2;
            this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            this.dgList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellEnter);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdNo";
            this.Column2.HeaderText = "Order Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "studentNo";
            this.Column3.HeaderText = "Student Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cName";
            this.Column4.HeaderText = "Product Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cBrgy";
            this.Column5.HeaderText = "Cost";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cDate";
            this.Column6.HeaderText = "Date Purchased";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // resultId
            // 
            this.resultId.AutoSize = true;
            this.resultId.Location = new System.Drawing.Point(218, 557);
            this.resultId.Name = "resultId";
            this.resultId.Size = new System.Drawing.Size(17, 15);
            this.resultId.TabIndex = 3;
            this.resultId.Text = "Id";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 470);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(359, 31);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(604, 536);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 31);
            this.txtName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Number";
            // 
            // txtBrgy
            // 
            this.txtBrgy.Location = new System.Drawing.Point(604, 579);
            this.txtBrgy.Multiline = true;
            this.txtBrgy.Name = "txtBrgy";
            this.txtBrgy.Size = new System.Drawing.Size(271, 31);
            this.txtBrgy.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Purchased";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(511, 678);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 678);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(687, 678);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(604, 449);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 31);
            this.txtID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Order Number";
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(604, 631);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(271, 23);
            this.dtTime.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Student No";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(604, 495);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(271, 31);
            this.txtNo.TabIndex = 20;
            // 
            // resultName
            // 
            this.resultName.AutoSize = true;
            this.resultName.Location = new System.Drawing.Point(218, 609);
            this.resultName.Name = "resultName";
            this.resultName.Size = new System.Drawing.Size(39, 15);
            this.resultName.TabIndex = 21;
            this.resultName.Text = "Name";
            // 
            // resultBrgy
            // 
            this.resultBrgy.AutoSize = true;
            this.resultBrgy.Location = new System.Drawing.Point(218, 634);
            this.resultBrgy.Name = "resultBrgy";
            this.resultBrgy.Size = new System.Drawing.Size(31, 15);
            this.resultBrgy.TabIndex = 22;
            this.resultBrgy.Text = "Brgy";
            // 
            // resultDate
            // 
            this.resultDate.AutoSize = true;
            this.resultDate.Location = new System.Drawing.Point(218, 660);
            this.resultDate.Name = "resultDate";
            this.resultDate.Size = new System.Drawing.Size(31, 15);
            this.resultDate.TabIndex = 23;
            this.resultDate.Text = "Date";
            // 
            // resultNo
            // 
            this.resultNo.AutoSize = true;
            this.resultNo.Location = new System.Drawing.Point(218, 583);
            this.resultNo.Name = "resultNo";
            this.resultNo.Size = new System.Drawing.Size(64, 15);
            this.resultNo.TabIndex = 24;
            this.resultNo.Text = "StudentNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search Result:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(800, 678);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type the Id ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "(fix student no this)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 583);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "StudentNo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 660);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 634);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Brgy:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 609);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 557);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Id:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Order Number";
            this.Column1.Name = "Column1";
            this.Column1.Width = 1111;
            // 
            // myList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1354, 912);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultNo);
            this.Controls.Add(this.resultDate);
            this.Controls.Add(this.resultBrgy);
            this.Controls.Add(this.resultName);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrgy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.resultId);
            this.Controls.Add(this.dgList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myList";
            this.Load += new System.EventHandler(this.myList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgList;
        private Label resultId;
        private TextBox txtSearch;
        private TextBox txtName;
        private Label label2;
        private TextBox txtBrgy;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtID;
        private Label label5;
        private DateTimePicker dtTime;
        private Label label6;
        private TextBox txtNo;
        private Label resultName;
        private Label resultBrgy;
        private Label resultDate;
        private Label resultNo;
        private Label label7;
        private Button btnExit;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}