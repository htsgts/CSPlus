namespace A_NetStat
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
            this.lvNetState = new System.Windows.Forms.ListView();
            this.clhLocalIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLocalPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRemoteIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRemotePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLocPort = new System.Windows.Forms.Label();
            this.lblForAdd = new System.Windows.Forms.Label();
            this.blForPort = new System.Windows.Forms.Label();
            this.txtForAdd = new System.Windows.Forms.TextBox();
            this.txtForPort = new System.Windows.Forms.TextBox();
            this.txtLocPort = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lvNetState
            // 
            this.lvNetState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhLocalIP,
            this.clhLocalPort,
            this.clhRemoteIP,
            this.clhRemotePort,
            this.clhState});
            this.lvNetState.GridLines = true;
            this.lvNetState.HideSelection = false;
            this.lvNetState.Location = new System.Drawing.Point(12, 12);
            this.lvNetState.Name = "lvNetState";
            this.lvNetState.Size = new System.Drawing.Size(621, 431);
            this.lvNetState.TabIndex = 0;
            this.lvNetState.UseCompatibleStateImageBehavior = false;
            this.lvNetState.View = System.Windows.Forms.View.Details;
            // 
            // clhLocalIP
            // 
            this.clhLocalIP.Text = "로컬주소";
            this.clhLocalIP.Width = 150;
            // 
            // clhLocalPort
            // 
            this.clhLocalPort.Text = "로컬포트";
            this.clhLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhLocalPort.Width = 90;
            // 
            // clhRemoteIP
            // 
            this.clhRemoteIP.Text = "외부주소";
            this.clhRemoteIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhRemoteIP.Width = 150;
            // 
            // clhRemotePort
            // 
            this.clhRemotePort.Text = "외부포트";
            this.clhRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhRemotePort.Width = 90;
            // 
            // clhState
            // 
            this.clhState.Text = "상태";
            this.clhState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhState.Width = 120;
            // 
            // lblLocPort
            // 
            this.lblLocPort.AutoSize = true;
            this.lblLocPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLocPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocPort.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLocPort.Location = new System.Drawing.Point(12, 470);
            this.lblLocPort.Name = "lblLocPort";
            this.lblLocPort.Size = new System.Drawing.Size(69, 18);
            this.lblLocPort.TabIndex = 1;
            this.lblLocPort.Text = "로컬포트";
            // 
            // lblForAdd
            // 
            this.lblForAdd.AutoSize = true;
            this.lblForAdd.BackColor = System.Drawing.Color.Magenta;
            this.lblForAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForAdd.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblForAdd.Location = new System.Drawing.Point(163, 470);
            this.lblForAdd.Name = "lblForAdd";
            this.lblForAdd.Size = new System.Drawing.Size(69, 18);
            this.lblForAdd.TabIndex = 2;
            this.lblForAdd.Text = "외부주소";
            // 
            // blForPort
            // 
            this.blForPort.AutoSize = true;
            this.blForPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.blForPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blForPort.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.blForPort.Location = new System.Drawing.Point(315, 469);
            this.blForPort.Name = "blForPort";
            this.blForPort.Size = new System.Drawing.Size(69, 18);
            this.blForPort.TabIndex = 3;
            this.blForPort.Text = "외부포트";
            // 
            // txtForAdd
            // 
            this.txtForAdd.Location = new System.Drawing.Point(240, 470);
            this.txtForAdd.Name = "txtForAdd";
            this.txtForAdd.Size = new System.Drawing.Size(68, 21);
            this.txtForAdd.TabIndex = 5;
            // 
            // txtForPort
            // 
            this.txtForPort.Location = new System.Drawing.Point(392, 470);
            this.txtForPort.Name = "txtForPort";
            this.txtForPort.Size = new System.Drawing.Size(68, 21);
            this.txtForPort.TabIndex = 6;
            // 
            // txtLocPort
            // 
            this.txtLocPort.Location = new System.Drawing.Point(89, 470);
            this.txtLocPort.Name = "txtLocPort";
            this.txtLocPort.Size = new System.Drawing.Size(68, 21);
            this.txtLocPort.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheck.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheck.Location = new System.Drawing.Point(555, 464);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 32);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "체크";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSave.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(466, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "txt";
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 505);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtForPort);
            this.Controls.Add(this.txtForAdd);
            this.Controls.Add(this.txtLocPort);
            this.Controls.Add(this.blForPort);
            this.Controls.Add(this.lblForAdd);
            this.Controls.Add(this.lblLocPort);
            this.Controls.Add(this.lvNetState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NetStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNetState;
        private System.Windows.Forms.Label lblLocPort;
        private System.Windows.Forms.Label lblForAdd;
        private System.Windows.Forms.Label blForPort;
        private System.Windows.Forms.TextBox txtForAdd;
        private System.Windows.Forms.TextBox txtForPort;
        private System.Windows.Forms.TextBox txtLocPort;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader clhLocalIP;
        private System.Windows.Forms.ColumnHeader clhLocalPort;
        private System.Windows.Forms.ColumnHeader clhRemoteIP;
        private System.Windows.Forms.ColumnHeader clhRemotePort;
        private System.Windows.Forms.ColumnHeader clhState;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}

