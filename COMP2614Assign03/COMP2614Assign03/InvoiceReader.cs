using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace COMP2614Assign03
{
    class InvoiceReader
    {

        private StreamReader streamReader;
        
        /// <summary>
        /// Read 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<Invoice> Reader(string path)
        {
            string line;
            string[] buf;
            string[] data;
            List<Invoice> invoiceList = new List<Invoice>();
            try
            {
                streamReader = new StreamReader(path);
                while (streamReader.Peek() > 0)
                {
                    line = streamReader.ReadLine();
                    buf = line.Split('|');

                    data = buf[0].Split(':');
                
                    Invoice invoice = new Invoice { Header = new InvoiceHeader { InvoiceNumber = int.Parse(data[0]), InvoiceDate = DateTime.Parse(data[1]), Terms = int.Parse(data[2]) } };
                    for(int i = 1; i < buf.Length; i++)
                    {
                        data = buf[i].Split(':');
                        invoice.DetailList.Add(new InvoiceDetail(int.Parse(data[0]), data[1], data[2], double.Parse(data[3]), char.Parse(data[4])));
                    }
                    invoiceList.Add(invoice);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                streamReader.Close();
            }
            return invoiceList;
        }


    }
}
