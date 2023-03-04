using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrigadaNovDom
{
    public class ParallelogramPictureBox : PictureBox
    {
        private float widthPart;
        private float heightPart;
        public float WidthPart { get => this.widthPart; set { if (value <= 1) this.widthPart = value; else this.widthPart = 1;  } }
        public float HeightPart { get => this.heightPart; set { if (value <= 1) this.heightPart = value; else this.heightPart = 1; } }
        public ParallelogramPictureBox()
        {
            this.Size = new Size(200, 100);
            this.WidthPart = 0.5f;
            this.HeightPart = 0.5f;
        }

        //private GraphicsPath GetFigurePath(RectangleF rect, double angle)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    path.StartFigure();
        //    path.AddRectangle(rect);
        //    //PointF p1 = new PointF(rect.Width,);
        //    PointF p1 = new PointF(rect.Width * 0.5F, rect.Height);
        //    PointF p2 = new PointF(0, rect.Height);
        //    PointF p3 = new PointF(rect.Width, 0);
        //    PointF[] points = { p1, p2, p3 };
        //    path.Warp(points, rect);
        //    //path.AddPolygon(points);
        //    path.CloseFigure();
        //    return path;
        //}

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath g = new GraphicsPath();
            RectangleF rectf = new RectangleF(0, 0, 100, 200);
            g.AddRectangle(rectf);
            PointF p1 = new PointF(this.Width * this.WidthPart, this.Height);
            PointF p2 = new PointF(0, this.Height);
            PointF p3 = new PointF(this.Width, 0);
            PointF[] points = { p1, p2, p3 };

            g.Warp(points, rectf);
            this.Region = new Region(g);
            base.OnPaint(pe);

            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
           
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
