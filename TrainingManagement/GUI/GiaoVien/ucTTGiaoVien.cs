using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainingManagement.GUI
{
    public partial class ucTTGiaoVien : UserControl
    {
        public ucTTGiaoVien()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClick = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null) ButtonClick(sender, e);
        }
    }
}
