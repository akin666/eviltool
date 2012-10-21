using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvilTool.Controller;
using EvilTool.utils;
using EvilTool.Model;
using System.Drawing.Drawing2D;

namespace EvilTool.Editor
{
    public partial class PolygonEditor : UserControl, EditorInterface
    {
        private Vec3 mouseOffset = new Vec3( 0.0f, 0.0f, 0.0f );
        private Vec3 dimensionhud = new Vec3(10.0f, 10.0f, 10.0f);
        private Vec3 lastmoveposition = new Vec3(0.0f, 0.0f, 0.0f);
        private PolygonController target;
        private List<int> selected = new List<int>();
        private Selector selector = new Selector();
        private TextureBrush brush;


        public PolygonEditor(PolygonController node)
        {
            InitializeComponent();

            target = node;
            this.view.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.view.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.view.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.view.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mouseWheel);

            this.view.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);

        //    this.view.Invalidate();
        }

        public ControllerInterface getNode()
        {
            return target;
        }

        private void addPoint(Vec3 position)
        {
            if (target.polygon.points == null)
            {
                target.polygon.points = new List<Vec3>();
            }
            target.polygon.points.Add(position);
            this.view.Invalidate();
        }

        private void mouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path with the mouse information
            Vec3 location = new Vec3(e.X, e.Y, 0.0f);

            if (this.radioadd.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    addPoint(location);
                }
            }
            else if (this.radioselect.Checked && target.polygon.points != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    selector.addToPoly(location);
                }
            }
            
            if (e.Button == MouseButtons.Right)
            {
                lastmoveposition.x = e.X;
                lastmoveposition.y = e.Y;
            }

            this.view.Focus();
            this.view.Invalidate();
        }

        private void mouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.radioadd.Checked)
            {
                return;
            }

            Vec3 location = new Vec3(e.X, e.Y, 0.0f);
            if (e.Button == MouseButtons.Left)
            {
                selector.addToPoly(location);
                this.view.Invalidate();
            }
            else if ( e.Button == MouseButtons.Right)
            {
                Vec3 diff = new Vec3(e.X - lastmoveposition.x, e.Y - lastmoveposition.y, 0.0f);

                lastmoveposition.x = e.X;
                lastmoveposition.y = e.Y;

                foreach (int idx in selected)
                {
                    target.polygon.points[idx].x += diff.x;
                    target.polygon.points[idx].y += diff.y;
                }
                this.view.Invalidate();
            }
        }

        private void mouseLeave(object sender, System.EventArgs e)
        {
            //selected.Clear();
        }

        private void mouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the drawing based upon the mouse wheel scrolling.
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            int numberOfPixelsToMove = numberOfTextLinesToMove;
        }

        private void mouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Vec3 location = new Vec3(e.X + mouseOffset.x, e.Y + mouseOffset.y , 0.0f);
            if (e.Button == MouseButtons.Left)
            {
                List<int> remaining = selector.collide(target.polygon.points);

                for (int i = 0; i < remaining.Count; ++i)
                {
                    int index = remaining[i];

                    if (selected.Exists(item => item == index))
                    {
                        selected.Remove(index);
                    }
                    else
                    {
                        selected.Add(index);
                    }
                }

                selector.reset();
            }
            this.view.Invalidate();
        }

        public void draw(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.AliceBlue);

            List<Vec3> vertexes = target.polygon.points;

            Pen blue = new Pen(Color.Blue, 2.0f);
            Pen red = new Pen(Color.Red, 1.0f);
            Pen black = new Pen(Color.Black, 2.0f);

            if (target.polygon.points != null)
            {
                if (vertexes.Count() > 1)
                {
                    if (this.radiolines.Checked)
                    {
                        GraphicsHelper.polygon(graphics, vertexes, blue);
                    }
                    else if (this.radiotexture.Checked && this.brush != null)
                    {
                        GraphicsHelper.polygon(graphics, vertexes, brush);
                    }
                    else
                    {
                        GraphicsHelper.polygon(graphics, vertexes, red);
                    }
                }
                foreach (Vec3 point in vertexes)
                {
                    GraphicsHelper.circle(graphics, point, 5, black);
                }

                foreach (int idx in selected)
                {
                    GraphicsHelper.circle(graphics, target.polygon.points[idx], 10, red);
                }
            }

            GraphicsHelper.draw(graphics, selector, red);
            GraphicsHelper.dimensions(graphics, dimensionhud, 50.0f);
        }

        private void addPoint_Click(object sender, EventArgs e)
        {
            addPoint(new Vec3(100, 100, 0.0f));
        }

        private void subdivide_Click(object sender, EventArgs e)
        {
            List<Vec3> points = new List<Vec3>();
            List<Vec3> old = target.polygon.points;

            if (old == null || old.Count < 2)
            {
                return;
            }

            for (int i = 1; i < old.Count; ++i)
            {
                Vec3 prev = old[i - 1];
                Vec3 current = old[i];

                // prev & (prev,current) midpoint..
                points.Add(prev);
                points.Add( MathHelper.midPoint( prev , current ) );
            }

            Vec3 first = old[0];
            Vec3 last = old[old.Count - 1];
            points.Add(last);
            points.Add(MathHelper.midPoint(first, last));

            target.polygon.points = points;
            this.view.Invalidate();
        }

        void loadTexture()
        {
            if (target.polygon.texture == null)
            {
                return;
            }
            Bitmap fillImage = new Bitmap(target.polygon.texture);

            brush = new TextureBrush(new Bitmap(fillImage));

            Matrix mtx = brush.Transform;
            mtx.Translate(0, 0);
            brush.Transform = mtx;

            this.view.Invalidate();
        }

        private void buttontexture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            target.polygon.texture = dlg.FileName;
            loadTexture();
        }

        private void fillChanged(object sender, EventArgs e)
        {
            if (brush == null)
            {
                loadTexture();
            }
            this.view.Invalidate();
        }
    }
}
