using Fitness.Common.Messages;
using Fitness.Models.DbConfiguration;
using Fitness.Models;
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

namespace Fitness.Forms.Supplements.Create
{
    public partial class EditSupplement : Form
    {
        private ApplicationDbContext _context;
        private Supplement activeSupplement;
        public EditSupplement(Supplement supplement)
        {
            InitializeComponent();
            ActiveControl = nameLabel;
            formPanel.Paint += new PaintEventHandler(LayoutHelper.set_FormBackground);

            _context = new ApplicationDbContext();
            activeSupplement = _context.Supplements.FirstOrDefault(s => s.Id == supplement.Id);
        }

        private void EditSupplement_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nackground;

            nameField.Text = activeSupplement.Name;
            priceField.Text = activeSupplement.Price.ToString();
            quantityField.Text = activeSupplement.Quantity.ToString();
            descriptionField.Text = activeSupplement.Description;
            supplementPicture.ImageLocation = activeSupplement.ImageLocation;

            quantityField.ForeColor = Color.DimGray;
            descriptionField.ForeColor = Color.DimGray;
            nameField.ForeColor = Color.DimGray;
            priceField.ForeColor = Color.DimGray;

            quantityField.Font = FontsPicker.DetailsFont;
            descriptionField.Font = FontsPicker.DetailsFont;
            nameField.Font = FontsPicker.DetailsFont;
            priceField.Font = FontsPicker.DetailsFont;

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
                if (_context.Supplements.Any(s => s.Name == name))
                {

                    activeSupplement.Name = name;
                    activeSupplement.Price = price;
                    activeSupplement.Quantity = quantity;
                    activeSupplement.Description = description;
                    activeSupplement.ImageLocation = imageUrl;

                    Logger log = new Logger()
                    {
                        Message = String.Format(SupplementsMessages.LogSupplementUpdated, name)
                        ,
                        ReportedOn = DateTime.Now
                    };

                    await _context.Logs.AddAsync(log);
                    await _context.SaveChangesAsync();

                    MessageBox.Show(SupplementsMessages.SuccessfulUpdate, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Fitness.Supplements supplementsForm = new Fitness.Supplements();
                    Program.SwitchMainForm(supplementsForm);
                }
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
