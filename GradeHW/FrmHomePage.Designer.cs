
namespace GradeHW
{
    partial class FrmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbClass = new System.Windows.Forms.ToolStripButton();
            this.TsbSkill = new System.Windows.Forms.ToolStripButton();
            this.TsbClassShow = new System.Windows.Forms.ToolStripButton();
            this.TsbSkillShow = new System.Windows.Forms.ToolStripButton();
            this.TsbStudio = new System.Windows.Forms.ToolStripButton();
            this.TsbLogin = new System.Windows.Forms.ToolStripButton();
            this.Tsblogout = new System.Windows.Forms.ToolStripButton();
            this.LabName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbClass,
            this.TsbSkill,
            this.TsbClassShow,
            this.TsbSkillShow,
            this.TsbStudio,
            this.TsbLogin,
            this.Tsblogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbClass
            // 
            this.TsbClass.Image = ((System.Drawing.Image)(resources.GetObject("TsbClass.Image")));
            this.TsbClass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClass.Name = "TsbClass";
            this.TsbClass.Size = new System.Drawing.Size(59, 51);
            this.TsbClass.Text = "前後測試";
            this.TsbClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbClass.Visible = false;
            this.TsbClass.Click += new System.EventHandler(this.TsbClass_Click);
            // 
            // TsbSkill
            // 
            this.TsbSkill.Image = ((System.Drawing.Image)(resources.GetObject("TsbSkill.Image")));
            this.TsbSkill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSkill.Name = "TsbSkill";
            this.TsbSkill.Size = new System.Drawing.Size(59, 51);
            this.TsbSkill.Text = "技能測試";
            this.TsbSkill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbSkill.Visible = false;
            this.TsbSkill.Click += new System.EventHandler(this.TsbSkill_Click);
            // 
            // TsbClassShow
            // 
            this.TsbClassShow.Image = ((System.Drawing.Image)(resources.GetObject("TsbClassShow.Image")));
            this.TsbClassShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClassShow.Name = "TsbClassShow";
            this.TsbClassShow.Size = new System.Drawing.Size(83, 51);
            this.TsbClassShow.Text = "前後測試檢視";
            this.TsbClassShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbClassShow.ToolTipText = "前後測試檢視";
            this.TsbClassShow.Visible = false;
            this.TsbClassShow.Click += new System.EventHandler(this.TsbClassShow_Click);
            // 
            // TsbSkillShow
            // 
            this.TsbSkillShow.Image = ((System.Drawing.Image)(resources.GetObject("TsbSkillShow.Image")));
            this.TsbSkillShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSkillShow.Name = "TsbSkillShow";
            this.TsbSkillShow.Size = new System.Drawing.Size(83, 51);
            this.TsbSkillShow.Text = "技能測試檢視";
            this.TsbSkillShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbSkillShow.ToolTipText = "技能測試檢視";
            this.TsbSkillShow.Visible = false;
            this.TsbSkillShow.Click += new System.EventHandler(this.TsbSkillShow_Click);
            // 
            // TsbStudio
            // 
            this.TsbStudio.Image = ((System.Drawing.Image)(resources.GetObject("TsbStudio.Image")));
            this.TsbStudio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbStudio.Name = "TsbStudio";
            this.TsbStudio.Size = new System.Drawing.Size(59, 51);
            this.TsbStudio.Text = "學習地圖";
            this.TsbStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbStudio.ToolTipText = "學習地圖";
            this.TsbStudio.Click += new System.EventHandler(this.TsbStudio_Click);
            // 
            // TsbLogin
            // 
            this.TsbLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("TsbLogin.Image")));
            this.TsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLogin.Name = "TsbLogin";
            this.TsbLogin.Size = new System.Drawing.Size(36, 51);
            this.TsbLogin.Text = "登入";
            this.TsbLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsbLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // Tsblogout
            // 
            this.Tsblogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsblogout.Image = ((System.Drawing.Image)(resources.GetObject("Tsblogout.Image")));
            this.Tsblogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsblogout.Name = "Tsblogout";
            this.Tsblogout.Size = new System.Drawing.Size(36, 51);
            this.Tsblogout.Text = "登出";
            this.Tsblogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tsblogout.Visible = false;
            this.Tsblogout.Click += new System.EventHandler(this.TsbLogout_Click);
            // 
            // LabName
            // 
            this.LabName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabName.AutoSize = true;
            this.LabName.BackColor = System.Drawing.SystemColors.Control;
            this.LabName.Font = new System.Drawing.Font("新細明體", 30F);
            this.LabName.Location = new System.Drawing.Point(503, 9);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(0, 40);
            this.LabName.TabIndex = 2;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(666, 328);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmHomePage";
            this.Text = "FrmHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsblogout;
        private System.Windows.Forms.ToolStripButton TsbClass;
        private System.Windows.Forms.ToolStripButton TsbSkill;
        private System.Windows.Forms.ToolStripButton TsbSkillShow;
        private System.Windows.Forms.ToolStripButton TsbClassShow;
        private System.Windows.Forms.ToolStripButton TsbStudio;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.ToolStripButton TsbLogin;
    }
}