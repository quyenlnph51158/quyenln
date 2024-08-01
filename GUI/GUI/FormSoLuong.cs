using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormSoLuong : Form
    {
        public int soLuongMuon { get; set; }
        public FormSoLuong()
        {
            InitializeComponent();
        }

        private void FormSoLuong_Enter(object sender, EventArgs e)
        {

        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    soLuongMuon = int.Parse(textBox1.Text);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!");
                }
            }
        }

        private void FormSoLuong_Load(object sender, EventArgs e)
        {

        }
    }
}
