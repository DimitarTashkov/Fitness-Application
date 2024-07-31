namespace Fitness.Forms.Personalization
{
    partial class Orders
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
            ordersLabel = new Label();
            ordersContainer = new FlowLayoutPanel();
            orderHeaders = new FlowLayoutPanel();
            userHeader = new Label();
            addressHeader = new Label();
            priceHeader = new Label();
            itemsHeader = new Label();
            paymentHeader = new Label();
            dateHeader = new Label();
            arriveHeader = new Label();
            navigationButton = new Button();
            ordersContainer.SuspendLayout();
            orderHeaders.SuspendLayout();
            SuspendLayout();
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.BackColor = Color.Transparent;
            ordersLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ordersLabel.ForeColor = Color.White;
            ordersLabel.Location = new Point(322, 9);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(148, 25);
            ordersLabel.TabIndex = 0;
            ordersLabel.Text = "Your orders";
            // 
            // ordersContainer
            // 
            ordersContainer.AutoScroll = true;
            ordersContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            ordersContainer.Controls.Add(orderHeaders);
            ordersContainer.Location = new Point(20, 37);
            ordersContainer.Name = "ordersContainer";
            ordersContainer.Size = new Size(760, 400);
            ordersContainer.TabIndex = 1;
            // 
            // orderHeaders
            // 
            orderHeaders.BackColor = Color.Cyan;
            orderHeaders.Controls.Add(userHeader);
            orderHeaders.Controls.Add(addressHeader);
            orderHeaders.Controls.Add(priceHeader);
            orderHeaders.Controls.Add(itemsHeader);
            orderHeaders.Controls.Add(paymentHeader);
            orderHeaders.Controls.Add(dateHeader);
            orderHeaders.Controls.Add(arriveHeader);
            orderHeaders.Location = new Point(8, 8);
            orderHeaders.Margin = new Padding(8);
            orderHeaders.Name = "orderHeaders";
            orderHeaders.Padding = new Padding(10);
            orderHeaders.Size = new Size(725, 32);
            orderHeaders.TabIndex = 0;
            // 
            // userHeader
            // 
            userHeader.AutoSize = true;
            userHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userHeader.Location = new Point(40, 10);
            userHeader.Margin = new Padding(30, 0, 3, 0);
            userHeader.Name = "userHeader";
            userHeader.Size = new Size(40, 16);
            userHeader.TabIndex = 0;
            userHeader.Text = "User";
            // 
            // addressHeader
            // 
            addressHeader.AutoSize = true;
            addressHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addressHeader.Location = new Point(113, 10);
            addressHeader.Margin = new Padding(30, 0, 3, 0);
            addressHeader.Name = "addressHeader";
            addressHeader.Size = new Size(65, 16);
            addressHeader.TabIndex = 1;
            addressHeader.Text = "Address";
            // 
            // priceHeader
            // 
            priceHeader.AutoSize = true;
            priceHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            priceHeader.Location = new Point(211, 10);
            priceHeader.Margin = new Padding(30, 0, 3, 0);
            priceHeader.Name = "priceHeader";
            priceHeader.Size = new Size(42, 16);
            priceHeader.TabIndex = 2;
            priceHeader.Text = "Price";
            // 
            // itemsHeader
            // 
            itemsHeader.AutoSize = true;
            itemsHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            itemsHeader.Location = new Point(291, 10);
            itemsHeader.Margin = new Padding(35, 0, 3, 0);
            itemsHeader.Name = "itemsHeader";
            itemsHeader.Size = new Size(50, 16);
            itemsHeader.TabIndex = 3;
            itemsHeader.Text = "Items";
            // 
            // paymentHeader
            // 
            paymentHeader.AutoSize = true;
            paymentHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            paymentHeader.Location = new Point(379, 10);
            paymentHeader.Margin = new Padding(35, 0, 3, 0);
            paymentHeader.Name = "paymentHeader";
            paymentHeader.Size = new Size(72, 16);
            paymentHeader.TabIndex = 4;
            paymentHeader.Text = "Payment";
            // 
            // dateHeader
            // 
            dateHeader.AutoSize = true;
            dateHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dateHeader.Location = new Point(489, 10);
            dateHeader.Margin = new Padding(35, 0, 3, 0);
            dateHeader.Name = "dateHeader";
            dateHeader.Size = new Size(88, 16);
            dateHeader.TabIndex = 5;
            dateHeader.Text = "Ordered on";
            // 
            // arriveHeader
            // 
            arriveHeader.AutoSize = true;
            arriveHeader.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            arriveHeader.Location = new Point(615, 10);
            arriveHeader.Margin = new Padding(35, 0, 3, 0);
            arriveHeader.Name = "arriveHeader";
            arriveHeader.Size = new Size(80, 16);
            arriveHeader.TabIndex = 6;
            arriveHeader.Text = "Arrives on";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(2, 2);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 4;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(navigationButton);
            Controls.Add(ordersContainer);
            Controls.Add(ordersLabel);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ordersContainer.ResumeLayout(false);
            orderHeaders.ResumeLayout(false);
            orderHeaders.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordersLabel;
        private FlowLayoutPanel ordersContainer;
        private FlowLayoutPanel orderHeaders;
        private Label userHeader;
        private Label addressHeader;
        private Label priceHeader;
        private Label itemsHeader;
        private Label paymentHeader;
        private Label dateHeader;
        private Label arriveHeader;
        private Button navigationButton;
    }
}