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
    public partial class FrmLearnMap : Form
    {
        public FrmLearnMap()
        {
            InitializeComponent();
        }
        public FrmLearnMap(string classid)
        {
            InitializeComponent();
            TxbSearch.Text = classid;
            BtnOK_Click(null,null);
            BtnOK.Focus();
            TxbSearch.Select(0, 0);
        }
        private void Skill_Click(object sender, EventArgs e)
        {
            FlpSkill.Controls.Clear();
            string Name = ((Label)sender).Name;
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tStudioInformation
                        where  p.fClassCategory.Equals(Name)
                        select p;
            foreach (var x in table)
            {
                Label label = new Label();
                label.Font = new Font("微軟正黑體", 15, FontStyle.Bold);
                label.AutoSize = true;
                label.Margin = new Padding(5, 5, 5, 5);
                label.Text = x.fClassSkill;
                label.Name = x.fClassSkill;
                FlpSkill.Controls.Add(label);
            }
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            FlpCategory.Controls.Clear();
            SchoolHWEntities db = new SchoolHWEntities();
            var table = from p in db.tStudioInformation
                        where p.fClassName.Contains(TxbSearch.Text.Trim()) || p.fClassSkill.Contains(TxbSearch.Text.Trim())
                        group p by p.fClassCategory into g
                        select g;
            foreach(var x in table)
            {
                Label label = new Label();
                label.Font = new Font("微軟正黑體", 15, FontStyle.Bold);
                label.AutoSize = true;
                label.Margin = new Padding(5, 5, 5, 5);
                label.Text = x.Key;
                label.Name = x.Key;
                label.Click += Skill_Click;
                FlpCategory.Controls.Add(label);
            }

        }
    }
}
