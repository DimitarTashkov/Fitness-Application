namespace Fitness.Forms.Supplements.Details
{
    partial class ReadMore
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
            supplementLabel = new Label();
            mainContainer = new FlowLayoutPanel();
            supplementContainer = new FlowLayoutPanel();
            supplementVisualsContainer = new Panel();
            addToCartBtn = new Button();
            supplementImage = new PictureBox();
            supplementDataContainer = new Panel();
            editSupplementBtn = new Button();
            supplementDescription = new Label();
            supplementQuantity = new Label();
            supplementPrice = new Label();
            supplementName = new Label();
            commentsLabel = new Label();
            navigationButton = new Button();
            mainContainer.SuspendLayout();
            supplementContainer.SuspendLayout();
            supplementVisualsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplementImage).BeginInit();
            supplementDataContainer.SuspendLayout();
            SuspendLayout();
            // 
            // supplementLabel
            // 
            supplementLabel.BackColor = Color.Transparent;
            supplementLabel.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            supplementLabel.Location = new Point(33, 0);
            supplementLabel.Name = "supplementLabel";
            supplementLabel.Padding = new Padding(0, 15, 0, 0);
            supplementLabel.Size = new Size(717, 40);
            supplementLabel.TabIndex = 0;
            supplementLabel.Text = "Supplement Info";
            supplementLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackColor = SystemColors.InactiveCaption;
            mainContainer.Controls.Add(supplementLabel);
            mainContainer.Controls.Add(supplementContainer);
            mainContainer.Controls.Add(commentsLabel);
            mainContainer.Location = new Point(12, 33);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(30, 0, 0, 0);
            mainContainer.Size = new Size(800, 391);
            mainContainer.TabIndex = 1;
            // 
            // supplementContainer
            // 
            supplementContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            supplementContainer.Controls.Add(supplementVisualsContainer);
            supplementContainer.Controls.Add(supplementDataContainer);
            supplementContainer.Location = new Point(33, 43);
            supplementContainer.Name = "supplementContainer";
            supplementContainer.Padding = new Padding(1, 0, 0, 0);
            supplementContainer.Size = new Size(717, 300);
            supplementContainer.TabIndex = 1;
            // 
            // supplementVisualsContainer
            // 
            supplementVisualsContainer.BackColor = Color.Transparent;
            supplementVisualsContainer.Controls.Add(addToCartBtn);
            supplementVisualsContainer.Controls.Add(supplementImage);
            supplementVisualsContainer.Location = new Point(21, 40);
            supplementVisualsContainer.Margin = new Padding(20, 40, 3, 3);
            supplementVisualsContainer.Name = "supplementVisualsContainer";
            supplementVisualsContainer.Size = new Size(200, 240);
            supplementVisualsContainer.TabIndex = 0;
            // 
            // addToCartBtn
            // 
            addToCartBtn.BackColor = Color.LightGreen;
            addToCartBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addToCartBtn.Location = new Point(0, 210);
            addToCartBtn.Name = "addToCartBtn";
            addToCartBtn.Size = new Size(200, 30);
            addToCartBtn.TabIndex = 1;
            addToCartBtn.Text = "Add to cart";
            addToCartBtn.UseVisualStyleBackColor = false;
            addToCartBtn.Click += addToCartBtn_Click;
            // 
            // supplementImage
            // 
            supplementImage.BackgroundImageLayout = ImageLayout.Stretch;
            supplementImage.Location = new Point(0, 0);
            supplementImage.Name = "supplementImage";
            supplementImage.Size = new Size(200, 200);
            supplementImage.SizeMode = PictureBoxSizeMode.StretchImage;
            supplementImage.TabIndex = 0;
            supplementImage.TabStop = false;
            // 
            // supplementDataContainer
            // 
            supplementDataContainer.BackColor = Color.BlanchedAlmond;
            supplementDataContainer.Controls.Add(editSupplementBtn);
            supplementDataContainer.Controls.Add(supplementDescription);
            supplementDataContainer.Controls.Add(supplementQuantity);
            supplementDataContainer.Controls.Add(supplementPrice);
            supplementDataContainer.Controls.Add(supplementName);
            supplementDataContainer.Location = new Point(244, 30);
            supplementDataContainer.Margin = new Padding(20, 30, 3, 3);
            supplementDataContainer.Name = "supplementDataContainer";
            supplementDataContainer.Padding = new Padding(25, 25, 0, 0);
            supplementDataContainer.Size = new Size(450, 250);
            supplementDataContainer.TabIndex = 1;
            // 
            // editSupplementBtn
            // 
            editSupplementBtn.BackColor = Color.LightGray;
            editSupplementBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point);
            editSupplementBtn.Location = new Point(130, 220);
            editSupplementBtn.Name = "editSupplementBtn";
            editSupplementBtn.Size = new Size(200, 30);
            editSupplementBtn.TabIndex = 4;
            editSupplementBtn.Text = "Edit supplement";
            editSupplementBtn.UseVisualStyleBackColor = false;
            editSupplementBtn.Click += editSupplementBtn_Click;
            // 
            // supplementDescription
            // 
            supplementDescription.AutoSize = true;
            supplementDescription.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            supplementDescription.Location = new Point(25, 115);
            supplementDescription.Name = "supplementDescription";
            supplementDescription.Size = new Size(94, 16);
            supplementDescription.TabIndex = 3;
            supplementDescription.Text = "Description:";
            // 
            // supplementQuantity
            // 
            supplementQuantity.AutoSize = true;
            supplementQuantity.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            supplementQuantity.Location = new Point(25, 85);
            supplementQuantity.Name = "supplementQuantity";
            supplementQuantity.Size = new Size(92, 16);
            supplementQuantity.TabIndex = 2;
            supplementQuantity.Text = "Availability:";
            // 
            // supplementPrice
            // 
            supplementPrice.AutoSize = true;
            supplementPrice.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            supplementPrice.Location = new Point(25, 55);
            supplementPrice.Name = "supplementPrice";
            supplementPrice.Size = new Size(47, 16);
            supplementPrice.TabIndex = 1;
            supplementPrice.Text = "Price:";
            // 
            // supplementName
            // 
            supplementName.AutoSize = true;
            supplementName.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            supplementName.Location = new Point(25, 25);
            supplementName.Name = "supplementName";
            supplementName.Size = new Size(54, 16);
            supplementName.TabIndex = 0;
            supplementName.Text = "Name:";
            // 
            // commentsLabel
            // 
            commentsLabel.BackColor = Color.Transparent;
            commentsLabel.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            commentsLabel.Location = new Point(33, 346);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Padding = new Padding(0, 15, 0, 0);
            commentsLabel.Size = new Size(717, 40);
            commentsLabel.TabIndex = 2;
            commentsLabel.Text = "Comments";
            commentsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.Location = new Point(1, 0);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 27);
            navigationButton.TabIndex = 4;
            navigationButton.Text = "Return to list";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // ReadMore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 450);
            Controls.Add(navigationButton);
            Controls.Add(mainContainer);
            Name = "ReadMore";
            Text = "ReadMore";
            Load += ReadMore_Load;
            mainContainer.ResumeLayout(false);
            supplementContainer.ResumeLayout(false);
            supplementVisualsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supplementImage).EndInit();
            supplementDataContainer.ResumeLayout(false);
            supplementDataContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label supplementLabel;
        private FlowLayoutPanel mainContainer;
        private FlowLayoutPanel supplementContainer;
        private Panel supplementVisualsContainer;
        private Button addToCartBtn;
        private PictureBox supplementImage;
        private Panel supplementDataContainer;
        private Label supplementName;
        private Label supplementPrice;
        private Label supplementQuantity;
        private Label supplementDescription;
        private Button editSupplementBtn;
        private Label commentsLabel;
        private Button navigationButton;
    }
}