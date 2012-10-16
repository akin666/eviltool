using EvilTool.Editor;
using EvilTool.Element;
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
                        if (tree.SelectedNode.Tag is ContainerNode)
                        {
                            menu = containerMenu;
                        }
                        else if (tree.SelectedNode.Tag is LayerNode)
                        {
                            menu = layerMenu;
                        }
                        else if (tree.SelectedNode.Tag is PointNode)
                        {
                            menu = basicMenu;
                        }
                        else if (tree.SelectedNode.Tag is PolygonNode)
                        {
                            menu = basicMenu;
                        }
                        else if (tree.SelectedNode.Tag is TextNode)
                        {
                            menu = basicMenu;
                        }
                    }
                }
                menu.Show(tree, e.Location);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
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

            if (editor is NodeControlInterface)
            {
                NodeControlInterface ni = (NodeControlInterface)editor;
                ni.kill();
            }
            editor = null;
        }

        private void setCurrentEditor( Control item )
        {
            if (item != null && editor != null)
            {
                // same node?
                if (editor is NodeControlInterface && item is NodeControlInterface)
                {
                    NodeControlInterface a = (NodeControlInterface)editor;
                    NodeControlInterface b = (NodeControlInterface)item;

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
            if (selected.Tag is LayerNode)
            {
                // model
                LayerNode parent = (LayerNode)selected.Tag;
                PointNode node = new PointNode(new PointModel());
                parent.add(node);

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
            }
        }

        private void createPolygon(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is LayerNode)
            {
                // model
                LayerNode parent = (LayerNode)selected.Tag;
                PolygonNode node = new PolygonNode(new PolygonModel());
                parent.add(node);

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
            }
        }

        private void createText(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is LayerNode)
            {
                // model
                LayerNode parent = (LayerNode)selected.Tag;
                TextNode node = new TextNode(new TextModel());
                parent.add(node);

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
            }
        }

        private void createLayer(object sender, EventArgs e)
        {
            TreeNode selected = tree.SelectedNode;
            if (selected.Tag is ContainerNode)
            {
                // model
                ContainerNode parent = (ContainerNode)selected.Tag;
                LayerNode node = new LayerNode(new LayerModel());
                parent.add(node);

                // ui
                TreeNode added = selected.Nodes.Add(node.getName());
                added.Tag = node;
            }
        }

        private void createContainer(object sender, EventArgs e)
        {
            NodeInterface node = new ContainerNode( new ContainerModel() );
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

            if (selected.Tag is NodeInterface)
            {
                NodeInterface node = (NodeInterface)selected.Tag;

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
                    List<ContainerNode> nodes = new List<ContainerNode>();
                    foreach (TreeNode rootnode in tree.Nodes)
                    {
                        if (rootnode.Tag is ContainerNode)
                        {
                            nodes.Add((ContainerNode)rootnode.Tag);
                        }
                    }

                    string json = JsonConvert.SerializeObject(
                        nodes ,
                        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
                        );

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
                        List<ContainerNode> nodes;
                        using (stream)
                        {
                            StreamReader reader = new StreamReader(stream);
                            string json = reader.ReadToEnd();

                            nodes = JsonConvert.DeserializeObject<List<ContainerNode>>(json);
                        }
                        if (nodes != null)
                        {
                            // convert 'nodes' to tree etc structure..
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
