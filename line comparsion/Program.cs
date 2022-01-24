using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_comparsion
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("welcome to linecomparision problems");
            Line_comparision Linecom = new Line_comparision();
            Linecom.length_line();
            Linecom.Comparelines();
            Console.ReadLine();
        }
    }
}
