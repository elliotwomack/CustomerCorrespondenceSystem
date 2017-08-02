using CustomerVoicemailSystem.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerVoicemailSystem
{
    public partial class Correspondence : System.Windows.Forms.Form
    {
        DataCommon dataObj = new DataCommon();
        DataGridViewRow row;

        public Correspondence()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadContents(e);

        }

        private void loadContents(DataGridViewCellEventArgs e)
        {
            row = dgvCorrespondence.Rows[e.RowIndex];
            cbCorrespondenceType.Text = row.Cells[5].Value.ToString();
            tbDate.Text = row.Cells[2].Value.ToString();
            tbTime.Text = row.Cells[3].Value.ToString();
            tbName.Text = row.Cells[4].Value.ToString();
            cbCustomer.Text = row.Cells[1].Value.ToString();
            chbFollowUp.Checked = Convert.ToBoolean(row.Cells[6].Value);
        }

        private void Correspondence_Load(object sender, EventArgs e)
        {
            loadCorrespondenceTypeCb();
            loadCustomerCb();
        }

        private void loadCorrespondenceTypeCb()
        {
            cbCorrespondenceType.DataSource = dataObj.getDatatable("Select Type, Name From CorrespondenceType;");
            cbCorrespondenceType.DisplayMember = "Name";
            cbCorrespondenceType.ValueMember = "Type";
            cbCorrespondenceType.SelectedIndex = -1;
        }

        private void loadCustomerCb()
        {
            cbCustomer.DataSource = dataObj.getDatatable("Select Distinct customerID, name From Customer;");
            cbCustomer.DisplayMember = "name";
            cbCustomer.ValueMember = "customerID";
            cbCustomer.SelectedIndex = -1;
        }

        private void btnInsert(object sender, EventArgs e)
        {
            if (noCorrespondenceSelected())
            {
                MessageBox.Show("Please select a correspondence.");
                return;
            }
            dataObj.executeDatbaseQuery("Insert Into Correspondence values(" + cbCustomer.SelectedValue + ",'" + tbDate.Text + "','" + tbTime.Text + "','" + tbName.Text + "', " + cbCorrespondenceType.SelectedValue + ", " + Convert.ToInt32(chbFollowUp.Checked) + ");");
            createCorrespondence();
        }

        private void createCorrespondence()
        {
            if (noCorrespondenceSelected())
            {
                MessageBox.Show("Please select a correspondence.");
                return;
            }
            DataTable dt = dataObj.getDatatable("Select correspondenceId from Correspondence where date = '" + tbDate.Text + "' AND time = '" + tbTime.Text + "'AND name = '" + tbName.Text + "'AND Type = " + cbCorrespondenceType.SelectedValue + ";");
            if (cbCorrespondenceType.Text.Trim() == "Email")
            {
                createEmailForm(dt.Rows[0]["correspondenceId"].ToString());
            }
            else if (cbCorrespondenceType.Text.Trim() == "Voicemail")
            {
                createVoicemailForm(dt.Rows[0]["correspondenceId"].ToString());
            }
        }

        public bool noCorrespondenceSelected()
        {
            return tbDate.Text == "" & tbName.Text == "" & tbTime.Text == "";
        }

        private void createEmailForm(String correspondenceId)
        {
            Email email = new Email(correspondenceId, dataObj);
            email.Show();
            email.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void createVoicemailForm(String correspondenceId)
        {
            Voicemail voicemail = new Voicemail(correspondenceId);
            voicemail.Show();
            voicemail.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            if (noCorrespondenceSelected())
            {
                MessageBox.Show("Please select a correspondence.");
                return;
            }
            dataObj.executeDatbaseQuery("Update Correspondence set date = '" + tbDate.Text + "', time = '" + tbTime.Text + "', name = '" + tbName.Text + "', Type = '" + cbCorrespondenceType.SelectedValue + "', customerID = '" + cbCustomer.SelectedValue + "', followUp = " + Convert.ToInt32(chbFollowUp.Checked) + " where correspondenceID = '" + row.Cells[0].Value.ToString() + "';");
            refreshGrid();
        }

        private void btnView(object sender, EventArgs e)
        {
            refreshGrid();
            clearContents();
        }

        private void refreshGrid()
        {
            dgvCorrespondence.DataSource = dataObj.getDatatable("Select c.correspondenceID, cst.name as 'Company', c.date, c.time, c.name as 'Name', ct.name as 'Type', c.followUp from Correspondence c inner join CorrespondenceType ct on c.Type = ct.Type inner join customer cst on c.customerID = cst.customerID;");
            dgvCorrespondence.Columns[0].Visible = false;
            dgvCorrespondence.Columns[6].Visible = false;
        }

        private void clearContents()
        {
            cbCorrespondenceType.Text = "";
            tbDate.Text = "";
            tbTime.Text = "";
            tbName.Text = "";
        }

        private void btnCorrespondence_click(object sender, EventArgs e)
        {
            createCorrespondence();
        }
    }
}
