﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DBConnect sessione = new DBConnect();

            List<List<string>> auto = sessione.Select("automobile");

            foreach (string i in auto[0])
                dgvRecord.Columns.Add(i, i);

            for (int i = 1; i < auto.Count; i++)
            {
                dgvRecord.Rows.Add();
                for (int j = 0; j < auto[i].Count; j++)
                    dgvRecord[j, i-1].Value = (auto[i][j]);

            }



        }
    }
}
