using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LP._1C.OS.L2.Processes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dX = (to - from) / 100000.0;
        }


        private int procCount = 1;
        private double from = 0.0, to = 1.0;
        private double dX;

        List<Process> processes = new List<Process>();

        private void button1_Click(object sender, EventArgs e)
        {
            //var process = new Process
            //{
            //    StartInfo =
            //    {
            //        FileName = "E:\\VS Projects\\LP.1C.OS.L2.Processes\\Teylor\\bin\\Debug\\Teylor.exe",
            //        //RedirectStandardOutput = true,
            //        UseShellExecute = false,
            //        Arguments = "0,0 1,0 "+ ((1.0 - 0.0)/100000.0).ToString()
            //    }
            //};
            //process.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            processes.Add(new Process
            {
                StartInfo =
                {
                    FileName = "E:\\VS Projects\\LP.1C.OS.L2.Processes\\Teylor\\bin\\Debug\\Teylor.exe",
                    UseShellExecute = false,
                    Arguments = string.Format("{0} {1} {2}",from, to, dX)
                }
            });
            
        }
        void AddNewListViewItem(string[] args)
        {
            var lvi = new ListViewItem() { Text = Name = args[0] };
            lvi.SubItems.Add(new System.Windows.Forms.ListViewItem.ListViewSubItem() { Text = Name = args[1] });
            lvi.SubItems.Add(new System.Windows.Forms.ListViewItem.ListViewSubItem() { Text = Name = args[2] });
            listView1.Items.Add(lvi);
        }

        private void NumerciUpdownValueChanged(object sender, EventArgs e)
        {
            var nupd = (NumericUpDown)sender;

            if (nupd.Name=="numericUpDown1")
            {
                from = (double)nupd.Value;
            }
            else if (nupd.Name == "numericUpDown2")
            {
                to = (double)nupd.Value;
            }
            else
            {
                procCount = (int)nupd.Value;
            }
        }

        private void CreateProcessbtnClick(object sender, EventArgs e)
        {
            dX = (to - from) / 100000.0;

            double tabDelta = (to - from) / procCount;

            for (double i = from; i < to; i+=tabDelta)
            {
                //return;
                var newProcess = new Process
                {
                    StartInfo =
                    {
                        FileName = "E:\\VS Projects\\LP.1C.OS.L2.Processes\\Teylor\\bin\\Debug\\Teylor.exe",
                        UseShellExecute = false,
                        
                        Arguments = string.Format("{0} {1} {2}", i, i+tabDelta, dX),
                    }
                };
                newProcess.EnableRaisingEvents = true;
                newProcess.Exited += newProcess_Exited;

                processes.Add(newProcess);

                processes[processes.Count - 1].Start();

                AddNewListViewItem(new string[] { newProcess.Id.ToString(), string.Format("[{0,10:f2};{1,10:0.f2}]", i, (i + tabDelta).ToString()), newProcess.PriorityClass.ToString() });

            }

        }
        delegate void listViewDelegate(Process proc2del);
        void DeleteElement(Process proc2del)
        {
            if (listView1.InvokeRequired)
            {
                BeginInvoke(new listViewDelegate(DeleteElement), new Process[] { proc2del });
                return;
            }
            else
            {
                int num = 0;
                IEnumerable<ListViewItem> lv = listView1.Items.Cast<ListViewItem>();
                var lvi = (from p in lv
                          where p.Text == proc2del.Id.ToString()
                          select p).SingleOrDefault();
                listView1.Items.Remove(lvi);
                listView1.Refresh();
            }
        }

        delegate void listViewRefreshDelegate();
        
        void newProcess_Exited(object sender, EventArgs e)
        {
            var senderProcess = (sender as Process);
            Process proc = (from p in processes where p.Id == (sender as Process).Id select p).SingleOrDefault();
            processes.Remove(proc);
            DeleteElement(proc);
        }
        private int procCounter = 0;
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            //MessageBox.Show("  ");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(" SelectedChanged ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach(Process p in processes)
                {
                    if (p.Id.ToString()==listView1.SelectedItems[0].Text)
                    {
                        p.Kill();
                        //p.Close();
                        //p.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the process from the list");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Process p in processes)
            {
                p.Kill();
                //p.Close();
                //p.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (Process p in processes)
                {
                    if (p.Id.ToString() == listView1.SelectedItems[0].Text)
                    {
                        //SuspendProcess(p.Handle);
                        NtResumeProcess(p.Handle);
                        //p.Start();//NtSuspendProcess(p.Handle);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the process from the list");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (Process p in processes)
                {
                    if (p.Id.ToString() == listView1.SelectedItems[0].Text)
                    {
                        NtSuspendProcess(p.Handle);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the process from the list");
            }
        }
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern IntPtr NtSuspendProcess(IntPtr ProcessHandle);
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern IntPtr NtResumeProcess(IntPtr ProcessHandle);
        //public static extern IntPtr ResumeThread(IntPtr ProcessHandle);

        //[DllImport("kernel32.dll", SetLastError = true)]
        //public static extern int SuspendThread(IntPtr ProcessHandle);


    }
}
