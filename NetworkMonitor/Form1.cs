using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using System.ComponentModel;

namespace NetworkMonitor
{
    public partial class Form1 : Form
    {
        //public const string urlMyIP = "http://myip.dnsdynamic.com/";
        public const string urlDNSIP = "http://checkip.dyndns.org/";
        public const string urlVodafone = "http://www.vodafone.co.nz";
        public const string urlTeresoft = "www.teresoft.co.nz";
        public const string urlGoogle = "google.com";
        public int frequency = 0;
        public int cycles = 0;
        public int count = 0;
        public int countChangedIPs = 0;
        public int nwErrors = 0;
        public double totalDowntime = 0;
        public double maxDowntime = 0;
        public StreamWriter sw;

        public string previousIP = "0.0.0.0";
        public DateTimeOffset startDT = new DateTimeOffset();
        public DateTimeOffset beginningDT = new DateTimeOffset();
        public DateTimeOffset LastChangeDT = new DateTimeOffset();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            DateTimeOffset dT = DateTimeOffset.Now;
            StringBuilder sb = new StringBuilder();

            try
            {
                frequency = 0;
                cycles = 0;
                textExternalIP.Text = "";
                textResponseTime.Text = "";
                textElapsedms.Text = "";
                textEndTime.Text = "";
                textStartTime.Text = "";
                textDownTime.Text = "";
                textMaxDownTime.Text = "";
                textTotalDownTime.Text = "";
                textLastScan.Text = "";
                textRunningTime.Text = "";
                textLastChangeTime.Text = "";
                textPreviousIP.Text = previousIP;

                if (int.TryParse(comboFrequency.Text, out frequency) && int.TryParse(textMaximumCycles.Text, out cycles))
                {
                    if (bw.IsBusy != true)
                    {
                        startDT = dT;
                        beginningDT = dT;
                        textStartTime.Text = dT.ToString("yyyy-MM-dd HH:mm:ss");
                        sb.Append("Starting ").Append(cycles.ToString()).Append(" cycles at ");
                        sb.Append(frequency.ToString()).Append(" seconds per cycle");
                        textStatus.Text = sb.ToString();
                        textStatus.Refresh();
                        sb.Clear();
                        sb.Append(textFileLocation.Text).Append(@"\MonitorData-");
                        sb.Append(dT.ToString("yyyyMMdd")).Append(".txt");
                        sw = new StreamWriter(sb.ToString(), true);

                        bw.RunWorkerAsync();    // Start the asynchronous operation.
                    }
                }
                else
                {
                    textStatus.Text = "Invalid Frequency and/or Maximum cycle count";
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                textStatus.Text = "Err: " + s;
            }

            textStatus.Refresh();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                bw.CancelAsync();
            }
        }

