using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace PCHealth
{
    class Drives
    {

        public static double GetTotalSpace_MB(DriveInfo inf, int precission)
        {
            double freeSpace = inf.TotalSize;
            return Math.Round(freeSpace / 1024 / 1024, precission);
        }

        public static double GetTotalSpace_GB(DriveInfo inf, int precission)
        {
            double freeSpace = inf.TotalSize;
            return Math.Round(freeSpace / 1024 / 1024 / 1024, precission);
        }

        public static double GetFreeSpace_MB(DriveInfo inf, int precission)
        {
            double freeSpace = inf.TotalFreeSpace;
            return Math.Round(freeSpace/1024/1024, precission);
        }

        public static double GetFreeSpace_GB(DriveInfo inf, int precission)
        {
            double freeSpace = inf.TotalFreeSpace;
            return Math.Round(freeSpace / 1024 / 1024/1024, precission);
        }

        public static double GetFreeSpaceOnDriveC_MB(int precission)
        {
            DriveInfo dInfo = new DriveInfo("C");
            return Drives.GetFreeSpace_MB(dInfo, precission);
        }
    }
}
