using Fitness.Common.Messages;
using Fitness.Forms.Supplements;
using Fitness.Forms.Supplements.Create;
using Fitness.Forms.Supplements.Details;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Properties;
using Fitness.Utilities;
using Microsoft.EntityFrameworkCore;


namespace Fitness
{
    public partial class Supplements : Form
    {
        private StreamReader reader;
        private ApplicationDbContext _context;
        private User activeUser;
        private bool isAuthorized;
        public Supplements()
        {
            InitializeComponent();

            _context = new ApplicationDbContext();
            reader = new StreamReader(@"..\..\..\..\Fitness\SessionToken.txt");

            activeUser = _context.Users
            .FirstOrDefault(u => u.Id == int.Parse(reader.ReadLine()));

            isAuthorized = AuthorizationHelper.IsUserAuthorized(activeUser);
        }

        private async void Supplements_Load(object sender, EventArgs e)
        {

            addSupplement.Font = FontsPicker.UnauthorisedBaseFont;
            if (AuthorizationHelper.IsUserAuthorized(activeUser))
            {
                addSupplement.Font = FontsPicker.BaseFont;
            }

            var supplements = await _context.Supplements.ToListAsync();

            int containerIndex = 1;
            foreach (var supplement in supplements)
            {
                Panel container = new Panel()
                {
                    Name = $"container{containerIndex}"
                };

                Label name = new Label()
                {
                    Name = $"nameLabel{containerIndex}"
                    ,
                    Text = supplement.Name
                    ,
                    Font = FontsPicker.BaseFont

                };

                Label price = new Label()
                {
                    Name = $"priceLabel{containerIndex}"
                    ,
                    Text = $"{supplement.Price}lv"
                    ,
                    Font = FontsPicker.DetailsFont
                };

                Label quantity = new Label()
                {
                    Name = $"quantityLabel{containerIndex}"
                    ,
                    Text = $"{supplement.Quantity} left"
                    ,
                    Font = FontsPicker.DetailsFont
                };

                Label description = new Label()
                {
                    Name = $"descriptionLabel{containerIndex}"
                    ,
                    Text = supplement.Description
                    ,
                    Font = FontsPicker.DetailsFont
                };

                PictureBox image = new PictureBox()
                {
                    Name = $"pictureBox{containerIndex}"
                    ,
                    ImageLocation = supplement.ImageLocation
                };

                Button readMore = new Button()
                {
                    Name = $"readMore{containerIndex}"
                    ,
                    BackColor = Color.LightPink
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Text = "Read more"
                };
                readMore.Click += (s, e) =>
                {
                    ReadMore readMoreForm = new ReadMore(supplement, activeUser);
                    Program.SwitchMainForm(readMoreForm);
                };

                Button addCart = new Button()
                {
                    Name = $"addCart{containerIndex}"
                    ,
                    BackColor = Color.LightGreen
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Text = "Add to cart"
                };
                addCart.Click += async (s, e) =>
                {
                    if (_context.UsersSupplements
                    .Any(u => u.User == activeUser && u.Supplement == supplement))
                    {
                        UserSupplement desiredUser = await _context.UsersSupplements
                        .FirstOrDefaultAsync(u => u.User == activeUser && u.Supplement == supplement);
                        desiredUser.Amount++;

                    }
                    else
                    {
                        activeUser?.UsersSupplements.Add(new UserSupplement
                        {
                            User = activeUser,
                            Supplement = supplement
                            ,
                            Amount = 1
                        });
                    }

                    await _context.SaveChangesAsync();
                };

                Button edit = new Button()
                {
                    Name = $"edit{containerIndex}"
                    ,
                    BackColor = Color.LightGray
                    ,
                    Font = FontsPicker.UnauthorisedDetailsFont
                    ,
                    Text = "Edit"
                };
                edit.Click += (s, e) =>
                {
                    //!! AUTHORIZATION
                    if (!isAuthorized)
                    {
                        MessageBox.Show(UserMessages.UnauthorizedAccess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    EditSupplement editForm = new EditSupplement(supplement);
                    Program.SwitchMainForm(editForm);
                };

                Button delete = new Button()
                {
                    Name = $"delete{containerIndex}"
                    ,
                    BackColor = Color.Red
                    ,
                    Font = FontsPicker.UnauthorisedDetailsFont
                    ,
                    Text = "Delete"
                };
                delete.Click += async (s, e) =>
                {
                    //!! AUTHORIZATION
                    if (!isAuthorized)
                    {
                        MessageBox.Show(UserMessages.UnauthorizedAccess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _context.Supplements.Remove(supplement);
                    await _context.SaveChangesAsync();

                    MessageBox.Show(String.Format(SupplementsMessages.LogRemovedSupplement, supplement.Name));
                    mainContainer.Controls.Remove(container);

                };

                if (isAuthorized)
                {
                    edit.Font = FontsPicker.DetailsFont;
                    delete.Font = FontsPicker.DetailsFont;
                }

                image.Size = new Size(151, 151);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Location = new Point(container.Location.X + 37, container.Location.Y);

                readMore.Size = new Size(112, 29);
                readMore.Location = new Point(container.Location.X, container.Location.Y + 215);

                addCart.Size = readMore.Size;
                addCart.Location = new Point(container.Location.X + 112, container.Location.Y + 215);

                edit.Size = new Size(112, 29);
                edit.Location = new Point(container.Location.X, container.Location.Y + 244);

                delete.Size = new Size(112, 29);
                delete.Location = new Point(container.Location.X + 112, container.Location.Y + 244);

                name.Location = new Point(container.Location.X + 78, container.Location.Y + 166);

                price.Location = new Point(container.Location.X + 30, container.Location.Y + 190);

                quantity.Location = new Point(container.Location.X + 130, container.Location.Y + 190);

                container.Size = new Size(225, 272);
                container.BackColor = Color.NavajoWhite;


                container.Controls.Add(image);
                container.Controls.Add(name);
                container.Controls.Add(price);
                container.Controls.Add(quantity);
                container.Controls.Add(readMore);
                container.Controls.Add(addCart);
                container.Controls.Add(edit);
                container.Controls.Add(delete);
                mainContainer.Controls.Add(container);

                containerIndex++;

            }
        }

        private void addSupplement_Click(object sender, EventArgs e)
        {
            //!!AUTHORIZATION
            if (!activeUser.IsAuthorized)
            {
                MessageBox.Show(UserMessages.UnauthorizedAccess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CreateSupplement csForm = new CreateSupplement();
            Program.SwitchMainForm(csForm);
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index();
            Program.SwitchMainForm(indexForm);
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart(activeUser);
            Program.SwitchMainForm(cartForm);
        }
    }
}
