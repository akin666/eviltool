namespace EvilTool.Editor
{
    partial class PolygonControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addPoint = new System.Windows.Forms.Button();
            this.subdivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(362, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addPoint
            // 
            this.addPoint.Location = new System.Drawing.Point(4, 4);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(75, 23);
            this.addPoint.TabIndex = 1;
            this.addPoint.Text = "add point";
            this.addPoint.UseVisualStyleBackColor = true;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // subdivide
            // 
            this.subdivide.Location = new System.Drawing.Point(85, 4);
            this.subdivide.Name = "subdivide";
            this.subdivide.Size = new System.Drawing.Size(75, 23);
            this.subdivide.TabIndex = 2;
            this.subdivide.Text = "subdivide";
            this.subdivide.UseVisualStyleBackColor = true;
            this.subdivide.Click += new System.EventHandler(this.subdivide_Click);
            // 
            // PolygonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.subdivide);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Name = "PolygonControl";
            this.Size = new System.Drawing.Size(362, 306);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button subdivide;

    }
}
