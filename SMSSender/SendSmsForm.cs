using ExcelDataReader;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSSender
{
    public partial class SendSmsForm : Form
    {
        public string SMSGatewayUrl { get; set; }
        public string SMSGatewayAuthCode { get; set; }
        public string MessageText { get; set; }
        public string LogFilePath { get; set; }

        public SendSmsForm()
        {
            InitializeComponent();
        }

        private void browserFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files (*.xls)|*.xlsx";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sFileName = openFileDialog1.FileName;
                filePathTextBox.Text = openFileDialog1.FileName.ToString();
            }
            else
            {
                filePathTextBox.Text = string.Empty;
            }
        }

        private void messageTextTextBox_TextChanged(object sender, EventArgs e)
        {
            totalCharactorsLabel.Text = string.Concat("Character Count: ", messageTextTextBox.Text.Count());
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SMSGatewayUrl = ConfigurationManager.AppSettings["SMS_GatewayURL"];
            SMSGatewayAuthCode = ConfigurationManager.AppSettings["SMS_Gateway_AuthCode"];

            if (string.IsNullOrEmpty(filePathTextBox.Text) || string.IsNullOrEmpty(messageTextTextBox.Text)
                || string.IsNullOrEmpty(SMSGatewayUrl) || string.IsNullOrEmpty(SMSGatewayAuthCode))
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //create log file for the current run
                string folderPath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, "Log\\");
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                LogFilePath = string.Concat(folderPath, DateTime.Now.ToString("yyyy-dd-M HH-mm-ss"), ".txt");

                LogInfo("SMS Sending Started at " + DateTime.Now.ToString("yyyy-dd-M HH-mm-ss"));

                string filePath = filePathTextBox.Text;
                MessageText = messageTextTextBox.Text;

                SendMessage(filePath);
            }
        }

        private async Task SendMessage(string filePath)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet dataSet = excelReader.AsDataSet();
            excelReader.Close();

            int ind = 0;

            for (int i = 0; i < dataSet.Tables.Count; i++)
            {
                int row_no = 1;
                while (row_no < dataSet.Tables[ind].Rows.Count)
                {
                    var currRow = dataSet.Tables[ind].Rows[row_no];

                    string phoneNumber = currRow[0].ToString();

                    await SendMessageAsync(phoneNumber, MessageText);

                    row_no++;
                }
                ind++;
            }

            LogInfo("SMS Sending Completed at " + DateTime.Now.ToString("yyyy-dd-M HH-mm-ss"));

            MessageText = string.Empty;
            filePathTextBox.Text = string.Empty;
            messageTextTextBox.Text = string.Empty;
            totalCharactorsLabel.Text = string.Concat("Character Count: ", messageTextTextBox.Text.Count());
            LogFilePath = string.Empty;

            MessageBox.Show(this, "Sending Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async Task SendMessageAsync(string Phone, string Message)
        {
            using (var stringContent = new StringContent("destination=" + Phone + "&q=" + SMSGatewayAuthCode + "&message=" + Message,
                                                            Encoding.UTF8, "application/x-www-form-urlencoded"))
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        var response = await client.PostAsync(SMSGatewayUrl, stringContent);
                        var result = await response.Content.ReadAsStringAsync();

                        if (result == "0")
                        {
                            LogInfo(Phone + " Sent at " + DateTime.Now.ToString("yyyy-dd-M HH-mm-ss"));
                        }
                        else
                        {
                            LogInfo(Phone + " Failed at " + DateTime.Now.ToString("yyyy-dd-M HH-mm-ss") + " " + result);
                        }

                    }
                    catch (Exception ex)
                    {
                        LogInfo(Phone + " Failed at " + DateTime.Now.ToString("yyyy-dd-M HH-mm-ss") + " - Exception " + ex.Message);

                    }
                }
            }
        }

        private void LogInfo(string logText)
        {
            using (StreamWriter sw = new StreamWriter(LogFilePath, true))
            {
                sw.WriteLine(logText);
            }
        }
    }
}
