using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HelloForm : Form
    {
        public HelloForm(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }
    }
}
