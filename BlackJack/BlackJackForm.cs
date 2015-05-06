using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJackForm : Form
    {
        public BlackJackForm()
        {
            InitializeComponent();
        }

        private void BlackJackForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(imageList1.Images[52], 10, 10);
    
        }
    }
}
