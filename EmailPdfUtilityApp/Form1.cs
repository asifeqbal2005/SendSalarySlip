using IronXL;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
//using Excel = Microsoft.Office.Interop.Excel;

namespace EmailPdfUtilityApp
{
    public partial class frmSalarySlip : Form
    {
        private SmtpClient smtpClient { get; set; }
        public frmSalarySlip()
        {
            InitializeComponent();  
            smtpClient = this.ConfigureSmtpClient();
        }

        private void frmSalarySlip_Load(object sender, EventArgs e)
        {
            this.LoadSmtpSettings();            
        }

        private void LoadSmtpSettings()
        {
            txtHost.Text = SmtpSetting.Default.Host;
            txtPort.Text = SmtpSetting.Default.Port.ToString();
            txtUser.Text = SmtpSetting.Default.UserName;
            txtPwd.Text = SmtpSetting.Default.Password;
        }

        private void SaveSmtpSettings()
        {            
            SmtpSetting.Default.Host = txtHost.Text;
            SmtpSetting.Default.Port = Convert.ToInt32(txtPort.Text);
            SmtpSetting.Default.UserName = txtUser.Text;
            SmtpSetting.Default.Password = txtPwd.Text;
            SmtpSetting.Default.Save();

            MessageBox.Show("Configuration Saved!", "SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private SmtpClient ConfigureSmtpClient()
        {
            var smtpClient = new SmtpClient()
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Host = SmtpSetting.Default.Host,
                Port = SmtpSetting.Default.Port,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(SmtpSetting.Default.UserName, SmtpSetting.Default.Password),
                EnableSsl = false
            };
            return smtpClient;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {            
            string sFileName = txtExcelFile.Text.Trim();
            if (!string.IsNullOrEmpty(sFileName))
            {
                string fileExt = Path.GetExtension(sFileName);
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = this.ReadExcelFile(sFileName);
                        System.Data.DataView view = new System.Data.DataView(dtExcel);
                        DataTable table2 = view.ToTable(false, "month", "NAME", "ECN", "EMAILID");
                        if (table2 != null && table2.Rows.Count > 0)
                        {
                            int totalCounts = table2.Rows.Count;
                            int counter = 0;
                            List<string> lstFailed = new List<string>();
                            string? month = string.Empty;
                            string? name = string.Empty;
                            string? toEmailId = string.Empty;
                            string? ecn = string.Empty;
                            string pdfFilename = string.Empty;
                            bool result = false;                            

                            EmailConfigModel emailConfig = new EmailConfigModel()
                            {
                                FromEmailId = txtFromEmail.Text.Trim(),
                                Subject = txtSubject.Text,
                                EmailBody = txtEmailBody.Text
                            };

                            string logFilePath = txtLogPath.Text.Trim();

                            foreach (DataRow row in table2.Rows)
                            {
                                pdfFilename = string.Empty;
                                result = false;
                                month = row["month"].ToString();
                                name = row["NAME"].ToString();
                                toEmailId = row["EMAILID"].ToString();
                                ecn = row["ECN"].ToString();

                                try
                                {
                                    if (!string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(toEmailId) && !string.IsNullOrEmpty(ecn))
                                    {
                                        pdfFilename = string.Format("{0}_{1}_{2}.pdf", month, ecn, name);                                                                                
                                        result = this.SendMail(emailConfig, toEmailId, pdfFilename);
                                        if (result)
                                        {
                                            WriteLog(logFilePath, string.Format("{0} - {1} => {2} ON {3} {4}", ecn, toEmailId, "Success", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString()));
                                            counter++;
                                        }
                                        else
                                        {
                                            WriteLog(logFilePath, string.Format("{0} - {1} => {2}", ecn, toEmailId, "Failed"));
                                            lstFailed.Add(string.Format("{0} - {1}", ecn, toEmailId));
                                        }
                                    }
                                    else
                                    {
                                        WriteLog(logFilePath, string.Format("{0} - {1} => {2}", ecn, toEmailId, "Failed"));
                                        lstFailed.Add(string.Format("{0} - {1}", ecn, toEmailId));
                                    }
                                }
                                catch
                                {
                                    WriteLog(logFilePath, string.Format("{0} - {1} => {2}", ecn, toEmailId, "Failed"));
                                }
                            }

                            if (totalCounts == counter)
                            {
                                MessageBox.Show("Salary Slip sent.", "Message");
                            }
                            else
                            {
                                string joined = string.Join(",", lstFailed);
                                string msg = string.Format("Email failed to employees: {0}", joined);
                                MessageBox.Show(msg, "Information");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception" + ex.Message);
                    }
                }
            }
        }

        private DataTable ReadExcelFile(string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            
            // Work with a single WorkSheet.
            //you can pass static sheet name like Sheet1 to get that sheet
            //WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            //You can also use workbook.DefaultWorkSheet to get default in case you want to get first sheet only
            WorkSheet sheet = workbook.DefaultWorkSheet;            
            
            //Convert the worksheet to System.Data.DataTable
            //Boolean parameter sets the first row as column names of your table.
            return sheet.ToDataTable(true);
        }

        private bool SendMail(EmailConfigModel emailConfig, string toEmailId, string fileName)
        {            
            using (MailMessage mailMessage = new MailMessage(emailConfig.FromEmailId, toEmailId))
            {
                mailMessage.Subject = emailConfig.Subject;
                mailMessage.Body = emailConfig.EmailBody;
                mailMessage.IsBodyHtml = false;
                
                string filePath = string.Format(@"{0}\{1}",txtPath.Text, fileName);
                if (File.Exists(filePath))
                {
                    mailMessage.Attachments.Add(new Attachment(filePath));
                }                                               

                this.smtpClient.Send(mailMessage);
                return true;
            }
        }       
        
        public static void WriteLog(string logFilePath, string logMessage)
        {
            StreamWriter log;
            FileStream fileStream;

            //string logFilePath = txtLogPath.Text.Trim(); //"C:\\Logs\\";
            System.IO.Directory.CreateDirectory(logFilePath);
            logFilePath = Path.Combine(logFilePath, "Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt");            
            FileInfo logFileInfo = new FileInfo(logFilePath);            
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }

            log = new StreamWriter(fileStream);
            log.WriteLine(logMessage);
            log.Close();
        }

        private void BrowseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;              
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnBrowseLogPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg1 = new FolderBrowserDialog();
            folderDlg1.ShowNewFolderButton = true;              
            DialogResult result = folderDlg1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtLogPath.Text = folderDlg1.SelectedPath;
                Environment.SpecialFolder root = folderDlg1.RootFolder;
            }
        }

        private void btnBrowseExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtExcelFile.Text = openFileDialog1.FileName;
            }
        }
                
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSmtpSettings();
        }
    }

    public class EmailConfigModel
    {
        public string FromEmailId { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }
    }
}