using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomerVoicemailSystem
{
    public partial class Customer : System.Windows.Forms.Form
    {
        DataCommon dataObj = new DataCommon();
        DataGridViewRow row;
        public Customer()
        {
            InitializeComponent();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadContents(e);

        }

        private void loadContents(DataGridViewCellEventArgs e)
        {
            row = dgvCustomer.Rows[e.RowIndex];
            tbCompanyName.Text = row.Cells[1].Value.ToString();
            tbAddress.Text = row.Cells[2].Value.ToString();
            tbPurchaseDate.Text = row.Cells[3].Value.ToString();
        }

        private void btnInsert(object sender, EventArgs e)
        {
            if (noCustomerSelected())
            {
                MessageBox.Show("Please Select a Customer.");
                return;
            }
            dataObj.executeDatbaseQuery("Insert Into Customer values('" + tbCompanyName.Text.Trim() + "','" + tbAddress.Text.Trim() + "','" + tbPurchaseDate.Text.Trim() + "');");
            refreshGrid();
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            if (noCustomerSelected())
            {
                MessageBox.Show("Please Select a Customer.");
                return;
            }
            dataObj.executeDatbaseQuery("Update Customer set purchaseDate = '" + tbPurchaseDate.Text.Trim() + "', name = '" + tbCompanyName.Text.Trim() + "', address = '" + tbAddress.Text.Trim() + "' where customerId = '" + row.Cells[0].Value.ToString() + "';");
            refreshGrid();
        }

        private bool noCustomerSelected()
        {
            return tbAddress.Text == "" & tbCompanyName.Text == "" & tbCompanyName.Text == "";
        }

        private void btnView(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            dgvCustomer.DataSource = dataObj.getDatatable("Select customerID, name, address, purchasedate from Customer;");
            dgvCustomer.Columns[0].Visible = false;
        }
    }
}
