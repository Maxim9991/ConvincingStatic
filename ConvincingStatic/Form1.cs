using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvincingStatic
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Location = new Point(rnd.Next(this.Width - pictureBox1.Width), rnd.Next(this.Height - pictureBox1.Height));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Properties.Resources.left_footprint);
            Icon icono = Icon.FromHandle(img.GetHicon());
            Cursor a = new Cursor(icono.Handle);
            this.Cursor = a;
        }
    }
}
