﻿namespace ListView
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvView = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAge,
            this.chWork});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.Location = new System.Drawing.Point(13, 13);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(431, 169);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름:";
            this.lblName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 218);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 12);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "나이:";
            this.lblAge.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(57, 215);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(245, 21);
            this.txtAge.TabIndex = 4;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(57, 242);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(245, 21);
            this.txtWork.TabIndex = 6;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(13, 245);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(33, 12);
            this.lblWork.TabIndex = 5;
            this.lblWork.Text = "직업:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 77);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 100;
            // 
            // chAge
            // 
            this.chAge.Text = "나이";
            this.chAge.Width = 100;
            // 
            // chWork
            // 
            this.chWork.Text = "직업";
            this.chWork.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 275);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "입력목록보기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chWork;
    }
}

