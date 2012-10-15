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

namespace EvilTool.Editor
{
    public partial class PointControl : UserControl, NodeControlInterface
    {
        private Point mouseOffset = new Point(0, 0);
        private PointNode target;

        public PointControl(PointNode node)
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
            Point mouseDownLocation = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    target.point.vertexes.Add(mouseDownLocation);
                    //                    element.update(mouseDownLocation);
                    break;
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
            Point mouseDownLocation = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);
            //           element.update(mouseDownLocation);
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
            Point mouseDownLocation = new Point(e.X + mouseOffset.X, e.Y + mouseOffset.Y);
            switch (e.Button)
            {
                case MouseButtons.Left:
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

            Pen pen = new Pen(Color.Black, 2.0f);
            /*
            if (tracking && current != null)
            {
                Pen red = new Pen(Color.Red, 3.0f);
                graphics.DrawEllipse(red, new Rectangle(current, new Size(10, 10)));
            }
            */
            foreach (Point point in target.point.vertexes)
            {
                graphics.DrawEllipse(pen, new Rectangle(point, new Size(5, 5)));
            }
            //graphics.Dispose();
        }
    }
}
