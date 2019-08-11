using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e) {
            MessageBox.Show("My First Message", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
