using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Notepad1
{
    public partial class Notepad : Form
    {
        private string fileName = null;
        private bool isUnsaved = false;
        private bool ignoreTextChangeEvent = false;

        public Notepad()
        {
            InitializeComponent();
            updateTitle();
        }

        private void updateTitle()
        {
            string file;

            if (string.IsNullOrEmpty(fileName))
                file = "Unnamed";
            else
                file = Path.GetFileName(fileName);

            if (isUnsaved)
                Text = file + "* - Notepad";
            else 
                Text = file + " - Notepad";
        }

        private void saveFile()
        {
            File.WriteAllText(fileName, textBox.Text);
            isUnsaved = false;
            updateTitle();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            textBox.Text = string.Empty;
            fileName = null;
            isUnsaved = false;
            updateTitle();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ignoreTextChangeEvent = true;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                fileName = openFileDialog.FileName;
                isUnsaved = false;
                updateTitle();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                }
                else
                    return;
            }

            saveFile();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (ignoreTextChangeEvent)
            {
                ignoreTextChangeEvent = false;
                return;
            }

            isUnsaved = true;
            updateTitle();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUnsaved)
            {
                var dialogResult = MessageBox.Show(this, "Would you like to save changes?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFile();
                }
                else if (dialogResult == System.Windows.Forms.DialogResult.No)
                {  
                    //Do Nothing
                }
                else if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Tobias de Vall", "Notepad About");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fontForm = new Font();

            fontForm.Show();
        }
    }
}
