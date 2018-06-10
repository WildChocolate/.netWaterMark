namespace ffmpeg水印
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SourceTxt = new System.Windows.Forms.TextBox();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.TargerTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoBtn = new System.Windows.Forms.Button();
            this.HandlerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FormatCombo = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.PosCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.ColorTxt = new System.Windows.Forms.TextBox();
            this.FontTxt = new System.Windows.Forms.TextBox();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.FontBtn = new System.Windows.Forms.Button();
            this.GenImgBtn = new System.Windows.Forms.Button();
            this.OpenDirBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "视频来源";
            // 
            // SourceTxt
            // 
            this.SourceTxt.Location = new System.Drawing.Point(79, 6);
            this.SourceTxt.Name = "SourceTxt";
            this.SourceTxt.Size = new System.Drawing.Size(634, 21);
            this.SourceTxt.TabIndex = 1;
            // 
            // SourceBtn
            // 
            this.SourceBtn.Location = new System.Drawing.Point(719, 4);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(75, 23);
            this.SourceBtn.TabIndex = 2;
            this.SourceBtn.Text = "选择";
            this.SourceBtn.UseVisualStyleBackColor = true;
            this.SourceBtn.Click += new System.EventHandler(this.SourceBtn_Click);
            // 
            // TargerTxt
            // 
            this.TargerTxt.Location = new System.Drawing.Point(79, 50);
            this.TargerTxt.Name = "TargerTxt";
            this.TargerTxt.Size = new System.Drawing.Size(634, 21);
            this.TargerTxt.TabIndex = 4;
            this.TargerTxt.TextChanged += new System.EventHandler(this.TargerTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出目录";
            // 
            // LogoTxt
            // 
            this.LogoTxt.Location = new System.Drawing.Point(79, 105);
            this.LogoTxt.Name = "LogoTxt";
            this.LogoTxt.Size = new System.Drawing.Size(634, 21);
            this.LogoTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "水印图片";
            // 
            // LogoBtn
            // 
            this.LogoBtn.Location = new System.Drawing.Point(719, 103);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoBtn.TabIndex = 9;
            this.LogoBtn.Text = "选择";
            this.LogoBtn.UseVisualStyleBackColor = true;
            this.LogoBtn.Click += new System.EventHandler(this.LogoBtn_Click);
            // 
            // HandlerBtn
            // 
            this.HandlerBtn.Location = new System.Drawing.Point(691, 174);
            this.HandlerBtn.Name = "HandlerBtn";
            this.HandlerBtn.Size = new System.Drawing.Size(103, 93);
            this.HandlerBtn.TabIndex = 10;
            this.HandlerBtn.Text = "处理";
            this.HandlerBtn.UseVisualStyleBackColor = true;
            this.HandlerBtn.Click += new System.EventHandler(this.HandlerBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "转换格式";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormatCombo
            // 
            this.FormatCombo.FormattingEnabled = true;
            this.FormatCombo.Location = new System.Drawing.Point(79, 157);
            this.FormatCombo.Name = "FormatCombo";
            this.FormatCombo.Size = new System.Drawing.Size(121, 20);
            this.FormatCombo.TabIndex = 12;
            // 
            // PosCombo
            // 
            this.PosCombo.FormattingEnabled = true;
            this.PosCombo.Location = new System.Drawing.Point(332, 157);
            this.PosCombo.Name = "PosCombo";
            this.PosCombo.Size = new System.Drawing.Size(121, 20);
            this.PosCombo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "水印位置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "水印文字";
            // 
            // TxtContent
            // 
            this.TxtContent.Location = new System.Drawing.Point(98, 202);
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(355, 21);
            this.TxtContent.TabIndex = 16;
            this.TxtContent.Text = "恒胜旺数码";
            // 
            // ColorTxt
            // 
            this.ColorTxt.Location = new System.Drawing.Point(98, 244);
            this.ColorTxt.Name = "ColorTxt";
            this.ColorTxt.Size = new System.Drawing.Size(118, 21);
            this.ColorTxt.TabIndex = 18;
            // 
            // FontTxt
            // 
            this.FontTxt.Location = new System.Drawing.Point(335, 246);
            this.FontTxt.Name = "FontTxt";
            this.FontTxt.Size = new System.Drawing.Size(118, 21);
            this.FontTxt.TabIndex = 20;
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(16, 242);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(75, 23);
            this.ColorBtn.TabIndex = 21;
            this.ColorBtn.Text = "选择颜色";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontBtn
            // 
            this.FontBtn.Location = new System.Drawing.Point(235, 244);
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(75, 23);
            this.FontBtn.TabIndex = 22;
            this.FontBtn.Text = "设置字体";
            this.FontBtn.UseVisualStyleBackColor = true;
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // GenImgBtn
            // 
            this.GenImgBtn.Location = new System.Drawing.Point(481, 174);
            this.GenImgBtn.Name = "GenImgBtn";
            this.GenImgBtn.Size = new System.Drawing.Size(92, 93);
            this.GenImgBtn.TabIndex = 23;
            this.GenImgBtn.Text = "生成图片";
            this.GenImgBtn.UseVisualStyleBackColor = true;
            this.GenImgBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OpenDirBtn
            // 
            this.OpenDirBtn.Location = new System.Drawing.Point(719, 50);
            this.OpenDirBtn.Name = "OpenDirBtn";
            this.OpenDirBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenDirBtn.TabIndex = 24;
            this.OpenDirBtn.Text = "打开目录";
            this.OpenDirBtn.UseVisualStyleBackColor = true;
            this.OpenDirBtn.Click += new System.EventHandler(this.OpenDirBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 299);
            this.Controls.Add(this.OpenDirBtn);
            this.Controls.Add(this.GenImgBtn);
            this.Controls.Add(this.FontBtn);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.FontTxt);
            this.Controls.Add(this.ColorTxt);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PosCombo);
            this.Controls.Add(this.FormatCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HandlerBtn);
            this.Controls.Add(this.LogoBtn);
            this.Controls.Add(this.LogoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TargerTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SourceBtn);
            this.Controls.Add(this.SourceTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SourceTxt;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.TextBox TargerTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogoBtn;
        private System.Windows.Forms.Button HandlerBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox FormatCombo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox PosCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.TextBox ColorTxt;
        private System.Windows.Forms.TextBox FontTxt;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.Button FontBtn;
        private System.Windows.Forms.Button GenImgBtn;
        private System.Windows.Forms.Button OpenDirBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

