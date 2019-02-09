using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\Linara\Desktop\PP2\Week 2\Task4\topic.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(file);
            sr.WriteLine("Hello");
            sr.Close();
            file.Close();
            File.Copy(@"C:\Users\Linara\Desktop\PP2\Week 2\Task4\topic.txt", @"C:\Users\Linara\Desktop\PP2\Week 2\Task4\Task4\topic.txt");

            File.Delete(@"C:\Users\Linara\Desktop\PP2\Week 2\Task4\topic.txt");
        }
    }
}
