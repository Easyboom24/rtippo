﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIPPO
{
    public partial class Form2 : Form
    {
        public List<int> idDeleted;
        ApplyApplicationsApi Api = new ApplyApplicationsApi();
        public bool boolDeleted = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Api.DeleteApplications(idDeleted);
            boolDeleted = true;
            this.Close();

        }

        public bool GetBoolDeleted() 
        {
            return boolDeleted;
        }
    }
}
