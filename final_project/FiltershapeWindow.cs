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
    public partial class FiltershapeWindow : Form
    {
        string action;
        ShapeList shapeList;
        /// <summary>
        /// Initializes a new instance of the <see cref="FiltershapeWindow"/> class.
        /// the window for helping with filtering shapes by shape.
        /// </summary>
        /// <param name="act"></param>
        /// <param name="shape"></param>
        public FiltershapeWindow(string act, ShapeList shape)
        {
            this.action = act;
            this.shapeList = shape;
            InitializeComponent();
        }

        /// <summary>
        /// used for the apply button to actually do the action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count == 1)
            {
                string shape = " ";
                foreach (string check in this.checkedListBox1.CheckedItems)
                {
                    shape = check;
                }

                this.shapeList.filter(this.action + ":" + shape);

                this.Close();
            }
        }
    }
}
