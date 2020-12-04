using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLibrary;

namespace WinFormUI
{
    public partial class EmployeeClass : Form
    {
        public EmployeeClass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameLabel.Text = StandardMessages.AskForName();
            phoneLabel.Text = StandardMessages.AskForPhoneNumber();
            ageLabel.Text = StandardMessages.AskForAge();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{nameTextBox.Text}\n {phoneTextBox.Text}\n {ageTextBox.Text}");
        }
    }
}
