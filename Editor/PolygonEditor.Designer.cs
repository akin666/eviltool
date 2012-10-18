namespace EvilTool.Editor
{
    partial class PolygonEditor
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
            this.addPointButton = new System.Windows.Forms.Button();
            this.subdivideButton = new System.Windows.Forms.Button();
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
            // addPointButton
            // 
            this.addPointButton.Location = new System.Drawing.Point(4, 4);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(75, 23);
            this.addPointButton.TabIndex = 1;
            this.addPointButton.Text = "add point";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // subdivideButton
            // 
            this.subdivideButton.Location = new System.Drawing.Point(85, 4);
            this.subdivideButton.Name = "subdivideButton";
            this.subdivideButton.Size = new System.Drawing.Size(75, 23);
            this.subdivideButton.TabIndex = 2;
            this.subdivideButton.Text = "subdivide";
            this.subdivideButton.UseVisualStyleBackColor = true;
            this.subdivideButton.Click += new System.EventHandler(this.subdivide_Click);
            // 
            // PolygonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.subdivideButton);
            this.Controls.Add(this.addPointButton);
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
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.Button subdivideButton;

    }
}
