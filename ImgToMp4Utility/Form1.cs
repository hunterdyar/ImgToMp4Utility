using FFMpegCore;
using System.Data.Common;
using System.Windows.Forms;

namespace ImgToMp4Utility
{
    public partial class Form1 : Form
    {
        private string inputPath;
        private string outputPath;
        private string[] filesUnfiltered;
        private string selectedExtension;
        private int startingValue;
        private readonly List<InputImage> images = new List<InputImage>();
        public Form1()
        {
            inputPath = "";
            outputPath = "";//load previous?
            filesUnfiltered = new string[0]; 
            InitializeComponent();
            filetypeSelect.SelectedIndex = 0;
            selectedExtension = filetypeSelect.Text.ToString();
            //filteredFilesView.DisplayMember = "Name";
            //filteredFilesView.ValueMember = "Number";
            CalculateFiltered();
        }

        private void onFolderSelectChange(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filesUnfiltered = Directory.GetFiles(fbd.SelectedPath);
                    inputPath = fbd.SelectedPath;
                    selectSrcLabel.Text = fbd.SelectedPath;//todo: replace with data binding
                    CalculateFiltered();
                }
            }
        }

        private void CalculateFiltered()
        {
            images.Clear();
            //update list

            startingValue = (int)startNumber.Value;

            if (filesUnfiltered != null)
            {
                foreach (var file in filesUnfiltered)
                {
                    var f = new InputImage(file);
                    if (f.HasExtension(selectedExtension))
                    {
                        if (f.UpdateNumber(prefixBox.Text, suffixBox.Text, out var number))
                        {
                            if (number >= startingValue)
                            {
                                images.Add(f);
                            }
                        }
                    }

                    //ffmpeg - i image-%03d.png video.webm
                }
            }

            UpdateFilterDisplayInfo();
        }

        private void OnNeedRecalculation(object sender, EventArgs e)
        {
            CalculateFiltered();
        }

        private void UpdateFilterDisplayInfo()
        {
            filteredFilesView.Items.Clear();
            filteredFilesView.Items.AddRange(images.ToArray());

            //filteredFilesView.Data
            int numberFiles = 0;
            if (filesUnfiltered != null)
            {
                numberFiles = filesUnfiltered.Length;
            }
            totalFileCountLabel.Text = $"Total File Count(unfiltered): {numberFiles}";
            filteredImageCount.Text = $"Total File Count(filtered): {images.Count}";
            filetypeSelect.Text = selectedExtension;
            foreach (var image in images)
            {
                image.UpdateNumber(prefixBox.Text, suffixBox.Text, out var n);
            }
        }

        private void extension_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedExtension = filetypeSelect.Text.ToString();
            CalculateFiltered();
        }

        private void renderButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(outputPath))
            {
                //report: no output path selected.
                return;
            }

            var imageInfos = new List<ImageInfo>();
            foreach (var item in images)
            {
                imageInfos.Add(ImageInfo.FromPath(item.FullPath));
            }
            if (images.Count > 0)
            {
                FFMpeg.JoinImageSequence(outputPath, frameRate: (int)framerate.Value, imageInfos.ToArray());
            }
            else
            {
                //report: No images!
            }
        }


        private void sortButton_Click(object sender, EventArgs e)
        {
            //todo: need a class that
            //holds name, holds path, is sortbale, 

            images.Sort((a, b) =>
            {
                return b.Number - a.Number;
            });
        }

        private void selectOutputFileButton_Click(object sender, EventArgs e)
        {

            DialogResult result = chooseOutputSaveFileDialogue.ShowDialog();

            if (result == DialogResult.OK)
            {
                outputPath = chooseOutputSaveFileDialogue.FileName;
                outputPathLabel.Text = outputPath;
            }
            else
            {
                //todo: put error
            }

        }
    }
}