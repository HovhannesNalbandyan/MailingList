using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MailList
{
    class ReadWrite
    {
        public string Emails { get; set; }


        public void Reads()
        {
            string _users = null;
            try
            {
                StreamReader Reader = new StreamReader(Emails);
                while ((_users = Reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(_users))
                    {
                        string Names = _users.Split(new char[] { '<' }, StringSplitOptions.RemoveEmptyEntries)[0];
                        Console.WriteLine(Names);
                    }
                }
                Reader.Close();
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Writes()
        {
            try
            {
                var Writer = new StreamWriter(Emails, true);
                Writer.WriteLine(Console.ReadLine());
                Writer.Close();

            }
            catch (FileNotFoundException Fnot)
            {
                Console.WriteLine(Fnot.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

