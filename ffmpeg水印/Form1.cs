using System;
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

namespace ffmpeg水印
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //openFileDialog1.InitialDirectory = @"C:\Users\xuzhicheng\Desktop";

            //folderBrowserDialog1.SelectedPath = @"C:\Users\xuzhicheng\Desktop\CW";
            var pos = new Positions();
            PosCombo.DataSource = pos.WMPositions;
            PosCombo.DisplayMember = "Key";
            PosCombo.ValueMember = "Value";
            BindFormatCombo();
            
        }
        string Source { get; set; }
        string Target { get; set; }
        string Watermark { get; set; }
        public Dictionary<string, string> WMPositions { get; private set; }
        private void BindFormatCombo()
        {
            foreach (var i in Enum.GetNames(typeof(Formats))) {
                FormatCombo.Items.Add(i);
            }
            FormatCombo.SelectedIndex = 0;
        }

        private async void HandlerBtn_Click(object sender, EventArgs e)
        {
            this.HandlerBtn.Enabled = false;
            this.HandlerBtn.Text = "处理中...";
            MessageBox.Show(await AddWaterMarkAsync(Source, Watermark));
            this.HandlerBtn.Enabled = true;
            this.HandlerBtn.Text = "处理";
            Process[] ps = Process.GetProcessesByName("ffmpeg");
            foreach (var p in ps)
            {
                p.Kill();
            }
        }
        private async Task<string> AddWaterMarkAsync(string sourceVideo, string waterMark)
        {
            sourceVideo = SourceTxt.Text;
            if (sourceVideo.Trim() == string.Empty||waterMark==string.Empty)
            {
                MessageBox.Show("请选择源文件");
                return "";
            }
            if (waterMark == string.Empty)
            {
                MessageBox.Show("请选择水印图片");
                return "";
            }
            Target = (TargerTxt.Text+"\\"+DateTime.Now.Ticks + "." + FormatCombo.Text);
            waterMark = LogoTxt.Text;
            //Target = @"C:\Users\xuzhicheng\Desktop\CW\" + DateTime.Now.Ticks + "." + FormatCombo.Text; ;
            ffmpegControl ff = new ffmpegControl();
            var para = "-i {0} -i {1} -filter_complex \"overlay={2}\" -b 1024k -acodec copy {3}";
            para = string.Format(para, sourceVideo, waterMark, PosCombo.SelectedValue, Target);
            ff.FFmpegPath = @"ffmpeg.exe";
            var watermarkTask = Task.Run(() =>
            {
                return ff.RunProcess(para);
            });
            var result = await watermarkTask;
            
            return result;
        }
        private async void SourceBtn_Click(object sender, EventArgs e)
        {
            await DialogOpened("SourceVideos", SourceTxt);
            Source = SourceTxt.Text;
            //Source = SourceTxt.Text.Substring(Environment.CurrentDirectory.Length+1);
        }
        public async Task DialogOpened(string diretory, TextBox txb) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txb.Text = openFileDialog1.FileName;
                return;
                if (openFileDialog1.FileName.StartsWith(Path.GetFullPath(diretory),StringComparison.OrdinalIgnoreCase)) {
                    txb.Text = openFileDialog1.FileName;
                }
                else
                {
                    var fn = openFileDialog1.FileName;
                    var targetFn = diretory + "\\" + fn.Substring(fn.LastIndexOf("\\")+1);
                    FileInfo fi1 = new FileInfo(fn);
                    FileInfo fi2 = new FileInfo(targetFn);

                    using (var fs = new FileStream(fn, FileMode.Open, FileAccess.Read))
                    {
                        if (fi2.Exists)
                        {
                            fi2.Delete();
                        }
                        using (var target = fi2.Create())
                        {
                            await fs.CopyToAsync(target);
                        }
                    }
                    txb.Text = Path.GetFullPath(targetFn);
                }

            }
        }
        

        private async void LogoBtn_Click(object sender, EventArgs e)
        {
            await DialogOpened("WaterMarks", LogoTxt);
            Watermark = LogoTxt.Text;
            //Watermark = LogoTxt.Text.Substring(Environment.CurrentDirectory.Length + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TargerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorTxt.Text = colorDialog1.Color.ToString();
            }
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                FontTxt.Text = fontDialog1.Font.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var color = colorDialog1.Color;
            var font = fontDialog1.Font;
            var txt = TxtContent.Text;
            var gen = new GenerateImage();
            Bitmap img = (Bitmap)gen.CreateImage(txt, font, color);
            var path = Path.GetFullPath("WaterMarks/") + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".png";
            img.Save(path);
        }

        private void OpenDirBtn_Click(object sender, EventArgs e)
        {
            //string v_OpenFolderPath = TargerTxt.Text;
            //System.Diagnostics.Process.Start("explorer.exe", v_OpenFolderPath);   
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TargerTxt.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
