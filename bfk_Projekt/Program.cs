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

        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                 return;
            }
            else if (args[0].Equals("list"))
            {

                try
                {
                    list.listAll();

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Parameter ist Invalide.");
                    Console.ReadKey();
                }
            }
            else if (args[0].Equals("listtype"))
            {
                if (!args[1].Equals(""))
                {
                    listtype.listAll(args[1]);
                }
                else
                {
                    Console.WriteLine("Du Pimmelberger");
                    Console.ReadKey();
                }
            }
            else if (args[0].Equals("listname"))
            {
                if (args[1].Equals(""))
                {

                }
            }
            else if (args[0].Equals( "backup"))
            {
                if (args[1].Equals(""))
                {

                }
            }
            else if (args[0].Equals("xml"))
            {
                
            }
            else if (args[0].Equals("join"))
            {
                string[] files = args;
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
