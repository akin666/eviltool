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

namespace EvilTool.Editor
{
    public partial class FieldEditor : UserControl, EditorInterface
    {
        private Point mouseOffset = new Point(0, 0);
        private FieldController target;

        public FieldEditor(FieldController node)
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

        public ControllerInterface getNode()
        {
            return target;
        }

        private void addPoint(Point position)
        {
            if (target.field.points == null)
            {
                target.field.points = new List<Point>();
            }
            target.field.points.Add(position);
        }

        private void mouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path with the mouse information
            Point location = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    addPoint(location);
                    break;
                case MouseButtons.Right:
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
            Point location = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);
            this.Invalidate();
        }

        private void mouseLeave(object sender, System.EventArgs e)
        {
        }

        private void mouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the drawing based upon the mouse wheel scrolling.
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            int numberOfPixelsToMove = numberOfTextLinesToMove;
        }

        private void mouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point location = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Right:
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
            if (target.field.points == null)
            {
                return;
            }
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.AliceBlue);

            Pen pen = new Pen(Color.Black, 2.0f);
            /*
            if (tracking && current != null)
            {
                Pen red = new Pen(Color.Red, 3.0f);
                graphics.DrawEllipse(red, new Rectangle(current, new Size(10, 10)));
            }
            */
            foreach (Point point in target.field.points)
            {
                graphics.DrawEllipse(pen, new Rectangle(point, new Size(5, 5)));
            }
            //graphics.Dispose();
        }
    }
}
