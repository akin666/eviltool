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
            this.subdivideButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiopolygon = new System.Windows.Forms.RadioButton();
            this.radiopoint = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioselect = new System.Windows.Forms.RadioButton();
            this.radioremove = new System.Windows.Forms.RadioButton();
            this.radioadd = new System.Windows.Forms.RadioButton();
            this.view = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // subdivideButton
            // 
            this.subdivideButton.Location = new System.Drawing.Point(3, 3);
            this.subdivideButton.Name = "subdivideButton";
            this.subdivideButton.Size = new System.Drawing.Size(75, 23);
            this.subdivideButton.TabIndex = 2;
            this.subdivideButton.Text = "subdivide";
            this.subdivideButton.UseVisualStyleBackColor = true;
            this.subdivideButton.Click += new System.EventHandler(this.subdivide_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.subdivideButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.view);
            this.splitContainer1.Size = new System.Drawing.Size(362, 306);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiopolygon);
            this.groupBox2.Controls.Add(this.radiopoint);
            this.groupBox2.Location = new System.Drawing.Point(3, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // radiopolygon
            // 
            this.radiopolygon.AutoSize = true;
            this.radiopolygon.Location = new System.Drawing.Point(6, 43);
            this.radiopolygon.Name = "radiopolygon";
            this.radiopolygon.Size = new System.Drawing.Size(62, 17);
            this.radiopolygon.TabIndex = 1;
            this.radiopolygon.TabStop = true;
            this.radiopolygon.Text = "polygon";
            this.radiopolygon.UseVisualStyleBackColor = true;
            // 
            // radiopoint
            // 
            this.radiopoint.AutoSize = true;
            this.radiopoint.Location = new System.Drawing.Point(6, 20);
            this.radiopoint.Name = "radiopoint";
            this.radiopoint.Size = new System.Drawing.Size(48, 17);
            this.radiopoint.TabIndex = 0;
            this.radiopoint.TabStop = true;
            this.radiopoint.Text = "point";
            this.radiopoint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioselect);
            this.groupBox1.Controls.Add(this.radioremove);
            this.groupBox1.Controls.Add(this.radioadd);
            this.groupBox1.Location = new System.Drawing.Point(2, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // radioselect
            // 
            this.radioselect.AutoSize = true;
            this.radioselect.Location = new System.Drawing.Point(6, 42);
            this.radioselect.Name = "radioselect";
            this.radioselect.Size = new System.Drawing.Size(53, 17);
            this.radioselect.TabIndex = 6;
            this.radioselect.TabStop = true;
            this.radioselect.Text = "select";
            this.radioselect.UseVisualStyleBackColor = true;
            // 
            // radioremove
            // 
            this.radioremove.AutoSize = true;
            this.radioremove.Location = new System.Drawing.Point(6, 65);
            this.radioremove.Name = "radioremove";
            this.radioremove.Size = new System.Drawing.Size(60, 17);
            this.radioremove.TabIndex = 5;
            this.radioremove.TabStop = true;
            this.radioremove.Text = "remove";
            this.radioremove.UseVisualStyleBackColor = true;
            // 
            // radioadd
            // 
            this.radioadd.AutoSize = true;
            this.radioadd.Location = new System.Drawing.Point(6, 19);
            this.radioadd.Name = "radioadd";
            this.radioadd.Size = new System.Drawing.Size(43, 17);
            this.radioadd.TabIndex = 3;
            this.radioadd.TabStop = true;
            this.radioadd.Text = "add";
            this.radioadd.UseVisualStyleBackColor = true;
            // 
            // view
            // 
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(258, 306);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            // 
            // PolygonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Name = "PolygonEditor";
            this.Size = new System.Drawing.Size(362, 306);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subdivideButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.RadioButton radioremove;
        private System.Windows.Forms.RadioButton radioadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiopolygon;
        private System.Windows.Forms.RadioButton radiopoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioselect;

    }
}
