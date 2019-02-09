using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpace(int lvl) //function for spaces each time it gets into directory it tabs two spaces
        {
            for (int i = 0; i < lvl; i++)
                Console.Write(" ");
        }
        static void DirectoryTree(DirectoryInfo dir,int lvl) //
        {
            FileInfo[] files = dir.GetFiles(); //open in an array for files in directory
            DirectoryInfo[] dirs = dir.GetDirectories(); // open in an array for directories 
            foreach(DirectoryInfo direct in dirs) //for each index creates its own variable 
            {
                PrintSpace(lvl); //functon for spaces
                Console.WriteLine(direct.Name);// output of files and directories
                DirectoryTree(direct, lvl + 1);//recursion for directories 
                                               //adds space from function lvl each time when opens new directory
            }
 
        }
        static void Main(string[] args)
        {
            DirectoryInfo doc = new DirectoryInfo(@"C:\Users\Linara\Desktop\PP2"); //gives information of the directories
            DirectoryTree(doc, 0); //recurssion of the directories
            Console.ReadKey();
        }
    }
}
