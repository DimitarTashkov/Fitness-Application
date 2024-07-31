namespace Fitness.Forms.Transaction
{
    partial class Checkout
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
            paymentBox = new ComboBox();
            cancel = new Label();
            orderBtn = new Button();
            paymentLabel = new Label();
            addressField = new TextBox();
            addressLabel = new Label();
            logo = new PictureBox();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__3_;
            formPanel.Controls.Add(paymentBox);
            formPanel.Controls.Add(cancel);
            formPanel.Controls.Add(orderBtn);
            formPanel.Controls.Add(paymentLabel);
            formPanel.Controls.Add(addressField);
            formPanel.Controls.Add(addressLabel);
            formPanel.Controls.Add(logo);
            formPanel.Location = new Point(225, 50);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(350, 350);
            formPanel.TabIndex = 1;
            // 
            // paymentBox
            // 
            paymentBox.BackColor = Color.LightGray;
            paymentBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            paymentBox.ForeColor = Color.DimGray;
            paymentBox.FormattingEnabled = true;
            paymentBox.Location = new Point(3, 214);
            paymentBox.Name = "paymentBox";
            paymentBox.Size = new Size(346, 26);
            paymentBox.TabIndex = 7;
            // 
            // cancel
            // 
            cancel.AutoSize = true;
            cancel.Cursor = Cursors.Hand;
            cancel.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            cancel.ForeColor = Color.Blue;
            cancel.Location = new Point(146, 315);
            cancel.Name = "cancel";
            cancel.Size = new Size(52, 14);
            cancel.TabIndex = 6;
            cancel.Text = "Cancel";
            cancel.Click += cancel_Click;
            // 
            // orderBtn
            // 
            orderBtn.BackColor = Color.LightGreen;
            orderBtn.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            orderBtn.Location = new Point(90, 260);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(160, 41);
            orderBtn.TabIndex = 5;
            orderBtn.Text = "Order";
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += orderBtn_Click;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.BackColor = Color.Transparent;
            paymentLabel.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            paymentLabel.Location = new Point(121, 173);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(92, 23);
            paymentLabel.TabIndex = 3;
            paymentLabel.Text = "Password";
            // 
            // addressField
            // 
            addressField.BackColor = Color.LightGray;
            addressField.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressField.ForeColor = Color.DimGray;
            addressField.Location = new Point(1, 131);
            addressField.Name = "addressField";
            addressField.Size = new Size(346, 27);
            addressField.TabIndex = 2;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = Color.Transparent;
            addressLabel.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addressLabel.Location = new Point(121, 105);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(77, 23);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address";
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
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(formPanel);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private ComboBox paymentBox;
        private Label cancel;
        private Button orderBtn;
        private Label paymentLabel;
        private TextBox addressField;
        private Label addressLabel;
        private PictureBox logo;
    }
}