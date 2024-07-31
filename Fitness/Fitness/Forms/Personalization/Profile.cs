using Fitness.Common.Messages;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Properties;
using Fitness.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class Profile : Form
    {
        private ApplicationDbContext _context;
        private User activeUser;
        public Profile(User user)
        {
            InitializeComponent();
            ActiveControl = usernameLabel;
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);
            _context = new ApplicationDbContext();
            activeUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            usernameField.Text = activeUser.Username;
            foreach (var character in activeUser.Password)
            {
                passwordField.Text += "*";
            }

            emailField.Text = activeUser.Email;
            ageField.Text = activeUser.Age.ToString();
            profilePicture.ImageLocation = activeUser.AvatarUrl;

            emailField.ForeColor = Color.DimGray;
            ageField.ForeColor = Color.DimGray;
            usernameField.ForeColor = Color.DimGray;
            passwordField.ForeColor = Color.DimGray;

            emailField.Font = FontsPicker.DetailsFont;
            ageField.Font = FontsPicker.DetailsFont;
            usernameField.Font = FontsPicker.DetailsFont;
            passwordField.Font = FontsPicker.DetailsFont;

        }

        private void clearInputs_click(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.Text = "";
        }
        private void input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.ForeColor = Color.Black;
            textBox.Font = FontsPicker.BaseFont;
        }
        private void uploadImage_click(Object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                }
                profilePicture.ImageLocation = imageLocation;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            saveButton.Visible = true;

            //Activate inputs
            usernameField.Enabled = true;
            passwordField.Enabled = true;

            passwordField.Text = activeUser.Password;
            passwordField.ForeColor = Color.DimGray;
            passwordField.Font = FontsPicker.DetailsFont;

            emailField.Enabled = true;
            ageField.Enabled = true;
            uploadButton.Enabled = true;

            ActiveControl = usernameField;

        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index();
            Program.SwitchMainForm(indexForm);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = true;
            saveButton.Visible = false;

            List<TextBox> inputs = new List<TextBox>
                {
                    usernameField,
                    passwordField,
                    emailField
                };
            bool isValid = ValidationHelper.ValidateUserInputs(inputs, profilePicture);
            if (isValid)
            {
                string username = usernameField.Text;
                string password = passwordField.Text;
                string email = emailField.Text;
                string photoUrl = profilePicture.ImageLocation;
                int age = ValidationHelper.ValidateUserAge(ageField);

                activeUser.Username = username;
                activeUser.Password = password;
                activeUser.Email = email;
                activeUser.AvatarUrl = photoUrl;
                activeUser.Age = age;


                Logger log = new Logger()
                {
                    Message = String.Format(UserMessages.LogUserEdited, activeUser.Username)
                     ,
                    ReportedOn = DateTime.Now
                };

                await _context.Logs.AddAsync(log);
                await _context.SaveChangesAsync();

                MessageBox.Show(String.Format(UserMessages.UserDataUpdate, activeUser.Username), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Profile profileForm = new Profile(activeUser);
                Program.SwitchMainForm(profileForm);


            }
            else
            {
                MessageBox.Show(UserMessages.InvalidInput, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            _context.Users.Remove(activeUser);
            await _context.SaveChangesAsync();

            MessageBox.Show(String.Format(UserMessages.UserDeleted, activeUser.Username), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login1 loginForm = new Login1();
            Program.SwitchMainForm(loginForm);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login1 loginForm = new Login1();
            Program.SwitchMainForm(loginForm);
        }
    }
}
