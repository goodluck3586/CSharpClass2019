using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace mook_NetworkChk
{
    public class SoundPlay
    {
        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true)]
        public static extern bool PlaySoundStart(string szSound, System.IntPtr hMod, PlaySoundFlags flags);
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }
    }
}