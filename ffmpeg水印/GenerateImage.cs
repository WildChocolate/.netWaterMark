using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffmpeg水印
{
    public class GenerateImage
    {
        /// <summary>
        /// 生成文字图片
        /// </summary>
        /// <param name="text"></param>
        /// <param name="isBold"></param>
        /// <param name="fontSize"></param>
        public Bitmap CreateImage(string text, Font font, Color color)
        {
            int wid = 400;
            int high = 200;
            //Font font;
            //if (isBold)
            //{
            //    font = new Font("Arial", fontSize, FontStyle.Bold);

            //}
            //else
            //{
            //    font = new Font("Arial", fontSize, FontStyle.Regular);

            //}
            //绘笔颜色
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, color));
            StringFormat format = new StringFormat(StringFormatFlags.NoClip);
            Bitmap image = new Bitmap(wid, high);
            Graphics g = Graphics.FromImage(image);
            SizeF sizef = g.MeasureString(text, font, PointF.Empty, format);//得到文本的宽高
            int width = (int)(sizef.Width +100);
            int height = (int)(sizef.Height +50);
            image.Dispose();
            image = new Bitmap(width, height);
            g = Graphics.FromImage(image);
            g.Clear(Color.Transparent);//透明
            var size = g.MeasureString(text, font);
            RectangleF rect = new RectangleF((width - size.Width)/2, (height-size.Height)/2, width, height);
            //绘制图片
            g.DrawString(text, font, brush, rect);
            //释放对象
            g.Dispose();
            return image;
        }
    }
}
