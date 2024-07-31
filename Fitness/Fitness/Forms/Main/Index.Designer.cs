namespace Fitness
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            Supplements = new ToolStripMenuItem();
            Workouts = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Comments = new ToolStripMenuItem();
            Profile = new ToolStripMenuItem();
            Orders = new ToolStripMenuItem();
            roundPictureBox1 = new Utilities.RoundPictureBox();
            pictureBox1 = new PictureBox();
            workoutsButton = new Button();
            supplementsButton = new Button();
            pictureBox2 = new PictureBox();
            welcomeLabel = new Label();
            footer = new Button();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImage = Properties.Resources.gradient_img__3_;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menu.Items.AddRange(new ToolStripItem[] { Supplements, Workouts, Users, Comments, Profile, Orders });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 1, 0, 5);
            menu.Size = new Size(799, 33);
            menu.TabIndex = 0;
            menu.Text = "Menu";
            // 
            // Supplements
            // 
            Supplements.ForeColor = SystemColors.ActiveCaptionText;
            Supplements.Name = "Supplements";
            Supplements.Padding = new Padding(4, 0, 4, 5);
            Supplements.Size = new Size(144, 27);
            Supplements.Text = "Suppplements";
            Supplements.Click += menu_ItemClicked;
            // 
            // Workouts
            // 
            Workouts.ForeColor = SystemColors.ActiveCaptionText;
            Workouts.Name = "Workouts";
            Workouts.Padding = new Padding(4, 0, 4, 5);
            Workouts.Size = new Size(105, 27);
            Workouts.Text = "Workouts";
            Workouts.Click += menu_ItemClicked;
            // 
            // Users
            // 
            Users.BackgroundImageLayout = ImageLayout.Center;
            Users.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point);
            Users.ForeColor = SystemColors.ActiveCaptionText;
            Users.Name = "Users";
            Users.Padding = new Padding(4, 0, 4, 5);
            Users.Size = new Size(148, 27);
            Users.Text = "Users Registry";
            Users.Click += menu_ItemClicked;
            // 
            // Comments
            // 
            Comments.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point);
            Comments.ForeColor = SystemColors.MenuText;
            Comments.Name = "Comments";
            Comments.Padding = new Padding(4, 0, 4, 5);
            Comments.Size = new Size(191, 27);
            Comments.Text = "Comments Registry";
            Comments.Click += menu_ItemClicked;
            // 
            // Profile
            // 
            Profile.ForeColor = SystemColors.ActiveCaptionText;
            Profile.Name = "Profile";
            Profile.Padding = new Padding(4, 0, 4, 5);
            Profile.Size = new Size(106, 27);
            Profile.Text = "My profile";
            Profile.Click += menu_ItemClicked;
            // 
            // Orders
            // 
            Orders.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Orders.ForeColor = SystemColors.ActiveCaptionText;
            Orders.Name = "Orders";
            Orders.Padding = new Padding(4, 0, 4, 5);
            Orders.Size = new Size(81, 27);
            Orders.Text = "Orders";
            Orders.Click += menu_ItemClicked;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackColor = Color.Transparent;
            roundPictureBox1.Location = new Point(463, 303);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(42, 39);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 1;
            roundPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supplementsbg;
            pictureBox1.Location = new Point(408, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // workoutsButton
            // 
            workoutsButton.BackColor = SystemColors.ButtonFace;
            workoutsButton.BackgroundImageLayout = ImageLayout.Stretch;
            workoutsButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            workoutsButton.Location = new Point(90, 302);
            workoutsButton.Name = "workoutsButton";
            workoutsButton.Size = new Size(185, 50);
            workoutsButton.TabIndex = 7;
            workoutsButton.Text = "Check out our latest workouts collection ";
            workoutsButton.UseVisualStyleBackColor = false;
            workoutsButton.Click += workoutsButton_Click;
            workoutsButton.MouseLeave += buttons_Leave;
            workoutsButton.MouseHover += buttons_Hover;
            // 
            // supplementsButton
            // 
            supplementsButton.BackColor = SystemColors.ButtonFace;
            supplementsButton.BackgroundImageLayout = ImageLayout.Stretch;
            supplementsButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            supplementsButton.Location = new Point(536, 303);
            supplementsButton.Name = "supplementsButton";
            supplementsButton.Size = new Size(203, 50);
            supplementsButton.TabIndex = 8;
            supplementsButton.Text = "Check out our latest supplements collection ";
            supplementsButton.UseVisualStyleBackColor = false;
            supplementsButton.Click += supplementsButton_Click;
            supplementsButton.MouseLeave += buttons_Leave;
            supplementsButton.MouseHover += buttons_Hover;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.workoutbg;
            pictureBox2.Location = new Point(0, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(402, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(293, 303);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(164, 56);
            welcomeLabel.TabIndex = 9;
            welcomeLabel.Text = "label1";
            // 
            // footer
            // 
            footer.BackColor = Color.Transparent;
            footer.BackgroundImage = Properties.Resources.gradient_img__3_;
            footer.BackgroundImageLayout = ImageLayout.Stretch;
            footer.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            footer.Location = new Point(0, 362);
            footer.Name = "footer";
            footer.Size = new Size(815, 39);
            footer.TabIndex = 10;
            footer.Text = "Ⓒ Dimitar 2024";
            footer.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.gradient_img__4_;
            ClientSize = new Size(799, 390);
            Controls.Add(footer);
            Controls.Add(welcomeLabel);
            Controls.Add(supplementsButton);
            Controls.Add(workoutsButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            DoubleBuffered = true;
            Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Index";
            Text = "Index";
            Load += Index_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem Supplements;
        private ToolStripMenuItem Workouts;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem Comments;
        private ToolStripMenuItem Profile;
        private ToolStripMenuItem Orders;
        private Utilities.RoundPictureBox roundPictureBox1;
        private PictureBox pictureBox1;
        private Button workoutsButton;
        private Button supplementsButton;
        private PictureBox pictureBox2;
        private Label welcomeLabel;
        private Button footer;
    }
}