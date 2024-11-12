namespace A_Notepad
{
    partial class Form2
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chOption = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdb02 = new System.Windows.Forms.RadioButton();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(36, 23);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(57, 12);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "찾을 내용";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(99, 20);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(297, 21);
            this.txtWord.TabIndex = 1;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOk.Location = new System.Drawing.Point(419, 23);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "다음 찾기";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(419, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chOption
            // 
            this.chOption.AutoSize = true;
            this.chOption.Location = new System.Drawing.Point(29, 59);
            this.chOption.Name = "chOption";
            this.chOption.Size = new System.Drawing.Size(106, 16);
            this.chOption.TabIndex = 4;
            this.chOption.Text = "대/소문자 구분";
            this.chOption.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rdb02);
            this.groupBox.Controls.Add(this.rdb01);
            this.groupBox.Location = new System.Drawing.Point(141, 59);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(177, 58);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "방향";
            // 
            // rdb02
            // 
            this.rdb02.AutoSize = true;
            this.rdb02.Checked = true;
            this.rdb02.Location = new System.Drawing.Point(94, 25);
            this.rdb02.Name = "rdb02";
            this.rdb02.Size = new System.Drawing.Size(59, 16);
            this.rdb02.TabIndex = 1;
            this.rdb02.TabStop = true;
            this.rdb02.Text = "아래쪽";
            this.rdb02.UseVisualStyleBackColor = true;
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(16, 25);
            this.rdb01.Name = "rdb01";
            this.rdb01.Size = new System.Drawing.Size(47, 16);
            this.rdb01.TabIndex = 0;
            this.rdb01.Text = "위쪽";
            this.rdb01.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 189);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.chOption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "찾기";
            this.TopMost = true;
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        internal System.Windows.Forms.TextBox txtWord;
        internal System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.CheckBox chOption;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rdb02;
        private System.Windows.Forms.RadioButton rdb01;
    }
}