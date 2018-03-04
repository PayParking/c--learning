using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary.Business;
using BusinessLibrary.Common;
using System.Data.SqlClient;

namespace COMP2614Assign06
{
    public partial class ClientEditDialog : Form
    {
        public ClientViewModel ClientVM { get; set; }

        public ClientEditDialog()
        {
            InitializeComponent();
        }

        private void ProductEditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
        }

        private void setBindings()
        {
            maskedTextBoxClientCode.DataBindings.Add("Text", ClientVM, "ClientCode", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Address2", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCity.DataBindings.Add("Text", ClientVM, "City", false, DataSourceUpdateMode.OnPropertyChanged);
            maskedTextBoxProvince.DataBindings.Add("Text", ClientVM, "Province", false, DataSourceUpdateMode.OnPropertyChanged);
            maskedTextBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "YTDSales", true, DataSourceUpdateMode.OnPropertyChanged, "", "#,##0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int rowAffected;

                Client client = ClientVM.GetDisplayClient();
                bool sameClientCode = false;

                //checking for same client code in the database.
                foreach (Client row in ClientValidation.GetAllClients())
                {
                    if(row.ClientCode == maskedTextBoxClientCode.Text)
                    {
                        sameClientCode = true;
                    }
                }
               
                if (sameClientCode)
                {
                    rowAffected = ClientValidation.UpdateClient(client);                        
                }
                else
                {
                    rowAffected = ClientValidation.AddClient(client);
                }

                if (rowAffected > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    errorProvider.SetError(buttonSave, ClientValidation.ErrorMessage);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
