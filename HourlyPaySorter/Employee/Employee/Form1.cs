﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void DescendPayRateButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.DescRate(this.personnelDataSet.Employee);
        }

        private void AscendPayRateButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.AscRate(this.personnelDataSet.Employee);
        }
    }
}
