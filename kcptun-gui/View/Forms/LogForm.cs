﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using kcptun_gui.Controller;

namespace kcptun_gui.View
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
        }

        private void openLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + Logging.LogFilePath + "\"";
            Process.Start("explorer.exe", argument);
        }

        private void cleanLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logViewerUserControl1.DoCleanLogs();
        }

        private void wrapTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wrapTextToolStripMenuItem.Checked = logViewerUserControl1.TriggerWrapText();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logViewerUserControl1.DoChangeFont();
        }

        private void resetFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logViewerUserControl1.ResetViewerFont();
        }
    }
}