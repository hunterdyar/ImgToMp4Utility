using FFMpegCore;
using System.Data.Common;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string inputPath;
        private string[] filesUnfiltered;
        private string selectedExtension;
        private int startingValue;
        private readonly List<InputImage> images = new List<InputImage>();
        public Form1()
        {
            InitializeComponent();
            filetypeSelect.SelectedIndex = 0;
            selectedExtension = filetypeSelect.Text.ToString();
            filteredFilesView.DataSource = images;
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

            if (filesUnfiltered != null)
            {
                foreach (var file in filesUnfiltered)
                {
                    var f = new InputImage(file);
                    if(f.HasExtension(selectedExtension))
                    {
                       
                        if(f.UpdateNumber(suffixBox.Text,prefixBox.Text, out var number))
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

        private void OnPrefixOrSuffixChange(object sender, EventArgs e)
        {
            CalculateFiltered();
        }

        private void UpdateFilterDisplayInfo()
        {
            filteredFilesView.DataSource = images;//rebind
            //filteredFilesView.Data
            int numberFiles = 0;
            if(filesUnfiltered != null)
            {
                numberFiles = filesUnfiltered.Length;
            }
            totalFileCountLabel.Text = $"Total File Count(unfiltered): {numberFiles}";
            filteredImageCount.Text = $"Total File Count(filtered): {images.Count}";
            filetypeSelect.Text = selectedExtension;
            foreach(var image in images)
            {
                image.UpdateNumber(prefixBox.Text, suffixBox.Text, out var n);
            }
        }

        private void extension_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedExtension = filetypeSelect.Text.ToString();
            CalculateFiltered();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filenameSuffixLabel_Click(object sender, EventArgs e)
        {

        }

        private async void renderButton_Click(object sender, EventArgs e)
        {
            var imageInfos = new List<ImageInfo>();
            foreach(var item in images)
            {
                imageInfos.Add(ImageInfo.FromPath(item.FullPath));
            }
            if(images.Count > 0)
            {
                FFMpeg.JoinImageSequence(inputPath + "/output.mp4", frameRate: (int)framerate.Value, imageInfos.ToArray());
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
       
    }
}