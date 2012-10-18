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
    public partial class TextEditor : UserControl, EditorInterface
    {
        private TextController target;

        public TextEditor(TextController node)
        {
            InitializeComponent();

            target = node;

            textBox1.Text = target.text.text;
        }

        public ControllerInterface getNode()
        {
            return target;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            target.text.text = textBox1.Text;
        }
    }
}
