using Fitness.Common.Messages;
using Fitness.Models.Enumerations;
using Fitness.Properties;
using Fitness.Utilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using Fitness.Models.DbConfiguration;

namespace Fitness
{
    public partial class Comments : Form
    {
        private ApplicationDbContext _context;

        private int index = 1;
        public Comments()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void Comments_Load(object sender, EventArgs e)
        {

            commentsContainer.Padding = new Padding(5, 30, 5, 5);
            commentsContainer.AutoScroll = true;
            //Create write a comment section

            Panel writeCommentContainer = InitializeCommentContainer();
            RoundPictureBox userWriteCommentPfp = InitializeProfilePicture();
            Label writeCommentUsername = InitializeCommentUsername();
            TextBox writeCommentTextArea = InitializeTextArea();

            foreach (var comment in _context.Comments.Include(c => c.User))
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
                    Cursor = Cursors.Default
                    ,
                    Location = new Point(commentContainer.Location.X + 560, commentContainer.Location.Y + 10)
                    ,
                    SelectedItem = comment.MessageStatus.ToString()
                    ,
                    Enabled = true
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
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(commentContainer.Location.X + 560, commentContainer.Location.Y + 40)
                    ,
                    Size = new Size(65, 40)
                };
                editComment.Click += (s, e) =>
                {
                    commentTextArea.Enabled = true;
                    commentTextArea.Cursor = Cursors.Default;
                    ActiveControl = commentTextArea;

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
                    Font = FontsPicker.DetailsFont
                    ,
                    Location = new Point(commentContainer.Location.X + 630, commentContainer.Location.Y + 40)
                    ,
                    Size = new Size(65, 40)
                };
                deleteComment.Click += async (s, e) =>
                {
                    _context.Comments.Remove(comment);
                    await _context.SaveChangesAsync();
                    MessageBox.Show(String.Format(SupplementsMessages.SupplementCommentRemoved, comment.User.Username ), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    commentsContainer.Controls.Remove(commentContainer);
                };

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

        }
        private Panel InitializeCommentContainer()
        {
            Panel commentContainer = new Panel
            {
                Size = new Size(710, 150)
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

            };
        }
        private Label InitializeCommentUsername()
        {
            Label writeCommentNameLabel;
            return writeCommentNameLabel = new Label
            {
                Name = $"commentUsername{index}"
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
            Index indexForm = new Index();
            Program.SwitchMainForm(indexForm);
        }
    }
}

