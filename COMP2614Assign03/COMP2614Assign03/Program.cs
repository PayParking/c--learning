using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path;
                if (args.Length > 0 && args != null)
                {
                    path = args[0];
                    InvoiceReporter.Report(new InvoiceReader().Reader(path));
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
            }
            
        }
    }
}
