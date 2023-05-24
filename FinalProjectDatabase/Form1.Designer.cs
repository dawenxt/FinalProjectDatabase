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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(261, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 900);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.btnHistory.Font = new System.Drawing.Font("Lexend Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(0, 307);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(260, 39);
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
            this.btnDashboard.Font = new System.Drawing.Font("Lexend Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(0, 268);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(260, 39);
            this.btnDashboard.TabIndex = 12;
            this.btnDashboard.Text = "     Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnBg
            // 
            this.pnBg.BackColor = System.Drawing.Color.DarkGray;
            this.pnBg.Controls.Add(this.btnSettings);
            this.pnBg.Controls.Add(this.btnSupport);
            this.pnBg.Controls.Add(this.button2);
            this.pnBg.Controls.Add(this.label6);
            this.pnBg.Controls.Add(this.btnHistory);
            this.pnBg.Controls.Add(this.lblDetails);
            this.pnBg.Controls.Add(this.btnNeworder);
            this.pnBg.Controls.Add(this.panelLogo);
            this.pnBg.Controls.Add(this.btnDashboard);
            this.pnBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnBg.Location = new System.Drawing.Point(0, 0);
            this.pnBg.Name = "pnBg";
            this.pnBg.Size = new System.Drawing.Size(261, 901);
            this.pnBg.TabIndex = 7;
            this.pnBg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBg_Paint);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkGray;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Lexend Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(1, 420);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(260, 37);
            this.btnSettings.TabIndex = 21;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.DarkGray;
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.Font = new System.Drawing.Font("Lexend Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupport.ForeColor = System.Drawing.Color.Black;
            this.btnSupport.Location = new System.Drawing.Point(1, 465);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(260, 37);
            this.btnSupport.TabIndex = 20;
            this.btnSupport.Text = "     Support";
            this.btnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lexend Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "     Stock Inventory";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "―――――――――――――――";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Lexend Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetails.Location = new System.Drawing.Point(2, 878);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(70, 21);
            this.lblDetails.TabIndex = 16;
            this.lblDetails.Text = "Welcome";
            // 
            // btnNeworder
            // 
            this.btnNeworder.Font = new System.Drawing.Font("Lexend Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNeworder.Location = new System.Drawing.Point(54, 749);
            this.btnNeworder.Name = "btnNeworder";
            this.btnNeworder.Size = new System.Drawing.Size(148, 45);
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
            this.pnBg.PerformLayout();
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
        private Label lblDetails;
        private Button button2;
        private Label label6;
        private Button btnSupport;
        private Button btnSettings;
    }
}