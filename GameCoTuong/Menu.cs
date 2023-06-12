using CoTuongLAN.CoTuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuongLAN
{
    public partial class Menu : Form
    {
        public static bool isClosed = false;
        public static bool isServer = false;
        public Menu()
        {
            InitializeComponent();
        } 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CoTuongLAN.CoTuong.BanCo.PheTa = 2;
            if(string.IsNullOrEmpty(tbPlayerName.Text))
                CoTuongLAN.CoTuong.BanCo.Name = "Red";
            else
                CoTuongLAN.CoTuong.BanCo.Name = tbPlayerName.Text;
            this.Close();
            isClosed = true;
            isServer = true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            CoTuongLAN.CoTuong.BanCo.PheTa = 1;
            if (string.IsNullOrEmpty(tbPlayerName.Text))
                CoTuongLAN.CoTuong.BanCo.Name = "Blue";
            else
                CoTuongLAN.CoTuong.BanCo.Name = tbPlayerName.Text;
            this.Close();
            isClosed = true;
        }
    }
}
