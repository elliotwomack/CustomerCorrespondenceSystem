using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerVoicemailSystem.Presentation
{
    public partial class Email : Form
    {
        String CorrespondenceId = "";
        DataCommon DataObj;

        public Email(String correspondenceId, DataCommon dataObj)
        {
            InitializeComponent();
            CorrespondenceId = correspondenceId;
            DataObj = dataObj;
            if (emailExists())
            {
                loadContent();
            }
        }

        public Email(DataCommon dataObj)
        {
            DataObj = dataObj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(emailExists())
            {
                DataObj.executeDatbaseQuery("Update Email set address = '" + tbEmailAddress.Text.Trim() + "', subject = '" + tbEmailSubject.Text.Trim() + "', message = '" + rtbMessage.Text.Trim() + "' where correspondenceID = " + Convert.ToInt32(CorrespondenceId) + ";");
            }else
            {
                DataObj.executeDatbaseQuery("Insert Into Email values(" + Convert.ToInt32(CorrespondenceId) + ",'" + tbEmailAddress.Text.Trim() + "','" + tbEmailSubject.Text.Trim() + "','" + rtbMessage.Text.Trim() + "');");
            }
            this.Close();
        }

        private Boolean emailExists()
        {
            return loadEmail().Rows.Count > 0;
        }

        private void loadContent()
        {
            DataTable dt = loadEmail();
            if(dt.Rows.Count > 0)
            {
                tbEmailAddress.Text = dt.Rows[0]["address"].ToString();
                tbEmailSubject.Text = dt.Rows[0]["subject"].ToString();
                rtbMessage.Text = dt.Rows[0]["message"].ToString();
            }
        }

        private DataTable loadEmail()
        {
            return DataObj.getDatatable("Select * From Email where correspondenceId = " + Convert.ToInt32(CorrespondenceId) + "");
        }
    }
}
