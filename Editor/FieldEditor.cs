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
using EvilTool.Model;
using EvilTool.utils;

namespace EvilTool.Editor
{
    public partial class FieldEditor : UserControl, EditorInterface
    {
        private Vec3 mouseOffset = new Vec3( 0.0f, 0.0f, 0.0f);
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

        private void addPoint(Vec3 position)
        {
            if (target.field.points == null)
            {
                target.field.points = new List<Vec3>();
            }
            target.field.points.Add(position);
        }

        private void mouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path with the mouse information
            Vec3 location = new Vec3(e.X + mouseOffset.x, e.Y + mouseOffset.y , 0.0f );

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
            Vec3 location = new Vec3(e.X + mouseOffset.x, e.Y + mouseOffset.y , 0.0f );
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
            Vec3 location = new Vec3(e.X + mouseOffset.x, e.Y + mouseOffset.y, 0.0f);
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

            foreach (Vec3 point in target.field.points)
            {
                GraphicsHelper.circle(graphics, point, 5, pen);
            }
        }
    }
}
