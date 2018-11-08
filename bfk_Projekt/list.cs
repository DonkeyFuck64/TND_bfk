using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bfk_Projekt
{
    class list
    {
        public static void listAll(string arg)
        {


            var files = from retrievedFile in Directory.EnumerateFiles("dir//", "*.txt", SearchOption.AllDirectories)
                        from line in File.ReadLines(retrievedFile)
                        where line.Contains("Example")
                        select new
                        {
                            File = retrievedFile,
                            Line = line
                        };

            foreach (var f in files)
            {
                Console.WriteLine("{0} contains {1}", f.File, f.Line);
            }
            Console.WriteLine("{0} lines found.", files.Count().ToString());
        }
    }
}

