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
    public partial class Định_dang : Form
    {
        public Định_dang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radred.Checked = true;
            radred.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Định_dang_Load(object sender, EventArgs e)
        {
            radred.Checked = true;
            radred.ForeColor = Color.Black;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Black;

        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Blue;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Green;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkchan_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
