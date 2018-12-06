using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    class listname
    {
        static public System.IO.DirectoryInfo directoryInfo;

        static public void listAll(string arg)
        {
            directoryInfo = new System.IO.DirectoryInfo(Program.currentFilePath);
            System.IO.FileInfo[] finfo = directoryInfo.GetFiles();
            arg = arg.ToLowerInvariant();


                for (int i = 0; i < finfo.Length; i++)
                {
                    try
                    {

                        string filename = finfo[i].Name.ToLowerInvariant();

                        

                        if (System.IO.Path.GetFileNameWithoutExtension(filename).StartsWith(arg))
                        {

                            Console.WriteLine(" - " + finfo[i].Name);
                  
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);

                    }
                }
        }
    }
}
