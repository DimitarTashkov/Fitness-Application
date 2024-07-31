namespace Fitness
{
    partial class Users
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
            usersContainer = new FlowLayoutPanel();
            usersHeaders = new FlowLayoutPanel();
            usernameHeader = new Label();
            passwordHeader = new Label();
            emailHeader = new Label();
            ageHeader = new Label();
            avatarHeader = new Label();
            label1 = new Label();
            dateHeader = new Label();
            arriveHeader = new Label();
            usersLabel = new Label();
            navigationButton = new Button();
            usersContainer.SuspendLayout();
            usersHeaders.SuspendLayout();
            SuspendLayout();
            // 
            // usersContainer
            // 
            usersContainer.AutoScroll = true;
            usersContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            usersContainer.Controls.Add(usersHeaders);
            usersContainer.Location = new Point(29, 43);
            usersContainer.Name = "usersContainer";
            usersContainer.Size = new Size(760, 400);
            usersContainer.TabIndex = 6;
            // 
            // usersHeaders
            // 
            usersHeaders.BackColor = Color.Cyan;
            usersHeaders.Controls.Add(usernameHeader);
            usersHeaders.Controls.Add(passwordHeader);
            usersHeaders.Controls.Add(emailHeader);
            usersHeaders.Controls.Add(ageHeader);
            usersHeaders.Controls.Add(avatarHeader);
            usersHeaders.Controls.Add(label1);
            usersHeaders.Controls.Add(dateHeader);
            usersHeaders.Controls.Add(arriveHeader);
            usersHeaders.Location = new Point(15, 8);
            usersHeaders.Margin = new Padding(15, 8, 8, 8);
            usersHeaders.Name = "usersHeaders";
            usersHeaders.Padding = new Padding(10);
            usersHeaders.Size = new Size(725, 32);
            usersHeaders.TabIndex = 0;
            // 
            // usernameHeader
            // 
            usernameHeader.AutoSize = true;
            usernameHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usernameHeader.Location = new Point(40, 10);
            usernameHeader.Margin = new Padding(30, 0, 40, 0);
            usernameHeader.Name = "usernameHeader";
            usernameHeader.Size = new Size(81, 16);
            usernameHeader.TabIndex = 0;
            usernameHeader.Text = "Username";
            // 
            // passwordHeader
            // 
            passwordHeader.AutoSize = true;
            passwordHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            passwordHeader.Location = new Point(161, 10);
            passwordHeader.Margin = new Padding(0, 0, 40, 0);
            passwordHeader.Name = "passwordHeader";
            passwordHeader.Size = new Size(77, 16);
            passwordHeader.TabIndex = 1;
            passwordHeader.Text = "Password";
            // 
            // emailHeader
            // 
            emailHeader.AutoSize = true;
            emailHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            emailHeader.Location = new Point(278, 10);
            emailHeader.Margin = new Padding(0, 0, 50, 0);
            emailHeader.Name = "emailHeader";
            emailHeader.Size = new Size(47, 16);
            emailHeader.TabIndex = 2;
            emailHeader.Text = "Email";
            // 
            // ageHeader
            // 
            ageHeader.AutoSize = true;
            ageHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ageHeader.Location = new Point(375, 10);
            ageHeader.Margin = new Padding(0, 0, 50, 0);
            ageHeader.Name = "ageHeader";
            ageHeader.Size = new Size(34, 16);
            ageHeader.TabIndex = 3;
            ageHeader.Text = "Age";
            // 
            // avatarHeader
            // 
            avatarHeader.AutoSize = true;
            avatarHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            avatarHeader.Location = new Point(459, 10);
            avatarHeader.Margin = new Padding(0, 0, 50, 0);
            avatarHeader.Name = "avatarHeader";
            avatarHeader.Size = new Size(55, 16);
            avatarHeader.TabIndex = 4;
            avatarHeader.Text = "Avatar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(564, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 7;
            label1.Text = "Authorized";
            // 
            // dateHeader
            // 
            dateHeader.AutoSize = true;
            dateHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dateHeader.Location = new Point(684, 10);
            dateHeader.Margin = new Padding(35, 0, 3, 0);
            dateHeader.Name = "dateHeader";
            dateHeader.Size = new Size(0, 16);
            dateHeader.TabIndex = 5;
            // 
            // arriveHeader
            // 
            arriveHeader.AutoSize = true;
            arriveHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            arriveHeader.Location = new Point(45, 26);
            arriveHeader.Margin = new Padding(35, 0, 3, 0);
            arriveHeader.Name = "arriveHeader";
            arriveHeader.Size = new Size(0, 16);
            arriveHeader.TabIndex = 6;
            // 
            // usersLabel
            // 
            usersLabel.AutoSize = true;
            usersLabel.BackColor = Color.Transparent;
            usersLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usersLabel.ForeColor = Color.White;
            usersLabel.Location = new Point(363, 7);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(77, 25);
            usersLabel.TabIndex = 5;
            usersLabel.Text = "Users";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(11, 8);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 7;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(usersContainer);
            Controls.Add(usersLabel);
            Controls.Add(navigationButton);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            usersContainer.ResumeLayout(false);
            usersHeaders.ResumeLayout(false);
            usersHeaders.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel usersContainer;
        private FlowLayoutPanel usersHeaders;
        private Label usernameHeader;
        private Label passwordHeader;
        private Label emailHeader;
        private Label ageHeader;
        private Label avatarHeader;
        private Label dateHeader;
        private Label arriveHeader;
        private Label usersLabel;
        private Button navigationButton;
        private Label label1;
    }
}