using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            args[0] = "list";
            if(args.Length < 1)
            {
                 return;
            }
            else if (args[0].Equals("list"))
            {
                try
                {
                    string arg = args[1];
                    list.listAll(arg);

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Parameter ist Invalide.");
                }
            }
            else if (args[0].Equals("listtype"))
            {
                if (args[1].Equals(""))
                {

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


            

        }
    }
}
