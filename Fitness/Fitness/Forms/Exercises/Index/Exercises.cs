using Fitness.Forms.Exercises.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness.Forms.Exercises.Index
{
    public partial class Exercises : Form
    {
        public Exercises()
        {
            InitializeComponent();
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Workouts workoutsForm = new Workouts();
            Program.SwitchMainForm(workoutsForm);
        }

        private void addExercise_Click(object sender, EventArgs e)
        {
            CreateExercise createForm = new CreateExercise();
            Program.SwitchMainForm(createForm);
        }
    }
}
