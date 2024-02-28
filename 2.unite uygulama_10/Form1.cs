using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch(gun)
            {
                case 0:
                    MessageBox.Show("pazartesi");
                    break;

                    case 1:
                    MessageBox.Show("salı");
                    break;

                case 2:
                    MessageBox.Show("çarşamba");
                    break;
                case 3:
                    MessageBox.Show("perşembe");
                    break;
                case 4:
                    MessageBox.Show("cuma");
                    break;
                case 5:
                    MessageBox.Show("cumartesi");
                    break;
                case 6:
                    MessageBox.Show("pazar");
                    break;


            }
        }
    }
}
