using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpMarkingMenu
{
    public partial class formFree : Form
    {
        public formFree()
        {
            InitializeComponent();

        }

        int onClickOriginX, onClickOriginY;//farenin tıkladığı yerden orijin alır
        int defaultOriginX, defaultOriginY;//farenin tıkladığı yeri verir
        int movingX, movingY;//farenin hareketini verir
        double hypotenuse, angle;

        private void formFree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                defaultOriginX = e.X;
                defaultOriginY = e.Y;
            }
        }

        private void formFree_MouseMove(object sender, MouseEventArgs e)
        {
            movingX = e.X;
            movingY = e.Y;
            onClickOriginX = movingX - defaultOriginX;
            onClickOriginY = movingY - defaultOriginY;


            hypotenuse = Math.Sqrt(onClickOriginX * onClickOriginX + onClickOriginY * onClickOriginY);

            angle = Math.Acos(onClickOriginY / hypotenuse);
            if (onClickOriginX < 0)
            {
                angle = angle * 180 / Math.PI;
            }
            else
            {
                angle -= angle * 180 / Math.PI;
                angle += 360;
            }

            this.Text = onClickOriginX + "=" + movingX + "  -  " + defaultOriginX+"   hipotenüs:   "+hypotenuse+"   açı:   "+angle;
            Graphics g = this.CreateGraphics();
            Pen d = new Pen(Color.FromArgb(48, 47, 55), 5);//çizici kalem
            Pen s = new Pen(Color.FromArgb(245, 245, 245), 5);//iz silici kalem, sıkıntısı var

            if (e.Button == MouseButtons.Right)
            {

                int angularEdge = ((Math.Abs(onClickOriginY) + Math.Abs(onClickOriginX)) / 2);
                if (angle > 337.5 || angle < 22.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, defaultOriginX, movingY);//çiziliyor
                    g.DrawLine(s, defaultOriginX, defaultOriginY, defaultOriginX, movingY);//çizginin izi siliniyor
                }
                else if (angle > 22.5 && angle < 67.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, (defaultOriginX - angularEdge), (angularEdge + defaultOriginY));
                    g.DrawLine(s, defaultOriginX, defaultOriginY, (defaultOriginX - angularEdge), (angularEdge + defaultOriginY));
                }
                else if (angle > 67.5 && angle < 112.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, movingX, defaultOriginY);//çiziliyor
                    g.DrawLine(s, defaultOriginX, defaultOriginY, movingX, defaultOriginY);//çizginin izi siliniyor
                }
                else if (angle > 112.5 && angle < 157.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, (defaultOriginX - angularEdge), (defaultOriginY - angularEdge));
                    g.DrawLine(s, defaultOriginX, defaultOriginY, (defaultOriginX - angularEdge), (defaultOriginY - angularEdge));
                }
                else if (angle > 157.5 && angle < 202.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, defaultOriginX, movingY);//çiziliyor
                    g.DrawLine(s, defaultOriginX, defaultOriginY, defaultOriginX, movingY);//çizginin izi siliniyor
                }
                else if (angle > 202.5 && angle < 247.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, (angularEdge + defaultOriginX), (defaultOriginY - angularEdge));
                    g.DrawLine(s, defaultOriginX, defaultOriginY, (angularEdge + defaultOriginX), (defaultOriginY - angularEdge));
                }
                else if (angle > 247.5 && angle < 292.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, movingX, defaultOriginY);//çiziliyor
                    g.DrawLine(s, defaultOriginX, defaultOriginY, movingX, defaultOriginY);//çizginin izi siliniyor
                }
                else if (angle > 292.5 && angle < 337.5)
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, (angularEdge + defaultOriginX), (angularEdge + defaultOriginY));
                    g.DrawLine(s, defaultOriginX, defaultOriginY, (angularEdge + defaultOriginX), (angularEdge + defaultOriginY));
                }
                else
                {
                    g.DrawLine(d, defaultOriginX, defaultOriginY, movingX, movingY);//çiziliyor
                    g.DrawLine(s, defaultOriginX, defaultOriginY, movingX, movingY);//çizginin izi siliniyor
                }
            }
        }

    }
}
