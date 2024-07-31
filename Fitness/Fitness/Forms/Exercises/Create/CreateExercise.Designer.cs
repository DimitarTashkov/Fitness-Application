namespace Fitness.Forms.Exercises.Create
{
    partial class CreateExercise
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
            vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            navigationButton = new Button();
            uploadSupplement = new Button();
            uploadVideo = new Button();
            descriptionField = new TextBox();
            descriptionLabel = new Label();
            quantityField = new TextBox();
            quantityLabel = new Label();
            priceField = new TextBox();
            priceLabel = new Label();
            nameField = new TextBox();
            nameLabel = new Label();
            logo = new PictureBox();
            exerciseLabel = new Label();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vlcControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(vlcControl1);
            formPanel.Controls.Add(uploadSupplement);
            formPanel.Controls.Add(uploadVideo);
            formPanel.Controls.Add(descriptionField);
            formPanel.Controls.Add(descriptionLabel);
            formPanel.Controls.Add(quantityField);
            formPanel.Controls.Add(quantityLabel);
            formPanel.Controls.Add(priceField);
            formPanel.Controls.Add(priceLabel);
            formPanel.Controls.Add(nameField);
            formPanel.Controls.Add(nameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(exerciseLabel);
            formPanel.Location = new Point(62, 23);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(577, 375);
            formPanel.TabIndex = 2;
            // 
            // vlcControl1
            // 
            vlcControl1.BackColor = Color.Black;
            vlcControl1.Location = new Point(321, 16);
            vlcControl1.Name = "vlcControl1";
            vlcControl1.Size = new Size(259, 195);
            vlcControl1.Spu = -1;
            vlcControl1.TabIndex = 0;
            vlcControl1.Text = "vlcControl";
            vlcControl1.VlcLibDirectory = null;
            vlcControl1.VlcMediaplayerOptions = null;
            vlcControl1.VlcLibDirectoryNeeded += VlcControl_VlcLibDirectoryNeeded;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.Location = new Point(7, 298);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(175, 42);
            navigationButton.TabIndex = 18;
            navigationButton.Text = "Return to catalog";
            navigationButton.UseVisualStyleBackColor = false;
            // 
            // uploadSupplement
            // 
            uploadSupplement.BackColor = Color.LightGreen;
            uploadSupplement.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadSupplement.Location = new Point(395, 298);
            uploadSupplement.Name = "uploadSupplement";
            uploadSupplement.Size = new Size(175, 42);
            uploadSupplement.TabIndex = 15;
            uploadSupplement.Text = "Upload to database";
            uploadSupplement.UseVisualStyleBackColor = false;
            // 
            // uploadVideo
            // 
            uploadVideo.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadVideo.Location = new Point(372, 215);
            uploadVideo.Name = "uploadVideo";
            uploadVideo.Size = new Size(175, 28);
            uploadVideo.TabIndex = 13;
            uploadVideo.Text = "Upload video";
            uploadVideo.UseVisualStyleBackColor = true;
            uploadVideo.Click += uploadVideo_Click;
            // 
            // descriptionField
            // 
            descriptionField.BackColor = Color.LightGray;
            descriptionField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionField.ForeColor = Color.DimGray;
            descriptionField.Location = new Point(19, 252);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(363, 23);
            descriptionField.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(169, 230);
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
            quantityField.Location = new Point(101, 188);
            quantityField.Name = "quantityField";
            quantityField.Size = new Size(214, 23);
            quantityField.TabIndex = 10;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            quantityLabel.Location = new Point(169, 165);
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
            priceField.Location = new Point(101, 124);
            priceField.Name = "priceField";
            priceField.Size = new Size(214, 23);
            priceField.TabIndex = 8;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            priceLabel.Location = new Point(169, 99);
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
            nameField.Location = new Point(101, 60);
            nameField.Name = "nameField";
            nameField.Size = new Size(214, 23);
            nameField.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nameLabel.Location = new Point(169, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(70, 18);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "*Name";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(-18, -15);
            logo.Name = "logo";
            logo.Size = new Size(88, 88);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // exerciseLabel
            // 
            exerciseLabel.AutoSize = true;
            exerciseLabel.BackColor = Color.Transparent;
            exerciseLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            exerciseLabel.Location = new Point(197, 0);
            exerciseLabel.Name = "exerciseLabel";
            exerciseLabel.Size = new Size(161, 25);
            exerciseLabel.TabIndex = 0;
            exerciseLabel.Text = "Exercise info";
            // 
            // CreateExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 422);
            Controls.Add(formPanel);
            Name = "CreateExercise";
            Text = "Form1";
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vlcControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Button navigationButton;
        private Button uploadSupplement;
        private Button uploadVideo;
        private TextBox descriptionField;
        private Label descriptionLabel;
        private TextBox quantityField;
        private Label quantityLabel;
        private TextBox priceField;
        private Label priceLabel;
        private TextBox nameField;
        private Label nameLabel;
        private PictureBox logo;
        private Label exerciseLabel;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
    }
}