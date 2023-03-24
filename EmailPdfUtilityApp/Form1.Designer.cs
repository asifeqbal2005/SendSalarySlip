namespace EmailPdfUtilityApp
{
    partial class frmSalarySlip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabSmtp = new System.Windows.Forms.TabPage();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tblName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseLogPath = new System.Windows.Forms.Button();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.BrowseFolderButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSmtp.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Browse Files";
            // 
            // tabSmtp
            // 
            this.tabSmtp.Controls.Add(this.txtPort);
            this.tabSmtp.Controls.Add(this.txtUser);
            this.tabSmtp.Controls.Add(this.txtPwd);
            this.tabSmtp.Controls.Add(this.txtHost);
            this.tabSmtp.Controls.Add(this.btnSave);
            this.tabSmtp.Controls.Add(this.label2);
            this.tabSmtp.Controls.Add(this.tblName);
            this.tabSmtp.Controls.Add(this.lblUserName);
            this.tabSmtp.Controls.Add(this.lblPassword);
            this.tabSmtp.Controls.Add(this.lblHost);
            this.tabSmtp.Location = new System.Drawing.Point(4, 24);
            this.tabSmtp.Name = "tabSmtp";
            this.tabSmtp.Padding = new System.Windows.Forms.Padding(3);
            this.tabSmtp.Size = new System.Drawing.Size(876, 422);
            this.tabSmtp.TabIndex = 1;
            this.tabSmtp.Text = "SMTP Configuration";
            this.tabSmtp.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(115, 57);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(275, 23);
            this.txtPort.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(115, 134);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(275, 23);
            this.txtUser.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(115, 166);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(275, 23);
            this.txtPwd.TabIndex = 3;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(115, 28);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(275, 23);
            this.txtHost.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Network Credential:";
            // 
            // tblName
            // 
            this.tblName.AutoSize = true;
            this.tblName.Location = new System.Drawing.Point(34, 59);
            this.tblName.Name = "tblName";
            this.tblName.Size = new System.Drawing.Size(29, 15);
            this.tblName.TabIndex = 6;
            this.tblName.Text = "Port";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(34, 136);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 15);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(34, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(34, 30);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 15);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.txtFromEmail);
            this.tabGeneral.Controls.Add(this.lblEmailFrom);
            this.tabGeneral.Controls.Add(this.txtEmailBody);
            this.tabGeneral.Controls.Add(this.txtSubject);
            this.tabGeneral.Controls.Add(this.txtExcelFile);
            this.tabGeneral.Controls.Add(this.txtLogPath);
            this.tabGeneral.Controls.Add(this.txtPath);
            this.tabGeneral.Controls.Add(this.lblBody);
            this.tabGeneral.Controls.Add(this.lblSubject);
            this.tabGeneral.Controls.Add(this.btnBrowseExcel);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.btnBrowseLogPath);
            this.tabGeneral.Controls.Add(this.lblLogPath);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.btnSend);
            this.tabGeneral.Controls.Add(this.BrowseFolderButton);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(876, 422);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Location = new System.Drawing.Point(19, 199);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(300, 23);
            this.txtFromEmail.TabIndex = 17;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(19, 181);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(70, 15);
            this.lblEmailFrom.TabIndex = 16;
            this.lblEmailFrom.Text = "Email From:";
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(460, 91);
            this.txtEmailBody.Multiline = true;
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(378, 136);
            this.txtEmailBody.TabIndex = 15;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(460, 37);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(378, 23);
            this.txtSubject.TabIndex = 13;
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(19, 146);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(300, 23);
            this.txtExcelFile.TabIndex = 8;
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(19, 91);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(300, 23);
            this.txtLogPath.TabIndex = 5;
            this.txtLogPath.Text = "D:\\Logs";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(19, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(300, 23);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "D:\\SalarySlips";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(457, 73);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(37, 15);
            this.lblBody.TabIndex = 14;
            this.lblBody.Text = "Body:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(457, 19);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 15);
            this.lblSubject.TabIndex = 12;
            this.lblSubject.Text = "Subject:";
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.Location = new System.Drawing.Point(327, 146);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(70, 25);
            this.btnBrowseExcel.TabIndex = 9;
            this.btnBrowseExcel.Text = "Browse";
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Excel File:";
            // 
            // btnBrowseLogPath
            // 
            this.btnBrowseLogPath.Location = new System.Drawing.Point(327, 90);
            this.btnBrowseLogPath.Name = "btnBrowseLogPath";
            this.btnBrowseLogPath.Size = new System.Drawing.Size(70, 25);
            this.btnBrowseLogPath.TabIndex = 6;
            this.btnBrowseLogPath.Text = "Browse";
            this.btnBrowseLogPath.UseVisualStyleBackColor = true;
            this.btnBrowseLogPath.Click += new System.EventHandler(this.btnBrowseLogPath_Click);
            // 
            // lblLogPath
            // 
            this.lblLogPath.AutoSize = true;
            this.lblLogPath.Location = new System.Drawing.Point(17, 73);
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.Size = new System.Drawing.Size(57, 15);
            this.lblLogPath.TabIndex = 4;
            this.lblLogPath.Text = "Log Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salary Slips Path:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(717, 252);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 38);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Now";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.Location = new System.Drawing.Point(327, 36);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.Size = new System.Drawing.Size(70, 25);
            this.BrowseFolderButton.TabIndex = 3;
            this.BrowseFolderButton.Text = "Browse";
            this.BrowseFolderButton.UseVisualStyleBackColor = true;
            this.BrowseFolderButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabSmtp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // frmSalarySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSalarySlip";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSalarySlip_Load);
            this.tabSmtp.ResumeLayout(false);
            this.tabSmtp.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
        private OpenFileDialog openFileDialog1;
        private TabPage tabSmtp;
        private TextBox txtPort;
        private TextBox txtUser;
        private TextBox txtPwd;
        private TextBox txtHost;
        private Button btnSave;
        private Label label2;
        private Label tblName;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblHost;
        private TabPage tabGeneral;
        private TextBox txtFromEmail;
        private Label lblEmailFrom;
        private TextBox txtEmailBody;
        private TextBox txtSubject;
        private TextBox txtExcelFile;
        private TextBox txtLogPath;
        private TextBox txtPath;
        private Label lblBody;
        private Label lblSubject;
        private Button btnBrowseExcel;
        private Label label3;
        private Button btnBrowseLogPath;
        private Label lblLogPath;
        private Label label1;
        private Button btnSend;
        private Button BrowseFolderButton;
        private TabControl tabControl1;
    }
}