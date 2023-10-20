namespace SchoolProject111
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            menuStrip1 = new MenuStrip();
            logInToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            myPictureBox = new PictureBox();
            myPanel = new Panel();
            Terms = new CheckBox();
            MaleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            numberTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            signUpBtn = new Button();
            firstnameTextBox1 = new TextBox();
            motto = new Label();
            myMottoLbl = new Label();
            platformLbl = new Label();
            schoolHeader = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CapPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myPictureBox).BeginInit();
            myPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CapPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logInToolStripMenuItem, exitToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStripbar";
            // 
            // logInToolStripMenuItem
            // 
            logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            logInToolStripMenuItem.Size = new Size(76, 27);
            logInToolStripMenuItem.Text = "Log in ";
            logInToolStripMenuItem.Click += logInToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(52, 27);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(71, 27);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // myPictureBox
            // 
            myPictureBox.Dock = DockStyle.Fill;
            myPictureBox.Image = Properties.Resources.tim_mossholder_WE_Kv_ZB1l0_unsplash__3_1;
            myPictureBox.Location = new Point(0, 31);
            myPictureBox.Name = "myPictureBox";
            myPictureBox.Size = new Size(923, 722);
            myPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            myPictureBox.TabIndex = 2;
            myPictureBox.TabStop = false;
            // 
            // myPanel
            // 
            myPanel.BackColor = Color.FromArgb(179, 187, 189);
            myPanel.Controls.Add(Terms);
            myPanel.Controls.Add(MaleRadioButton);
            myPanel.Controls.Add(femaleRadioButton);
            myPanel.Controls.Add(numberTextBox);
            myPanel.Controls.Add(lastNameTextBox);
            myPanel.Controls.Add(emailTextBox);
            myPanel.Controls.Add(signUpBtn);
            myPanel.Controls.Add(firstnameTextBox1);
            myPanel.Controls.Add(motto);
            myPanel.Controls.Add(myMottoLbl);
            myPanel.Controls.Add(platformLbl);
            myPanel.Controls.Add(schoolHeader);
            myPanel.Controls.Add(flowLayoutPanel1);
            myPanel.Location = new Point(114, 89);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(726, 623);
            myPanel.TabIndex = 3;
            myPanel.MouseClick += myPanel_MouseClick;
            // 
            // Terms
            // 
            Terms.AutoSize = true;
            Terms.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Terms.Location = new Point(72, 471);
            Terms.Name = "Terms";
            Terms.Size = new Size(238, 32);
            Terms.TabIndex = 5;
            Terms.Text = "Terms and agreement.";
            Terms.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MaleRadioButton.Location = new Point(289, 423);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(82, 32);
            MaleRadioButton.TabIndex = 14;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male.";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            femaleRadioButton.Location = new Point(72, 423);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(103, 32);
            femaleRadioButton.TabIndex = 4;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female.";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numberTextBox.Location = new Point(72, 370);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.PlaceholderText = "Phone number.";
            numberTextBox.Size = new Size(584, 47);
            numberTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(72, 237);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last name.";
            lastNameTextBox.Size = new Size(584, 47);
            lastNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            emailTextBox.Location = new Point(72, 303);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email address.";
            emailTextBox.Size = new Size(584, 47);
            emailTextBox.TabIndex = 2;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.DimGray;
            signUpBtn.FlatAppearance.BorderColor = Color.White;
            signUpBtn.FlatAppearance.BorderSize = 2;
            signUpBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.ForeColor = SystemColors.ControlLightLight;
            signUpBtn.Location = new Point(194, 547);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(339, 54);
            signUpBtn.TabIndex = 9;
            signUpBtn.Text = "Sign up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // firstnameTextBox1
            // 
            firstnameTextBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            firstnameTextBox1.Location = new Point(72, 169);
            firstnameTextBox1.Name = "firstnameTextBox1";
            firstnameTextBox1.PlaceholderText = "First name.";
            firstnameTextBox1.Size = new Size(584, 47);
            firstnameTextBox1.TabIndex = 0;
            // 
            // motto
            // 
            motto.AutoSize = true;
            motto.BackColor = Color.FromArgb(179, 187, 189);
            motto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            motto.ForeColor = SystemColors.ActiveCaptionText;
            motto.Location = new Point(149, 114);
            motto.Name = "motto";
            motto.Size = new Size(73, 28);
            motto.TabIndex = 7;
            motto.Text = "motto:";
            // 
            // myMottoLbl
            // 
            myMottoLbl.AutoSize = true;
            myMottoLbl.BackColor = Color.FromArgb(179, 187, 189);
            myMottoLbl.Font = new Font("Bradley Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            myMottoLbl.ForeColor = SystemColors.ActiveCaptionText;
            myMottoLbl.Location = new Point(215, 112);
            myMottoLbl.Name = "myMottoLbl";
            myMottoLbl.Size = new Size(247, 37);
            myMottoLbl.TabIndex = 6;
            myMottoLbl.Text = "Pride of the city..";
            // 
            // platformLbl
            // 
            platformLbl.AutoSize = true;
            platformLbl.BackColor = Color.FromArgb(179, 187, 189);
            platformLbl.Font = new Font("Bradley Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            platformLbl.ForeColor = SystemColors.ActiveCaptionText;
            platformLbl.Location = new Point(194, 79);
            platformLbl.Name = "platformLbl";
            platformLbl.Size = new Size(125, 35);
            platformLbl.TabIndex = 3;
            platformLbl.Text = "platform";
            // 
            // schoolHeader
            // 
            schoolHeader.AutoSize = true;
            schoolHeader.BackColor = Color.FromArgb(179, 187, 189);
            schoolHeader.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            schoolHeader.ForeColor = Color.WhiteSmoke;
            schoolHeader.Location = new Point(72, 18);
            schoolHeader.Name = "schoolHeader";
            schoolHeader.Size = new Size(372, 72);
            schoolHeader.TabIndex = 2;
            schoolHeader.Text = "School Project";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(51, 138);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(624, 377);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // CapPictureBox
            // 
            CapPictureBox.BackColor = Color.FromArgb(179, 187, 189);
            CapPictureBox.Image = Properties.Resources.images_removebg_preview__1_;
            CapPictureBox.Location = new Point(263, 49);
            CapPictureBox.Name = "CapPictureBox";
            CapPictureBox.Size = new Size(143, 68);
            CapPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CapPictureBox.TabIndex = 10;
            CapPictureBox.TabStop = false;
            // 
            // SignupForm
            // 
            AcceptButton = signUpBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 187, 189);
            ClientSize = new Size(923, 753);
            Controls.Add(CapPictureBox);
            Controls.Add(myPanel);
            Controls.Add(myPictureBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(945, 804);
            MinimizeBox = false;
            MinimumSize = new Size(945, 804);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myPictureBox).EndInit();
            myPanel.ResumeLayout(false);
            myPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CapPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logInToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox myPictureBox;
        private Panel myPanel;
        private Label schoolHeader;
        private Label platformLbl;
        private Label myMottoLbl;
        private Label motto;
        private TextBox firstnameTextBox1;
        private Button signUpBtn;
        private TextBox numberTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private PictureBox CapPictureBox;
        private RadioButton femaleRadioButton;
        private RadioButton MaleRadioButton;
        private CheckBox Terms;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}