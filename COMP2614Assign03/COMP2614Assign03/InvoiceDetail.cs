using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    class InvoiceDetail
    {
        private int quantity;
        private string sku;
        private string description;
        private double price;
        private char pst;

        public InvoiceDetail(int quantity, string sku, string description, double price, char pst)
        {
            this.quantity = quantity;
            this.sku = sku;
            this.description = description;
            this.price = price;
            this.pst = pst;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string Sku
        {
            get
            {
                return sku;
            }
            set
            {
                sku = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public char Pst
        {
            get
            {
                return pst;
            }
            set
            {
                pst = value;
            }
        }
    }
}
