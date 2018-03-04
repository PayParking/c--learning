using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary.Common;
using BusinessLibrary.Data;
using BusinessLibrary.Business;
using System.Data.SqlClient;

namespace COMP2614Assign06
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool configured = false;
            configured = true;
            checkBoxConfirmDeletion.Checked = true;
            try
            {
                clientVM = new ClientViewModel(ClientValidation.GetAllClients());
                setBindings(configured);
                UpdateLabels();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (configured)
            {
                setupDataGridView();
            }
        }

        private void setBindings(bool configured)
        {
            dataGridViewClients.AutoGenerateColumns = !configured;
            dataGridViewClients.DataSource = clientVM.Clients;
        }

        private void setupDataGridView()
        {
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn clientCode = new DataGridViewTextBoxColumn();
            clientCode.Name = "clientCode";
            clientCode.DataPropertyName = "ClientCode";
            clientCode.HeaderText = "ClientCode";
            clientCode.Width = 75;
            clientCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clientCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(clientCode);

            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "CompanyName";
            companyName.Width = 165;
            companyName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address1";
            address1.Width = 155;
            address1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address2";
            address2.Width = 80;
            address2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 70;
            city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            city.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 65;
            province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "PostalCode";
            postalCode.Width = 75;
            postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn YTDsales = new DataGridViewTextBoxColumn();
            YTDsales.Name = "YTDsales";
            YTDsales.DataPropertyName = "YTDSales";
            YTDsales.HeaderText = "YTDSales";
            YTDsales.Width = 70;
            YTDsales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            YTDsales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            YTDsales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(YTDsales);

            DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "CreditHold";
            creditHold.Width = 70;
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 165;
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;

            Client client = clientVM.Clients[index];
            clientVM.SetDisplayClient(client);
        }

        private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            clientVM.SetDisplayClient(clientVM.Clients[index]);

            ClientEditDialog dialog = new ClientEditDialog();
            dialog.ClientVM = clientVM;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                clientVM.Clients = ClientRepository.GetAllClients();
                dataGridViewClients.DataSource = clientVM.Clients;
                UpdateLabels();
            }

            dialog.Dispose();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;
                Client client = clientVM.Clients[index];
                if (checkBoxConfirmDeletion.Checked)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ClientRepository.DeleteClient(client);
                    }
                }
                else
                {
                    ClientRepository.DeleteClient(client);
                }
                clientVM.Clients = ClientRepository.GetAllClients();
                dataGridViewClients.DataSource = clientVM.Clients;
                UpdateLabels();
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

        private void UpdateLabels()
        {
            labelTotalYTDSales.Text = "Total YTDSales: $" + clientVM.Clients.TotalYTDSales.ToString();
            labelCreditHoldCount.Text = "Credit Hold Count: " + clientVM.Clients.CreditHoldCount.ToString();
        }
    }
}
