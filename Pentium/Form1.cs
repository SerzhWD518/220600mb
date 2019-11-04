using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Pentium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher Proc = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_USBHub");
            foreach (ManagementObject queryObj in Proc.Get())
            {
               dataGridView1.Rows[0].Cells[0].Value = queryObj["Description"];
            }
        }
    }
}
