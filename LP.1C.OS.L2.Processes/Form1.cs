using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        }

        private int procCount = 1;
        private double from = 0.0, to = 1.0;
        private double dX;
        StreamWriter w = new StreamWriter("E:\\TeylorLog.txt");
        List<Process> processes = new List<Process>();

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

        //private bool isFirst = true;
        private void CreateProcessbtnClick(object sender, EventArgs e)
        {
            dX = (to - from) / 100000.0;
            //MessageBox.Show(dX.ToString


            double tabDelta = (to - from) / procCount;

            for (double i = from; i + tabDelta <= to; i+=tabDelta)
            {
                var newProcess = new Process
                {
                    StartInfo =
                    {
                        FileName = "E:\\VS Projects\\LP.1C.OS.L2.Processes\\Teylor\\bin\\Debug\\Teylor.exe",
                        UseShellExecute = false,
                        
                        Arguments = string.Format("{0} {1} {2}", i, i+tabDelta, dX),

                    }
                };


                w.WriteLine(dX);
                w.WriteLine(to);
                w.WriteLine(from+"\n");


                newProcess.EnableRaisingEvents = true;
                newProcess.Exited += newProcess_Exited;

                processes.Add(newProcess);

                processes[processes.Count - 1].Start();

                AddNewListViewItem(new string[] { newProcess.Id.ToString(), string.Format("[{0,10:f2};{1,10:0.f2}]", i, (i + tabDelta).ToString()), newProcess.PriorityClass.ToString() });
            }
            //w.Close();
            st = processes[0].StartTime;
            Counter = processes.Count;

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
                
                if (listView1.Items.Count<1)
                {
                    var lvi2 = new ListViewItem() { Text = Counter.ToString() };
                    SetEndTime(proc2del);
                    TimeSpan dtm = new TimeSpan();
                    dtm = end - st;
                    lvi2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtm.Seconds.ToString() + "." + dtm.Milliseconds.ToString() });
                    listView2.Items.Add(lvi2);
                }
            }
        }
        private int Counter = 0;
        private List<TimeSpan> dtlist = new List<TimeSpan>();

        delegate void SetEndTimeDelegate(Process proc);
        void SetEndTime(Process proc)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SetEndTimeDelegate(SetEndTime), new Process[] { proc });
                return;
            }
            else
            {
                end = proc.ExitTime;
            }
        }        

        private DateTime st;
        private DateTime end;
        void newProcess_Exited(object sender, EventArgs e)
        {
            var senderProcess = (sender as Process);
            Process proc = (from p in processes where p.Id == (sender as Process).Id select p).SingleOrDefault();
            processes.Remove(proc);

            var dtspan = proc.ExitTime - proc.StartTime;
            
            DeleteElement(proc);
        }
        private int procCounter = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach(Process p in processes)
                    if (p.Id.ToString()==listView1.SelectedItems[0].Text)
                        p.Kill();
            else
                MessageBox.Show("Select the process from the list");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Process p in processes)
                p.Kill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (Process p in processes)
                    if (p.Id.ToString() == listView1.SelectedItems[0].Text)
                        NtResumeProcess(p.Handle);
            else
                MessageBox.Show("Select the process from the list");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (Process p in processes)
                    if (p.Id.ToString() == listView1.SelectedItems[0].Text)
                        NtSuspendProcess(p.Handle);
            else
                MessageBox.Show("Select the process from the list");
        }


        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern IntPtr NtSuspendProcess(IntPtr ProcessHandle);
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern IntPtr NtResumeProcess(IntPtr ProcessHandle);


        private void PriorityStateChanged(object sender, EventArgs e)
        {
            var sBtn = sender as RadioButton;

            if (listView1.SelectedItems.Count > 0)
                foreach (Process p in processes)
                    if (p.Id.ToString() == listView1.SelectedItems[0].Text)
                    {
                        if (sBtn == IdlePriorityBtn)
                            p.PriorityClass = ProcessPriorityClass.Idle;
                        if (sBtn == BelowNormalPriorityBtn)
                            p.PriorityClass = ProcessPriorityClass.BelowNormal;
                        if (sBtn == NormalPriorityBtn)
                            p.PriorityClass = ProcessPriorityClass.Normal;
                        if (sBtn == AboveNormalPriorityBtn)
                            p.PriorityClass = ProcessPriorityClass.AboveNormal;
                        if (sBtn == HighPriorityBtn)
                            p.PriorityClass = ProcessPriorityClass.High;
                        if (sBtn == RealTimePriorityBtn)
                            p.PriorityClass = ProcessPriorityClass.RealTime;

                        listView1.SelectedItems[0].SubItems[2].Text = p.PriorityClass.ToString();
                    }
        }
        void PrioritiesReset()
        {
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrioritiesReset();
        }

    }
}
