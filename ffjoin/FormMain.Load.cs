﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ffjoin
{
    public partial class FormMain : Form
    {
        private void FormMain_Load(object sender, EventArgs e)
        {
            getffmpeg();
            UpdateTitle();
        }
    }
}
