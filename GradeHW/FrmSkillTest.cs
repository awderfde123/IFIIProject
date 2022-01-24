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
    public partial class FrmSkillTest : Form
    {
        public FrmSkillTest()
        {
            InitializeComponent();
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tSkillTestPaper
                        group p by p.TestPaper into g
                        select g;
            foreach(var p in table)
            {
                ComBoPeper.Items.Add(p.Key);
            }

        }

        private void BtnPaperId_Click(object sender, EventArgs e)
        {
            //int counter = 1;
            flowLayoutPanel1.Controls.Clear();
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tSkillTestPaper
                        where p.TestPaper.Equals(ComBoPeper.Text)
                        select p;
            foreach (var p in table)
            {
                Label label = new Label();
                label.Font = new Font("新細明體", 20, FontStyle.Regular);
                label.AutoSize = true;
                TextBox textBox = new TextBox();
                textBox.Font = new Font("新細明體", 20, FontStyle.Regular);
                textBox.AutoSize = true;
                label.Text = p.TopicID + p.Topic;
                textBox.Name = "Txb" + p.TopicID;
                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(textBox);
            }
            BtnPaperId.Visible = false;
            ComBoPeper.Enabled = false;
            BtnCheck.Visible = true;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int testgrade = 0;
            //int count = 0;
            //string temp;
            tSkillGrade tSkill = new tSkillGrade();
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tSkillTestPaper
                        where p.TestPaper.Equals(ComBoPeper.Text)
                        group p by p.SkillJobClass into g
                        select g;
            foreach (var p in table)
            {
                SchoolHWEntities dbchange = new SchoolHWEntities();
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    foreach (var pp in p)
                    {
                        if (pp.TopicAnswer == (control.Name.Equals($"Txb{pp.TopicID}") ? control.Text : ""))
                        {
                            testgrade++;
                        }
                    }

                }
                int Grade = (int)(((float)testgrade / p.Count()) * 100);
                tSkill.fIdentityCardID = FrmHomePage.custormer.fIdentityCardId;
                tSkill.fMemberName = FrmHomePage.custormer.fMemberName;
                tSkill.fGrade = Grade;
                tSkill.fSkillCategory = p.Key;
                dbchange.tSkillGrade.Add(tSkill);
                dbchange.SaveChanges();

                //count = 0;
                testgrade = 0;
            }
            //MessageBox.Show("YA");
            FrmSkillView f = new FrmSkillView();
            f.MdiParent = FrmHomePage.ActiveForm;
            f.Show();
            Close();
        }
    }
}
