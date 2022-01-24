using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeHW
{
    public partial class login : Form
    {
        private tCustormer customerCurrent;
        public login()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            customerCurrent = (new SchoolHWEntities()).tCustormer.FirstOrDefault(p => p.fAccountNumber.Equals(TxbAccount.Text)&&p.fPassWord.Equals(TxbPassWord.Text));
            if (customerCurrent != null)
            {
                //MessageBox.Show("歡迎  " + customerCurrent.fMemberName);
                Close();
            }
            else
                MessageBox.Show("登入失敗");
        }
        public tCustormer Get()
        {
            return customerCurrent;
        }
    }
}
