using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.ServiceProcess;
using Microsoft.Win32;

namespace ServiceStatusChange
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        BackgroundWorker backGroundWorker = new BackgroundWorker();
        public WindowsServiceMonitor _windowsServiceMonitor { get; set; }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            FillServices();
            StatusToolStripProgressBar.Visible = false;
        }

        private void FillServices()
        {
            ServicesDataGridView.Rows.Clear();
            ServicesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServicesDataGridView.ColumnCount = 3;
            ServicesDataGridView.Columns[0].Name = "Name";
            ServicesDataGridView.Columns[0].Width = 125;
            ServicesDataGridView.Columns[1].Name = "Display Name";
            ServicesDataGridView.Columns[1].Width = 350;
            ServicesDataGridView.Columns[2].Name = "Status";

            ServiceController[] services = ServiceController.GetServices();
            string[] row;
            foreach (ServiceController service in services)
            {
                if (service.ServiceName.Contains("SP"))
                {
                    row = new string[] { service.ServiceName, service.DisplayName, service.Status.ToString() };
                    ServicesDataGridView.Rows.Add(row);
                }
            }

        }

        private void ChangeServiceStatus(string status)
        {
            try
            {
                string message = string.Empty;
                StatusToolStripStatusLabel.Text = "Please wait";
                StatusToolStripProgressBar.Visible = true;

                ProgressBar();
                foreach (DataGridViewRow row in ServicesDataGridView.SelectedRows)
                {
                    
                    _windowsServiceMonitor = new WindowsServiceMonitor(row.Cells[0].Value.ToString());
                    switch (status)
                    {
                        case "Start": _windowsServiceMonitor.Start();
                            break;
                        case "Stop": _windowsServiceMonitor.Stop();
                            break;
                        case "Restart": _windowsServiceMonitor.Restart();
                            break;
                        case "Disable": _windowsServiceMonitor.Disable();
                            break;
                        case "Enable": _windowsServiceMonitor.Enable();
                            break;
                        default:
                            break;
                    }
                    FillServices();
                    
                    message += row.Cells[0].Value.ToString() + ", ";

                }
                StatusToolStripStatusLabel.Text = string.Format("{0} service(s) status changed.", message);

            }
            catch (Exception ex)
            {
                StatusToolStripStatusLabel.Text = ex.Message;
            }
        }

        private void ProgressBar()
        {
            backGroundWorker.RunWorkerAsync();

            backGroundWorker.DoWork += new DoWorkEventHandler(backGroundWorker_DoWork);
            backGroundWorker.ProgressChanged += new ProgressChangedEventHandler(backGroundWorker_ProgressChanged);
            backGroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backGroundWorker_RunWorkerCompleted);
            backGroundWorker.WorkerReportsProgress = true;

        }

        void backGroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StatusToolStripProgressBar.Visible = false;
        }

        void backGroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StatusToolStripProgressBar.Value = e.ProgressPercentage;
        }

        void backGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                backGroundWorker.ReportProgress(i);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void EnabledButton_Click(object sender, EventArgs e)
        {
            ChangeServiceStatus("Enable");
        }

        private void DisabledButton_Click(object sender, EventArgs e)
        {
            ChangeServiceStatus("Disable");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ChangeServiceStatus("Start");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ChangeServiceStatus("Stop");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            ChangeServiceStatus("Restart");
        }
    }
}
