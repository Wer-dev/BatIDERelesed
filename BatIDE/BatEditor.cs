using AutocompleteMenuNS;
using FastColoredTextBoxNS;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatIDE
{
    public partial class BatEditor : Form
    {
        List<string> listprojectstring = new List<string>();
        public BatEditor()
        {
            InitializeComponent();
            NameProject.Text = Settings1.Default.name + " - " + Settings1.Default.path;
            CodeTXT.Text = File.ReadAllText(Settings1.Default.path);

            if (!listprojectstring.Contains(Settings1.Default.path))
            {
                listprojectstring.Add(Settings1.Default.path);
                ListProject.Items.Add(Settings1.Default.name);
            }
        }

        private void CloseEditor_Click(object sender, EventArgs e)
        {
            Form1.IsActivedFormEditor = false;
            this.Close();
        }

        private void HideEditor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseEditor_MouseEnter(object sender, EventArgs e)
        {
            CloseEditor.BackColor = Color.Red;
        }

        private void CloseEditor_MouseLeave(object sender, EventArgs e)
        {
            CloseEditor.BackColor = Color.Black;
        }

        private void HideEditor_MouseEnter(object sender, EventArgs e)
        {
            HideEditor.BackColor = Color.Aqua;
        }

        private void HideEditor_MouseLeave(object sender, EventArgs e)
        {
            HideEditor.BackColor = Color.Black;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(listprojectstring[ListProject.SelectedIndex], CodeTXT.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please click on the project you want to save", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bat Files | *.bat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog.FileName).Close();

                Settings1.Default.path = saveFileDialog.FileName;
                Settings1.Default.name = Path.GetFileName(saveFileDialog.FileName);
                Settings1.Default.Save();

                if (!listprojectstring.Contains(Settings1.Default.path))
                {
                    listprojectstring.Add(saveFileDialog.FileName);
                    ListProject.Items.Add(Settings1.Default.name);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bat Files | *.bat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Settings1.Default.path = openFileDialog.FileName;
                Settings1.Default.name = Path.GetFileName(openFileDialog.FileName);
                Settings1.Default.Save();

                if (!listprojectstring.Contains(Settings1.Default.path))
                {
                    listprojectstring.Add(openFileDialog.FileName);
                    ListProject.Items.Add(Settings1.Default.name);
                }
            }
        }

        private void backgroundEditorCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog backgroundFileDialog = new OpenFileDialog();
            if (backgroundFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Завантаження зображення з обраного файлу
                Image backgroundImage = Image.FromFile(backgroundFileDialog.FileName);

                // Встановлення зображення як фонового зображення для CodeTXT
                CodeTXT.BackgroundImage = backgroundImage;
            }
        }

        private void ListProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameProject.Text = ListProject.Items[ListProject.SelectedIndex] + " - " + listprojectstring[ListProject.SelectedIndex];
            CodeTXT.Text = File.ReadAllText(listprojectstring[ListProject.SelectedIndex]);
            CodeTXT.ClearUndo();
        }
        bool IsMouseDown;
        private void BatEditor_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
        }

        private void BatEditor_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void BatEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                this.Location = new Point(MousePosition.X, MousePosition.Y);
            }
        }

        private void documentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process chrome = new Process())
                {
                    chrome.StartInfo.FileName = "chrome.exe";
                    chrome.StartInfo.Arguments = "https://learn.microsoft.com/en-us/windows-server/administration/windows-commands/windows-commands";
                    chrome.Start();
                }
            }
            catch (Exception)
            {
                using (Process chrome = new Process())
                {
                    chrome.StartInfo.FileName = "msedge.exe";
                    chrome.StartInfo.Arguments = "https://learn.microsoft.com/en-us/windows-server/administration/windows-commands/windows-commands";
                    chrome.Start();
                }
            }

        }

        private void сommentingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = CodeTXT.SelectedText;
            if(selectedText != "" && selectedText != "::")  
            {
                // Розділити виділений текст на окремі рядки
                string[] lines = selectedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                // Перевірити, чи перший рядок вже коментар, щоб визначити, чи коментувати чи розкоментувати
                bool isCommented = lines[0].Trim().StartsWith("::") || lines[0].Trim().StartsWith("//");

                // Опрацювання кожного рядка
                for (int i = 0; i < lines.Length; i++)
                {
                    if (isCommented)
                    {
                        // Видалити коментар з початку рядка
                        lines[i] = lines[i].TrimStart(new char[] { ':', '/', ' ' });
                    }
                    else
                    {
                        // Додати коментар на початок рядка
                        lines[i] = "::" + lines[i];
                    }
                }

                // З'єднати рядки назад
                string processedText = string.Join(Environment.NewLine, lines);

                // Замінити виділений текст на опрацьований текст
                CodeTXT.SelectedText = processedText;
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Process bat = new Process())
            {
                bat.StartInfo.FileName = listprojectstring[ListProject.SelectedIndex];
                bat.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CodeTXT.Undo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodeTXT.Redo();
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeTXT.ShowReplaceDialog();
        }

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CodeTXT.ShowFindDialog();
        }

        private void findToGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeTXT.ShowGoToDialog();
        }
    }
}
