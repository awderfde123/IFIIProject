
namespace GradeHW
{
    partial class FrmClassView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LabPaperId = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.ChartClassTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartAvgTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lab2 = new System.Windows.Forms.Label();
            this.Lab1 = new System.Windows.Forms.Label();
            this.LabClassBeforeTest = new System.Windows.Forms.Label();
            this.LabClassAfterTest = new System.Windows.Forms.Label();
            this.BtnlearnMap = new System.Windows.Forms.Button();
            this.BtnCompany = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnPersonalAvg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartClassTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAvgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // LabPaperId
            // 
            this.LabPaperId.AutoSize = true;
            this.LabPaperId.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabPaperId.Location = new System.Drawing.Point(98, 19);
            this.LabPaperId.Name = "LabPaperId";
            this.LabPaperId.Size = new System.Drawing.Size(80, 27);
            this.LabPaperId.TabIndex = 8;
            this.LabPaperId.Text = "姓名 :";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabName.Location = new System.Drawing.Point(199, 19);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(0, 27);
            this.LabName.TabIndex = 9;
            // 
            // ChartClassTest
            // 
            this.ChartClassTest.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.Interval = 2D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.Interval = 0D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.Interval = 2D;
            chartArea3.AxisY.StripLines.Add(stripLine2);
            chartArea3.AxisY2.LineWidth = 0;
            chartArea3.CursorX.LineWidth = 0;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            this.ChartClassTest.ChartAreas.Add(chartArea3);
            legend3.ItemColumnSpacing = 100;
            legend3.Name = "Legend1";
            this.ChartClassTest.Legends.Add(legend3);
            this.ChartClassTest.Location = new System.Drawing.Point(17, 138);
            this.ChartClassTest.Name = "ChartClassTest";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartClassTest.Series.Add(series3);
            this.ChartClassTest.Size = new System.Drawing.Size(730, 300);
            this.ChartClassTest.TabIndex = 13;
            this.ChartClassTest.Text = "課後檢視";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title3.Name = "前後測試份數";
            title3.Text = "前後測試分數";
            this.ChartClassTest.Titles.Add(title3);
            // 
            // ChartAvgTest
            // 
            this.ChartAvgTest.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea2";
            this.ChartAvgTest.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartAvgTest.Legends.Add(legend4);
            this.ChartAvgTest.Location = new System.Drawing.Point(743, 138);
            this.ChartAvgTest.Name = "ChartAvgTest";
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChartAvgTest.Series.Add(series4);
            this.ChartAvgTest.Size = new System.Drawing.Size(332, 300);
            this.ChartAvgTest.TabIndex = 12;
            this.ChartAvgTest.Text = "綜合檢視";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            this.ChartAvgTest.Titles.Add(title4);
            // 
            // Lab2
            // 
            this.Lab2.AutoSize = true;
            this.Lab2.Font = new System.Drawing.Font("新細明體", 20F);
            this.Lab2.Location = new System.Drawing.Point(393, 86);
            this.Lab2.Name = "Lab2";
            this.Lab2.Size = new System.Drawing.Size(134, 27);
            this.Lab2.TabIndex = 14;
            this.Lab2.Text = "課後測試 :";
            // 
            // Lab1
            // 
            this.Lab1.AutoSize = true;
            this.Lab1.Font = new System.Drawing.Font("新細明體", 20F);
            this.Lab1.Location = new System.Drawing.Point(44, 86);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(134, 27);
            this.Lab1.TabIndex = 15;
            this.Lab1.Text = "課前測試 :";
            // 
            // LabClassBeforeTest
            // 
            this.LabClassBeforeTest.AutoSize = true;
            this.LabClassBeforeTest.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabClassBeforeTest.Location = new System.Drawing.Point(199, 86);
            this.LabClassBeforeTest.Name = "LabClassBeforeTest";
            this.LabClassBeforeTest.Size = new System.Drawing.Size(0, 27);
            this.LabClassBeforeTest.TabIndex = 16;
            // 
            // LabClassAfterTest
            // 
            this.LabClassAfterTest.AutoSize = true;
            this.LabClassAfterTest.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabClassAfterTest.Location = new System.Drawing.Point(557, 86);
            this.LabClassAfterTest.Name = "LabClassAfterTest";
            this.LabClassAfterTest.Size = new System.Drawing.Size(0, 27);
            this.LabClassAfterTest.TabIndex = 17;
            // 
            // BtnlearnMap
            // 
            this.BtnlearnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnlearnMap.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnlearnMap.Location = new System.Drawing.Point(909, 19);
            this.BtnlearnMap.Name = "BtnlearnMap";
            this.BtnlearnMap.Size = new System.Drawing.Size(175, 43);
            this.BtnlearnMap.TabIndex = 18;
            this.BtnlearnMap.Text = "前往學習地圖";
            this.BtnlearnMap.UseVisualStyleBackColor = true;
            this.BtnlearnMap.Click += new System.EventHandler(this.BtnlearnMap_Click);
            // 
            // BtnCompany
            // 
            this.BtnCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCompany.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnCompany.Location = new System.Drawing.Point(909, 82);
            this.BtnCompany.Name = "BtnCompany";
            this.BtnCompany.Size = new System.Drawing.Size(175, 43);
            this.BtnCompany.TabIndex = 19;
            this.BtnCompany.Text = "企業公司平均";
            this.BtnCompany.UseVisualStyleBackColor = true;
            this.BtnCompany.Visible = false;
            this.BtnCompany.Click += new System.EventHandler(this.BtnCompany_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(510, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 35);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnPersonalAvg
            // 
            this.BtnPersonalAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonalAvg.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnPersonalAvg.Location = new System.Drawing.Point(728, 82);
            this.BtnPersonalAvg.Name = "BtnPersonalAvg";
            this.BtnPersonalAvg.Size = new System.Drawing.Size(175, 43);
            this.BtnPersonalAvg.TabIndex = 21;
            this.BtnPersonalAvg.Text = "整體個人平均";
            this.BtnPersonalAvg.UseVisualStyleBackColor = true;
            this.BtnPersonalAvg.Visible = false;
            this.BtnPersonalAvg.Click += new System.EventHandler(this.BtnPersonalAvg_Click);
            // 
            // FrmClassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.BtnPersonalAvg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnCompany);
            this.Controls.Add(this.BtnlearnMap);
            this.Controls.Add(this.LabClassAfterTest);
            this.Controls.Add(this.LabClassBeforeTest);
            this.Controls.Add(this.Lab1);
            this.Controls.Add(this.Lab2);
            this.Controls.Add(this.ChartClassTest);
            this.Controls.Add(this.ChartAvgTest);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.LabPaperId);
            this.Name = "FrmClassView";
            this.Text = "view";
            this.Load += new System.EventHandler(this.ClassView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartClassTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAvgTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabPaperId;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartClassTest;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAvgTest;
        private System.Windows.Forms.Label Lab2;
        private System.Windows.Forms.Label Lab1;
        private System.Windows.Forms.Label LabClassBeforeTest;
        private System.Windows.Forms.Label LabClassAfterTest;
        private System.Windows.Forms.Button BtnlearnMap;
        private System.Windows.Forms.Button BtnCompany;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnPersonalAvg;
    }
}