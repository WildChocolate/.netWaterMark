using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffmpeg水印
{
    public class Corner
    {
        public Corner(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
        public string key { get; set; }
        public string value { get; set; }
    }
    public class Positions : IEnumerable<Corner>
    {
        
        public List<Corner> WMPositions { get; set; }
        public Positions()
        {
            if (WMPositions == null)
                WMPositions = new List<Corner>();
            WMPositions.Add(new Corner("左上角", "10:10"));
            WMPositions.Add(new Corner("右上角", "main_w-overlay_w-10:10"));
            WMPositions.Add(new Corner("左下角", "10:main_h-overlay_h-10"));
            WMPositions.Add(new Corner("右下角", "main_w-overlay_w-10:main_h-overlay_h-10"));
        }
        public IEnumerator<Corner> GetEnumerator()
        {
            return WMPositions.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
