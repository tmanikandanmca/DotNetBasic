using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DotNetBasic
{
    internal static class DirectoryInformation
    {

        // 1. GetFilefrom directory
        // 2. txt
        // 3. filedetails 

        public static void GetAllfileInFolder(string Path)
        {
            DirectoryInfo dirc = new DirectoryInfo(Path);
            dirc.Create();
            {
                Console.WriteLine("Folder Created");
            }

        }


        public static void GetfileInFolder(string Path)
        {
            DirectoryInfo re = new DirectoryInfo(Path);
            re.Delete();
            if (Directory.Exists(Path))
            {
                var filedetails = re.GetFiles("css");
                foreach (var file in filedetails)
                {
                    Console.WriteLine(file.Name);
                }
            }
        }

    }
}
