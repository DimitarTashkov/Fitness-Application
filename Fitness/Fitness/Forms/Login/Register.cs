using Fitness.Common.Messages;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Utilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class Register : Form
    {
        private ApplicationDbContext _context;
        public Register()
        {
            InitializeComponent();
            ActiveControl = usernameLabel;
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);
            _context = new ApplicationDbContext();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            usernameField.Text = "\"foulcoast\"";
            passwordField.Text = "\"mitko123\"";
            emailField.Text = "\"dimitar.tashkov@pmggd.bg\"";
            ageField.Text = "\"17\"";

            emailField.ForeColor = Color.DimGray;
            ageField.ForeColor = Color.DimGray;
            usernameField.ForeColor = Color.DimGray;
            passwordField.ForeColor = Color.DimGray;
            disclaimer.ForeColor = Color.DimGray;


            emailField.Font = FontsPicker.DetailsFont;
            ageField.Font = FontsPicker.DetailsFont;
            usernameField.Font = FontsPicker.DetailsFont;
            passwordField.Font = FontsPicker.DetailsFont;
            disclaimer.Font = FontsPicker.DetailsFont;

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

        private async void registerButton_Click(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.DarkGreen;

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

                if (!_context.Users.Any(u => u.Username == username))
                {
                    User user = new User
                    {
                        Username = username
    ,
                        Password = password
    ,
                        Email = email
    ,
                        AvatarUrl = photoUrl
    ,
                        Age = age
                    };

                    Logger log = new Logger()
                    {
                        Message = String.Format(UserMessages.LogUserRegistered, username)
                        ,
                        ReportedOn = DateTime.Now
                    };

                    await _context.Logs.AddAsync(log);
                    await _context.Users.AddAsync(user);
                    await _context.SaveChangesAsync();

                    MessageBox.Show(UserMessages.RegistrationSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login1 loginForm = new Login1();
                    Program.SwitchMainForm(loginForm);
                }
                MessageBox.Show(UserMessages.UserExists, "User exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(UserMessages.InvalidInput, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_hover(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.Green;
        }

        private void register_leave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.LightGreen;
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Login1 loginForm = new Login1();
            Program.SwitchMainForm(loginForm);
        }
    }
}
