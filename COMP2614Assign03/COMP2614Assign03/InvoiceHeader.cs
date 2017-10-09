using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class InvoiceHeader
    {
        private int invoiceNumber;
        private DateTime invoiceDate;
        private int terms;

        public int InvoiceNumber
        {
            get
            {
                return invoiceNumber;
            }
            set
            {
                invoiceNumber = value;
            }
        }
        public DateTime InvoiceDate
        {
            get
            {
                return invoiceDate;
            }
            set
            {
                invoiceDate = value;
            }
        }
        public int Terms
        {
            get
            {
                return terms;
            }
            set
            {
                terms = value;
            }
        }
    }
}
