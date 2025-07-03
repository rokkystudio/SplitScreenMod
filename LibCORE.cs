using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SplitScreenMod
{
    public static class LibCORE
    {
        public const UInt32 MUTEX_DELETE = 0x00010000;
        public const UInt32 MUTEX_READ_CONTROL = 0x00020000;
        public const UInt32 MUTEX_SYNCHRONIZE = 0x00100000;
        public const UInt32 MUTEX_WRITE_DAC = 0x00040000;
        public const UInt32 MUTEX_WRITE_OWNER = 0x00080000;
        public const UInt32 MUTEX_ALL_ACCESS = 0x001F0001;
        public const UInt32 MUTEX_MODIFY_STATE = 0x00000001;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenMutex(uint dwDesiredAccess, bool bInheritHandle, string lpName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseMutex(IntPtr handle);
    }
}
