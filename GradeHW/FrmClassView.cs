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
    public partial class FrmClassView : Form
    {
        public FrmClassView()
        {
            InitializeComponent();
        }
        string ShowId = FrmHomePage.custormer.fIdentityCardId;
        private void ClassView_Load(object sender, EventArgs e)
        {

            if (FrmHomePage.custormer.fMemberType == 2)
            {
                BtnCompany.Visible = true;
                BtnPersonalAvg.Visible = true;
                comboBox1.Visible = true;

                SchoolHWEntities db = new SchoolHWEntities();

                var stable = from p in db.tClassGrade
                             join s in db.tCustormer on p.fIdentityCardId equals s.fIdentityCardId
                             where s.fCompanyName == FrmHomePage.custormer.fCompanyName
                             select p;
                foreach (var p in stable)
                {
                    if (p.fIdentityCardId != ShowId)
                        comboBox1.Items.Add(p.fMemberName);
                }
            }
            else
            ChartShow();

        }

        private void ChartShow()
        {
            SchoolHWEntities db = new SchoolHWEntities();
            ChartClassTest.Series.Clear();
            LabName.Text = db.tClassGrade.FirstOrDefault(p => p.fIdentityCardId == ShowId).fMemberName.ToString();
            LabClassBeforeTest.Text = db.tClassGrade.FirstOrDefault(p => p.fIdentityCardId == ShowId).fBeforeClassGrade.ToString();
            LabClassAfterTest.Text = db.tClassGrade.FirstOrDefault(p => p.fIdentityCardId == ShowId).fAfterClassGrade.ToString();
            ChartClassTest.Series.Add("BeforeGrade");
            ChartClassTest.Series["BeforeGrade"].YValueType = ChartValueType.Int32;
            //ChartClassBeforeTest.Series
            //ChartClassTest.Series["BeforeGrade"].Points.AddXY("0", 0);
            for (int x = 10; x <= 100; x += 5)
            {
                if (x % 2 == 0)
                {
                    var table = from p in db.tClassGrade
                                where p.fBeforeClassGrade > x - 10 && p.fBeforeClassGrade <= x
                                select p;
                    ChartClassTest.Series["BeforeGrade"].Points.AddXY("" + (x - 5), table.Count());
                }
                else
                    ChartClassTest.Series["BeforeGrade"].Points.AddXY("" + (x - 5), 0);
            }
            ChartClassTest.Series["BeforeGrade"].Points.AddXY("100", 0);
            ChartClassTest.Series.Add("AfterGrade");
            ChartClassTest.Series["AfterGrade"].YValueType = ChartValueType.Int32;
            for (int x = 10; x <= 100; x += 5)
            {
                if (x % 2 == 0)
                {
                    var table = from p in db.tClassGrade
                                where p.fAfterClassGrade > x - 10 && p.fAfterClassGrade <= x
                                select p;
                    ChartClassTest.Series["AfterGrade"].Points.AddXY("" + (x - 5), table.Count());
                }
                else
                    ChartClassTest.Series["AfterGrade"].Points.AddXY("" + (x - 5), 0);

            }
            ChartClassTest.Series["AfterGrade"].Points.AddXY("100", 0);
            BtnPersonalAvg_Click(null, null);
        }

        private void BtnlearnMap_Click(object sender, EventArgs e)
        {
            FrmLearnMap f = new FrmLearnMap(FrmHomePage.custormer.fClassMessage);
            f.MdiParent = FrmHomePage.ActiveForm;
            f.Show();
            Close();
        }

        private void BtnCompany_Click(object sender, EventArgs e)
        {
            SchoolHWEntities db = new SchoolHWEntities();
            ChartAvgTest.Series.Clear();
            ChartAvgTest.Series.Add("CompanyAvgGrade");
            ChartAvgTest.Titles.Clear();
            ChartAvgTest.Series["CompanyAvgGrade"].ChartType = SeriesChartType.Pie;
            ChartAvgTest.Titles.Add("企業平均分數");
            //ChartAvgTest.Series["CompanyAvgGrade"].YValueType = ChartValueType.Int32;
            for (int x = 10; x <= 100; x += 5)
            {
                    var table = from p in db.tClassGrade
                                join s in db.tCustormer on p.fIdentityCardId equals s.fIdentityCardId
                                where s.fCompanyName == FrmHomePage.custormer.fCompanyName
                                group p by s.fCompanyName into g
                                select new { Avg = g.Average(xx => xx.fBeforeClassGrade) };
                foreach (var p in table)
                    if(p.Avg>x-10 && p.Avg<=x)
                        ChartAvgTest.Series["CompanyAvgGrade"].Points.AddXY((x - 10) + "~" + (x), table.Count());
                
            }
            ChartAvgTest.Titles["Title1"].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchoolHWEntities db = new SchoolHWEntities();
            ShowId = db.tClassGrade.FirstOrDefault(p => p.fMemberName == comboBox1.Text).fIdentityCardId.ToString();
            ChartShow();
        }

        private void BtnPersonalAvg_Click(object sender, EventArgs e)
        {
            SchoolHWEntities db = new SchoolHWEntities();
            ChartAvgTest.Series.Clear();
            ChartAvgTest.Series.Add("AvgGrade");
            ChartAvgTest.Titles.Clear();
            ChartAvgTest.Titles.Add("個人平均分數");
            ChartAvgTest.Series["AvgGrade"].ChartType = SeriesChartType.Pie;
            ChartAvgTest.Titles["Title1"].Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            for (int x = 10; x <= 100; x += 10)
            {
                var table = from p in db.tClassGrade
                            where (p.fAfterClassGrade + p.fBeforeClassGrade) / 2 > (x - 10) && (p.fAfterClassGrade + p.fBeforeClassGrade) / 2 <= x
                            select p;
                if (table.Count() > 0)
                    ChartAvgTest.Series["AvgGrade"].Points.AddXY((x - 10) + "~" + (x), table.Count());
            }
        }
    }
}
