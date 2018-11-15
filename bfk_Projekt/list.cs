using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bfk_Projekt
{
    public class list
    {

        public static void listAll()
        {
            System.IO.DirectoryInfo directoryInfo;

            directoryInfo = new System.IO.DirectoryInfo(Program.currentFilePath); 
            System.IO.DirectoryInfo[] dirInfo = directoryInfo.GetDirectories(); 
            System.IO.FileInfo[] finfo = directoryInfo.GetFiles();
            for (int i = 0; i < dirInfo.Length; i++)
            {         
                Console.WriteLine("<dir> " + dirInfo[i].Name);  
            }
            for (int i = 0; i < finfo.Length; i++)               
            {
                Console.WriteLine("--- " + finfo[i].Name);          
            }
        }
    }
}

