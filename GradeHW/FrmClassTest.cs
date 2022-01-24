using GradeHW;
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
    public partial class FrmClassText : Form
    {
        public FrmClassText()
        {
            InitializeComponent();
        }
        private void BtnPaperId_Click(object sender, EventArgs e)
        {
            int PaperId = int.Parse(TxbPaperId.Text);
            //int counter = 1;
            flowLayoutPanel1.Controls.Clear();
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tClassTestPaper
                        where p.TestPaperID.Equals(PaperId)
                        select p;
            foreach(var p in table)
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
            TxbPaperId.ReadOnly = true;
            BtnCheck.Visible = true;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int PaperId = int.Parse(TxbPaperId.Text);
            int testgrade = 0;
            //string temp;
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tClassTestPaper
                        where p.TestPaperID.Equals(PaperId)
                        select p;
            foreach (var p in table.ToList())
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (p.TopicAnswer == (control.Name.Equals($"Txb{p.TopicID}") ? control.Text : ""))
                    {
                       testgrade++;
                    }
                }
            }
            int Grade = (int)(((float)testgrade / table.Count()) * 100);
            tClassGrade classGrade = new tClassGrade();
            if (db.tClassGrade.FirstOrDefault(p => p.fIdentityCardId == FrmHomePage.custormer.fIdentityCardId) == null)
            {
                classGrade.fBeforeClassGrade = Grade;
                classGrade.fTestPaperId= int.Parse(TxbPaperId.Text);
                classGrade.fIdentityCardId = FrmHomePage.custormer.fIdentityCardId;
                classGrade.fMemberName = FrmHomePage.custormer.fMemberName;
                db.tClassGrade.Add(classGrade);
                db.SaveChanges();
            }
            else
            {
                tClassGrade x = db.tClassGrade.FirstOrDefault(p => p.fIdentityCardId == FrmHomePage.custormer.fIdentityCardId);
                x.fAfterClassGrade = Grade;
                db.SaveChanges();
            }
            FrmClassView f = new FrmClassView();
            f.MdiParent = FrmHomePage.ActiveForm;
            f.Show();
            Close();

        }

    }
}
