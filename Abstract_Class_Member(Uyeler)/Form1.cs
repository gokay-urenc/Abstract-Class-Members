using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Class_Member_Uyeler_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AClass a = new AClass();
            MessageBox.Show(a.Fonksiyon());
            MessageBox.Show(a.MesajVer());

            BClass b = new BClass();
            MessageBox.Show(b.Fonksiyon());
            MessageBox.Show(b.MesajVer());
        }
    }
}