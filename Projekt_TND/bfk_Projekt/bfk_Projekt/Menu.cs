using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    static class Menu
    {

        public static void Menue()
        {
            try
            {
                using (StreamReader sr = new StreamReader("dir\\Testfile.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    Console.ReadKey();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}

