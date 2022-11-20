namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label inputPanelLabel;
            System.Windows.Forms.Label outputPanelLabel;
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label filenamePrefixLabel;
            System.Windows.Forms.Label filenameSuffixLabel;
            System.Windows.Forms.Label startNumberLabel;
            System.Windows.Forms.Label framerateLabel;
            this.selectSrcLabel = new System.Windows.Forms.Label();
            this.selectSrcButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sortButton = new System.Windows.Forms.Button();
            this.startNumber = new System.Windows.Forms.NumericUpDown();
            this.suffixBox = new System.Windows.Forms.TextBox();
            this.prefixBox = new System.Windows.Forms.TextBox();
            this.filetypeSelect = new System.Windows.Forms.ComboBox();
            this.filteredFilesView = new System.Windows.Forms.ListBox();
            this.totalFileCountLabel = new System.Windows.Forms.Label();
            this.framerate = new System.Windows.Forms.NumericUpDown();
            this.renderButton = new System.Windows.Forms.Button();
            this.filteredImageCount = new System.Windows.Forms.Label();
            inputPanelLabel = new System.Windows.Forms.Label();
            outputPanelLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            filenamePrefixLabel = new System.Windows.Forms.Label();
            filenameSuffixLabel = new System.Windows.Forms.Label();
            startNumberLabel = new System.Windows.Forms.Label();
            framerateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framerate)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanelLabel
            // 
            inputPanelLabel.AutoSize = true;
            inputPanelLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            inputPanelLabel.Location = new System.Drawing.Point(3, 0);
            inputPanelLabel.Name = "inputPanelLabel";
            inputPanelLabel.Size = new System.Drawing.Size(58, 28);
            inputPanelLabel.TabIndex = 2;
            inputPanelLabel.Text = "Input";
            // 
            // outputPanelLabel
            // 
            outputPanelLabel.AutoSize = true;
            outputPanelLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            outputPanelLabel.Location = new System.Drawing.Point(3, 0);
            outputPanelLabel.Name = "outputPanelLabel";
            outputPanelLabel.Size = new System.Drawing.Size(75, 28);
            outputPanelLabel.TabIndex = 3;
            outputPanelLabel.Text = "Output";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new System.Drawing.Point(3, 213);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(61, 15);
            extensionLabel.TabIndex = 6;
            extensionLabel.Text = "Extension:";
            // 
            // filenamePrefixLabel
            // 
            filenamePrefixLabel.AutoSize = true;
            filenamePrefixLabel.Location = new System.Drawing.Point(3, 123);
            filenamePrefixLabel.Name = "filenamePrefixLabel";
            filenamePrefixLabel.Size = new System.Drawing.Size(91, 15);
            filenamePrefixLabel.TabIndex = 7;
            filenamePrefixLabel.Text = "Filename Prefix:";
            filenamePrefixLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // filenameSuffixLabel
            // 
            filenameSuffixLabel.AutoSize = true;
            filenameSuffixLabel.Location = new System.Drawing.Point(0, 184);
            filenameSuffixLabel.Name = "filenameSuffixLabel";
            filenameSuffixLabel.Size = new System.Drawing.Size(91, 15);
            filenameSuffixLabel.TabIndex = 8;
            filenameSuffixLabel.Text = "Filename Suffix:";
            filenameSuffixLabel.Click += new System.EventHandler(this.filenameSuffixLabel_Click);
            // 
            // startNumberLabel
            // 
            startNumberLabel.AutoSize = true;
            startNumberLabel.Location = new System.Drawing.Point(0, 154);
            startNumberLabel.Name = "startNumberLabel";
            startNumberLabel.Size = new System.Drawing.Size(81, 15);
            startNumberLabel.TabIndex = 13;
            startNumberLabel.Text = "Start Number:";
            // 
            // framerateLabel
            // 
            framerateLabel.AutoSize = true;
            framerateLabel.Location = new System.Drawing.Point(15, 120);
            framerateLabel.Name = "framerateLabel";
            framerateLabel.Size = new System.Drawing.Size(63, 15);
            framerateLabel.TabIndex = 16;
            framerateLabel.Text = "Framerate:";
            // 
            // selectSrcLabel
            // 
            this.selectSrcLabel.AutoSize = true;
            this.selectSrcLabel.Location = new System.Drawing.Point(197, 73);
            this.selectSrcLabel.Name = "selectSrcLabel";
            this.selectSrcLabel.Size = new System.Drawing.Size(16, 15);
            this.selectSrcLabel.TabIndex = 1;
            this.selectSrcLabel.Text = "...";
            // 
            // selectSrcButton
            // 
            this.selectSrcButton.Location = new System.Drawing.Point(3, 69);
            this.selectSrcButton.Name = "selectSrcButton";
            this.selectSrcButton.Size = new System.Drawing.Size(188, 23);
            this.selectSrcButton.TabIndex = 0;
            this.selectSrcButton.Text = "Select Folder";
            this.selectSrcButton.UseVisualStyleBackColor = true;
            this.selectSrcButton.Click += new System.EventHandler(this.onFolderSelectChange);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.filteredImageCount);
            this.splitContainer1.Panel1.Controls.Add(this.sortButton);
            this.splitContainer1.Panel1.Controls.Add(this.startNumber);
            this.splitContainer1.Panel1.Controls.Add(this.suffixBox);
            this.splitContainer1.Panel1.Controls.Add(this.prefixBox);
            this.splitContainer1.Panel1.Controls.Add(filenameSuffixLabel);
            this.splitContainer1.Panel1.Controls.Add(filenamePrefixLabel);
            this.splitContainer1.Panel1.Controls.Add(startNumberLabel);
            this.splitContainer1.Panel1.Controls.Add(extensionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.filetypeSelect);
            this.splitContainer1.Panel1.Controls.Add(this.filteredFilesView);
            this.splitContainer1.Panel1.Controls.Add(this.totalFileCountLabel);
            this.splitContainer1.Panel1.Controls.Add(inputPanelLabel);
            this.splitContainer1.Panel1.Controls.Add(this.selectSrcButton);
            this.splitContainer1.Panel1.Controls.Add(this.selectSrcLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.framerate);
            this.splitContainer1.Panel2.Controls.Add(framerateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.renderButton);
            this.splitContainer1.Panel2.Controls.Add(outputPanelLabel);
            this.splitContainer1.Size = new System.Drawing.Size(776, 426);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 1;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(6, 298);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 15;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // startNumber
            // 
            this.startNumber.Location = new System.Drawing.Point(100, 152);
            this.startNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(91, 23);
            this.startNumber.TabIndex = 14;
            // 
            // suffixBox
            // 
            this.suffixBox.Location = new System.Drawing.Point(97, 181);
            this.suffixBox.Name = "suffixBox";
            this.suffixBox.Size = new System.Drawing.Size(94, 23);
            this.suffixBox.TabIndex = 10;
            this.suffixBox.Leave += new System.EventHandler(this.OnPrefixOrSuffixChange);
            // 
            // prefixBox
            // 
            this.prefixBox.Location = new System.Drawing.Point(100, 120);
            this.prefixBox.Name = "prefixBox";
            this.prefixBox.Size = new System.Drawing.Size(91, 23);
            this.prefixBox.TabIndex = 9;
            this.prefixBox.Leave += new System.EventHandler(this.OnPrefixOrSuffixChange);
            // 
            // filetypeSelect
            // 
            this.filetypeSelect.FormattingEnabled = true;
            this.filetypeSelect.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".jpeg"});
            this.filetypeSelect.Location = new System.Drawing.Point(70, 210);
            this.filetypeSelect.Name = "filetypeSelect";
            this.filetypeSelect.Size = new System.Drawing.Size(121, 23);
            this.filetypeSelect.TabIndex = 5;
            this.filetypeSelect.Text = ".png";
            this.filetypeSelect.SelectedIndexChanged += new System.EventHandler(this.extension_SelectedIndexChanged);
            // 
            // filteredFilesView
            // 
            this.filteredFilesView.FormattingEnabled = true;
            this.filteredFilesView.ItemHeight = 15;
            this.filteredFilesView.Location = new System.Drawing.Point(3, 327);
            this.filteredFilesView.Name = "filteredFilesView";
            this.filteredFilesView.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.filteredFilesView.Size = new System.Drawing.Size(322, 94);
            this.filteredFilesView.TabIndex = 4;
            // 
            // totalFileCountLabel
            // 
            this.totalFileCountLabel.AutoSize = true;
            this.totalFileCountLabel.Location = new System.Drawing.Point(3, 95);
            this.totalFileCountLabel.Name = "totalFileCountLabel";
            this.totalFileCountLabel.Size = new System.Drawing.Size(163, 15);
            this.totalFileCountLabel.TabIndex = 3;
            this.totalFileCountLabel.Text = "Total File Count (unfiltered): 0";
            // 
            // framerate
            // 
            this.framerate.Location = new System.Drawing.Point(84, 115);
            this.framerate.Maximum = new decimal(new int[] {
            165,
            0,
            0,
            0});
            this.framerate.Name = "framerate";
            this.framerate.Size = new System.Drawing.Size(91, 23);
            this.framerate.TabIndex = 17;
            this.framerate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(33, 217);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(382, 59);
            this.renderButton.TabIndex = 4;
            this.renderButton.Text = "Do It";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // filteredImageCount
            // 
            this.filteredImageCount.AutoSize = true;
            this.filteredImageCount.Location = new System.Drawing.Point(176, 306);
            this.filteredImageCount.Name = "filteredImageCount";
            this.filteredImageCount.Size = new System.Drawing.Size(149, 15);
            this.filteredImageCount.TabIndex = 16;
            this.filteredImageCount.Text = "Total File Count (filtered): 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "ImageSequenceToMp4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label selectSrcLabel;
        private SplitContainer splitContainer1;
        private Label inputPanelLabel;
        private Label outputPanelLabel;
        private Button renderButton;
        protected Button selectSrcButton;
        private Label totalFileCountLabel;
        private ListBox filteredFilesView;
        private ComboBox filetypeSelect;
        private TextBox suffixBox;
        private TextBox prefixBox;
        private NumericUpDown startNumber;
        private NumericUpDown framerate;
        private Button sortButton;
        private Label filteredImageCount;
    }
}