using Fitness.Forms.Transaction;
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
    public partial class Cart : Form
    {
        private User activeUser;
        private ApplicationDbContext _context;
        private int index = 1;
        public Cart(User user)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            activeUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = activeUser.Username;
            userPfp.ImageLocation = activeUser.AvatarUrl;

            foreach (var supplement in _context.UsersSupplements.Include(s => s.Supplement).Where(u => u.UserId == activeUser.Id))
            {
                Panel supplementContainer = new Panel
                {
                    Name = $"supplementContainer{index}"
                    ,
                    Size = new Size(190, 163)
                    ,
                    BackColor = Color.DarkOrange
                };

                Label supplementName = new Label
                {
                    Name = $"supplementName{index}"
                    ,
                    Text = $"{supplement.Supplement.Name}"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(supplementContainer.Location.X + 55, supplementContainer.Location.Y + 15)

                };

                PictureBox supplementImage = new PictureBox
                {
                    Name = $"supplementImage{index}"
                    ,
                    Size = new Size(50, 50)
                    ,
                    SizeMode = PictureBoxSizeMode.StretchImage
                    ,
                    BackgroundImageLayout = ImageLayout.Stretch
                    ,
                    ImageLocation = supplement.Supplement.ImageLocation
                    ,
                    Location = new Point(supplementContainer.Location.X + 60, supplementContainer.Location.Y + 30)
                };

                Label supplementAmount = new Label
                {
                    Name = $"supplementAmout{index}"
                    ,
                    Text = $"{supplement.Amount} in cart"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(supplementContainer.Location.X + 55, supplementContainer.Location.Y + 85)
                };

                Button increaseQuantity = new Button
                {
                    Name = $"increaseQuantity{index}"
                    ,
                    BackColor = Color.LightGreen
                    ,
                    Text = "+"
                    ,
                    Size = new Size(30, 30)
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(supplementContainer.Location.X + 50, supplementContainer.Location.Y + 115)
                };

                Button decreaseQuantity = new Button
                {
                    Name = $"decreaseQuantity{index}"
                    ,
                    BackColor = Color.DarkRed
                    ,
                    Text = "-"
                    ,
                    Size = new Size(30, 30)
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(supplementContainer.Location.X + 90, supplementContainer.Location.Y + 115)

                };
                Button removeItem = new Button
                {
                    Name = $"removeItem{index}"
                    ,
                    BackColor = Color.OrangeRed
                    ,
                    Text = "x"
                    ,
                    Size = new Size(25, 25)

                };

                Label supplementTotalPrice = new Label
                {
                    Name = $"supplementTotalPrice{index}"
                    ,
                    Text = $"{supplement.Supplement.Price * supplement.Amount:f2}lv"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(supplementContainer.Location.X + 50, supplementContainer.Location.Y + 145)

                };

                increaseQuantity.Click += async (s, e) =>
                {
                    supplement.Amount++;
                    await _context.SaveChangesAsync();
                    supplementTotalPrice.Text = $"{supplement.Supplement.Price * supplement.Amount:f2}lv";
                    supplementAmount.Text = $"{supplement.Amount} in cart";
                };

                decreaseQuantity.Click += async (s, e) =>
                {
                    supplement.Amount--;
                    await _context.SaveChangesAsync();
                    supplementTotalPrice.Text = $"{supplement.Supplement.Price * supplement.Amount:f2}lv";
                    supplementAmount.Text = $"{supplement.Amount} in cart";
                };
                removeItem.Click += async (s, e) =>
                {
                    _context.UsersSupplements.Remove(supplement);
                    await _context.SaveChangesAsync();
                    supplementsInfo.Controls.Remove(supplementContainer);
                };

                supplementContainer.Controls.Add(supplementName);
                supplementContainer.Controls.Add(supplementImage);
                supplementContainer.Controls.Add(supplementAmount);
                supplementContainer.Controls.Add(increaseQuantity);
                supplementContainer.Controls.Add(decreaseQuantity);
                supplementContainer.Controls.Add(removeItem);
                supplementContainer.Controls.Add(supplementTotalPrice);

                supplementsInfo.Controls.Add(supplementContainer);


                index++;
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (!_context.UsersSupplements.Any(u => u.UserId == activeUser.Id))
            {
                MessageBox.Show("Empty cart cannot be processed!", "Empty cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Checkout checkoutForm = new Checkout(activeUser);
                Program.SwitchMainForm(checkoutForm);
            }
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index();
            Program.SwitchMainForm(indexForm);
        }
    }
}
