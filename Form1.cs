using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenNhoTu_32_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String hotenSV = " Nguyen nho Tu";
            String mssv = "1223240071";
            String monthi = "Lap trinh windowrs 2 -c#";

            lblinfo.Text = "ho va ten: " + hotenSV;
            lblinfo.Text += "\nMSSV" + hotenSV;
            lblinfo.Text += "\n ngay thi: " + System.DateTime.Now.ToString();
            lblinfo.Text += "\nMonThi" + monthi;
   
        }
    }
}
