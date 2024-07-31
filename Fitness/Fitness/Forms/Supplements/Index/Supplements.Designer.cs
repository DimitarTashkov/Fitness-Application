namespace Fitness
{
    partial class Supplements
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
            addSupplement = new Button();
            mainContainer = new FlowLayoutPanel();
            cartButton = new Button();
            navigationButton = new Button();
            SuspendLayout();
            // 
            // addSupplement
            // 
            addSupplement.BackColor = Color.LightGreen;
            addSupplement.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point);
            addSupplement.Location = new Point(327, 0);
            addSupplement.Name = "addSupplement";
            addSupplement.Size = new Size(148, 29);
            addSupplement.TabIndex = 0;
            addSupplement.Text = "Add";
            addSupplement.UseVisualStyleBackColor = false;
            addSupplement.Click += addSupplement_Click;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            mainContainer.Location = new Point(39, 32);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(723, 391);
            mainContainer.TabIndex = 1;
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.LightCoral;
            cartButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cartButton.Location = new Point(652, 0);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(148, 29);
            cartButton.TabIndex = 2;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += cartButton_Click;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(2, 0);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 3;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // Supplements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(navigationButton);
            Controls.Add(cartButton);
            Controls.Add(addSupplement);
            Controls.Add(mainContainer);
            DoubleBuffered = true;
            Name = "Supplements";
            Text = "Supplements";
            Load += Supplements_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addSupplement;
        private FlowLayoutPanel mainContainer;
        private Button cartButton;
        private Button navigationButton;
    }
}