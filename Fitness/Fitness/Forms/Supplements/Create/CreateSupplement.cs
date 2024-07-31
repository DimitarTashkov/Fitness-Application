using Fitness.Common.Messages;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Properties;
using Fitness.Utilities;
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

namespace Fitness.Forms.Supplements
{
    public partial class CreateSupplement : Form
    {
        private ApplicationDbContext _context;
        public CreateSupplement()
        {
            InitializeComponent();
            ActiveControl = nameLabel;
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

            _context = new ApplicationDbContext();
        }

        private void CreateSupplement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nackground;

            nameField.Text = "\"protein\"";
            priceField.Text = "60";
            quantityField.Text = "3";
            descriptionField.Text = "\"Whey protein, 30g per spoon, cookie taste....\"";

            quantityField.ForeColor = Color.DimGray;
            descriptionField.ForeColor = Color.DimGray;
            nameField.ForeColor = Color.DimGray;
            priceField.ForeColor = Color.DimGray;

            quantityField.Font = FontsPicker.DetailsFont;
            descriptionField.Font = FontsPicker.DetailsFont;
            nameField.Font = FontsPicker.DetailsFont;
            priceField.Font = FontsPicker.DetailsFont;
            supplementsLabel.Font = FontsPicker.HeadersFont;


        }

        private async void addButton_Click(object sender, EventArgs e)
        {

            List<TextBox> inputs = new List<TextBox>
            {
                nameField,
                priceField,
                quantityField
            };
            bool isValid = ValidationHelper.ValidateUserInputs(inputs, supplementPicture);
            bool isNumericsValid = ValidationHelper.ValidateNumerics
                (new List<TextBox>() { priceField, quantityField });

            if (isValid && isNumericsValid)
            {
                string name = nameField.Text;
                decimal price = decimal.Parse(priceField.Text);
                int quantity = int.Parse(quantityField.Text);
                string? description = descriptionField.Text;
                string imageUrl = supplementPicture.ImageLocation;
                if (!_context.Supplements.Any(s => s.Name == name))
                {

                    Supplement supplement = new Supplement
                    {
                        Name = name
                       ,
                        Price = price
                       ,
                        Quantity = quantity
                       ,
                        Description = description
                       ,
                        ImageLocation = imageUrl
                    };

                    Logger log = new Logger()
                    {
                        Message = String.Format(SupplementsMessages.LogSupplementAdded, name)
                        ,
                        ReportedOn = DateTime.Now
                    };

                    await _context.Logs.AddAsync(log);
                    await _context.Supplements.AddAsync(supplement);
                    await _context.SaveChangesAsync();

                    MessageBox.Show(SupplementsMessages.SuccessfulAdd, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Fitness.Supplements supplementsForm = new Fitness.Supplements();
                    Program.SwitchMainForm(supplementsForm);
                }
                MessageBox.Show(SupplementsMessages.SupplementExists, "Supplement exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(UserMessages.InvalidInput, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                supplementPicture.ImageLocation = imageLocation;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void add_hover(object sender, EventArgs e)
        {
            uploadSupplement.BackColor = Color.Green;
        }

        private void add_leave(object sender, EventArgs e)
        {
            uploadSupplement.BackColor = Color.LightGreen;

        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Fitness.Supplements supplementsForm = new Fitness.Supplements();
            Program.SwitchMainForm(supplementsForm);
        }


    }
}
