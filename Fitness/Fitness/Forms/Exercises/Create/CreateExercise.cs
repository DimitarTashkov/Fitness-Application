using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace Fitness.Forms.Exercises.Create
{
    public partial class CreateExercise : Form
    {
        public CreateExercise()
        {
            InitializeComponent();
        }

        private void VlcControl_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (IntPtr.Size == 4)
            {
                e.VlcLibDirectory = new System.IO.DirectoryInfo(System.IO.Path.Combine(currentDirectory, @"libvlc\win-x86"));
            }
            else
            {
                e.VlcLibDirectory = new System.IO.DirectoryInfo(System.IO.Path.Combine(currentDirectory, @"libvlc\win-x64"));
            }
        }

        private void uploadVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.wmv";
                openFileDialog.Title = "Select a Video File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    vlcControl1.Play(new Uri(openFileDialog.FileName));
                }
            }
        }
    }
}
