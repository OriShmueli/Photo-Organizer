using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Photo_Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _repetitiveId;

        private string _getLocation()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }

        private void _checkLocations()
        {
            if (newLocationPhotosLabel.Text != "...")
            {
                if(originalPhotosLocationlabel.Text != "...")
                {
                    if (newLocationPhotosLabel.Text == originalPhotosLocationlabel.Text)
                    {
                        MessageBox.Show("plz select different locations, or choose a location");
                    }
                    else
                    {
                        _unlockRepetitivId();
                    }
                }   
            }
        }

        private void _unlockRepetitivId()
        {
            repetitiveIDPanel.Enabled = true;
        }

        private void _unlockNumbersRegistering()
        {
            numbersInputPanel.Enabled = true;
            
        }

        private void openOriginalFolderButton_Click(object sender, EventArgs e)
        {
            originalPhotosLocationlabel.Text = _getLocation();
            _checkLocations();
        }

        private void openNewSelectedImagesLocationButton_Click(object sender, EventArgs e)
        {
            newLocationPhotosLabel.Text = _getLocation();
            _checkLocations();
        }

        private void repetitiveValueTextBox_MouseLeave(object sender, EventArgs e)
        {
            _unlockNumbersRegistering();
            _repetitiveId = repetitiveValueTextBox.Text;
            //MessageBox.Show(_repetitiveId);
        }

        List<string> filesNames = new List<string>();

        private void _addImageNumber()
        {
            if (string.IsNullOrWhiteSpace(photoNumberTextBox.Text))
            {
                return;
            }
            filesNames.Add(photoNumberTextBox.Text);
            idsListBox.Items.Add(photoNumberTextBox.Text);
            photoNumberTextBox.Clear();
            photoNumberTextBox.Focus();
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            _addImageNumber();
        }

        private void photoNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                _addImageNumber();
                e.Handled = true;
            }
        }

        private void removeNumberButton_Click(object sender, EventArgs e)
        {
            if (idsListBox.Items.Count > 0)
            {
                try
                {
                    MessageBox.Show("removed: " + idsListBox.Items[idsListBox.SelectedIndex].ToString());
                    filesNames.Remove(idsListBox.Items[idsListBox.SelectedIndex].ToString());
                    idsListBox.Items.RemoveAt(idsListBox.SelectedIndex);
                }
                catch
                {
                    MessageBox.Show("plz select the number you want to remove");
                }
            }
                
        }
        
        private void _cleanList()
        {
            idsListBox.Items.Clear();
            repetitiveValueTextBox.Clear();
            photoNumberTextBox.Clear();
            newLocationPhotosLabel.Text = "...";
            originalPhotosLocationlabel.Text = "...";
            _reverseApp();
            _repetitiveId = null;
        }

        private void _reverseApp()
        {
            repetitiveIDPanel.Enabled = false;
            numbersInputPanel.Enabled = false;
            filesNames.Clear();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (idsListBox.Items.Count > 0)
            {
                result = MessageBox.Show("Are you sure you want to delete all the list?", "", buttons);
                if(result == DialogResult.Yes)
                {
                    _cleanList();
                }
                
                if(result == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            string filename;
            string originalPath;
            string newPath;
            StringBuilder str = new StringBuilder();
            //List<string> nun = new List<string>();
            foreach(string num in filesNames)
            {
                try
                {
                    filename = _repetitiveId + num + ".jpg";
                    originalPath = Path.Combine(originalPhotosLocationlabel.Text, filename);
                    newPath = Path.Combine(newLocationPhotosLabel.Text, filename);
                    /*File.Copy(originalPhotosLocationlabel.Text + @"\" + _repetitiveId + num + ".jpg",
                              newLocationPhotosLabel.Text + @"\" + _repetitiveId + num + ".jpg",
                              false);*/
                    File.Copy(originalPath, newPath);
                }
                catch
                {
                    str.AppendLine(num);
                }
            }

            MessageBox.Show(str.ToString() + "\n------\n" + _repetitiveId + filesNames[0] + ".jpg");
            //MessageBox.Show();
        }


    }
}
