namespace FinalProjectDatabase
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnBg = new System.Windows.Forms.Panel();
            this.pnDes = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnPasswordDesign = new System.Windows.Forms.Panel();
            this.pnUsernameDesign = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnPasswordDesign.SuspendLayout();
            this.pnUsernameDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(735, 363);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(508, 46);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // pnBg
            // 
            this.pnBg.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnBg.Controls.Add(this.pnDes);
            this.pnBg.Location = new System.Drawing.Point(-1, -2);
            this.pnBg.Name = "pnBg";
            this.pnBg.Size = new System.Drawing.Size(624, 811);
            this.pnBg.TabIndex = 5;
            this.pnBg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBg_Paint);
            // 
            // pnDes
            // 
            this.pnDes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnDes.Location = new System.Drawing.Point(150, 437);
            this.pnDes.Name = "pnDes";
            this.pnDes.Size = new System.Drawing.Size(302, 245);
            this.pnDes.TabIndex = 0;
            this.pnDes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDes_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbLogo.ErrorImage = null;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(905, 26);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(156, 146);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(735, 470);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(508, 46);
            this.textBox1.TabIndex = 7;
            // 
            // pnPasswordDesign
            // 
            this.pnPasswordDesign.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnPasswordDesign.Controls.Add(this.label2);
            this.pnPasswordDesign.Location = new System.Drawing.Point(746, 463);
            this.pnPasswordDesign.Name = "pnPasswordDesign";
            this.pnPasswordDesign.Size = new System.Drawing.Size(106, 18);
            this.pnPasswordDesign.TabIndex = 1;
            this.pnPasswordDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPasswordDesign_Paint);
            // 
            // pnUsernameDesign
            // 
            this.pnUsernameDesign.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnUsernameDesign.Controls.Add(this.label1);
            this.pnUsernameDesign.Location = new System.Drawing.Point(746, 357);
            this.pnUsernameDesign.Name = "pnUsernameDesign";
            this.pnUsernameDesign.Size = new System.Drawing.Size(106, 20);
            this.pnUsernameDesign.TabIndex = 2;
            this.pnUsernameDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.pnUsernameDesign_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(937, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(794, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "The best way to manage your Storage and Save ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(838, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Information and more features.";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(735, 576);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(508, 47);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(838, 772);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Login only as Admin!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(1006, 772);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 18);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Learn More.";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 809);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnUsernameDesign);
            this.Controls.Add(this.pnPasswordDesign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnBg);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnPasswordDesign.ResumeLayout(false);
            this.pnPasswordDesign.PerformLayout();
            this.pnUsernameDesign.ResumeLayout(false);
            this.pnUsernameDesign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox txtUsername;
        private Panel pnBg;
        private PictureBox pbLogo;
        private Panel pnDes;
        private TextBox textBox1;
        private Panel pnPasswordDesign;
        private Panel pnUsernameDesign;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLogin;
        private Label label7;
        private LinkLabel linkLabel1;
    }
}