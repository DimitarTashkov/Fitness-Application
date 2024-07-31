using Fitness.Common.Messages;
using Fitness.Forms.Personalization;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class Index : Form
    {

        private ApplicationDbContext _context;
        private StreamReader sessionReader;
        private User activeUser;
        public Index()
        {
            InitializeComponent();

            sessionReader = new StreamReader(@"..\..\..\..\Fitness\SessionToken.txt");
            _context = new ApplicationDbContext();
            activeUser = _context.Users.FirstOrDefault(u => u.Id == int.Parse(sessionReader.ReadLine()));
        }

        private async void Index_Load(object sender, EventArgs e)
        {
            Comments.Font = FontsPicker.UnauthorisedBaseFont;
            Users.Font = FontsPicker.UnauthorisedBaseFont;
            if (AuthorizationHelper.IsUserAuthorized(activeUser))
            {
                Comments.Font = FontsPicker.BaseFont;
                Users.Font = FontsPicker.BaseFont;
            }

            using (sessionReader)
            {
                //!!AUTHORIZATION          
                welcomeLabel.Text = $"Welcome to our app {activeUser.Username}";
                roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
            }

        }

        private void buttons_Hover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.ButtonHighlight;
        }
        private void buttons_Leave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.ButtonFace;
        }

        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item.Font == FontsPicker.UnauthorisedBaseFont)
            {
                MessageBox.Show(UserMessages.UnauthorizedAccess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string formName = item.Name;
            Form form = new Form();

            switch (formName)
            {
                case "Supplements":
                    form = new Supplements();
                    break;
                case "Workouts":
                    form = new Workouts();
                    break;
                case "Users":
                    form = new Users();
                    break;
                case "Profile":
                    form = new Profile(activeUser);
                    break;
                case "Comments":
                    form = new Comments();
                    break;
                case "Orders":
                    form = new Orders(activeUser);
                    break;
                default:
                    form = new Index();
                    break;
            }
            Program.SwitchMainForm(form);
        }
        private void supplementsButton_Click(object sender, EventArgs e)
        {
            Supplements supplementsForm = new Supplements();
            Program.SwitchMainForm(supplementsForm);
        }

        private void workoutsButton_Click(object sender, EventArgs e)
        {
            Workouts workoutsForm = new Workouts();
            Program.SwitchMainForm(workoutsForm);
        }
    }
}
