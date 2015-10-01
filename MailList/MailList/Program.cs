using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite a = new ReadWrite() { Emails = @"C:\Users\HovArp\Documents\Visual Studio 2015\Projects\EmailList\MailingList.txt" };
            a.Reads();
            a.Writes();

            Console.ReadKey();
        }
    }
}