        private IPData TestAddress(string hostName)
        {
            IPData ipd = new IPData();

            try
            {
                ipd.CheckTime = DateTime.Now;
                Ping ping = new Ping();
                string address = GetIPAddress(hostName);
                PingReply replay = ping.Send(address);
                if (replay.Status == IPStatus.Success)
                {
                    ipd.ResponseTime = replay.RoundtripTime;
                    ipd.ExternalIP = GetExternalIPAddress(urlDNSIP);
                    ipd.Status = "Good";
                }
                else
                {
                    ipd.ResponseTime = replay.RoundtripTime;
                    ipd.ExternalIP = GetExternalIPAddress(urlDNSIP);
                    ipd.Status = replay.Status.ToString();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                ipd.ResponseTime = -1;
                ipd.ExternalIP = "0.0.0.0";
                ipd.Status = "Err: " + ex.Message;
            }

            return ipd;

        }

        private string GetIPAddress(string hostName)
        {
            string sResult = "";
            try
            {
                IPHostEntry host = Dns.GetHostEntry(hostName);
                sResult = host.AddressList[0].ToString();
            }
            catch (Exception ex)
            {
                sResult = "Err: " + ex.Message;
            }

            return sResult;

        }

        private string GetExternalIPAddress(string url)
        {
            string sResult = "";

            try
            {
                string externalIPstring = GetHttpTextData(url);
                if (externalIPstring.Contains(":"))
                {
                    string[] parts = externalIPstring.Split(':');
                    string[] smallerParts = parts[1].Split('<');
                    sResult = smallerParts[0].Trim();
                }
                else
                {
                    sResult = externalIPstring.Substring(0, 50);
                }
            }
            catch (Exception ex)
            {
                sResult = ex.Message;
            }

            return sResult;

        }
        private string GetHttpTextData(string url)
        {
            string responseData = "";
            string urlDataRequest = url;

            try
            {
                HttpWebRequest webRequest = WebRequest.Create(urlDataRequest) as HttpWebRequest;
                webRequest.Accept = "text/html";

                StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                responseData = responseReader.ReadToEnd();
                responseReader.Close();
                responseReader = null;
            }
            catch (Exception ex)
            {
                responseData = "Exception: " + ex.Message;
            }

            return responseData;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Stopwatch sw = new Stopwatch();
            DateTimeOffset dT = DateTimeOffset.Now;
            StringBuilder sb = new StringBuilder();
            IPData ipd = new IPData();

            try
            {
                while (true)
                {
                    if (worker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        e.Result = "Cancelled";
                        break;
                    }
                    else
                    {
                        dT = DateTimeOffset.Now;
                        sw.Start();
                        ipd = TestAddress(urlTeresoft);
                        sw.Stop();
                        ipd.ElapsedMilliseconds = sw.ElapsedMilliseconds;
                        count++;
                        worker.ReportProgress(count, ipd);
                        sw.Reset();
                        if (cycles > 0 && count >= cycles)
                        {
                            e.Result = "Cycle maximum reached";
                            break;
                        }

                        Thread.Sleep(frequency * 1000);
                    }
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                DateTimeOffset dT = DateTimeOffset.Now;
                StringBuilder sb = new StringBuilder();
                IPData ipd = new IPData();
                TimeSpan ts = new TimeSpan();
                ipd = (IPData)e.UserState;

                textExternalIP.Text = ipd.ExternalIP;


                if (textExternalIP.Text != previousIP)
                {
                    if (previousIP != "0.0.0.0")
                    {
                        string[] parts = ipd.ExternalIP.Split('.');

                        if (parts.Length == 4)  //then numbers
                            countChangedIPs++;
                        else // Error text
                            nwErrors++;

                        textNWErrors.Text = nwErrors.ToString();
                        textPreviousIP.Text = previousIP;
                        previousIP = ipd.ExternalIP;
                        
                        sb.Clear();
                        sb.Append(countChangedIPs.ToString());
                        textIPChangeCount.Text = sb.ToString();
                        ts = dT - startDT;
                        LastChangeDT = dT;
                        textDownTime.Text = ts.TotalMilliseconds.ToString() + " ms";
                        if (ts.TotalMilliseconds > maxDowntime)
                            maxDowntime = ts.TotalMilliseconds;

                        if (countChangedIPs > 1)
                            totalDowntime += ts.TotalMilliseconds;
                    }
                }
                else
                {
                    startDT = dT;
                    ts = dT - startDT;
                    textDownTime.Text = ts.TotalMilliseconds.ToString() + " ms";
                }

                ts = dT - beginningDT;
                sb.Clear();
                sb.Append(ts.Duration().ToString());
                sb.Length -= 8;
                textRunningTime.Text = sb.ToString();                
                textLastScan.Text = dT.ToString("yyyy-MM-dd HH:mm:ss");
                textMaxDownTime.Text = (maxDowntime/1000).ToString("F2") + " secs"; ;
                textResponseTime.Text = ipd.ResponseTime.ToString() + " ms";
                textElapsedms.Text = ipd.ElapsedMilliseconds.ToString() + " ms";

                textLastChangeTime.Text = LastChangeDT.ToString("yyyy-MM-dd HH:mm:ss");
                textTotalDownTime.Text = (totalDowntime/1000).ToString("F2") + " secs";
                sb.Clear();
                sb.Append(dT.ToString("yyyy-MM-dd HH:mm:ss"));
                sb.Append(" - Cycle:  ").Append(e.ProgressPercentage.ToString());
                sb.Append(", External IP: ").Append(ipd.ExternalIP);
                sb.Append(", Ping Time: ").Append(ipd.ResponseTime.ToString()).Append(" ms");
                sb.Append(", Cycle Time: ").Append(ipd.ElapsedMilliseconds.ToString()).Append(" ms");
                sb.AppendLine();
                string text = textLogs.Text;
                sb.Append(text);
                textLogs.Text = sb.ToString();
                textLogs.Refresh();

                if (checkSaveFile.Checked == true && textFileLocation.Text != "")
                {
                    if (sw != null)
                    {
                        sb.Clear();
                        sb.Append(dT.ToString("yyyy-MM-dd HH:mm:ss"));
                        sb.Append(" External IP: ").Append(ipd.ExternalIP);
                        sb.Append(", Previous IP: ").Append(previousIP);
                        sb.Append(", Failed Duration: ").Append(textDownTime.Text);
                        sb.Append(", Ping Time: ").Append(textResponseTime.Text);
                        sb.Append(", Cycle Time: ").Append(textElapsedms.Text);
                        sw.WriteLine(sb.ToString());
                        sw.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    textStatus.Text = "Monitoring has been cancelled";
                }
                else if (e.Error != null)
                {
                    textStatus.Text = "Error. Details: " + (e.Error as Exception).ToString();
                }
                else
                {
                    textStatus.Text = "Monitoring has been completed. Results: " + e.Result.ToString();
                }

                DateTimeOffset dT = DateTimeOffset.Now;
                textEndTime.Text = dT.ToString("yyyy-MM-dd HH:mm:ss");
                sw.Close();
                sw.Dispose();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSearchDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
                textFileLocation.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

    public class IPData
    {
        public long ElapsedMilliseconds { get; set; }
        public long ResponseTime { get; set; }
       
        public string ExternalIP { get; set; }
        public DateTime CheckTime { get; set; }
        public string Status { get; set; }
    }
}
