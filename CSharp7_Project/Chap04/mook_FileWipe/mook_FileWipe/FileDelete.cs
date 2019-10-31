using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace mook_FileWipe
{
    class FileDelete
    {
        FileInfo fi = null;
        FileStream fs = null;
        byte[] ByteArray = null;
        public FileDelete(string FilePath)
        {
            fi = new FileInfo(FilePath);
        }
        public delegate void ProcessEventHandler(int Current);
        public event ProcessEventHandler runPer;
        public void British_HMG_IS5_BaseLine(string FilePath)
        {
            try
            {
                ByteArray = new byte[fi.Length];
                runPer(0);
                Application.DoEvents();
                for (int i = 0; i < fi.Length; i++)
                {
                    ByteArray[i] = 0x0;
                    runPer((int)(((float)i / (float)(fi.Length - 1.0)) * 100.0));
                }
                RunBuffer(FilePath, ByteArray);
                fi.Delete();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void British_HMG_IS5_Enhanced(string FilePath)
        {
            try
            {
                ByteArray = new byte[fi.Length];
                runPer(0);
                Application.DoEvents();
                int n = 0;
                for (int c = 1; c < 4; c++)
                {
                    switch (c)
                    {
                        case 1:
                            for (int i = 0; i < fi.Length; i++)
                            {
                                ByteArray[i] = 0x0;
                                runPer((int)(((float)n / (float)((fi.Length - 1.0) * 3.0)) * 100.0));
                                n++;
                            }
                            RunBuffer(FilePath, ByteArray);
                            ByteArray = new byte[fi.Length];
                            break;
                        case 2:
                            for (int i = 0; i < fi.Length; i++)
                            {
                                ByteArray[i] = 0x0;
                                runPer((int)(((float)n / (float)((fi.Length - 1.0) * 3.0)) * 100.0));
                                n++;
                            }
                            RunBuffer(FilePath, ByteArray);
                            ByteArray = new byte[fi.Length];
                            break;
                        case 3:
                            switch (RandomBuffer(n))
                            {
                                case true:
                                    break;
                            }
                            RunBuffer(FilePath, ByteArray);
                            ByteArray = new byte[fi.Length];
                            break;
                    }
                }
                fi.Delete();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RunBuffer(string FilePath, byte[] Buffer)
        {
            fs = new FileStream(FilePath, FileMode.Open,
                FileAccess.Write, FileShare.None);
            fs.Write(Buffer, 0, Buffer.Length);
            fs.Flush();
            fs.Close();
        }
        private bool RandomBuffer(int n)
        {
            ByteArray = new byte[fi.Length];
            Application.DoEvents();
            for (int i = 0; i < fi.Length; i++)
            {
                ByteArray[i] = RandomByte();
                runPer((int)(((float)n / (float)((fi.Length - 1.0) * 3.0)) * 100.0));
                n++;
            }
            return true;
        }
        private byte RandomByte()
        {
            byte Minimo = 0;
            byte maximo = 255;
            Random Rnd = new Random();
            byte ResultRnd = (byte)(Rnd.Next(Minimo, maximo));
            return ResultRnd;
        }
    }
}
