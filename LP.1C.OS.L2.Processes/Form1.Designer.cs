namespace LP._1C.OS.L2.Processes
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BelowNormalPriorityBtn = new System.Windows.Forms.RadioButton();
            this.AboveNormalPriorityBtn = new System.Windows.Forms.RadioButton();
            this.RealTimePriorityBtn = new System.Windows.Forms.RadioButton();
            this.NormalPriorityBtn = new System.Windows.Forms.RadioButton();
            this.IdlePriorityBtn = new System.Windows.Forms.RadioButton();
            this.HighPriorityBtn = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tab range";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown2.Location = new System.Drawing.Point(62, 47);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumerciUpdownValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(62, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumerciUpdownValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Startup params";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(62, 24);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.NumerciUpdownValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Count";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BelowNormalPriorityBtn);
            this.groupBox3.Controls.Add(this.AboveNormalPriorityBtn);
            this.groupBox3.Controls.Add(this.RealTimePriorityBtn);
            this.groupBox3.Controls.Add(this.NormalPriorityBtn);
            this.groupBox3.Controls.Add(this.IdlePriorityBtn);
            this.groupBox3.Controls.Add(this.HighPriorityBtn);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 393);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processes";
            // 
            // BelowNormalPriorityBtn
            // 
            this.BelowNormalPriorityBtn.AutoSize = true;
            this.BelowNormalPriorityBtn.Location = new System.Drawing.Point(171, 345);
            this.BelowNormalPriorityBtn.Name = "BelowNormalPriorityBtn";
            this.BelowNormalPriorityBtn.Size = new System.Drawing.Size(88, 17);
            this.BelowNormalPriorityBtn.TabIndex = 13;
            this.BelowNormalPriorityBtn.TabStop = true;
            this.BelowNormalPriorityBtn.Text = "Below normal";
            this.BelowNormalPriorityBtn.UseVisualStyleBackColor = true;
            this.BelowNormalPriorityBtn.CheckedChanged += new System.EventHandler(this.PriorityStateChanged);
            // 
            // AboveNormalPriorityBtn
            // 
            this.AboveNormalPriorityBtn.AutoSize = true;
            this.AboveNormalPriorityBtn.Location = new System.Drawing.Point(261, 325);
            this.AboveNormalPriorityBtn.Name = "AboveNormalPriorityBtn";
            this.AboveNormalPriorityBtn.Size = new System.Drawing.Size(90, 17);
            this.AboveNormalPriorityBtn.TabIndex = 12;
            this.AboveNormalPriorityBtn.TabStop = true;
            this.AboveNormalPriorityBtn.Text = "Above normal";
            this.AboveNormalPriorityBtn.UseVisualStyleBackColor = true;
            this.AboveNormalPriorityBtn.CheckedChanged += new System.EventHandler(this.PriorityStateChanged);
            // 
            // RealTimePriorityBtn
            // 
            this.RealTimePriorityBtn.AutoSize = true;
            this.RealTimePriorityBtn.Location = new System.Drawing.Point(261, 365);
            this.RealTimePriorityBtn.Name = "RealTimePriorityBtn";
            this.RealTimePriorityBtn.Size = new System.Drawing.Size(99, 17);
            this.RealTimePriorityBtn.TabIndex = 11;
            this.RealTimePriorityBtn.TabStop = true;
            this.RealTimePriorityBtn.Text = "Realtime priority";
            this.RealTimePriorityBtn.UseVisualStyleBackColor = true;
            this.RealTimePriorityBtn.CheckedChanged += new System.EventHandler(this.PriorityStateChanged);
            // 
            // NormalPriorityBtn
            // 
            this.NormalPriorityBtn.AutoSize = true;
            this.NormalPriorityBtn.Location = new System.Drawing.Point(171, 365);
            this.NormalPriorityBtn.Name = "NormalPriorityBtn";
            this.NormalPriorityBtn.Size = new System.Drawing.Size(91, 17);
            this.NormalPriorityBtn.TabIndex = 9;
            this.NormalPriorityBtn.TabStop = true;
            this.NormalPriorityBtn.Text = "Normal priority";
            this.NormalPriorityBtn.UseVisualStyleBackColor = true;
            this.NormalPriorityBtn.CheckedChanged += new System.EventHandler(this.PriorityStateChanged);
            // 
            // IdlePriorityBtn
            // 
            this.IdlePriorityBtn.AutoSize = true;
            this.IdlePriorityBtn.Checked = true;
            this.IdlePriorityBtn.Location = new System.Drawing.Point(171, 325);
            this.IdlePriorityBtn.Name = "IdlePriorityBtn";
            this.IdlePriorityBtn.Size = new System.Drawing.Size(76, 17);
            this.IdlePriorityBtn.TabIndex = 8;
            this.IdlePriorityBtn.TabStop = true;
            this.IdlePriorityBtn.Text = "Idle Priority";
            this.IdlePriorityBtn.UseVisualStyleBackColor = true;
            this.IdlePriorityBtn.CheckedChanged += new System.EventHandler(this.PriorityStateChanged);
            // 
            // HighPriorityBtn
            // 
            this.HighPriorityBtn.AutoSize = true;
            this.HighPriorityBtn.Location = new System.Drawing.Point(261, 345);
            this.HighPriorityBtn.Name = "HighPriorityBtn";
            this.HighPriorityBtn.Size = new System.Drawing.Size(80, 17);
            this.HighPriorityBtn.TabIndex = 10;
            this.HighPriorityBtn.TabStop = true;
            this.HighPriorityBtn.Text = "High priority";
            this.HighPriorityBtn.UseVisualStyleBackColor = true;
            this.HighPriorityBtn.CheckedChanged += new System.EventHandler(this.PriorityStateChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Pause";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "KillAll";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.TabRange,
            this.Priority});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 300);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 35;
            // 
            // TabRange
            // 
            this.TabRange.Text = "TabRange";
            this.TabRange.Width = 190;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 107;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateProcessbtnClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 186);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Timing";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Location = new System.Drawing.Point(6, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(188, 162);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Count";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time(s)";
            this.columnHeader2.Width = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Tag = "Lab2";
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader TabRange;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton RealTimePriorityBtn;
        private System.Windows.Forms.RadioButton HighPriorityBtn;
        private System.Windows.Forms.RadioButton NormalPriorityBtn;
        private System.Windows.Forms.RadioButton IdlePriorityBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RadioButton BelowNormalPriorityBtn;
        private System.Windows.Forms.RadioButton AboveNormalPriorityBtn;

    }
}

