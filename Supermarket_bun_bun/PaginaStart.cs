using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_bun_bun
{
    public partial class PaginaStart : Form
    {
        public PaginaStart()
        {
            InitializeComponent();
        }
        int punct_start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            punct_start += 100;
            bara_progres.Value = punct_start;
            if (bara_progres.Value == 100)
            {
                bara_progres.Value = 0;
                timer1.Stop();
                Supermarket log = new Supermarket();
                this.Hide();
                log.Show();
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
