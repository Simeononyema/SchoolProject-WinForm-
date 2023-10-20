using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SchoolProject111
{
    public partial class HomeForm : Form
    {
        Random random = new Random();
        string mainEmail;
        string fName;
        string lName;
        public HomeForm()
        {
            InitializeComponent();
            this.Show();
        }
        public HomeForm(string majorEmail)
        {
            InitializeComponent();
            this.Show();
            mainEmail = majorEmail;
            displayNameText();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Get the names of all embedded resources (pictures).
            string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            // Check if there are any resources available.
            if (resourceNames.Length > 0)
            {
                // Randomly select a resource name.
                int randomIndex = random.Next(resourceNames.Length);
                string randomResourceName = resourceNames[randomIndex];

                // Load the selected resource as a stream.
                Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(randomResourceName);

                if (resourceStream != null)
                {
                    try
                    {
                        Bitmap randomPicture = new Bitmap(resourceStream);

                        pictureBox1.Image = randomPicture;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Failed to load the image: " + ex.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("resourceStream is truly null!");
                }
            }
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("School Project is a great school thats changes the narrative of life on the leaders of tomorrow\n" +
                "Laced with underlining optimism, the schools upholds the tenets of hope and redemption in the life of our children\n..");
        }

        private void exitWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!");
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to save details before logging out?");
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void displayNameText()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                     + Path.DirectorySeparatorChar + mainEmail + ".txt";
            if (File.Exists(path))
            {
                string[] myNames = File.ReadAllLines(path).ToArray();
                MessageBox.Show("Hey, " + myNames[0] + " " + myNames[1] + " Welcome to School Project homepage", "Information");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
