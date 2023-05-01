namespace FinalProjectDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seeList = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.myDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnBg = new System.Windows.Forms.Panel();
            this.btnNeworder = new System.Windows.Forms.Button();
            this.pnBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(997, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome User!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // seeList
            // 
            this.seeList.Location = new System.Drawing.Point(51, 119);
            this.seeList.Name = "seeList";
            this.seeList.Size = new System.Drawing.Size(75, 23);
            this.seeList.TabIndex = 3;
            this.seeList.Text = "See List";
            this.seeList.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // myDashboard
            // 
            this.myDashboard.Location = new System.Drawing.Point(0, 0);
            this.myDashboard.Name = "myDashboard";
            this.myDashboard.Size = new System.Drawing.Size(75, 23);
            this.myDashboard.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(261, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 900);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DimGray;
            this.panelLogo.Location = new System.Drawing.Point(27, 39);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 160);
            this.panelLogo.TabIndex = 10;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DarkGray;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(1, 294);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(260, 43);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.Text = "     Order History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(1, 245);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(260, 43);
            this.btnDashboard.TabIndex = 12;
            this.btnDashboard.Text = "     Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnBg
            // 
            this.pnBg.BackColor = System.Drawing.Color.DarkGray;
            this.pnBg.Controls.Add(this.btnNeworder);
            this.pnBg.Controls.Add(this.btnHistory);
            this.pnBg.Controls.Add(this.panelLogo);
            this.pnBg.Controls.Add(this.btnDashboard);
            this.pnBg.Location = new System.Drawing.Point(0, 0);
            this.pnBg.Name = "pnBg";
            this.pnBg.Size = new System.Drawing.Size(261, 901);
            this.pnBg.TabIndex = 7;
            this.pnBg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBg_Paint);
            // 
            // btnNeworder
            // 
            this.btnNeworder.Location = new System.Drawing.Point(69, 803);
            this.btnNeworder.Name = "btnNeworder";
            this.btnNeworder.Size = new System.Drawing.Size(115, 45);
            this.btnNeworder.TabIndex = 14;
            this.btnNeworder.Text = "New Order";
            this.btnNeworder.UseVisualStyleBackColor = true;
            this.btnNeworder.Click += new System.EventHandler(this.btnNeworder_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1616, 901);
            this.Controls.Add(this.pnBg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnBg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button seeList;
        private Panel mainPanel;
        private Button myDashboard;
        private Panel panel1;
        private Button myDash;
        private Button myLisT;
        private Panel panelLogo;
        private Button btnDashboard;
        private Button btnHistory;
        private Panel pnBg;
        private Button btnNeworder;
    }
}