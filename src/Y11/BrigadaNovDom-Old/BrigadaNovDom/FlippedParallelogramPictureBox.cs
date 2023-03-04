using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrigadaNovDom
{
    class FlippedParallelogramPictureBox : PictureBox
    {
        private float widthPart;
        private float heightPart;
        public float WidthPart { get => this.widthPart; set { if (value <= 1) this.widthPart = value; else this.widthPart = 1; } }
        public float HeightPart { get => this.heightPart; set { if (value <= 1) this.heightPart = value; else this.heightPart = 1; } }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            GraphicsPath g = new GraphicsPath();
            RectangleF rectf = new RectangleF(0, 0, 100, 200);
            g.AddRectangle(rectf);
            PointF p1 = new PointF(this.Width, this.Height * this.HeightPart);
            PointF p2 = new PointF(0, this.Height);
            PointF p3 = new PointF(this.Width, 0);
            PointF[] points = { p1, p2, p3 };
            g.Warp(points, rectf);
            this.Region = new Region(g);
        }
    }
}
