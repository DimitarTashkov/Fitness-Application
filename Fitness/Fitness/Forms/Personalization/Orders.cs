using Fitness.Models;
using Fitness.Models.DbConfiguration;
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

namespace Fitness.Forms.Personalization
{
    public partial class Orders : Form
    {
        private User activeUser;
        private ApplicationDbContext _context;
        private int index = 1;
        private bool isAuthorized;
        public Orders(User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            activeUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            isAuthorized = AuthorizationHelper.IsUserAuthorized(activeUser);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            var query = isAuthorized ? _context.Orders.Include(o => o.User) : _context.Orders.Include(o => o.User).Where(o => o.User == activeUser);
            foreach (var order in query)
            {
                FlowLayoutPanel orderContainer = new FlowLayoutPanel
                {
                    Name = $"orderContainer{index}"
                    ,
                    Size = new Size(725, 120)
                    ,
                    Margin = new Padding(8, 8, 8, 8)
                    ,
                    BackColor = Color.RosyBrown
                };

                Panel userCredentials = new Panel
                {
                    Name = $"userCredentials{index}"
                    ,
                    Size = new Size(100, 80)

                };
                RoundPictureBox userAvatar = new RoundPictureBox
                {
                    Name = $"userAvatar{index}"
                    ,
                    Size = new Size(50, 50)
                    ,
                    ImageLocation = order.User.AvatarUrl
                    ,
                    Location = new Point(userCredentials.Location.X + 20, userCredentials.Location.Y + 5)
                    ,
                    SizeMode = PictureBoxSizeMode.StretchImage

                };

                Label username = new Label
                {
                    Name = $"username{index}"
                    ,
                    Text = order.User.Username
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(userAvatar.Location.X - 10, userAvatar.Location.Y + 60)

                };

                Label address = new Label
                {
                    Name = $"address{index}"
                    ,
                    Text = order.Address
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                Label price = new Label
                {
                    Name = $"price{index}"
                    ,
                    Text = order.TotalPrice.ToString()
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                Label items = new Label
                {
                    Name = $"items{index}"
                    ,
                    Text = order.ItemsBought.ToString()
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                Label payment = new Label
                {
                    Name = $"payment{index}"
                    ,
                    Text = order.Payment.ToString()
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                Label orderedDate = new Label
                {
                    Name = $"orderedDate{index}"
                    ,
                    Text = order.PurchasedOn.ToString()
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                Label arrivalDate = new Label
                {
                    Name = $"arrivalDate{index}"
                    ,
                    Text = order.ArrivesOn.ToString()
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Margin = new Padding(0, 5, 0, 0)
                };

                Button cancelOrder = new Button
                {
                    Name = $"cancelOrder{index}"
                    ,
                    Text = "Cancel"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    BackColor = Color.Red
                    ,
                    Margin = new Padding(330, 0, 0, 0)
                };

                cancelOrder.Click += async (s, e) =>
                {
                    //Log order as cancled
                    _context.Orders.Remove(order);
                    await _context.SaveChangesAsync();
                    ordersContainer.Controls.Remove(orderContainer);
                };

                userCredentials.Controls.Add(userAvatar);
                userCredentials.Controls.Add(username);

                orderContainer.Controls.Add(userCredentials);
                orderContainer.Controls.Add(address);
                orderContainer.Controls.Add(price);
                orderContainer.Controls.Add(items);
                orderContainer.Controls.Add(payment);
                orderContainer.Controls.Add(orderedDate);
                orderContainer.Controls.Add(arrivalDate);
                orderContainer.Controls.Add(cancelOrder);

                ordersContainer.Controls.Add(orderContainer);

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
