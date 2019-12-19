namespace CrashIt
{
    partial class CrashIt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PID = new System.Windows.Forms.TextBox();
            this.button_Crash = new System.Windows.Forms.Button();
            this.listView_WatchList = new System.Windows.Forms.ListView();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process ID:";
            // 
            // textBox_PID
            // 
            this.textBox_PID.Location = new System.Drawing.Point(77, 19);
            this.textBox_PID.Name = "textBox_PID";
            this.textBox_PID.Size = new System.Drawing.Size(109, 20);
            this.textBox_PID.TabIndex = 1;
            // 
            // button_Crash
            // 
            this.button_Crash.Location = new System.Drawing.Point(291, 8);
            this.button_Crash.Name = "button_Crash";
            this.button_Crash.Size = new System.Drawing.Size(140, 41);
            this.button_Crash.TabIndex = 3;
            this.button_Crash.Text = "Crash It!";
            this.button_Crash.UseVisualStyleBackColor = true;
            this.button_Crash.Click += new System.EventHandler(this.button_Crash_Click);
            // 
            // listView_WatchList
            // 
            this.listView_WatchList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_WatchList.FullRowSelect = true;
            this.listView_WatchList.GridLines = true;
            this.listView_WatchList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_WatchList.HideSelection = false;
            this.listView_WatchList.Location = new System.Drawing.Point(12, 55);
            this.listView_WatchList.MultiSelect = false;
            this.listView_WatchList.Name = "listView_WatchList";
            this.listView_WatchList.Size = new System.Drawing.Size(419, 197);
            this.listView_WatchList.TabIndex = 6;
            this.listView_WatchList.UseCompatibleStateImageBehavior = false;
            this.listView_WatchList.View = System.Windows.Forms.View.Details;
            this.listView_WatchList.SelectedIndexChanged += new System.EventHandler(this.listView_WatchList_SelectedIndexChanged);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(192, 15);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(93, 27);
            this.button_Refresh.TabIndex = 7;
            this.button_Refresh.Text = "Refresh Process";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Command line usage: \r\n>CrashIt [ProcessName] [Optional:ProcessTitle], Example: Cr" +
    "ashIt newconsole setup\r\n>CrashIt [id:ProcessID], Example: CrashIt id:100";
            // 
            // CrashIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.listView_WatchList);
            this.Controls.Add(this.button_Crash);
            this.Controls.Add(this.textBox_PID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrashIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crash It!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PID;
        private System.Windows.Forms.Button button_Crash;
        private System.Windows.Forms.ListView listView_WatchList;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label2;
    }
}

