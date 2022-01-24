
namespace GradeHW
{
    partial class FrmSkillView
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
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine3 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnlearnMap = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.LabPaperId = new System.Windows.Forms.Label();
            this.ChartClassTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ComBoCompany = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartClassTest)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnlearnMap
            // 
            this.BtnlearnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnlearnMap.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnlearnMap.Location = new System.Drawing.Point(912, 9);
            this.BtnlearnMap.Name = "BtnlearnMap";
            this.BtnlearnMap.Size = new System.Drawing.Size(175, 43);
            this.BtnlearnMap.TabIndex = 27;
            this.BtnlearnMap.Text = "前往學習地圖";
            this.BtnlearnMap.UseVisualStyleBackColor = true;
            this.BtnlearnMap.Click += new System.EventHandler(this.BtnlearnMap_Click);
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabName.Location = new System.Drawing.Point(109, 13);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(0, 27);
            this.LabName.TabIndex = 20;
            // 
            // LabPaperId
            // 
            this.LabPaperId.AutoSize = true;
            this.LabPaperId.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabPaperId.Location = new System.Drawing.Point(23, 13);
            this.LabPaperId.Name = "LabPaperId";
            this.LabPaperId.Size = new System.Drawing.Size(80, 27);
            this.LabPaperId.TabIndex = 19;
            this.LabPaperId.Text = "姓名 :";
            // 
            // ChartClassTest
            // 
            this.ChartClassTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartClassTest.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.Interval = 2D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.Interval = 0D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.Interval = 2D;
            chartArea3.AxisY.StripLines.Add(stripLine3);
            chartArea3.AxisY2.LineWidth = 0;
            chartArea3.CursorX.LineWidth = 0;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            this.ChartClassTest.ChartAreas.Add(chartArea3);
            legend3.ItemColumnSpacing = 100;
            legend3.Name = "Legend1";
            this.ChartClassTest.Legends.Add(legend3);
            this.ChartClassTest.Location = new System.Drawing.Point(18, 127);
            this.ChartClassTest.Name = "ChartClassTest";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartClassTest.Series.Add(series3);
            this.ChartClassTest.Size = new System.Drawing.Size(1067, 301);
            this.ChartClassTest.TabIndex = 29;
            this.ChartClassTest.Text = "課後檢視";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(98, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(934, 48);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // ComBoCompany
            // 
            this.ComBoCompany.Font = new System.Drawing.Font("新細明體", 20F);
            this.ComBoCompany.FormattingEnabled = true;
            this.ComBoCompany.Location = new System.Drawing.Point(674, 12);
            this.ComBoCompany.Name = "ComBoCompany";
            this.ComBoCompany.Size = new System.Drawing.Size(167, 35);
            this.ComBoCompany.TabIndex = 31;
            this.ComBoCompany.Visible = false;
            this.ComBoCompany.SelectedIndexChanged += new System.EventHandler(this.ComBoCompany_SelectedIndexChanged);
            // 
            // FrmSkillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 439);
            this.Controls.Add(this.ComBoCompany);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ChartClassTest);
            this.Controls.Add(this.BtnlearnMap);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.LabPaperId);
            this.Name = "FrmSkillView";
            this.Text = "FrmSkillView";
            this.Load += new System.EventHandler(this.FrmSkillView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartClassTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnlearnMap;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label LabPaperId;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartClassTest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox ComBoCompany;
    }
}