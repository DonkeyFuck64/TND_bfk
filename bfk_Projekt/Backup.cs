using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    public static class Backup
    {
        static public System.IO.DirectoryInfo directoryInfo;

        static public void CreateBackup(string arg)
        {
            directoryInfo = new System.IO.DirectoryInfo(Program.currentFilePath);
            System.IO.FileInfo[] finfo = directoryInfo.GetFiles();
            //Backup vezeichniss
            System.IO.Directory.CreateDirectory(directoryInfo + "\\bfk.exe Backup " + arg);

            var backupDir = new System.IO.DirectoryInfo(directoryInfo + "\\bfk.exe Backup " + arg);

            


           foreach(var s in finfo)
           {
                try
                {

                   string destFile = System.IO.Path.Combine(directoryInfo.ToString(), s.FullName);


                    //Exception
                   System.IO.File.Copy(s.Name, destFile, true);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }
        }
    }
}
