namespace SchoolProject111
{
    partial class LogInForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            exitButton1 = new Button();
            panel3 = new Panel();
            signUplbl = new LinkLabel();
            loginBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            numberTextBox2 = new TextBox();
            emailTextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.tim_mossholder_WE_Kv_ZB1l0_unsplash__3_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(923, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 187, 189);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 423);
            panel1.TabIndex = 1;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 425);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(179, 187, 189);
            label2.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(0, -3);
            label2.Name = "label2";
            label2.Size = new Size(372, 72);
            label2.TabIndex = 1;
            label2.Text = "School Project";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(179, 187, 189);
            pictureBox2.Image = Properties.Resources.images_removebg_preview__1_1;
            pictureBox2.Location = new Point(234, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // exitButton1
            // 
            exitButton1.BackColor = Color.DimGray;
            exitButton1.FlatAppearance.BorderColor = Color.White;
            exitButton1.FlatAppearance.MouseOverBackColor = Color.Silver;
            exitButton1.FlatStyle = FlatStyle.Flat;
            exitButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton1.ForeColor = SystemColors.ControlLightLight;
            exitButton1.Location = new Point(796, 12);
            exitButton1.Name = "exitButton1";
            exitButton1.Size = new Size(119, 42);
            exitButton1.TabIndex = 9;
            exitButton1.Text = "Exit.";
            exitButton1.UseVisualStyleBackColor = false;
            exitButton1.Click += exitButton1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 187, 189);
            panel3.Controls.Add(signUplbl);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(loginBtn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(numberTextBox2);
            panel3.Controls.Add(emailTextBox1);
            panel3.Location = new Point(147, 256);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 465);
            panel3.TabIndex = 0;
            // 
            // signUplbl
            // 
            signUplbl.AutoSize = true;
            signUplbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            signUplbl.LinkColor = Color.Black;
            signUplbl.Location = new Point(198, 402);
            signUplbl.Name = "signUplbl";
            signUplbl.Size = new Size(261, 31);
            signUplbl.TabIndex = 18;
            signUplbl.TabStop = true;
            signUplbl.Text = "Don't have an account ?";
            signUplbl.LinkClicked += signUplbl_LinkClicked;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DimGray;
            loginBtn.FlatAppearance.BorderColor = Color.White;
            loginBtn.FlatAppearance.BorderSize = 2;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ControlLightLight;
            loginBtn.Location = new Point(210, 317);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(226, 54);
            loginBtn.TabIndex = 15;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(179, 187, 189);
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(82, 99);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 13;
            label3.Text = "motto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(179, 187, 189);
            label4.Font = new Font("Bradley Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(146, 99);
            label4.Name = "label4";
            label4.Size = new Size(247, 37);
            label4.TabIndex = 14;
            label4.Text = "Pride of the city..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(179, 187, 189);
            label1.Font = new Font("Bradley Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(161, 64);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 11;
            label1.Text = "platform";
            // 
            // numberTextBox2
            // 
            numberTextBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numberTextBox2.Location = new Point(40, 227);
            numberTextBox2.Name = "numberTextBox2";
            numberTextBox2.PlaceholderText = "Phone Number.";
            numberTextBox2.Size = new Size(584, 47);
            numberTextBox2.TabIndex = 1;
            // 
            // emailTextBox1
            // 
            emailTextBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            emailTextBox1.Location = new Point(40, 152);
            emailTextBox1.Name = "emailTextBox1";
            emailTextBox1.PlaceholderText = "Email Address.";
            emailTextBox1.Size = new Size(584, 47);
            emailTextBox1.TabIndex = 0;
            // 
            // LogInForm
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 753);
            Controls.Add(panel3);
            Controls.Add(exitButton1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximumSize = new Size(945, 804);
            MinimumSize = new Size(945, 804);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button exitButton1;
        private Panel panel3;
        private Button loginBtn;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox numberTextBox2;
        private TextBox emailTextBox1;
        private LinkLabel signUplbl;
    }
}