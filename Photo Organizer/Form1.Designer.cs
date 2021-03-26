
namespace Photo_Organizer
{
    partial class Form1
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
            this.openOriginalFolderButton = new System.Windows.Forms.Button();
            this.openNewSelectedImagesLocationButton = new System.Windows.Forms.Button();
            this.newLocationLabel = new System.Windows.Forms.Label();
            this.originalLocationLabel = new System.Windows.Forms.Label();
            this.idsListBox = new System.Windows.Forms.ListBox();
            this.repetitiveLabel = new System.Windows.Forms.Label();
            this.repetitiveValueTextBox = new System.Windows.Forms.TextBox();
            this.photoNumberLabel = new System.Windows.Forms.Label();
            this.photoNumberTextBox = new System.Windows.Forms.TextBox();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.addNumberButton = new System.Windows.Forms.Button();
            this.removeNumberButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.originalPhotosLocationlabel = new System.Windows.Forms.Label();
            this.newLocationPhotosLabel = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.repetitiveIDPanel = new System.Windows.Forms.Panel();
            this.numbersInputPanel = new System.Windows.Forms.Panel();
            this.repetitiveIDPanel.SuspendLayout();
            this.numbersInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openOriginalFolderButton
            // 
            this.openOriginalFolderButton.Location = new System.Drawing.Point(12, 34);
            this.openOriginalFolderButton.Name = "openOriginalFolderButton";
            this.openOriginalFolderButton.Size = new System.Drawing.Size(75, 23);
            this.openOriginalFolderButton.TabIndex = 0;
            this.openOriginalFolderButton.Text = "Choose...";
            this.openOriginalFolderButton.UseVisualStyleBackColor = true;
            this.openOriginalFolderButton.Click += new System.EventHandler(this.openOriginalFolderButton_Click);
            // 
            // openNewSelectedImagesLocationButton
            // 
            this.openNewSelectedImagesLocationButton.Location = new System.Drawing.Point(12, 95);
            this.openNewSelectedImagesLocationButton.Name = "openNewSelectedImagesLocationButton";
            this.openNewSelectedImagesLocationButton.Size = new System.Drawing.Size(75, 23);
            this.openNewSelectedImagesLocationButton.TabIndex = 1;
            this.openNewSelectedImagesLocationButton.Text = "Choose...";
            this.openNewSelectedImagesLocationButton.UseVisualStyleBackColor = true;
            this.openNewSelectedImagesLocationButton.Click += new System.EventHandler(this.openNewSelectedImagesLocationButton_Click);
            // 
            // newLocationLabel
            // 
            this.newLocationLabel.AutoSize = true;
            this.newLocationLabel.Location = new System.Drawing.Point(12, 79);
            this.newLocationLabel.Name = "newLocationLabel";
            this.newLocationLabel.Size = new System.Drawing.Size(200, 13);
            this.newLocationLabel.TabIndex = 2;
            this.newLocationLabel.Text = "The new location of the selected photos:";
            // 
            // originalLocationLabel
            // 
            this.originalLocationLabel.AutoSize = true;
            this.originalLocationLabel.Location = new System.Drawing.Point(12, 18);
            this.originalLocationLabel.Name = "originalLocationLabel";
            this.originalLocationLabel.Size = new System.Drawing.Size(212, 13);
            this.originalLocationLabel.TabIndex = 3;
            this.originalLocationLabel.Text = "Select the location of all the original photos:";
            // 
            // idsListBox
            // 
            this.idsListBox.FormattingEnabled = true;
            this.idsListBox.Location = new System.Drawing.Point(54, 91);
            this.idsListBox.Name = "idsListBox";
            this.idsListBox.Size = new System.Drawing.Size(238, 147);
            this.idsListBox.TabIndex = 4;
            // 
            // repetitiveLabel
            // 
            this.repetitiveLabel.AutoSize = true;
            this.repetitiveLabel.Location = new System.Drawing.Point(3, 3);
            this.repetitiveLabel.Name = "repetitiveLabel";
            this.repetitiveLabel.Size = new System.Drawing.Size(87, 13);
            this.repetitiveLabel.TabIndex = 5;
            this.repetitiveLabel.Text = "Repetitive value:";
            // 
            // repetitiveValueTextBox
            // 
            this.repetitiveValueTextBox.Location = new System.Drawing.Point(97, 3);
            this.repetitiveValueTextBox.Name = "repetitiveValueTextBox";
            this.repetitiveValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.repetitiveValueTextBox.TabIndex = 6;
            this.repetitiveValueTextBox.MouseLeave += new System.EventHandler(this.repetitiveValueTextBox_MouseLeave);
            // 
            // photoNumberLabel
            // 
            this.photoNumberLabel.AutoSize = true;
            this.photoNumberLabel.Location = new System.Drawing.Point(0, 65);
            this.photoNumberLabel.Name = "photoNumberLabel";
            this.photoNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.photoNumberLabel.TabIndex = 7;
            this.photoNumberLabel.Text = "Number:";
            // 
            // photoNumberTextBox
            // 
            this.photoNumberTextBox.Location = new System.Drawing.Point(54, 65);
            this.photoNumberTextBox.Name = "photoNumberTextBox";
            this.photoNumberTextBox.Size = new System.Drawing.Size(238, 20);
            this.photoNumberTextBox.TabIndex = 8;
            this.photoNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.photoNumberTextBox_KeyPress);
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Location = new System.Drawing.Point(0, 91);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(52, 13);
            this.numbersLabel.TabIndex = 9;
            this.numbersLabel.Text = "Numbers:";
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(308, 61);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 10;
            this.addNumberButton.Text = "Add";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // removeNumberButton
            // 
            this.removeNumberButton.Location = new System.Drawing.Point(308, 91);
            this.removeNumberButton.Name = "removeNumberButton";
            this.removeNumberButton.Size = new System.Drawing.Size(75, 23);
            this.removeNumberButton.TabIndex = 11;
            this.removeNumberButton.Text = "Remove";
            this.removeNumberButton.UseVisualStyleBackColor = true;
            this.removeNumberButton.Click += new System.EventHandler(this.removeNumberButton_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(54, 244);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 12;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // originalPhotosLocationlabel
            // 
            this.originalPhotosLocationlabel.AutoSize = true;
            this.originalPhotosLocationlabel.Location = new System.Drawing.Point(94, 43);
            this.originalPhotosLocationlabel.Name = "originalPhotosLocationlabel";
            this.originalPhotosLocationlabel.Size = new System.Drawing.Size(16, 13);
            this.originalPhotosLocationlabel.TabIndex = 13;
            this.originalPhotosLocationlabel.Text = "...";
            // 
            // newLocationPhotosLabel
            // 
            this.newLocationPhotosLabel.AutoSize = true;
            this.newLocationPhotosLabel.Location = new System.Drawing.Point(93, 105);
            this.newLocationPhotosLabel.Name = "newLocationPhotosLabel";
            this.newLocationPhotosLabel.Size = new System.Drawing.Size(16, 13);
            this.newLocationPhotosLabel.TabIndex = 14;
            this.newLocationPhotosLabel.Text = "...";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(308, 121);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 15;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(377, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // repetitiveIDPanel
            // 
            this.repetitiveIDPanel.Controls.Add(this.repetitiveValueTextBox);
            this.repetitiveIDPanel.Controls.Add(this.repetitiveLabel);
            this.repetitiveIDPanel.Enabled = false;
            this.repetitiveIDPanel.Location = new System.Drawing.Point(12, 145);
            this.repetitiveIDPanel.Name = "repetitiveIDPanel";
            this.repetitiveIDPanel.Size = new System.Drawing.Size(200, 53);
            this.repetitiveIDPanel.TabIndex = 18;
            // 
            // numbersInputPanel
            // 
            this.numbersInputPanel.Controls.Add(this.idsListBox);
            this.numbersInputPanel.Controls.Add(this.photoNumberLabel);
            this.numbersInputPanel.Controls.Add(this.progressBar1);
            this.numbersInputPanel.Controls.Add(this.photoNumberTextBox);
            this.numbersInputPanel.Controls.Add(this.cleanButton);
            this.numbersInputPanel.Controls.Add(this.numbersLabel);
            this.numbersInputPanel.Controls.Add(this.addNumberButton);
            this.numbersInputPanel.Controls.Add(this.removeNumberButton);
            this.numbersInputPanel.Controls.Add(this.processButton);
            this.numbersInputPanel.Enabled = false;
            this.numbersInputPanel.Location = new System.Drawing.Point(12, 217);
            this.numbersInputPanel.Name = "numbersInputPanel";
            this.numbersInputPanel.Size = new System.Drawing.Size(387, 308);
            this.numbersInputPanel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 669);
            this.Controls.Add(this.numbersInputPanel);
            this.Controls.Add(this.repetitiveIDPanel);
            this.Controls.Add(this.newLocationPhotosLabel);
            this.Controls.Add(this.originalPhotosLocationlabel);
            this.Controls.Add(this.originalLocationLabel);
            this.Controls.Add(this.newLocationLabel);
            this.Controls.Add(this.openNewSelectedImagesLocationButton);
            this.Controls.Add(this.openOriginalFolderButton);
            this.Name = "Form1";
            this.Text = "Photo Organizer";
            this.repetitiveIDPanel.ResumeLayout(false);
            this.repetitiveIDPanel.PerformLayout();
            this.numbersInputPanel.ResumeLayout(false);
            this.numbersInputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openOriginalFolderButton;
        private System.Windows.Forms.Button openNewSelectedImagesLocationButton;
        private System.Windows.Forms.Label newLocationLabel;
        private System.Windows.Forms.Label originalLocationLabel;
        private System.Windows.Forms.ListBox idsListBox;
        private System.Windows.Forms.Label repetitiveLabel;
        private System.Windows.Forms.TextBox repetitiveValueTextBox;
        private System.Windows.Forms.Label photoNumberLabel;
        private System.Windows.Forms.TextBox photoNumberTextBox;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Button removeNumberButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label originalPhotosLocationlabel;
        private System.Windows.Forms.Label newLocationPhotosLabel;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel repetitiveIDPanel;
        private System.Windows.Forms.Panel numbersInputPanel;
    }
}

