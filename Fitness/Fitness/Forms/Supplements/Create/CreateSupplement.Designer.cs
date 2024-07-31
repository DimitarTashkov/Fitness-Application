namespace Fitness.Forms.Supplements
{
    partial class CreateSupplement
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
            formPanel = new Panel();
            navigationButton = new Button();
            supplementPicture = new PictureBox();
            uploadSupplement = new Button();
            uploadImage = new Button();
            descriptionField = new TextBox();
            descriptionLabel = new Label();
            quantityField = new TextBox();
            quantityLabel = new Label();
            priceField = new TextBox();
            priceLabel = new Label();
            nameField = new TextBox();
            nameLabel = new Label();
            logo = new PictureBox();
            supplementsLabel = new Label();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplementPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(supplementPicture);
            formPanel.Controls.Add(uploadSupplement);
            formPanel.Controls.Add(uploadImage);
            formPanel.Controls.Add(descriptionField);
            formPanel.Controls.Add(descriptionLabel);
            formPanel.Controls.Add(quantityField);
            formPanel.Controls.Add(quantityLabel);
            formPanel.Controls.Add(priceField);
            formPanel.Controls.Add(priceLabel);
            formPanel.Controls.Add(nameField);
            formPanel.Controls.Add(nameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(supplementsLabel);
            formPanel.Location = new Point(71, 25);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(659, 400);
            formPanel.TabIndex = 1;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.Location = new Point(8, 318);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(200, 45);
            navigationButton.TabIndex = 18;
            navigationButton.Text = "Return to catalog";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // supplementPicture
            // 
            supplementPicture.BackgroundImageLayout = ImageLayout.Stretch;
            supplementPicture.Location = new Point(451, 16);
            supplementPicture.Name = "supplementPicture";
            supplementPicture.Size = new Size(200, 200);
            supplementPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            supplementPicture.TabIndex = 17;
            supplementPicture.TabStop = false;
            // 
            // uploadSupplement
            // 
            uploadSupplement.BackColor = Color.LightGreen;
            uploadSupplement.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadSupplement.Location = new Point(451, 318);
            uploadSupplement.Name = "uploadSupplement";
            uploadSupplement.Size = new Size(200, 45);
            uploadSupplement.TabIndex = 15;
            uploadSupplement.Text = "Upload to database";
            uploadSupplement.UseVisualStyleBackColor = false;
            uploadSupplement.Click += addButton_Click;
            uploadSupplement.MouseLeave += add_leave;
            uploadSupplement.MouseHover += add_hover;
            // 
            // uploadImage
            // 
            uploadImage.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadImage.Location = new Point(451, 222);
            uploadImage.Name = "uploadImage";
            uploadImage.Size = new Size(200, 30);
            uploadImage.TabIndex = 13;
            uploadImage.Text = "Upload image";
            uploadImage.UseVisualStyleBackColor = true;
            uploadImage.Click += uploadImage_click;
            // 
            // descriptionField
            // 
            descriptionField.BackColor = Color.LightGray;
            descriptionField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Location = new Point(22, 269);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(414, 23);
            descriptionField.TabIndex = 12;
            descriptionField.Click += clearInputs_click;
            descriptionField.TextChanged += input_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(193, 245);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(106, 18);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description";
            // 
            // quantityField
            // 
            quantityField.BackColor = Color.LightGray;
            quantityField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            quantityField.ForeColor = Color.DimGray;
            quantityField.Location = new Point(115, 200);
            quantityField.Name = "quantityField";
            quantityField.Size = new Size(244, 23);
            quantityField.TabIndex = 10;
            quantityField.Click += clearInputs_click;
            quantityField.TextChanged += input_TextChanged;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            quantityLabel.Location = new Point(193, 176);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(94, 18);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "*Quantity";
            // 
            // priceField
            // 
            priceField.BackColor = Color.LightGray;
            priceField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            priceField.ForeColor = Color.DimGray;
            priceField.Location = new Point(115, 132);
            priceField.Name = "priceField";
            priceField.Size = new Size(244, 23);
            priceField.TabIndex = 8;
            priceField.Click += clearInputs_click;
            priceField.TextChanged += input_TextChanged;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            priceLabel.Location = new Point(193, 106);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(94, 18);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "*Price(lv)";
            // 
            // nameField
            // 
            nameField.BackColor = Color.LightGray;
            nameField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nameField.ForeColor = Color.DimGray;
            nameField.Location = new Point(115, 64);
            nameField.Name = "nameField";
            nameField.Size = new Size(244, 23);
            nameField.TabIndex = 6;
            nameField.Click += clearInputs_click;
            nameField.TextChanged += input_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.Location = new Point(193, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(70, 18);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "*Name";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(-21, -16);
            logo.Name = "logo";
            logo.Size = new Size(101, 94);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // supplementsLabel
            // 
            supplementsLabel.AutoSize = true;
            supplementsLabel.BackColor = Color.Transparent;
            supplementsLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            supplementsLabel.Location = new Point(225, 0);
            supplementsLabel.Name = "supplementsLabel";
            supplementsLabel.Size = new Size(206, 25);
            supplementsLabel.TabIndex = 0;
            supplementsLabel.Text = "Supplement info";
            // 
            // CreateSupplement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "CreateSupplement";
            Text = "CreateSupplement";
            Load += CreateSupplement_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)supplementPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Button uploadSupplement;
        private Button uploadImage;
        private TextBox descriptionField;
        private Label descriptionLabel;
        private TextBox quantityField;
        private Label quantityLabel;
        private TextBox priceField;
        private Label priceLabel;
        private TextBox nameField;
        private Label nameLabel;
        private PictureBox logo;
        private Label supplementsLabel;
        private PictureBox supplementPicture;
        private Button navigationButton;
    }
}