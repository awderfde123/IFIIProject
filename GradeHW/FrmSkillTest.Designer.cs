
namespace GradeHW
{
    partial class FrmSkillTest
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
            this.BtnCheck = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabPaperId = new System.Windows.Forms.Label();
            this.BtnPaperId = new System.Windows.Forms.Button();
            this.ComBoPeper = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCheck
            // 
            this.BtnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCheck.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnCheck.Location = new System.Drawing.Point(685, 500);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(103, 39);
            this.BtnCheck.TabIndex = 14;
            this.BtnCheck.Text = "確認";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Visible = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("新細明體", 12F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 444);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // LabPaperId
            // 
            this.LabPaperId.AutoSize = true;
            this.LabPaperId.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabPaperId.Location = new System.Drawing.Point(12, 13);
            this.LabPaperId.Name = "LabPaperId";
            this.LabPaperId.Size = new System.Drawing.Size(92, 27);
            this.LabPaperId.TabIndex = 12;
            this.LabPaperId.Text = "試卷ID";
            // 
            // BtnPaperId
            // 
            this.BtnPaperId.Font = new System.Drawing.Font("新細明體", 15F);
            this.BtnPaperId.Location = new System.Drawing.Point(550, 11);
            this.BtnPaperId.Name = "BtnPaperId";
            this.BtnPaperId.Size = new System.Drawing.Size(99, 31);
            this.BtnPaperId.TabIndex = 11;
            this.BtnPaperId.Text = "確認";
            this.BtnPaperId.UseVisualStyleBackColor = true;
            this.BtnPaperId.Click += new System.EventHandler(this.BtnPaperId_Click);
            // 
            // ComBoPeper
            // 
            this.ComBoPeper.Font = new System.Drawing.Font("新細明體", 15F);
            this.ComBoPeper.FormattingEnabled = true;
            this.ComBoPeper.Location = new System.Drawing.Point(110, 13);
            this.ComBoPeper.Name = "ComBoPeper";
            this.ComBoPeper.Size = new System.Drawing.Size(434, 28);
            this.ComBoPeper.TabIndex = 15;
            // 
            // FrmSkillTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 548);
            this.Controls.Add(this.ComBoPeper);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabPaperId);
            this.Controls.Add(this.BtnPaperId);
            this.Name = "FrmSkillTest";
            this.Text = "/+-]7\\\'4>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabPaperId;
        private System.Windows.Forms.Button BtnPaperId;
        private System.Windows.Forms.ComboBox ComBoPeper;
    }
}