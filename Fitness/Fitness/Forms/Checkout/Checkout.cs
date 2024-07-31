using Fitness.Common.Messages;
using Fitness.Forms.Personalization;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Models.Enumerations;
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

namespace Fitness.Forms.Transaction
{
    public partial class Checkout : Form
    {
        private User activeUser;
        private ApplicationDbContext _context;

        public Checkout(User user)
        {
            InitializeComponent();
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);
            ActiveControl = addressLabel;
            _context = new ApplicationDbContext();
            activeUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
        }

        private async void orderBtn_Click(object sender, EventArgs e)
        {
            if (addressField.Text != "" && addressField.TextLength > 1)
            {
                string address = addressField.Text;
                decimal totalPayment = _context.UsersSupplements
                    .Include(s => s.Supplement)
                    .AsNoTracking()
                    .Where(u => u.User == activeUser)
                    .Sum(p => p.Amount * p.Supplement.Price);
                PaymentType paymentType = (PaymentType)paymentBox.SelectedIndex;

                Order order = new Order
                {
                    Address = address
                    ,
                    Payment = paymentType
                    ,
                    User = activeUser
                    ,
                    UserId = activeUser.Id
                    ,
                    PurchasedOn = DateTime.Now
                    ,
                    ArrivesOn = DateTime.Now.Date.AddDays(7)
                    ,
                    TotalPrice = totalPayment
                    ,
                    ItemsBought = _context.UsersSupplements.Where(u => u.User == activeUser).Sum(u => u.Amount)
                };
                _context.Orders.Add(order);
                _context.RemoveRange(_context.UsersSupplements.Where(u => u.User == activeUser));
                await _context.SaveChangesAsync();

                Orders ordersForm = new Orders(activeUser);
                Program.SwitchMainForm(ordersForm);
            }
            else
            {
                MessageBox.Show(UserMessages.InvalidInput, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            addressField.ForeColor = Color.Black;
            paymentBox.ForeColor = Color.Black;
            addressField.Font = FontsPicker.BaseFont;
            paymentBox.Font = FontsPicker.BaseFont;
            paymentBox.Items.AddRange(new object[] { PaymentType.Stripe, PaymentType.Cash });
            paymentBox.SelectedIndex = 1;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart(activeUser);
            Program.SwitchMainForm(cartForm);
        }
    }
}
