using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExelFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing ExelFile");
        }

        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report...");
        }
    }
}
