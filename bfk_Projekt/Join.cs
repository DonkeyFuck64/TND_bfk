using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfk_Projekt
{
    public static class Join
    {
        public static void Joint(string a, string b, string c) { 
        
        var FileOne = System.IO.File.ReadAllText(Program.currentFilePath + "\\" + a);
        var FileTwo = System.IO.File.ReadAllText(Program.currentFilePath + "\\" + b);

        var FinalFile = System.IO.File.CreateText(Program.currentFilePath + "\\" + c);


            //Funktioniert nicht ganz 
        FinalFile.Write(FileOne + FileTwo);
        
        
        }
    }
}
