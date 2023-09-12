using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls
{
    class Ball : PictureBox
    {
        // описали поля классов
        //described the field's class
        protected double x, y;
        protected int radius = 20;


        //пустой конструктор для наследования
        public Ball() { }


        //constructor
        public Ball(Form owner)
        {
            x = 100;
            y = 100;
            this.Width = 2 * radius;
            this.Height = 2 * radius;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Load(Environment.CurrentDirectory+"/images/red.png");
            //список содержащий объекты находящиеся на форме - контролс
            //a list containing objects located on the form - control
            owner.Controls.Add(this);
        }

        public void SetPosition(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        //method
        public void Show()
        {
            this.Top = (int) (y-radius);
            this.Left =(int) (x-radius);
        }
        

    }

    class FlyBall : Ball
    {
        double vx = 5;
        double vy = 5;

        Timer t ;

        public FlyBall(Form owner) : base(owner)
        {
            t = new Timer();
            t.Interval = 10;
            t.Tick += T_Tick;
            t.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.Move();
            this.Show();
        }

        public void SetSpeed(double vx,double vy)
        {
            this.vx = vx;
            this.vy = vy;
        }

        public void SetRandomSpeed(int min, int max)
        {
            Random rnd = new Random();

            this.vx = rnd.Next(min,max);
            this.vy = rnd.Next(min,max);
        }

        public void Move()
        {
            x = x + vx;
            y = y + vy;
        }
    }
}
