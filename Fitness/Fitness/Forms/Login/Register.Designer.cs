namespace Fitness
{
    partial class Register
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
            disclaimer = new Label();
            navigationButton = new Button();
            profilePicture = new Utilities.RoundPictureBox();
            registerButton = new Button();
            uploadButton = new Button();
            ageField = new TextBox();
            ageLabel = new Label();
            emailField = new TextBox();
            emailLabel = new Label();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            register_label = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__3_;
            formPanel.Controls.Add(disclaimer);
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(profilePicture);
            formPanel.Controls.Add(registerButton);
            formPanel.Controls.Add(uploadButton);
            formPanel.Controls.Add(ageField);
            formPanel.Controls.Add(ageLabel);
            formPanel.Controls.Add(emailField);
            formPanel.Controls.Add(emailLabel);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(register_label);
            formPanel.Location = new Point(77, 12);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(659, 400);
            formPanel.TabIndex = 0;
            // 
            // disclaimer
            // 
            disclaimer.AutoSize = true;
            disclaimer.BackColor = Color.Transparent;
            disclaimer.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            disclaimer.ForeColor = Color.DimGray;
            disclaimer.Location = new Point(0, 362);
            disclaimer.Name = "disclaimer";
            disclaimer.Size = new Size(161, 16);
            disclaimer.TabIndex = 18;
            disclaimer.Text = "(if you have account)";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.Location = new Point(0, 318);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(160, 41);
            navigationButton.TabIndex = 17;
            navigationButton.Text = "Return to login";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // profilePicture
            // 
            profilePicture.Location = new Point(460, 52);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(144, 118);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 16;
            profilePicture.TabStop = false;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.LightGreen;
            registerButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            registerButton.Location = new Point(444, 318);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(160, 41);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            registerButton.MouseLeave += register_leave;
            registerButton.MouseHover += register_hover;
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadButton.Location = new Point(460, 200);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(130, 30);
            uploadButton.TabIndex = 13;
            uploadButton.Text = "Upload pfp";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadImage_click;
            // 
            // ageField
            // 
            ageField.BackColor = Color.LightGray;
            ageField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ageField.ForeColor = Color.DimGray;
            ageField.Location = new Point(115, 269);
            ageField.Name = "ageField";
            ageField.Size = new Size(244, 23);
            ageField.TabIndex = 12;
            ageField.Click += clearInputs_click;
            ageField.TextChanged += input_TextChanged;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ageLabel.Location = new Point(193, 248);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(42, 18);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age";
            // 
            // emailField
            // 
            emailField.BackColor = Color.LightGray;
            emailField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            emailField.ForeColor = Color.DimGray;
            emailField.Location = new Point(115, 200);
            emailField.Name = "emailField";
            emailField.Size = new Size(244, 23);
            emailField.TabIndex = 10;
            emailField.Click += clearInputs_click;
            emailField.TextChanged += input_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            emailLabel.Location = new Point(193, 176);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(65, 18);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "*Email";
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
            passwordField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            passwordField.ForeColor = Color.DimGray;
            passwordField.Location = new Point(115, 132);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(244, 23);
            passwordField.TabIndex = 8;
            passwordField.Click += clearInputs_click;
            passwordField.TextChanged += input_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            passwordLabel.Location = new Point(193, 106);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(105, 18);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "*Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
            usernameField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usernameField.ForeColor = Color.DimGray;
            usernameField.Location = new Point(115, 64);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(244, 23);
            usernameField.TabIndex = 6;
            usernameField.Click += clearInputs_click;
            usernameField.TextChanged += input_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.Location = new Point(193, 40);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 18);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "*Username";
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
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.Transparent;
            register_label.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            register_label.Location = new Point(218, 0);
            register_label.Name = "register_label";
            register_label.Size = new Size(250, 25);
            register_label.TabIndex = 0;
            register_label.Text = "Register Credentials";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label register_label;
        private PictureBox logo;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private TextBox ageField;
        private Label ageLabel;
        private TextBox emailField;
        private Label emailLabel;
        private Button uploadButton;
        private Button registerButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Utilities.RoundPictureBox profilePicture;
        private Button navigationButton;
        private Label disclaimer;
    }
}