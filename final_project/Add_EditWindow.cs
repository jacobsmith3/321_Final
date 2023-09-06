using Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Add_EditWindow : Form
    {
        private ShapeList list;
        private string color;
        private int index = -1;
        public Add_EditWindow(ShapeList shapelist)
        {
            this.list = shapelist;
            InitializeComponent();
        }

        public Add_EditWindow(ShapeList shapelist, int index)
        {
            this.list = shapelist;
            this.index = index;
            InitializeComponent();
            this.checkedListBox1.SetItemChecked(this.checkedListBox1.Items.IndexOf(this.list.getShape(index).shapes), true);
            this.checkedListBox2.SetItemChecked(this.checkedListBox2.Items.IndexOf(this.list.getShape(index).Texture), true);
            this.color = this.list.getShape(index).Clr;
            this.textBox1.Text = this.color;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count != 1 || this.checkedListBox2.CheckedItems.Count != 1 || this.color == null)
            {
                return;
            }
            else
            {
                string shape = " ";
                foreach (string item in this.checkedListBox1.CheckedItems)
                {
                    shape = item;
                }

                string texture = " ";
                foreach (string item in this.checkedListBox2.CheckedItems)
                {
                    texture = item;
                }

                if (this.index == -1)
                {
                    this.list.addshape(shape, this.color, texture);
                }
                else
                {
                    this.list.editshape(this.index, shape, this.color, texture);
                }

                int index = this.list.getIndex();
                this.Close();
            }
        }

        private void Colorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowHelp = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.color = colorDialog.Color.ToString();
                this.color = this.color.Split('[')[1];
                this.color = this.color.Split(']')[0];
                this.textBox1.Text = this.color;
            }
        }
    }
}
