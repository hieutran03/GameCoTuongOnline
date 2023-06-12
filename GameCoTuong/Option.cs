using CoTuongLAN.CoTuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuongLAN
{
    public partial class Option : Form
    {
        public static bool isClosed = false; 
        public Option()
        {
            InitializeComponent();
        }
        private void SetTime(int time)
        {
            BanCo.OptionTime = time;
            isClosed = true;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int time = 900;
            SetTime(time);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int time = 1800;
            SetTime(time);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int time = 3600;
            SetTime(time);
        }
    }
}
