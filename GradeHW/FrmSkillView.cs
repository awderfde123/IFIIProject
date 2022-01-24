using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GradeHW
{
    public partial class FrmSkillView : Form
    {
        public FrmSkillView()
        {
            InitializeComponent();

        }
        string ShowId = FrmHomePage.custormer.fIdentityCardId;
        private void FrmSkillView_Load(object sender, EventArgs e)
        {
            if (FrmHomePage.custormer.fMemberType == 2)
            {
                ComBoCompany.Visible = true;

                SchoolHWEntities db = new SchoolHWEntities();

                var stable = from p in db.tClassGrade
                             join s in db.tCustormer on p.fIdentityCardId equals s.fIdentityCardId
                             where s.fCompanyName == FrmHomePage.custormer.fCompanyName
                             select p;
                foreach (var p in stable)
                {
                    if (p.fIdentityCardId != ShowId)
                        ComBoCompany.Items.Add(p.fMemberName);
                }
            }
            else
                ShowCart();
        }

        private void ShowCart()
        {
            //LabName.Text = FrmHomePage.custormer.fMemberName;
                SchoolHWEntities db = new SchoolHWEntities();

            ChartClassTest.Series.Clear();
            flowLayoutPanel1.Controls.Clear();
            bool isShow = false;
            int count = 0;
            var gradename = (from p in db.tSkillGrade
                            group p by p.fSkillCategory into g
                            select g).ToList();

            var skillCategories = (from p in db.tSkillGrade
                                                  where p.fIdentityCardID == ShowId
                                                  select p.fSkillCategory).ToList();

            foreach (var p in gradename)
            {
                //if(p.Key == )
                if (!skillCategories.Contains(p.Key))
                {
                    continue;
                }

                ChartClassTest.Series.Add($"{p.Key}Grade");
                ChartClassTest.Series[$"{p.Key}Grade"].YValueType = ChartValueType.Int32;

                for (int x = 10; x <= 100; x += 5)
                {
                    if (x % 2 == 0)
                    {
                        foreach (var pp in p)
                        {
                            if (pp.fIdentityCardID == ShowId && !isShow)
                            {
                                Label labelName = new Label();
                                labelName.Font = new Font("微軟正黑體", 15, FontStyle.Regular);
                                labelName.AutoSize = true;
                                labelName.Text = p.Key;
                                flowLayoutPanel1.Controls.Add(labelName);
                                Label labelGrade = new Label();
                                labelGrade.Font = new Font("新細明體", 20, FontStyle.Regular);
                                labelGrade.AutoSize = true;
                                labelGrade.Text = pp.fGrade.ToString();
                                flowLayoutPanel1.Controls.Add(labelGrade);
                                isShow = true;
                            }
                            if (pp.fGrade > x - 10 && pp.fGrade <= x)
                                count++;
                        }
                        ChartClassTest.Series[$"{p.Key}Grade"].Points.AddXY("" + (x - 5), count);
                        count = 0;
                    }
                    else { ChartClassTest.Series[$"{p.Key}Grade"].Points.AddXY("" + (x - 5), 0); }
                }
                isShow = false;
            }
        }

        private void BtnlearnMap_Click(object sender, EventArgs e)
        {
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tSkillGrade
                        where p.fIdentityCardID == ShowId
                        orderby p.fGrade ascending
                        select p;

            FrmLearnMap f = new FrmLearnMap(table.First().fSkillCategory.ToString());
            f.MdiParent = FrmHomePage.ActiveForm;
            f.Show();
            Close();
        }

        private void ComBoCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
                SchoolHWEntities db = new SchoolHWEntities();
                ShowId = db.tClassGrade.FirstOrDefault(p => p.fMemberName == ComBoCompany.Text).fIdentityCardId.ToString();
                ShowCart();
        }
    }
}
