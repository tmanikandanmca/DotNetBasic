     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DotNetBasic
{
    internal static class TestFileInfo
    { 

        public static void Filedetails(string fileName)
        {
            FileInfo f1= new FileInfo(fileName);
            f1.Create();
            f1.Delete();
            

        }


    }
}
