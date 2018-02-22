using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Common
{
    public class ClientCollection : BindingList<Client>
    {
        public decimal TotalYTDSales
        {
            get
            {
                decimal totalYTDsales = 0.0m;
                foreach (Client client in this)
                {
                    totalYTDsales += client.YTDSales;
                }
                return totalYTDsales;
            }
        }

        public int CreditHoldCount
        {
            get
            {
                int creditHoldCount = 0;
                foreach (Client client in this)
                {
                    if (client.CreditHold)
                    {
                        creditHoldCount++;
                    }
                }
                return creditHoldCount;
            }
        }
    }
}
