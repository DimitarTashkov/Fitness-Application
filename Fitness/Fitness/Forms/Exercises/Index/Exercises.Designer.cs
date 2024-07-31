namespace Fitness.Forms.Exercises.Index
{
    partial class Exercises
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
            navigationButton = new Button();
            addExercise = new Button();
            mainContainer = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            navigationButton.ForeColor = SystemColors.ControlText;
            navigationButton.Location = new Point(2, 0);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(193, 29);
            navigationButton.TabIndex = 11;
            navigationButton.Text = "Return to workouts";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // addExercise
            // 
            addExercise.BackColor = Color.LightGreen;
            addExercise.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addExercise.Location = new Point(327, 0);
            addExercise.Name = "addExercise";
            addExercise.Size = new Size(148, 29);
            addExercise.TabIndex = 8;
            addExercise.Text = "Add";
            addExercise.UseVisualStyleBackColor = false;
            addExercise.Click += addExercise_Click;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            mainContainer.Location = new Point(38, 46);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(723, 391);
            mainContainer.TabIndex = 9;
            // 
            // Exercises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(navigationButton);
            Controls.Add(addExercise);
            Controls.Add(mainContainer);
            Name = "Exercises";
            Text = "Exercises";
            ResumeLayout(false);
        }

        #endregion

        private Button navigationButton;
        private Button addExercise;
        private FlowLayoutPanel mainContainer;
    }
}