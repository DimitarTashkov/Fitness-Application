namespace Fitness
{
    partial class Cart
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
            mainContainer = new FlowLayoutPanel();
            userSupplementsLbl = new Label();
            cartInfo = new FlowLayoutPanel();
            userInfo = new Panel();
            usernameLbl = new Label();
            userPfp = new Utilities.RoundPictureBox();
            supplementsInfo = new FlowLayoutPanel();
            checkoutBtn = new Button();
            logo = new PictureBox();
            navigationButton = new Button();
            mainContainer.SuspendLayout();
            cartInfo.SuspendLayout();
            userInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPfp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.BackColor = SystemColors.Control;
            mainContainer.BackgroundImage = Properties.Resources.gradient_img__3_;
            mainContainer.BackgroundImageLayout = ImageLayout.Stretch;
            mainContainer.Controls.Add(userSupplementsLbl);
            mainContainer.Controls.Add(cartInfo);
            mainContainer.Controls.Add(checkoutBtn);
            mainContainer.Controls.Add(logo);
            mainContainer.Location = new Point(12, 34);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(7, 0, 0, 0);
            mainContainer.Size = new Size(800, 391);
            mainContainer.TabIndex = 0;
            // 
            // userSupplementsLbl
            // 
            userSupplementsLbl.AutoSize = true;
            userSupplementsLbl.BackColor = Color.Transparent;
            userSupplementsLbl.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userSupplementsLbl.Location = new Point(297, 0);
            userSupplementsLbl.Margin = new Padding(290, 0, 3, 0);
            userSupplementsLbl.Name = "userSupplementsLbl";
            userSupplementsLbl.Size = new Size(206, 23);
            userSupplementsLbl.TabIndex = 3;
            userSupplementsLbl.Text = "User Supplements";
            // 
            // cartInfo
            // 
            cartInfo.BackgroundImage = Properties.Resources.gradient_img__2_;
            cartInfo.Controls.Add(userInfo);
            cartInfo.Controls.Add(supplementsInfo);
            cartInfo.Location = new Point(10, 33);
            cartInfo.Margin = new Padding(3, 10, 3, 3);
            cartInfo.Name = "cartInfo";
            cartInfo.Padding = new Padding(8, 0, 0, 0);
            cartInfo.Size = new Size(780, 180);
            cartInfo.TabIndex = 0;
            // 
            // userInfo
            // 
            userInfo.BackgroundImage = Properties.Resources.gradient_img__4_;
            userInfo.Controls.Add(usernameLbl);
            userInfo.Controls.Add(userPfp);
            userInfo.Location = new Point(11, 19);
            userInfo.Margin = new Padding(3, 19, 3, 3);
            userInfo.Name = "userInfo";
            userInfo.Size = new Size(140, 140);
            userInfo.TabIndex = 0;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.BackColor = Color.Transparent;
            usernameLbl.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usernameLbl.Location = new Point(31, 83);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(81, 16);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "Username";
            // 
            // userPfp
            // 
            userPfp.BackgroundImageLayout = ImageLayout.Stretch;
            userPfp.Location = new Point(46, 30);
            userPfp.Name = "userPfp";
            userPfp.Size = new Size(50, 50);
            userPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            userPfp.TabIndex = 0;
            userPfp.TabStop = false;
            // 
            // supplementsInfo
            // 
            supplementsInfo.AutoScroll = true;
            supplementsInfo.BackgroundImage = Properties.Resources.gradient_img__4_;
            supplementsInfo.Location = new Point(160, 3);
            supplementsInfo.Margin = new Padding(6, 3, 3, 3);
            supplementsInfo.Name = "supplementsInfo";
            supplementsInfo.Padding = new Padding(3, 3, 0, 0);
            supplementsInfo.Size = new Size(610, 170);
            supplementsInfo.TabIndex = 1;
            // 
            // checkoutBtn
            // 
            checkoutBtn.BackColor = Color.LightGreen;
            checkoutBtn.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkoutBtn.Location = new Point(297, 246);
            checkoutBtn.Margin = new Padding(290, 30, 3, 3);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(200, 50);
            checkoutBtn.TabIndex = 1;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.UseVisualStyleBackColor = false;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.logo;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(697, 316);
            logo.Margin = new Padding(197, 100, 3, 3);
            logo.Name = "logo";
            logo.Size = new Size(100, 100);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.Location = new Point(12, 1);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(172, 27);
            navigationButton.TabIndex = 5;
            navigationButton.Text = "Return to index";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(819, 450);
            Controls.Add(navigationButton);
            Controls.Add(mainContainer);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            mainContainer.ResumeLayout(false);
            mainContainer.PerformLayout();
            cartInfo.ResumeLayout(false);
            userInfo.ResumeLayout(false);
            userInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPfp).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel mainContainer;
        private FlowLayoutPanel cartInfo;
        private Panel userInfo;
        private Utilities.RoundPictureBox userPfp;
        private FlowLayoutPanel supplementsInfo;
        private Label usernameLbl;
        private Button checkoutBtn;
        private PictureBox logo;
        private Label userSupplementsLbl;
        private Button navigationButton;
    }
}