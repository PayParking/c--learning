using BusinessLibrary.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Data
{
    public class ClientRepository
    {
        private static string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                             Initial Catalog=mc1730;
                                             User ID=student;
                                             Password=93nu5#S163;
                                             Encrypt=True;
                                             TrustServerCertificate=False;
                                             Connection Timeout=30;";

        public static int AddClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO Client869963
                                (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                                 VALUES (@clientCode, @companyName, @address1, @address2, @city, @province, @postalCode, @YTDsales, @creditHold, @notes)";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    
                    if (client.ClientCode != null)
                    {
                        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@clientCode", DBNull.Value);
                    }

                    if (client.CompanyName != null)
                    {
                        cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@companyName", DBNull.Value);
                    }

                    if (client.Address1 != null)
                    {
                        cmd.Parameters.AddWithValue("@address1", client.Address1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address1", DBNull.Value);
                    }

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }
                    if (client.Province != null)
                    {
                        cmd.Parameters.AddWithValue("@province", client.Province);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@province", DBNull.Value);
                    }
                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@YTDsales", client.YTDSales);
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }   
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }
                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;

                    
                }
            }
        }

        public static int UpdateClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Client869963
                                 SET CompanyName = @companyName
                                 , Address1 = @address1
                                 , Address2 = @address2
                                 , City = @city
                                 , Province = @province
                                 , PostalCode = @postalCode
                                 , YTDSales = @YTDsales
                                 , CreditHold = @creditHold
                                 , Notes = @notes
                                 WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    if (client.CompanyName != null)
                    {
                        cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@companyName", DBNull.Value);
                    }

                    if (client.Address1 != null)
                    {
                        cmd.Parameters.AddWithValue("@address1", client.Address1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address1", DBNull.Value);
                    }

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }
                    if (client.Province != null)
                    {
                        cmd.Parameters.AddWithValue("@province", client.Province);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@province", DBNull.Value);
                    }
                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@YTDsales", client.YTDSales);
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }


        public static ClientCollection GetAllClients()
        {
            ClientCollection clients;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                                 FROM Client869963
                                 ORDER BY ClientCode, CompanyName, Address1, Address2";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    clients = new ClientCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string clientCode;
                        string companyName;
                        string address1;
                        string address2 = null;
                        string city = null;
                        string province;
                        string postalCode = null;
                        decimal YTDsales;
                        bool creditHold;
                        string notes = null;

                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;
                            if (!reader.IsDBNull(3))
                            {
                                address2 = reader["Address2"] as string;
                            }
                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;
                            }
                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(6))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }
                            YTDsales = (decimal)reader["YTDSales"];
                            creditHold = (bool)reader["CreditHold"];
                            if (!reader.IsDBNull(9))
                            {
                                notes = reader["Notes"] as string;
                            }

                            clients.Add(new Client { ClientCode=clientCode
                                                    ,CompanyName=companyName
                                                    ,Address1=address1
                                                    ,Address2=address2
                                                    ,City=city
                                                    ,Province=province
                                                    ,PostalCode=postalCode
                                                    ,YTDSales=YTDsales
                                                    ,CreditHold=creditHold
                                                    ,Notes=notes });

                            address2 = null;
                            city = null;
                            postalCode = null;
                            notes = null;
                        }
                    }

                    return clients;
                }
            }
        }

        public static int DeleteClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"DELETE Client869963
                                 WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}
