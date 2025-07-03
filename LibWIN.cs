using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Foundation;

public static class WIN32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT {
        public int Left, Top, Right, Bottom;
    }

    // Объявляют неверным lpRectUpdate, или prgnUpdate (только один не должен быть NULL). Если оба NULL все окно лишено законной силы.
    public const uint RDW_INVALIDATE = 0x0001;

    // Заставляет WM_PAINT сообщение быть посланным к окну независимо от того, содержит ли окно недопустимую область.
    public const uint RDW_INTERNALPAINT = 0x0002;

    // Заставляет окно получать WM_ERASEBKGND сообщение, когда окно повторно окрашено. Флажок RDW_INVALIDATE должен также быть определен иначе RDW_ERASE не имеет никакого эффекта.
    public const uint RDW_ERASE = 0x0004;

    // Проверяет правильность lpRectUpdate, или prgnUpdate (только один должен быть не NULL). Если оба NULL, все окно утверждено. Этот флажок не воздействует на внутренние WM_PAINT сообщения.
    public const uint RDW_VALIDATE = 0x0008;

    // Подавляет любые ждущие обработки внутренние WM_PAINT сообщения. Этот флажок не воздействует на WM_PAINT сообщения, следующие из недопустимых областей.
    public const uint RDW_NOINTERNALPAINT = 0x0010;

    // Подавляет любую задержку WM_ERASEBKGND сообщения.
    public const uint RDW_NOERASE = 0x0020;

    // Исключает дочерние окна, из операции перезакрашивания.
    public const uint RDW_NOCHILDREN = 0x0040;

    // Включает дочерние окна, в операциях перезакрашивания.
    public const uint RDW_ALLCHILDREN = 0x0080;

    // Заставляет воздействующиеся окна (как определено RDW_ALLCHILDREN и флажками RDW_NOCHILDREN) получать WM_NCPAINT, WM_ERASEBKGND, и WM_PAINT сообщения, в случае необходимости, перед возвратом функции.
    public const uint RDW_UPDATENOW = 0x0100;

    // Заставляет воздействующиеся окна (как определено RDW_ALLCHILDREN и флажками RDW_NOCHILDREN) получать WM_NCPAINT и WM_ERASEBKGND сообщения, в случае необходимости, перед возвратом функции. WM_PAINT сообщения отсрочены.
    public const uint RDW_ERASENOW = 0x0200;

    // Заставляет любую часть неклиентской области котороя пересекает область модификации, чтобы получить WM_NCPAINT сообщение. Флажок RDW_INVALIDATE должен также быть определен иначе RDW_FRAME не имеет никакого эффекта.
    public const uint RDW_FRAME = 0x0400;

    // Подавляет любую задержку WM_NCPAINT сообщения. Этот флажок должен использоваться с RDW_VALIDATE и обычно используется с RDW_NOCHILDREN. Эта опция должна использоваться состорожностью, поскольку она может предотвращать Закрашивания части части окна.
    public const uint RDW_NOFRAME = 0x0800;

    private static IntPtr ICON_BIG    = new IntPtr(0);
    private static IntPtr ICON_SMALL  = new IntPtr(1);
    private static IntPtr ICON_SMALL2 = new IntPtr(2);

    private static IntPtr IDI_APPLICATION = new IntPtr(0x7F00);
    private const int GCL_HICON = -14;

    [DllImport("user32.dll")]
    private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);
    public delegate bool EnumWindowsProc(IntPtr handle, IntPtr lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWindow(IntPtr handle);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UpdateWindow(IntPtr handle);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnableWindow(IntPtr handle, bool enable);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool RedrawWindow(IntPtr handle, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, uint flags);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool RedrawWindow(IntPtr handle, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr GetDesktopWindow();

    public const uint WM_GETICON       = 0x007F;
    public const uint WM_ACTIVATE      = 0x0006;
    public const uint WM_MOUSEACTIVATE = 0x0021;

    public const uint MA_NOACTIVATEANDEAT = 0x0004;

    public static IntPtr WA_INACTIVE    = new IntPtr(0);
    public static IntPtr WA_ACTIVE      = new IntPtr(1);
    public static IntPtr WA_CLICKACTIVE = new IntPtr(2);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr SendMessage(IntPtr handle, uint msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr GetWindowDC(IntPtr handle);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr ReleaseDC(IntPtr handle, IntPtr hDC);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr GetWindowRect(IntPtr handle, out RECT rect);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIconName);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, EntryPoint = "GetClassLong")]
    static extern uint GetClassLong32(IntPtr handle, int nIndex);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, EntryPoint = "GetClassLongPtr")]
    static extern IntPtr GetClassLong64(IntPtr handle, int nIndex);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetForegroundWindow(IntPtr handle);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
    private static extern int GetWindowTextLength(IntPtr handle);

    [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern int GetWindowText(IntPtr handle, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern uint GetWindowThreadProcessId(IntPtr handle, out uint processId);

    public static IntPtr HWND_TOPMOST   = new IntPtr(-1);
    public static IntPtr HWND_NOTOPMOST = new IntPtr(-2);
    public static IntPtr HWND_TOP       = new IntPtr(0);
    public static IntPtr HWND_BOTTOM    = new IntPtr(1);

    public const short SWP_NOSIZE     = 0x0001;
    public const short SWP_NOMOVE     = 0x0002;
    public const short SWP_NOZORDER   = 0x0004;
    public const int   SWP_SHOWWINDOW = 0x0040;

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, EntryPoint = "SetWindowPos")]
    public static extern IntPtr SetWindowPos(IntPtr handle, IntPtr handleAfterInsert, int x, int y, int cx, int cy, int wFlags);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public extern static IntPtr SetActiveWindow(IntPtr handle);

    public static List<IntPtr> FindWindows()
    {
        List<IntPtr> result = new List<IntPtr>();

        EnumWindows(delegate (IntPtr handle, IntPtr param) {
            result.Add(handle);
            return true;
        }, IntPtr.Zero);

        return result;
    }

    private static IntPtr GetClassLongPtr(IntPtr handle, int nIndex)
    {
        if (IntPtr.Size == 4)
            return new IntPtr((long) GetClassLong32(handle, nIndex));
        else
            return GetClassLong64(handle, nIndex);
    }

    public static String GetWindowTitle(IntPtr handle)
    {
        int length = GetWindowTextLength(handle);
        StringBuilder builder = new StringBuilder(length + 1);
        int size = GetWindowText(handle, builder, builder.Capacity);
        return (size == 0) ? "" : builder.ToString();
    }

    public static Image GetWindowIcon(IntPtr handle)
    {
        try
        {
            IntPtr hIcon = IntPtr.Zero;
            hIcon = SendMessage(handle, WM_GETICON, ICON_BIG, IntPtr.Zero);

            if (hIcon == IntPtr.Zero)
                hIcon = GetClassLongPtr(handle, GCL_HICON);

            if (hIcon == IntPtr.Zero)
                hIcon = LoadIcon(IntPtr.Zero, IDI_APPLICATION);

            if (hIcon != IntPtr.Zero)
                return new Bitmap(Icon.FromHandle(hIcon).ToBitmap(), 32, 32);
            else
                return null;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static int GetProcessID(IntPtr handle)
    {
        uint pid = 0;
        GetWindowThreadProcessId(handle, out pid);
        if (pid == 0) return 0;
        return (int) pid;
    }

    public static String GetProcessFilename(int pid)
    {
        try
        {
            Process process = Process.GetProcessById(pid);
            return process.MainModule.FileName;
        }
        catch (Exception)
        {
            return "";
        }
    }

    public static Image GetProcessIcon(IntPtr handle)
    {
        Image empty = new Bitmap(16, 16, PixelFormat.Format32bppArgb);

        int pid = GetProcessID(handle);
        if (pid == 0) return empty;

        String filename = GetProcessFilename(pid);
        if (filename == null) return empty;

        try {
            Icon icon = Icon.ExtractAssociatedIcon(filename);
            if (icon == null) return empty;
            return icon.ToBitmap();
        } catch (Exception) {
            return empty;
        }
    }

    public static Image GetWindowCapture(IntPtr handle)
    {
        RECT windowRect;
        GetWindowRect(handle, out windowRect);
        int width = windowRect.Right - windowRect.Left;
        int height = windowRect.Bottom - windowRect.Top;
        if (width <= 1 || height <= 1) return null;

        IntPtr hdcSrc = GetWindowDC(handle);
        IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
        IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
        if (hdcSrc == IntPtr.Zero || hdcDest == IntPtr.Zero || hBitmap == IntPtr.Zero) return null;

        IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap); // select the bitmap object
        if (hOld == IntPtr.Zero) return null;

        GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY); // bitblt over
        GDI32.SelectObject(hdcDest, hOld); // restore selection
        GDI32.DeleteDC(hdcDest); // clean up
        ReleaseDC(handle, hdcSrc);

        Image image = Image.FromHbitmap(hBitmap);
        GDI32.DeleteObject(hBitmap);

        return image;
    }

    public static Image GetDesktopCapture()
    {
        return GetWindowCapture(GetDesktopWindow());
    }

    public static void DrawRect(IntPtr handle, int border)
    {
        RECT rect = new RECT();
        GetWindowRect(handle, out rect);

        IntPtr hDC = GetWindowDC(handle);
        if (hDC == IntPtr.Zero) return;

        using (Pen pen = new Pen(Color.Red, border))
        {
            using (Graphics graphics = Graphics.FromHdc(hDC))
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = rect.Right - rect.Left;
                rectangle.Height = rect.Bottom - rect.Top;
                rectangle.Inflate(-border, -border);
                graphics.DrawRectangle(pen, rectangle);
            }
        }

        ReleaseDC(handle, hDC);
    }
}