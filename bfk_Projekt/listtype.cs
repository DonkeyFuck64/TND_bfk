using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    static class listtype
    {
        public static void listAll(string arg)
        {
            System.IO.DirectoryInfo directoryInfo;

            directoryInfo = new System.IO.DirectoryInfo(Program.currentFilePath);
            System.IO.DirectoryInfo[] dirInfo = directoryInfo.GetDirectories();
            System.IO.FileInfo[] finfo = directoryInfo.GetFiles(arg);
            for (int i = 0; i < dirInfo.Length; i++)
            {
                Console.WriteLine("" + dirInfo[i].Name);
            }
            for (int i = 0; i < finfo.Length; i++)                
                {
                    try
                    {
                        if (System.IO.Path.GetExtension(finfo[i].Name).Equals("." + arg))
                        {
                            Console.WriteLine("--- " + finfo[i].Name);
                        }

                    }catch(Exception e){
                        Console.WriteLine(e);
                       
                    }
                }//end of for
        }
    }
}
