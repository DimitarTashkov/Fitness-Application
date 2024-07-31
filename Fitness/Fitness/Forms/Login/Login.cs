using Fitness.Common.Messages;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
namespace Fitness
{
    public partial class Login1 : Form
    {
        private ApplicationDbContext _context;
        public Login1()
        {
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);
            ActiveControl = usernameLabel;
            _context = new ApplicationDbContext();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            usernameField.Text = "\"foulcoast\"";
            usernameField.ForeColor = Color.DimGray;
            passwordField.Text = "\"mitko123\"";
            passwordField.ForeColor = Color.DimGray;
            usernameField.Font = FontsPicker.DetailsFont;
            passwordField.Font = FontsPicker.DetailsFont;

        }

        private void register_hover(object sender, EventArgs e)
        {
            register.ForeColor = Color.Indigo;
        }

        private void register_leave(object sender, EventArgs e)
        {
            register.ForeColor = Color.Blue;
        }
        private void register_Click(object sender, EventArgs e)
        {
            register.ForeColor = Color.BlueViolet;
            Register registerForm = new Register();
            Program.SwitchMainForm(registerForm);
        }

        private void login_hover(object sender, EventArgs e)
        {
            login.BackColor = Color.DeepSkyBlue;
        }

        private void login_leave(object sender, EventArgs e)
        {
            login.BackColor = Color.SkyBlue;
            login.ForeColor = Color.Black;
        }
        private async void login_Click(object sender, EventArgs e)
        {
            login.BackColor = Color.SteelBlue;
            List<TextBox> inputs = new List<TextBox>()
            {
                usernameField
                ,passwordField
            };

            bool isValid = ValidationHelper.ValidateUserInputs(inputs);
            if (isValid)
            {
                string username = usernameField.Text;
                string password = passwordField.Text;

                User user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    if (user.Username == "admin")
                    {
                        user.IsAuthorized = true;
                    }

                    StreamWriter sessionSaver = new StreamWriter(@"..\..\..\..\Fitness\SessionToken.txt");
                    using (sessionSaver)
                    {
                        sessionSaver.WriteLine(user.Id);
                    }
                    Logger log = new Logger()
                    {
                        Message = String.Format(UserMessages.LogUserLoggedIn, username)
                        ,
                        ReportedOn = DateTime.Now
                    };

                    await _context.Logs.AddAsync(log);
                    await _context.SaveChangesAsync();

                    Index indexForm = new Index();
                    Program.SwitchMainForm(indexForm);
                }
                MessageBox.Show(UserMessages.InvalidCredentials, "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(UserMessages.InvalidInput, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}