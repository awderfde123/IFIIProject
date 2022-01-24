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
    public partial class FrmHomePage : Form
    {
        internal static tCustormer custormer;
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void TsbClass_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            FrmClassText f = new FrmClassText();
            f.MdiParent = this;
            SchoolHWEntities db = new SchoolHWEntities();
            if (custormer.fClassMessage == null)
                MessageBox.Show("請先報名課程");
            else
                f.Show();
        }

        private void TsbClassShow_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            FrmClassView f = new FrmClassView();
            f.MdiParent = this;
            SchoolHWEntities db = new SchoolHWEntities();
            if (db.tClassGrade.FirstOrDefault(p => p.fIdentityCardId == FrmHomePage.custormer.fIdentityCardId) == null && custormer.fMemberType != 2)
                MessageBox.Show("請先測試題目");
            else
            f.Show();
        }

        private void TsbStudio_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            FrmLearnMap f = new FrmLearnMap();
            f.MdiParent = this;
            f.Show();
        }
        public void CloseMidChildren()
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.ShowDialog();
            custormer = f.Get();
            //MessageBox.Show(custormer.IdentityCardId.ToString());
            if (custormer != null)
            {
                TsbClass.Visible = true;
                TsbSkill.Visible = true;
                TsbSkillShow.Visible = true;
                TsbClassShow.Visible = true;
                Tsblogout.Visible = true;
                TsbLogin.Visible = false;
                LabName.Text = custormer.fMemberName;
            }
        }

        private void TsbLogout_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            TsbClass.Visible = false;
            TsbSkill.Visible = false;
            TsbSkillShow.Visible = false;
            TsbClassShow.Visible = false;
            Tsblogout.Visible = false;
            LabName.Text = "";
            custormer = null;
            TsbLogin.Visible = true;
        }

        private void TsbSkill_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            
            FrmSkillTest f = new FrmSkillTest();
            f.MdiParent = this;
                f.Show();
        }

        private void TsbSkillShow_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            SchoolHWEntities db = new SchoolHWEntities();
            FrmSkillView f = new FrmSkillView();
            f.MdiParent = this;
            if (db.tSkillGrade.FirstOrDefault(p => p.fIdentityCardID == FrmHomePage.custormer.fIdentityCardId) == null && custormer.fMemberType != 2)
                MessageBox.Show("請先測試題目");
            else
                f.Show();
        }
    }
}
