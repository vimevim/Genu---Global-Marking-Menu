using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace cSharpMarkingMenu
{
    public partial class FloatingWithMousePos : Form
    {
        int defaultOriginX, defaultOriginY;
        int formOriginX, formOriginY;
        int formCentreX, formCentreY;
        double hypotenuse, angle;

        private void floatingWithMousePos_MouseMove(object sender, MouseEventArgs e)
        {
            //Varsayılan orijin ataması yapılıyor
            defaultOriginX = e.X;
            defaultOriginY = e.Y;
            //mouse merkezi orijin olarak atanıyor, bu komutun üstte olması lazım.
            formOriginX = defaultOriginX - formCentreX;//
            formOriginY = defaultOriginY - formCentreY;

            //orijine göre hypotenuse hesaplaması
            hypotenuse = Math.Sqrt(formOriginX * formOriginX + formOriginY * formOriginY);

            //orijin ve hipotenüs ile açı hesaplaması - 360 ve 0 derece çakışınca bize 360 veriyor
            angle = Math.Acos(formOriginY / hypotenuse);
            if (formOriginX < 0)
            {
                angle = angle * 180 / Math.PI;
            }
            else
            {
                angle -= angle * 180 / Math.PI;
                angle += 360;
            }

            //çizgi başlangıcı
            Graphics g = this.CreateGraphics();
            Pen d = new Pen(Color.FromArgb(48, 47, 55), 10);//çizici kalem
            if (e.Button == MouseButtons.Middle)
            {
                int angularEdge = ((Math.Abs(formOriginY) + Math.Abs(formOriginX)) / 2);
                if (angle > 337.5 || angle < 22.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, formCentreX, defaultOriginY);//çiziliyor
                    lblDownMid.ForeColor = Color.FromArgb(245,245,245);
                    //this.Invalidate();
                }
                else if (angle > 22.5 && angle < 67.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, (formCentreX - angularEdge), (angularEdge + formCentreY));
                    //this.Invalidate();
                }
                else if (angle > 67.5 && angle < 112.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, defaultOriginX, formCentreY);//çiziliyor
                    //this.Invalidate();
                }
                else if (angle > 112.5 && angle < 157.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, (formCentreX - angularEdge), (formCentreY - angularEdge));
                    //this.Invalidate();
                }
                else if (angle > 157.5 && angle < 202.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, formCentreX, defaultOriginY);//çiziliyor
                    //this.Invalidate();
                }
                else if (angle > 202.5 && angle < 247.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, (angularEdge + formCentreX), (formCentreY - angularEdge));
                    //this.Invalidate();
                }
                else if (angle > 247.5 && angle < 292.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, defaultOriginX, formCentreY);//çiziliyor
                    //this.Invalidate();
                }
                else if (angle > 292.5 && angle < 337.5)
                {
                    g.DrawLine(d, formCentreX, formCentreY, (angularEdge + formCentreX), (angularEdge + formCentreY));
                    //this.Invalidate();
                }
                else
                {
                    g.DrawLine(d, formCentreX, formCentreY, defaultOriginX, defaultOriginY);//çiziliyor
                    //this.Invalidate();
                }
                this.Invalidate();
            }
            else
            {
                FormFollowsCursor();
            }
        }

        private void floatingWithMousePos_MouseUp(object sender, MouseEventArgs e)
        {
            if (hypotenuse <= 50)
            {

            }
            else
            {
                if (angle > 337.5 || angle < 22.5)
                {

                }
                else if (angle > 22.5 && angle < 67.5)
                {

                }
                else if (angle > 67.5 && angle < 112.5)
                {

                }
                else if (angle > 112.5 && angle < 157.5)
                {

                }
                else if (angle > 157.5 && angle < 202.5)
                {

                }
                else if (angle > 202.5 && angle < 247.5)
                {


                }
                else if (angle > 247.5 && angle < 292.5)
                {

                }
                else if (angle > 292.5 && angle < 337.5)
                {

                }
            }
            //Form1_Click(null, null);//formun dışına çıkınca çalışmasını sağlıyor ama hata var
            FormFollowsCursor();
        }

        public FloatingWithMousePos()
        {
            InitializeComponent();
            this.TransparencyKey = BackColor;
            formCentreX = this.Width / 2;
            formCentreY = this.Height / 2;
            Hook.GlobalEvents().MouseDoubleClick += async (sender, e) =>
            {
                if (e.Button == MouseButtons.Middle)
                {
                    this.Show();
                }
                else
                {

                }
            };
        }

        private void floatingWithMousePos_Load(object sender, EventArgs e)
        {
            FormFollowsCursor();
        }
        private void FormFollowsCursor()
        {//formun konumu 2 ye bölünüp farenin konumundan çıkartıldı,doğal olarak form farenin merkezine geçmiş oldu
            this.Location = new Point(MousePosition.X - formCentreX, MousePosition.Y - formCentreY);
        }

        private void floatingWithMousePos_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
