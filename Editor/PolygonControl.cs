using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvilTool.Element;
using EvilTool.utils;

namespace EvilTool.Editor
{
    public partial class PolygonControl : UserControl, NodeControlInterface
    {
        private Point mouseOffset = new Point(-10, -10);
        private PolygonNode target;
        private int selected = -1;

        public PolygonControl(PolygonNode node)
        {
            InitializeComponent();

            target = node;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mouseWheel);

            this.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);
        }

        public void kill()
        {
        }

        public NodeInterface getNode()
        {
            return target;
        }

        private void mouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path with the mouse information
            Point location = new Point(e.X , e.Y);

            switch (e.Button)
            {
                case MouseButtons.Left:
                {
                    //target.points.Add(mouseDownLocation);
                    //                    element.update(mouseDownLocation);
                    List<int> candidates = new List<int>();
                    for( int i = 0 ; i < target.points.Count ; ++i )
                    {
                        Point point = target.points[i];
                        double distance = MathHelper.distance(location, point);
                        if (distance < 15.0f)
                        {
                            candidates.Add( i );
                        }
                    }
                    double min = 15.0f;
                    foreach (int index in candidates)
                    {
                        Point point = target.points[index];
                        double distance = MathHelper.distance(location, point);
                        if (distance < min)
                        {
                            selected = index;
                            min = distance;
                        }
                    }
                    break;
                }
                case MouseButtons.Right:
                    //                   element.add();
                    //                   element.update(mouseDownLocation);
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                case MouseButtons.None:
                default:
                    break;
            }

            this.Focus();
            this.Invalidate();
        }

        private void mouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path that is drawn onto the Panel.
            Point location = new Point(e.X , e.Y );
            //           element.update(mouseDownLocation);

            if (selected >= 0)
            {
                target.points[selected] = location;
            }

            this.Invalidate();
        }

        private void mouseLeave(object sender, System.EventArgs e)
        {
            selected = -1;
        }

        private void mouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the drawing based upon the mouse wheel scrolling.
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            int numberOfPixelsToMove = numberOfTextLinesToMove;
        }

        private void mouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    selected = -1;
                    break;
                case MouseButtons.Right:
                    //                   element.commit();
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                case MouseButtons.None:
                default:
                    break;
            }
            this.Invalidate();
        }

        public void draw(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.AliceBlue);

            Pen blue = new Pen(Color.Blue, 2.0f);
            Pen red = new Pen(Color.Red, 1.0f);
            Pen black = new Pen(Color.Black, 2.0f);
           
            if (target.points.Count() > 1)
            {
                try
                {
                    graphics.DrawPolygon(blue, target.points.ToArray());
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Attempted divide by zero." + ex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("exception happened." + ex.ToString());
                }

            }
            foreach (Point point in target.points)
            {
                GraphicsHelper.circle(graphics, point, 15, red);
            }
            if (selected >= 0)
            {
                GraphicsHelper.circle(graphics, target.points[selected], 10, black);
            }
            //graphics.Dispose();
        }

        private void addPoint_Click(object sender, EventArgs e)
        {
            target.points.Add( new Point(100, 100) );
        }

        private void subdivide_Click(object sender, EventArgs e)
        {
            List<Point> points = new List<Point>();
            List<Point> old = target.points;

            if (old.Count < 2)
            {
                return;
            }

            for (int i = 1; i < old.Count; ++i)
            {
                Point prev = old[i - 1];
                Point current = old[i];

                // prev & (prev,current) midpoint..
                points.Add(prev);
                points.Add( MathHelper.midPoint( prev , current ) );
            }

            Point first = old[0];
            Point last = old[old.Count-1];
            points.Add(last);
            points.Add(MathHelper.midPoint(first, last));

            target.points = points;
        }

        /*
        public void draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Blue, 2.0f);
            try
            {
                if (tracking && current != null)
                {
                    Pen red = new Pen(Color.Red, 3.0f);
                    graphics.DrawEllipse(red, new Rectangle(current, new Size(10, 10)));
                }

                graphics.DrawPolygon(pen, points.ToArray());
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine("exception happened.");
            }
        }
        */
    }
}
