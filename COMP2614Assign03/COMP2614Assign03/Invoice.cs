using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class Invoice
    {
        private InvoiceHeader header;
        private List<InvoiceDetail> detailList;

        public Invoice()
        {
            header = new InvoiceHeader();
            detailList = new List<InvoiceDetail>();
        }

        public InvoiceHeader Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
        public List<InvoiceDetail> DetailList
        {
            get
            {
                return detailList;
            }
        }

      

    }
}
