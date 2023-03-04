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
    /// <summary>
    /// A picturebox of a parallelogram's shape
    /// </summary>
    class ParallelogramPictureBox : PictureBox
    {
        private float widthPart;
        private float heightPart;
        public float WidthPart { 
            get => this.widthPart;
            set { if (value <= 1) this.widthPart = value;
                else this.widthPart = 1; } }
        public float HeightPart { 
            get => this.heightPart; 
            set { if (value <= 1) this.heightPart = value; 
                else this.heightPart = 1; } }
        public ParallelogramPictureBox() { }
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath g = new GraphicsPath(); // initialise a grphics path for the parallelogram
            RectangleF rectf = new RectangleF(0, 0, 100, 200); // define the circumscribed rectangle
            g.AddRectangle(rectf); // add the rectangle to the graphics path

            // define points for warping the rectangle to a parallelogram
            PointF p1 = new PointF(this.Width * this.WidthPart, this.Height); // lower right point
            PointF p2 = new PointF(0, this.Height); // lower left point
            PointF p3 = new PointF(this.Width, 0); // upper right point
            PointF[] points = { p1, p2, p3 }; // combine the 3 points
            g.Warp(points, rectf); // warp the rectangle to a parallelogram
            this.Region = new Region(g); // change picturebox's region to the new parallelogram shaped
            base.OnPaint(pe); //base method
        }
    }
}
