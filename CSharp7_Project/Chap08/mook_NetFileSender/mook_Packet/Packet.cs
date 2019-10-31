using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mook_Packet
{
    [Serializable]
    public class Packet
    {
        public byte[] Data
        {
            get;
            private set;
        }
        public string FileName
        {
            get;
            private set;
        }
        public int Size
        {
            get;
            private set;
        }
        public string Date
        {
            get;
            private set;
        }
        public Packet(string filename, int filelength, byte[] buf, string date)
        {
            FileName = filename;
            Size = filelength;
            Data = buf;
            Date = date;
        }
    }
}
