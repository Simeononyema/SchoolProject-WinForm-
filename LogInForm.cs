namespace SchoolProject111
{
    public partial class LogInForm : Form
    {
        string[] password;
        string majorEmail;
        string majorNumber;

        public LogInForm()
        {
            InitializeComponent();
   
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (emailTextBox1.Text == "" || numberTextBox2.Text == "")
            {
                MessageBox.Show("Try Entering Your Details to Log in!", "Note:");
            }
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            long value;
            var email = emailTextBox1.Text;
            var number = numberTextBox2.Text;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                     + Path.DirectorySeparatorChar + email + ".txt";
            if (email == "" || number == "")
            {
                MessageBox.Show("Hey, The textBoxes must not be left empty!", "Error");
            }
            else if (!(Int64.TryParse(number, out value)) || !(number.Length == 11))
            {
                MessageBox.Show("Hey, PhoneNumber Must be 11 digits!", "Error");
            }
            else if (File.Exists(path))
            {
                password = File.ReadAllLines(path).ToArray();

                if (number == password[3])
                {
                    MessageBox.Show("Details match, log in was Sucessful", "Success");
                    HomeForm homeForm = new HomeForm(emailTextBox1.Text);
                    this.Hide();
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Password do not match, Check your password and try again!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Details do not exist, Check your details and try again" +
                    " \nor Sign up if you don't have an account");
            }

        }
        public LogInForm(string email, string number)
        {
            InitializeComponent();
            majorEmail = email;
            majorNumber = number;
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signUplbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            this.Hide();
            signupForm.Show();
        }
    }
}