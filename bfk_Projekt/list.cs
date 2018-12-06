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

        public static void listAll(bool dir )
        {
            System.IO.DirectoryInfo directoryInfo;

            directoryInfo = new System.IO.DirectoryInfo(Program.currentFilePath); 
            System.IO.DirectoryInfo[] dirInfo = directoryInfo.GetDirectories(); 
            System.IO.FileInfo[] finfo = directoryInfo.GetFiles();

            if (dir == true)
            {
                for (int i = 0; i < dirInfo.Length; i++)
                {
                    Console.WriteLine("<dir>  " + dirInfo[i].Name);
                }
                Console.WriteLine("\n----------------------------------------------\n");
                Console.WriteLine("File: \n");
                for (int i = 0; i < finfo.Length; i++)
                {
                    Console.WriteLine(" - " + finfo[i].Name);
                }
            }
            else if (dir == false)
            {
                for (int i = 0; i < finfo.Length; i++)
                {
                    Console.WriteLine(" - " + finfo[i].Name);
                }
            }
            else
            {
                Console.WriteLine("Irgend etwas ist schief gelaufen keine Ahnung diggi.");
            }
        }
    }
}

