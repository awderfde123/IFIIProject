
namespace GradeHW
{
    partial class login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LabTietal = new System.Windows.Forms.Label();
            this.LabAccount = new System.Windows.Forms.Label();
            this.LabPassWord = new System.Windows.Forms.Label();
            this.TxbAccount = new System.Windows.Forms.TextBox();
            this.TxbPassWord = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabTietal
            // 
            this.LabTietal.AutoSize = true;
            this.LabTietal.Font = new System.Drawing.Font("新細明體", 49F);
            this.LabTietal.Location = new System.Drawing.Point(102, 19);
            this.LabTietal.Name = "LabTietal";
            this.LabTietal.Size = new System.Drawing.Size(292, 66);
            this.LabTietal.TabIndex = 0;
            this.LabTietal.Text = "登入畫面";
            // 
            // LabAccount
            // 
            this.LabAccount.AutoSize = true;
            this.LabAccount.Font = new System.Drawing.Font("新細明體", 29F);
            this.LabAccount.Location = new System.Drawing.Point(40, 103);
            this.LabAccount.Name = "LabAccount";
            this.LabAccount.Size = new System.Drawing.Size(115, 39);
            this.LabAccount.TabIndex = 1;
            this.LabAccount.Text = "帳號 :";
            // 
            // LabPassWord
            // 
            this.LabPassWord.AutoSize = true;
            this.LabPassWord.Font = new System.Drawing.Font("新細明體", 29F);
            this.LabPassWord.Location = new System.Drawing.Point(40, 177);
            this.LabPassWord.Name = "LabPassWord";
            this.LabPassWord.Size = new System.Drawing.Size(115, 39);
            this.LabPassWord.TabIndex = 2;
            this.LabPassWord.Text = "密碼 :";
            // 
            // TxbAccount
            // 
            this.TxbAccount.Font = new System.Drawing.Font("新細明體", 19F);
            this.TxbAccount.Location = new System.Drawing.Point(161, 104);
            this.TxbAccount.Name = "TxbAccount";
            this.TxbAccount.Size = new System.Drawing.Size(311, 38);
            this.TxbAccount.TabIndex = 3;
            // 
            // TxbPassWord
            // 
            this.TxbPassWord.Font = new System.Drawing.Font("新細明體", 19F);
            this.TxbPassWord.Location = new System.Drawing.Point(161, 178);
            this.TxbPassWord.Name = "TxbPassWord";
            this.TxbPassWord.Size = new System.Drawing.Size(311, 38);
            this.TxbPassWord.TabIndex = 4;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("新細明體", 19F);
            this.BtnOK.Location = new System.Drawing.Point(359, 232);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(113, 38);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxbPassWord);
            this.Controls.Add(this.TxbAccount);
            this.Controls.Add(this.LabPassWord);
            this.Controls.Add(this.LabAccount);
            this.Controls.Add(this.LabTietal);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabTietal;
        private System.Windows.Forms.Label LabAccount;
        private System.Windows.Forms.Label LabPassWord;
        private System.Windows.Forms.TextBox TxbAccount;
        private System.Windows.Forms.TextBox TxbPassWord;
        private System.Windows.Forms.Button BtnOK;
    }
}

