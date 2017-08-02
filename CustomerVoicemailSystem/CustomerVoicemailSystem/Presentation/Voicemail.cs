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
    public partial class Voicemail : Form
    {
        String CorrespondenceId;
        DataCommon dataObj = new DataCommon();

        public Voicemail(String correspondenceId)
        {
            InitializeComponent();
            CorrespondenceId = correspondenceId;
            if (voicemailExists())
            {
                loadContent();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (voicemailExists())
            {
                dataObj.executeDatbaseQuery("Update Voicemail set phoneNumber = '" + tbPhoneNumber.Text.Trim() + "', messageSummary = '" + rtbMessageSummary.Text.Trim() + "' where correspondenceId = " + Convert.ToInt32(CorrespondenceId) + "");
            }else
            {
                dataObj.executeDatbaseQuery("Insert Into Voicemail values(" + Convert.ToInt32(CorrespondenceId) + ",'" + tbPhoneNumber.Text.Trim() + "','" + rtbMessageSummary.Text.Trim() + "');");
            }
            this.Close();
        }

        private Boolean voicemailExists()
        {
            return loadVoicemail().Rows.Count > 0;
        }

        private void loadContent()
        {
            DataTable dt = loadVoicemail();
            if (dt.Rows.Count > 0)
            {
                tbPhoneNumber.Text = dt.Rows[0]["phoneNumber"].ToString();
                rtbMessageSummary.Text = dt.Rows[0]["messageSummary"].ToString();
            }
        }

        private DataTable loadVoicemail()
        {
            return dataObj.getDatatable("Select * From Voicemail where correspondenceId = " + Convert.ToInt32(CorrespondenceId) + "");
        }
    }
}
