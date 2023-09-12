using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls
{
    public partial class FormGame : Form
    {
        FlyBall b;
        public FormGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = new FlyBall(this);
            b.Show();
            //this.Controls.Add(b);
        }

        private void FormGame_MouseDown(object sender, MouseEventArgs e)
        {
            FlyBall a = new FlyBall(this);
            a.SetPosition(e.X, e.Y);
            a.SetRandomSpeed(1,10);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b.Move();
            b.Show();
        }
    }
}
