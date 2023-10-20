using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolProject111
{
    public partial class SignupForm : Form
    {

        public SignupForm()
        {
            InitializeComponent();
        }

        private void myPanel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (firstnameTextBox1.Text == "" || lastNameTextBox.Text == "" || emailTextBox.Text == "" || numberTextBox.Text == "")
                {
                    MessageBox.Show("Hey, Enter your Details" +
                        "\nto enable you log into the School Project Platform!", "Note!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string[] myDetails =
            {
                firstnameTextBox1.Text, lastNameTextBox.Text, emailTextBox.Text, numberTextBox.Text
            };

            try
            {

                long value;

                //MAKING SURE USER DOES NOT LEAVE BOXES EMPTY BEFORE HITTING THE SIGN UP BUTTON

                if (firstnameTextBox1.Text == "" || lastNameTextBox.Text == "" || emailTextBox.Text == "" || numberTextBox.Text == "")
                {
                    MessageBox.Show("Hey, TextBoxes cannot be left empty,\n" +
                        " Enter your details to enable you log into the School Project Platform!", "Note!");
                }
                else
                {
                    //MAKING SURE PHONENUMBER ACCEPTS 11 DIGITS ONLY
                    if (!(Int64.TryParse(numberTextBox.Text, out value)) || !(numberTextBox.Text.Length == 11))
                    {
                        MessageBox.Show("Hey, Phone numbers must be 11 digits!", "Error!");
                    }
                    else if (!(femaleRadioButton.Checked || MaleRadioButton.Checked))//ONE RADIO BUTTON MUST BE CHECKED
                    {
                        MessageBox.Show("Hey, you have to indicate your Gender!", "Gender Check");
                    }
                    else if (!Terms.Checked)//CHECK BOXES MUST BE CHECKED
                    {
                        MessageBox.Show("You must agree to Terms and conditions!", "Note");
                    }
                    else
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                             + Path.DirectorySeparatorChar + emailTextBox.Text + ".txt";
                        if (File.Exists(path))
                        {
                            MessageBox.Show("Details already Exist", "Note");
                        }
                        else
                        {
                            //SAVING DETAILS TO THE TEXTFILE CREATED
                            File.Create(path).Dispose();
                            File.WriteAllLines(path, myDetails);//saving details to user's file.
                            //File.WriteAllText(path, myDetails[0]);
                            //File.WriteAllText(path, myDetails[1]);
                            //File.WriteAllText(path, myDetails[2]);
                            //File.WriteAllText(path, myDetails[3]);
                            MessageBox.Show("Saving Details!\n" +
                                "Now try Logging in with the details you have provided", "Note");
                            LogInForm form = new LogInForm(emailTextBox.Text, numberTextBox.Text);
                            this.Hide();
                            form.ShowDialog();
                        }

                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }

        }
        //THE LOG IN MENU POPS UP WHEN USER HITS THE LOG IN BUTTON ONTHE STRIP MENU ITEM
        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm schoolProjectForm = new LogInForm(emailTextBox.Text, numberTextBox.Text);
            this.Hide();
            schoolProjectForm.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to log in first!", "Note");
        }

        public void clear_Text()
        {
            firstnameTextBox1.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            numberTextBox.Text = string.Empty;
        }
    }
}
