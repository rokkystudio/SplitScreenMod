using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SplitScreenMod
{
    class Protect
    {
        private static String RegKey = @"SOFTWARE\Microsoft\Protect";

        public static String GenerateID(int length)
        {
            String result = "";
            String pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();

            for (int i= 0; i < length; i++) {
                result += pattern[random.Next(pattern.Length)];
            }

            return result;
        }

        public static String GetAppID()
        {
            String id = null;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(RegKey, false);
            if (key != null)
            {
                object value = key.GetValue("ID");
                if (value != null) {
                    id = value.ToString();
                }
                key.Close();
            }
            
            if (id == null)
            {
                key = Registry.LocalMachine.CreateSubKey(RegKey);
                id = GenerateID(4);
                key.SetValue("ID", id);
                key.Close();
            }

            return id;
        }

        public static DateTime getFirstTime()
        {
            long timestamp = 0;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(RegKey, false);
            
            if (key != null) {
                object value = key.GetValue("Key");
                if (value != null) {
                    timestamp = Int64.Parse(value.ToString());
                }
                key.Close();
            }

            if (timestamp == 0) {
                key = Registry.LocalMachine.CreateSubKey(RegKey);
                timestamp = DateTime.Now.Ticks;
                key.SetValue("Key", timestamp.ToString());
                key.Close();
            }

            return new DateTime(timestamp);
        }
    }
}
