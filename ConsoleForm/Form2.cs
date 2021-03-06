using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleLibrary;
using Console = ConsoleLibrary.Console;

namespace ConsoleFrom
{
    public partial class Form2 : Form
    {

        ConsoleLibrary.Console console;

        public Form2()
        {
            InitializeComponent();
            console = new ConsoleLibrary.Console(32, 32, 1);
            RasterFont rasterFont = new RasterFont();
            rasterFont.Load("IBM_PC_V1_8x8.bin");
            console.Font = rasterFont;
            console.Set(0, 0);
            console.ForegroundColor = TextAdaptor.ConsoleColor.Green;
            console.BackgroundColor = TextAdaptor.ConsoleColor.Black;
            console.Write("HELLO THIS SHOULD WRAP AROUND");
            pictureBox1.Select();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap b = console.Generate();
            g.DrawImageUnscaled(b, 0, 0);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 400; i++)
            {
                console.Write((byte)'e');
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int key = e.KeyValue;
            console.Write((byte)key);
            pictureBox1.Invalidate();
        }
    }
}
