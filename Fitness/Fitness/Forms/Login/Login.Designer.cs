namespace Fitness
{
    partial class Login1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formPanel = new Panel();
            register = new Label();
            login = new Button();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__3_;
            formPanel.Controls.Add(register);
            formPanel.Controls.Add(login);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Location = new Point(231, 44);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(350, 350);
            formPanel.TabIndex = 0;
            // 
            // register
            // 
            register.AutoSize = true;
            register.BackColor = Color.Transparent;
            register.Cursor = Cursors.Hand;
            register.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            register.ForeColor = Color.Blue;
            register.Location = new Point(136, 315);
            register.Name = "register";
            register.Size = new Size(62, 14);
            register.TabIndex = 6;
            register.Text = "Register";
            register.Click += register_Click;
            register.MouseLeave += register_leave;
            register.MouseHover += register_hover;
            // 
            // login
            // 
            login.BackColor = Color.SkyBlue;
            login.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            login.Location = new Point(90, 260);
            login.Name = "login";
            login.Size = new Size(160, 41);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            login.MouseLeave += login_leave;
            login.MouseHover += login_hover;
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
            passwordField.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordField.ForeColor = Color.DimGray;
            passwordField.Location = new Point(4, 197);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(346, 27);
            passwordField.TabIndex = 4;
            passwordField.Click += clearInputs_click;
            passwordField.TextChanged += input_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(116, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(92, 23);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
            usernameField.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameField.ForeColor = Color.DimGray;
            usernameField.Location = new Point(4, 131);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(346, 27);
            usernameField.TabIndex = 2;
            usernameField.Click += clearInputs_click;
            usernameField.TextChanged += input_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(116, 105);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(98, 23);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(-21, -16);
            logo.Name = "logo";
            logo.Size = new Size(101, 94);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // Login1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "Login1";
            Text = "Login";
            Load += Form1_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private PictureBox logo;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private Button login;
        private Label register;
    }
}