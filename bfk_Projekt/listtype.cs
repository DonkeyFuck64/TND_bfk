﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    static class listtype
    {
        static public System.IO.DirectoryInfo directoryInfo;

        static public void listAll(string arg)
        {
            directoryInfo = new System.IO.DirectoryInfo(Program.currentFilePath); 
            System.IO.FileInfo[] finfo = directoryInfo.GetFiles(); 

    
                for (int i = 0; i < finfo.Length; i++)                
                {
                    try
                    {
                        if (System.IO.Path.GetExtension(finfo[i].Name).Equals("." + arg))
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
