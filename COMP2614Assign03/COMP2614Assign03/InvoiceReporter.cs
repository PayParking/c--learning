using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class InvoiceReporter
    {
        private const string INVOICE_NUMBER = "Invoice Number:";
        private const string INVOICE_DATE = "Invoice Date:";
        private const string DISCOUNT_DATE = "Discount Date:";
        private const string TERMS = "Terms:";
        private const double PST = 0.07;
        private const double GST = 0.05;
        public static void Report(List<Invoice> invoice)
        {
            Console.WriteLine("Invoice Listing");
            Console.WriteLine(new String('-', 64));
            foreach (Invoice eachInvoice in invoice) {
             
                Console.WriteLine("");
                Console.WriteLine("{0,-15} {1}", INVOICE_NUMBER, eachInvoice.Header.InvoiceNumber);

                Console.WriteLine("{0,-15} {1}", INVOICE_DATE, eachInvoice.Header.InvoiceDate.ToString("MMM dd, yyyy"));

                int days = eachInvoice.Header.Terms % 100;
                double discountPercent = eachInvoice.Header.Terms / 100;

                Console.WriteLine("{0,-15} {1}", DISCOUNT_DATE, eachInvoice.Header.InvoiceDate.AddDays(days).ToString("MMM dd, yyyy"));
                Console.WriteLine("{0,-15} {1:N2}% {2} days ADI", TERMS, discountPercent, days);
                Console.WriteLine(new String('-', 64));

                Console.WriteLine($"{"Qty"} {"SKU",-11} {"Description",-26} {"Price",-6} {"PST",-10} {"Ext"}");
                Console.WriteLine(new String('-', 64));
                double subTotal = 0.0;
                double gst = 0.0;
                double pst = 0.0;
                double total = 0.0;
                double discount = 0.0;
                Boolean hasPst = false;
                foreach (InvoiceDetail details in eachInvoice.DetailList)
                {
                    double ext = details.Price * details.Quantity;
                    Console.WriteLine($"{details.Quantity,3} {details.Sku,-11} {details.Description,-20} {details.Price,11:N2} {details.Pst,3} {ext,11:N2}");
                    subTotal += ext;
                    if(details.Pst == 'N')
                    {
                        gst += ext * GST;
                    }
                    else 
                    {
                        gst += ext * GST;
                        pst += ext * PST;
                        hasPst = true;
                    }
                }
                Console.WriteLine(new String('-', 64));
                Console.WriteLine("{0,25} {1,38:N2}", "Subtotal:", subTotal);
                Console.WriteLine("{0,20} {1,43:N2}", "GST:", gst);
                if(hasPst)
                {
                    Console.WriteLine("{0,20} {1,43:N2}", "PST:", pst);
                    total = subTotal + gst + pst;
                }
                else
                {
                    total = subTotal + gst;
                }
                Console.WriteLine(new String('-', 64));
                Console.WriteLine("{0,22} {1,41:N2}", "Total:", total);
                Console.WriteLine();
                discount = total * (discountPercent/100);
                Console.WriteLine("{0,25} {1,38:N2}", "Discount:", discount);
                Console.WriteLine();
            }
        }
    }
}
