﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
     class UpdateProcessor
     {
        [Obsolete("this method is no longer usable use the DownloadAndInstall Method",false)]
        public static void Download(Update[] updates)
        {
            for(int i=0;i<updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }
        [Obsolete("this method is no longer usable use the DownloadAndInstall Method", false)]

        public static void Install(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }
        public static void DownloadAndInstall(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }
    }
}
