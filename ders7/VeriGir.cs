using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders7
{    
    public partial class VeriGir : Form
    {
        public string veri { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public VeriGir()
        {
            InitializeComponent();
        }

        
    }
}
