
namespace GradeHW
{
    partial class FrmLearnMap
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
            this.TxbSearch = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.FlpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpSkill = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // TxbSearch
            // 
            this.TxbSearch.Font = new System.Drawing.Font("新細明體", 19F);
            this.TxbSearch.Location = new System.Drawing.Point(12, 29);
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(496, 38);
            this.TxbSearch.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("新細明體", 12F);
            this.BtnOK.Location = new System.Drawing.Point(514, 28);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(111, 38);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "確認";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FlpCategory
            // 
            this.FlpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlpCategory.AutoScroll = true;
            this.FlpCategory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpCategory.Location = new System.Drawing.Point(13, 74);
            this.FlpCategory.Name = "FlpCategory";
            this.FlpCategory.Size = new System.Drawing.Size(268, 364);
            this.FlpCategory.TabIndex = 2;
            // 
            // FlpSkill
            // 
            this.FlpSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlpSkill.AutoScroll = true;
            this.FlpSkill.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpSkill.Location = new System.Drawing.Point(287, 74);
            this.FlpSkill.Name = "FlpSkill";
            this.FlpSkill.Size = new System.Drawing.Size(338, 364);
            this.FlpSkill.TabIndex = 3;
            // 
            // FrmLearnMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.FlpSkill);
            this.Controls.Add(this.FlpCategory);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxbSearch);
            this.Name = "FrmLearnMap";
            this.Text = "FrmLearnMap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbSearch;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.FlowLayoutPanel FlpCategory;
        private System.Windows.Forms.FlowLayoutPanel FlpSkill;
    }
}