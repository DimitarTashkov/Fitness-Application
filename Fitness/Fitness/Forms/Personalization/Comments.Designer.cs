namespace Fitness
{
    partial class Comments
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
            commentsContainer = new FlowLayoutPanel();
            ordersLabel = new Label();
            navigationButton = new Button();
            SuspendLayout();
            // 
            // commentsContainer
            // 
            commentsContainer.AutoScroll = true;
            commentsContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            commentsContainer.Location = new Point(29, 43);
            commentsContainer.Name = "commentsContainer";
            commentsContainer.Size = new Size(760, 400);
            commentsContainer.TabIndex = 6;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.BackColor = Color.Transparent;
            ordersLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ordersLabel.ForeColor = Color.White;
            ordersLabel.Location = new Point(331, 15);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(136, 25);
            ordersLabel.TabIndex = 5;
            ordersLabel.Text = "Comments";
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
            // Comments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(commentsContainer);
            Controls.Add(ordersLabel);
            Controls.Add(navigationButton);
            Name = "Comments";
            Text = "Comments";
            Load += Comments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel commentsContainer;
        private Label ordersLabel;
        private Button navigationButton;
    }
}