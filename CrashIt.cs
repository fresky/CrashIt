using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CrashIt
{
    public partial class CrashIt : Form
    {
        public CrashIt()
        {
            InitializeComponent();
            InitWatchList();
        }

        private void InitWatchList()
        {
            listView_WatchList.Columns.Add("PID", 45);
            listView_WatchList.Columns.Add("Process Name", 120);
            listView_WatchList.Columns.Add("Title", 200);

            RefreshProcess();
        }

        private void RefreshProcess()
        {
            listView_WatchList.Items.Clear();
            List<string> watchList = new List<string>();
            var watchlistFile = "Watchlist.txt";
            if (File.Exists(watchlistFile))
            {
                using (StreamReader sr = new StreamReader(watchlistFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        watchList.Add(line.Trim());
                    }
                }
            }
            else
            {
                watchList = new List<string>
                {
                    "ExeJobManager",
                    "NewConsole",
                    "WLAcquisitionService",
                    "ComputationServer",
                    "ComputationService",
                    "FrontEndService",
                    "EventDispatcher",
                    "FrameworkCache",
                    "ExeExecutionManager",
                    "HzStartupManager",
                    "InstrumentationCache",
                    "MsgMMFWriter"
                };
            }
            
            

            foreach (var name in watchList)
            {
                foreach (var process in Process.GetProcessesByName(name).Where(p=>!p.HasExited))
                {
                    listView_WatchList.Items.Add(new ListViewItem(new string[]
                        {process.Id.ToString(), process.ProcessName, process.MainWindowTitle}));
                }
            }
        }

        private void listView_WatchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listView_WatchList.SelectedItems;
            if (selectedItems.Count > 0)
            {
                textBox_PID.Text = selectedItems[0].Text;
            }
        }

        private void button_Crash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PID.Text) || !int.TryParse(textBox_PID.Text, out var pid) ||
                !CrashInjecter.Crash(pid))
            {
                MessageBox.Show("Please tell me the process ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            button_Refresh.Enabled = false;
            RefreshProcess();
            button_Refresh.Enabled = true;
        }
    }
}
