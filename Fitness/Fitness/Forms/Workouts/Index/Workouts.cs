using Fitness.Forms.Exercises.Index;
using Fitness.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class Workouts : Form
    {
        public Workouts()
        {
            InitializeComponent();
        }

        private void Workouts_Load(object sender, EventArgs e)
        {

        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index();
            Program.SwitchMainForm(indexForm);
        }

        private void addWorkout_Click(object sender, EventArgs e)
        {

        }

        private void exercisesButton_Click(object sender, EventArgs e)
        {
            Exercises exercisesForm = new Exercises();
            Program.SwitchMainForm(exercisesForm);
        }
    }
}
