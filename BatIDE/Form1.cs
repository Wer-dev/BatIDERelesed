using BatIDE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatIDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool IsActivedFormEditor;
        private void CloseForms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_MouseEnter(object sender, EventArgs e)
        {
            Open.Text = "Open x";
            Open.BackColor = Color.Green;
        }

        private void Open_MouseLeave(object sender, EventArgs e)
        {
            Open.Text = "Open";
            Open.BackColor = Color.Black;
        }

        private void Create_MouseEnter(object sender, EventArgs e)
        {
            Create.Text = "Create x";
            Create.BackColor = Color.Green;
        }

        private void Create_MouseLeave(object sender, EventArgs e)
        {
            Create.Text = "Create";
            Create.BackColor = Color.Black;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bat Files | *.bat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog.FileName).Close();

                Settings1.Default.path = saveFileDialog.FileName;
                Settings1.Default.name = Path.GetFileName(saveFileDialog.FileName);
                Settings1.Default.Save();

                if (IsActivedFormEditor == false)
                {
                    IsActivedFormEditor = true;
                    BatEditor batEditor = new BatEditor();
                    batEditor.Enabled = true;
                    batEditor.Show();
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bat Files | *.bat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Settings1.Default.path = openFileDialog.FileName;
                Settings1.Default.name = Path.GetFileName(openFileDialog.FileName);
                Settings1.Default.Save();

                if (IsActivedFormEditor == false)
                {
                    IsActivedFormEditor = true;
                    BatEditor batEditor = new BatEditor();
                    batEditor.Enabled = true;
                    batEditor.Show();
                }
            }
        }
        private void CloseForms_MouseEnter_1(object sender, EventArgs e)
        {
            CloseForms.BackColor = Color.Red;
        }

        private void CloseForms_MouseLeave_1(object sender, EventArgs e)
        {
            CloseForms.BackColor = Color.Black;
        }

        private void HideForms_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HideForms_MouseEnter_1(object sender, EventArgs e)
        {
            HideForms.BackColor = Color.Aqua;
        }

        private void HideForms_MouseLeave_1(object sender, EventArgs e)
        {
            HideForms.BackColor = Color.Black;
        }
    }
}
