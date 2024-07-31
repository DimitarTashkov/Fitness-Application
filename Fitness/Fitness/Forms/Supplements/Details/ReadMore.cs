using Fitness.Common.Messages;
using Fitness.Forms.Supplements.Create;
using Fitness.Models;
using Fitness.Models.DbConfiguration;
using Fitness.Models.Enumerations;
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

namespace Fitness.Forms.Supplements.Details
{
    public partial class ReadMore : Form
    {
        private Supplement activeSupplement;
        private User activeUser;
        private ApplicationDbContext _context;
        private bool isAuthorized;


        private int index = 1;
        public ReadMore(Supplement supplement, User user)
        {
            InitializeComponent();
            this.BackgroundImage = Resources.nackground;
            _context = new ApplicationDbContext();
            activeSupplement = _context.Supplements.FirstOrDefault(s => s.Id == supplement.Id);
            activeUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);

            isAuthorized = AuthorizationHelper.IsUserAuthorized(activeUser);

        }

        private void ReadMore_Load(object sender, EventArgs e)
        {
            editSupplementBtn.Font = FontsPicker.UnauthorisedDetailsFont;

            if(isAuthorized)
            {
                editSupplementBtn.Font = FontsPicker.DetailsFont;
            }

            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = FontsPicker.BaseFont;

            supplementImage.ImageLocation = activeSupplement.ImageLocation;
            supplementName.Text = supplementName.Text + " " + activeSupplement.Name;
            supplementPrice.Text = supplementPrice.Text + " " + activeSupplement.Price.ToString();
            supplementQuantity.Text = supplementQuantity.Text + " " + activeSupplement.Quantity.ToString();
            supplementDescription.Text = supplementDescription.Text + " " + activeSupplement.Description;

            FlowLayoutPanel commentsContainer = new FlowLayoutPanel();
            commentsContainer.Padding = new Padding(5, 30, 5, 5);
            commentsContainer.AutoScroll = true;
            commentsContainer.Size = new Size(740, 400);
            //Create write a comment section

            Panel writeCommentContainer = InitializeCommentContainer();
            RoundPictureBox userWriteCommentPfp = InitializeProfilePicture();
            Label writeCommentUsername = InitializeCommentUsername();
            TextBox writeCommentTextArea = InitializeTextArea();

            userWriteCommentPfp.Location = new Point(writeCommentContainer.Location.X + 10, writeCommentContainer.Location.Y + 20);
            writeCommentUsername.Location = new Point(writeCommentContainer.Location.X + 85, writeCommentContainer.Location.Y + 10);
            writeCommentTextArea.Location = new Point(writeCommentContainer.Location.X + 80, writeCommentContainer.Location.Y + 35);
            writeCommentTextArea.Click += (s, e) =>
            {
                writeCommentTextArea.Text = "";
                writeCommentTextArea.ForeColor = Color.Black;
            };

            writeCommentContainer.Controls.Add(userWriteCommentPfp);
            writeCommentContainer.Controls.Add(writeCommentUsername);
            writeCommentContainer.Controls.Add(writeCommentTextArea);

            Button sendComment = new Button
            {
                Name = "sendComment"
                ,
                Text = "Send"
                ,
                Font = FontsPicker.DetailsFont
                ,
                BackColor = Color.LightGreen
                ,
                Size = new Size(80, 40)
                ,
                Location = new Point(writeCommentContainer.Location.X + 560, writeCommentContainer.Location.Y + 40)
            };
            writeCommentContainer.Controls.Add(sendComment);
            commentsContainer.Controls.Add(writeCommentContainer);

            sendComment.Click += async (s, e) =>
            {
                Comment comment = new Comment
                {
                    Message = writeCommentTextArea.Text
                    ,
                    PublishedOn = DateTime.Now
                    ,
                    MessageStatus = FeedbackStatus.Unverified
                    ,
                    User = activeUser
                    ,
                    UserId = activeUser.Id
                    ,
                    CommentCategory = CommentType.Supplement
                    ,
                    CategoryId = activeSupplement.Id
                };
                await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();
                MessageBox.Show(SupplementsMessages.SupplementCommentAdded, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReadMore reloadForm = new ReadMore(activeSupplement, activeUser);
                Program.SwitchMainForm(reloadForm);
            };

            //Load all comments for the specific supplement
            foreach (var comment in _context.Comments.Include(c => c.User).Where(c => c.CategoryId == activeSupplement.Id))
            {
                index++;

                Panel commentContainer = InitializeCommentContainer();

                RoundPictureBox userPfp = InitializeProfilePicture();
                userPfp.ImageLocation = comment.User.AvatarUrl;

                Label commentUsername = InitializeCommentUsername();
                commentUsername.Text = comment.User.Username;
                TextBox commentTextArea = InitializeTextArea();
                commentTextArea.Text = comment.Message;
                Label date = new Label
                {
                    Name = $"date{index}"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Text = $"On: {comment.PublishedOn.Year}/{comment.PublishedOn.Month:d2}/{comment.PublishedOn.Day:d2}  At:{comment.PublishedOn.Hour:d2}:{comment.PublishedOn.Minute:d2}"
                    ,
                    Location = new Point(commentContainer.Location.X + 190, commentContainer.Location.Y + 10)
                    ,
                    BackColor = Color.Transparent
                    ,
                    AutoSize = true

                };
                Label commentState = new Label()
                {
                    Name = $"commentState{index}"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Text = $"{(FeedbackStatus)comment.MessageStatus}"
                    ,
                    Location = new Point(commentContainer.Location.X + 450, commentContainer.Location.Y + 10)
                    ,
                    BackColor = Color.Transparent
                };

                ComboBox commentStatus = new ComboBox
                {
                    Name = $"commentStatus{index}"
                    ,
                    Font = FontsPicker.DetailsFont
                    ,
                    Cursor = isAuthorized ? Cursors.Default : Cursors.No
                    ,
                    Location = new Point(commentContainer.Location.X + 560, commentContainer.Location.Y + 10)
                    ,
                    SelectedItem = comment.MessageStatus.ToString()
                    ,
                    Enabled = isAuthorized                
                };
                commentStatus.SelectedIndexChanged += async (s, e) =>
                {
                    comment.MessageStatus = (FeedbackStatus)commentStatus.SelectedIndex;
                    commentState.Text = $"{(FeedbackStatus)comment.MessageStatus}";
                    await _context.SaveChangesAsync();
                };


                commentStatus.Items.AddRange(new object[] { FeedbackStatus.Verified, FeedbackStatus.Unverified, FeedbackStatus.Falsery });

                userPfp.Location = new Point(commentContainer.Location.X + 10, commentContainer.Location.Y + 20);
                commentUsername.Location = new Point(commentContainer.Location.X + 85, commentContainer.Location.Y + 10);
                commentTextArea.Location = new Point(commentContainer.Location.X + 80, commentContainer.Location.Y + 35);

                commentTextArea.ForeColor = Color.Black;
                commentTextArea.Enabled = false;

                Button editComment = new Button
                {
                    Name = $"editBtn{index}"
                    ,
                    Text = "Edit"
                    ,
                    BackColor = Color.LightGray
                    ,
                    Font = FontsPicker.UnauthorisedDetailsFont
                    ,
                    Location = new Point(commentContainer.Location.X + 560, commentContainer.Location.Y + 40)
                    ,
                    Size = new Size(65, 40)
                };
                editComment.Click += (s, e) =>
                {
                    if (comment.UserId != activeUser.Id && !isAuthorized)
                    {
                        MessageBox.Show("Unathorized action", "Unathourzied action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        commentTextArea.Enabled = true;
                        commentTextArea.Cursor = Cursors.Default;
                        ActiveControl = commentTextArea;
                    }
                };
                commentTextArea.MouseUp += async (s, e) =>
                {
                    commentTextArea.Enabled = false;
                    commentTextArea.Cursor = Cursors.No;
                    ActiveControl = commentUsername;
                    comment.PublishedOn = DateTime.Now;
                    comment.Message = commentTextArea.Text;
                    date.Text = $"On: {comment.PublishedOn.Year}:{comment.PublishedOn.Month}:{comment.PublishedOn.Day}  At:{comment.PublishedOn.Hour:d2}:{comment.PublishedOn.Minute:d2}";
                    await _context.SaveChangesAsync();
                };

                Button deleteComment = new Button
                {
                    Name = $"deleteBtn{index}"
                    ,
                    Text = "Delete"
                    ,
                    BackColor = Color.Red
                    ,
                    Font = FontsPicker.UnauthorisedDetailsFont
                    ,
                    Location = new Point(commentContainer.Location.X + 630, commentContainer.Location.Y + 40)
                    ,
                    Size = new Size(65, 40)
                };
                deleteComment.Click += async (s, e) =>
                {
                    //!! AUTHORIZATION
                    if (comment.UserId != activeUser.Id && !isAuthorized)
                    {
                        MessageBox.Show("Unathorized action", "Unathourzied action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        _context.Comments.Remove(comment);
                        await _context.SaveChangesAsync();
                        MessageBox.Show(String.Format(SupplementsMessages.SupplementCommentRemoved, activeUser.Username), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        commentsContainer.Controls.Remove(commentContainer);
                    }
                };

                if(isAuthorized || comment.UserId == activeUser.Id)
                {
                    editComment.Font = FontsPicker.DetailsFont;
                    deleteComment.Font = FontsPicker.DetailsFont;
                }


                commentContainer.Controls.Add(userPfp);
                commentContainer.Controls.Add(commentUsername);
                commentContainer.Controls.Add(date);
                commentContainer.Controls.Add(commentState); 
                commentContainer.Controls.Add(commentStatus);
                commentContainer.Controls.Add(commentTextArea);
                commentContainer.Controls.Add(editComment);
                commentContainer.Controls.Add(deleteComment);

                commentsContainer.Controls.Add(commentContainer);
            }
            mainContainer.Controls.Add(commentsContainer);


        }

        private async void addToCartBtn_Click(object sender, EventArgs e)
        {
            //Optional: Messagebox for quantity added
            if (_context.UsersSupplements
                    .Any(u => u.User == activeUser && u.Supplement == activeSupplement))
            {
                UserSupplement desiredUser = await _context.UsersSupplements
                .FirstOrDefaultAsync(u => u.User == activeUser && u.Supplement == activeSupplement);
                desiredUser.Amount++;
            }
            else
            {
                activeUser?.UsersSupplements.Add(new UserSupplement
                {
                    User = activeUser,
                    Supplement = activeSupplement
                ,
                    Amount = 1
                });
            }
            await _context.SaveChangesAsync();
        }

        private void editSupplementBtn_Click(object sender, EventArgs e)
        {
            if(!isAuthorized)
            {
                MessageBox.Show(UserMessages.UnauthorizedAccess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditSupplement editForm = new EditSupplement(activeSupplement);
            Program.SwitchMainForm(editForm);
        }
        private Panel InitializeCommentContainer()
        {
            Panel commentContainer = new Panel
            {
                Size = new Size(710, 110)
                ,
                Name = $"commentContainer{index}"
                ,
                BackgroundImage = Resources.gradient_img__4_
                ,
                AutoSize = false
            };

            return commentContainer;
        }
        private RoundPictureBox InitializeProfilePicture()
        {
            RoundPictureBox userImage;
            return userImage = new RoundPictureBox
            {
                Name = $"userPfp{index}"
                ,
                Size = new Size(60, 60)
                ,
                SizeMode = PictureBoxSizeMode.StretchImage
                ,
                ImageLocation = activeUser.AvatarUrl
            };
        }
        private Label InitializeCommentUsername()
        {
            Label writeCommentNameLabel;
            return writeCommentNameLabel = new Label
            {
                Name = $"commentUsername{index}"
                ,
                Text = activeUser.Username
                ,
                Font = FontsPicker.DetailsFont
                ,
                BackColor = Color.Transparent

            };
        }
        private TextBox InitializeTextArea()
        {
            TextBox writeCommentArea;
            return writeCommentArea = new TextBox
            {
                Name = $"commentTextArea{index}"
                ,
                Text = "Write your comment here..."
                ,
                Font = FontsPicker.DetailsFont
                ,
                MinimumSize = new Size(475, 44)
                ,
                ForeColor = Color.DimGray

            };

        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Fitness.Supplements supplementsForm = new Fitness.Supplements();
            Program.SwitchMainForm(supplementsForm);
        }
    }
}
