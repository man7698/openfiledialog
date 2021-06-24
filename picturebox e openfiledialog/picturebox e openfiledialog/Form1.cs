using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picturebox_e_openfiledialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dglabrir.ShowDialog();
                if(dglabrir.FileName != "")
                {
                    picimagem.Load(dglabrir.FileName);
                }
            
            
            
            
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
