using BusinessLibrary.Common;
using BusinessLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLibrary.Business
{
    public class ClientValidation
    {
        private static List<string> errors;

        static ClientValidation()
        {
            errors = new List<string>();
        }

        public static ClientCollection GetAllClients() => ClientRepository.GetAllClients();

        public static int AddClient(Client client)
        {
            if (Validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return -1;
            }
        }

        public static int UpdateClient(Client client)
        {
            if (Validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }

        public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);

        private static bool Validate(Client client)
        {
            bool success = true;
            errors.Clear();

            string clientCodePattern = @"^[A-Z][A-Z][A-Z][A-Z][A-Z]$";
            string provincePattern = @"^[A-Z][A-Z]$";
            string postalCodePattern = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";

            if (!Regex.IsMatch(client.ClientCode, clientCodePattern))
            {
                errors.Add("ClientCode must be filled or in form AAAAA");
                success = false;
            }
            if(string.IsNullOrWhiteSpace(client.CompanyName))
            {
                errors.Add("CompanyName must be filled");
                success = false;
            }
            if (string.IsNullOrWhiteSpace(client.Address1)) 
            {
                errors.Add("Address1 must be filled");
                success = false;
            }
            if(!Regex.IsMatch(client.Province, provincePattern))
            {
                errors.Add("Province must be filled or in form AA");
                success = false;
            }
            if(!Regex.IsMatch(client.PostalCode, postalCodePattern))
            {
                errors.Add("Postal Code must be filled or in form A9A 9A9");
                success = false;
            }
            if(client.YTDSales < 0.00m)
            {
                errors.Add("YTDSales cannot be less than 0");
                success = false;
            }
            return success;
        }
        public static string ErrorMessage
        {
            get
            {
                string message = "";
                foreach(string line in errors)
                {
                    message += line + "\r\n";
                }
                return message;
            }
        }
    }
}
