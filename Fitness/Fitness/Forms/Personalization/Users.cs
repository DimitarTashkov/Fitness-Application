using Fitness.Models.DbConfiguration;
using Fitness.Properties;
using Fitness.Utilities;
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
    public partial class Users : Form
    {
        private ApplicationDbContext _context;
        private int index = 1;
        public Users()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void Users_Load(object sender, EventArgs e)
        {


            foreach (var activeUser in _context.Users)
            {
                FlowLayoutPanel userContainer = new FlowLayoutPanel
                {
                    Name = $"orderContainer{index}"
                    ,
                    Size = new Size(725, 120)
                    ,
                    Margin = new Padding(8, 8, 8, 8)
                    ,
                    BackColor = Color.RosyBrown
                };

                RoundPictureBox userAvatar = new RoundPictureBox
                {
                    Name = $"userAvatar{index}"
                    ,
                    Size = new Size(50, 50)
                    ,
                    ImageLocation = activeUser.AvatarUrl
                    ,
                    Margin = new Padding(0, 5, 30, 0)
                    ,
                    SizeMode = PictureBoxSizeMode.StretchImage

                };

                Label username = new Label
                {
                    Name = $"username{index}"
                    ,
                    Text = activeUser.Username
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(25, 5, 25, 0)

                };

                Label password = new Label
                {
                    Name = $"password{index}"                 
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 20, 0)
                };
                foreach (var letter in activeUser.Password)
                {
                    password.Text += "*";
                }

                Label email = new Label
                {
                    Name = $"email{index}"
                    ,
                    Text = activeUser.Email
                    ,
                    MaximumSize = new Size(100, 0)
                    ,
                    AutoSize = true
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 20, 0)
                };

                Label age = new Label
                {
                    Name = $"items{index}"
                    ,
                    Text = activeUser.Age.ToString()
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                ComboBox isAuthorized = new ComboBox
                {
                    Name = $"isAuthorized{index}"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 20, 0)
                    ,
                    SelectedText = activeUser.IsAuthorized.ToString()
                };
                isAuthorized.Items.AddRange(new object[] { false, true });

                isAuthorized.SelectedIndexChanged += async (s, e) =>
                {
                    bool value = (bool)isAuthorized.SelectedItem;
                    activeUser.IsAuthorized = value;
                    await _context.SaveChangesAsync();
                };

                Button edit = new Button
                {
                    Name = $"edit{index}"
                    ,
                    Text = "Edit"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    BackColor = Color.LightGray
                    ,
                    Margin = new Padding(330, 0, 0, 0)
                };

                edit.Click += (s, e) =>
                {
                    Profile profileForm = new Profile(activeUser);
                    Program.SwitchMainForm(profileForm);
                };

                Button delete = new Button
                {
                    Name = $"delete{index}"
                   ,
                    Text = "Delete"
                   ,
                    Font = FontsPicker.DetailsFont
                   ,
                    BackColor = Color.Red
                   ,
                    Margin = new Padding(330, 10, 0, 0)
                };

                delete.Click += async (s, e) =>
                {
                    _context.Users.Remove(activeUser);
                    await _context.SaveChangesAsync();
                    usersContainer.Controls.Remove(usersContainer);
                };

                userContainer.Controls.Add(username);
                userContainer.Controls.Add(password);
                userContainer.Controls.Add(email);
                userContainer.Controls.Add(age);
                userContainer.Controls.Add(userAvatar);
                userContainer.Controls.Add(isAuthorized);
                userContainer.Controls.Add(edit);
                userContainer.Controls.Add(delete);

                usersContainer.Controls.Add(userContainer);

                index++;
            }

        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index();
            Program.SwitchMainForm(indexForm);
        }

    }
}
