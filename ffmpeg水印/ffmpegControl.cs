using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffmpeg水印
{
    public class ffmpegControl
    {
        /// <summary>
        /// 视频处理器ffmpeg.exe的位置
        /// </summary>
        public string FFmpegPath { get; set; }

        /// <summary>
        /// 调用ffmpeg.exe 执行命令
        /// </summary>
        /// <param name="Parameters">命令参数</param>
        /// <returns>返回执行结果</returns>
        public string RunProcess(string Parameters)
        {
            //创建一个ProcessStartInfo对象 并设置相关属性
            var oInfo = new ProcessStartInfo(FFmpegPath, Parameters);
            oInfo.UseShellExecute = false;
            oInfo.CreateNoWindow = true;
            oInfo.RedirectStandardOutput = true;
            oInfo.RedirectStandardError = true;
            oInfo.RedirectStandardInput = true;

            //创建一个字符串和StreamReader 用来获取处理结果
            string output = null;
            StreamReader srOutput = null;

            try
            {
                //调用ffmpeg开始处理命令
                var proc = Process.Start(oInfo);

                //proc.WaitForExit();


                //获取输出流
                srOutput = proc.StandardError;

                //转换成string
                output = srOutput.ReadToEnd();

                //关闭处理程序
                proc.Close();
            }
            catch (Exception)
            {
                output = string.Empty;
            }
            finally
            {
                //释放资源
                if (srOutput != null)
                {
                    srOutput.Close();
                    srOutput.Dispose();
                }
            }
            return output;
        }
    }
}
