using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    static class Program
    {
        public static string currentFilePath =  Directory.GetCurrentDirectory();

        static void Main(string[]  args)
        {
            if(args.Length < 1)
            {
                 return;
            }
            else if (args[0].Equals("list"))
            {

                try
                {
                    list.listAll(true);

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Parameter ist Invalide.");
                    Console.ReadKey();
                }
            }
            else if (args[0].Equals("listtype"))
            {
                if (args.Length == 2)
                {
                    listtype.listAll(args[1]);
                    
                }
                else if (args.Length == 1)
                {
                    list.listAll(false);
                }
                else
                {
                    Console.WriteLine("Parameter ist Invalide.");
                    Console.ReadKey();
                }

                
            }
            else if (args[0].Equals("listname"))
            {
                if (args.Length == 2)
                {
                    listname.listAll(args[1]);

                }
                else if (args.Length == 1)
                {
                    list.listAll(false);
                }
                else
                {
                    Console.WriteLine("Parameter ist Invalide.");
                    Console.ReadKey();
                }
            }
            else if (args[0].Equals( "backup"))
            {
                if (args[1].Equals(""))
                {
                    Console.WriteLine("Parameter ist Invalide.");
                }
                else
                {
                    Backup.CreateBackup(args[1]);
                }
            }
            else if (args[0].Equals("xml"))
            {
                
            }
            else if (args[0].Equals("Join"))
            {
                string[] files = args;
                if (args[1].Equals("") || args[2].Equals("") || args[3].Equals(""))
                {
                    Console.WriteLine("Parameter ist Invalide.");
                }
                else
                {
                    Join.Joint(args[1], args[2], args[3]);
                }
            }
            else if (args[0].Equals("attrib"))
            {
                string[] files = args;
            }
            else if (args[0].Equals("rename"))
            {
                string[] files = args;
            }
            else if (args[0] .Equals("find txt"))
            {
                string[] files = args;
            }
            else if (args[0].Equals("censorship"))
            {
                string[] files = args;
            }



            Console.ReadKey();
        
        
        
        }
    }
}
