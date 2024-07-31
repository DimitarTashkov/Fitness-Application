namespace Fitness
{
    partial class Workouts
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
            exercisesButton = new Button();
            addWorkout = new Button();
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
            navigationButton.Size = new Size(148, 29);
            navigationButton.TabIndex = 7;
            navigationButton.Text = "Return to main";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // exercisesButton
            // 
            exercisesButton.BackColor = Color.LightCoral;
            exercisesButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            exercisesButton.Location = new Point(652, 0);
            exercisesButton.Name = "exercisesButton";
            exercisesButton.Size = new Size(148, 29);
            exercisesButton.TabIndex = 6;
            exercisesButton.Text = "Exercises";
            exercisesButton.UseVisualStyleBackColor = false;
            exercisesButton.Click += exercisesButton_Click;
            // 
            // addWorkout
            // 
            addWorkout.BackColor = Color.LightGreen;
            addWorkout.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addWorkout.Location = new Point(327, 0);
            addWorkout.Name = "addWorkout";
            addWorkout.Size = new Size(148, 29);
            addWorkout.TabIndex = 4;
            addWorkout.Text = "Add";
            addWorkout.UseVisualStyleBackColor = false;
            addWorkout.Click += addWorkout_Click;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.BackgroundImage = Properties.Resources.gradient_img__4_;
            mainContainer.Location = new Point(39, 32);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(723, 391);
            mainContainer.TabIndex = 5;
            // 
            // Workouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(navigationButton);
            Controls.Add(exercisesButton);
            Controls.Add(addWorkout);
            Controls.Add(mainContainer);
            Name = "Workouts";
            Text = "Workouts";
            Load += Workouts_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button navigationButton;
        private Button exercisesButton;
        private Button addWorkout;
        private FlowLayoutPanel mainContainer;
    }
}