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
    public partial class CustomerVoicemailSystem : System.Windows.Forms.Form
    {
        public CustomerVoicemailSystem()
        {
            InitializeComponent();
        }

        private void showCustomer(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.Show();
            customerForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void showVoicemail(object sender, EventArgs e)
        {
            Correspondence voicemailForm = new Correspondence();
            voicemailForm.Show();
            voicemailForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }
    }
}
