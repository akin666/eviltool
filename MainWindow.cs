using EvilTool.Editor;
using EvilTool.Controller;
using EvilTool.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilTool
{
    public partial class MainWindow : Form
    {
        private Control editor;

        public MainWindow()
        {
            InitializeComponent();

            tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeMouseUp);
            tree.DoubleClick += new System.EventHandler(this.editNode);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; // this.panel1.CreateGraphics();
            graphics.Clear(Color.AliceBlue);
            graphics.Dispose();
        }

        void treeMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                tree.SelectedNode = tree.GetNodeAt(e.X, e.Y);

                ContextMenuStrip menu = treemenu;
                if (tree.SelectedNode != null)
                {
                    // Menu selection if elses.. for each node type there is a if else branch
                    // TODO! shoot myself for creating such structure..
                    if (tree.SelectedNode.Tag != null)
                    {
                        if (tree.SelectedNode.Tag is ContainerController)
                        {
                            menu = containerMenu;
                        }
                        else if (tree.SelectedNode.Tag is LayerController)
                        {
                            LayerController lc = (LayerController)tree.SelectedNode.Tag;
                            if (!lc.alreadyInUse())
                            {
                                menu = layerMenu;
                            }
                            else
                            {
                                menu = basicMenu;
                            }
                        }
                        else if (tree.SelectedNode.Tag is FieldController)
                        {
                            menu = basicMenu;
                        }
                        else if (tree.SelectedNode.Tag is PolygonController)
                        {
                            menu = basicMenu;
                        }
                        else if (tree.SelectedNode.Tag is TextController)
                        {
                            menu = basicMenu;
                        }
                    }
                }
                menu.Show(tree, e.Location);
            }
        }

        private void exitApplication(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit :(", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void removeNode(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove?", "?RM?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void killCurrentEditor()
        {
            if (editor == null)
            {
                return;
            }

            this.splitContainer1.Panel2.Controls.Clear();

            editor = null;
        }

        private void setCurrentEditor( Control item )
        {
            if (item != null && editor != null)
            {
                // same node?
                if (editor is EditorInterface && item is EditorInterface)
                {
                    EditorInterface a = (EditorInterface)editor;
                    EditorInterface b = (EditorInterface)item;

                    if (a.getNode() == b.getNode())
                    {
                        return;
                    }
                }
            }

            if (item == null)
            {
                return;
            }
            killCurrentEditor();

            editor = item;

            item.AutoSize = true; 
            item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(item);
        }

        private void createPoint(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is LayerController)
            {
                // model
                LayerController parent = (LayerController)selected.Tag;
                FieldController node = new FieldController(new Field());
                if (!parent.add(node))
                {
                    // failed! TODO
                }

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
                selected.Expand();
            }
        }

        private void createPolygon(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is LayerController)
            {
                // model
                LayerController parent = (LayerController)selected.Tag;
                PolygonController node = new PolygonController(new Polygon());
                if (!parent.add(node))
                {
                    // failed! TODO
                }

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
                selected.Expand();
            }
        }

        private void createText(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is LayerController)
            {
                // model
                LayerController parent = (LayerController)selected.Tag;
                TextController node = new TextController(new Text());
                if (!parent.add(node))
                {
                    // failed! TODO
                }

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
                selected.Expand();
            }
        }

        private void createLayer(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is ContainerController)
            {
                // model
                ContainerController parent = (ContainerController)selected.Tag;
                LayerController node = new LayerController(new Layer());
                parent.add(node);

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
                selected.Expand();
            }
        }

        private void createContainer(object sender, EventArgs e)
        {
            ControllerInterface node = new ContainerController( new EvilTool.Model.Container() );
            TreeNode added = tree.Nodes.Add(node.getName());
            added.Tag = node;
        }

        private void editNode(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag == null)
            {
                return;
            }

            if (selected.Tag is ControllerInterface)
            {
                ControllerInterface node = (ControllerInterface)selected.Tag;

                setCurrentEditor(node.createControl());
            }
        }

        private void saveAsFileMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            Stream stream;

            dialog.Filter = "Json files (*.json)|*.json|Json files (*.js)|*.js|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = dialog.OpenFile()) == null)
                {
                    // Failed!
                    return;
                }

                try
                {
                    // write data here..
                    Root root = new Root();
                    root.container = new List<Model.Container>();

                    foreach (TreeNode rootnode in tree.Nodes)
                    {
                        if (rootnode.Tag is ContainerController)
                        {
                            root.container.Add(((ContainerController)rootnode.Tag).container);
                        }
                    }

                    string json = JsonConvert.SerializeObject(
                        root,
                        new JsonSerializerSettings { 
                            NullValueHandling = NullValueHandling.Ignore
                        } );

                    byte[] byteArray = Encoding.UTF8.GetBytes( json );
                    stream.Write(byteArray, 0, byteArray.Length);
                    stream.Close();
                }
                catch (Exception ex)
                {
                    stream.Close();
                    Console.WriteLine("Exception while parsin json. " + ex.ToString());
                }
            }
        }

        private void loadFileMenu_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Json files (*.json)|*.json|Json files (*.js)|*.js|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = dialog.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            StreamReader reader = new StreamReader(stream);
                            string json = reader.ReadToEnd();

                            var nodes = JsonConvert.DeserializeObject<List<ContainerController>>(json);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
