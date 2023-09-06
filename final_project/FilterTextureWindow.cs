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
    /// <summary>
    /// window is for filtering the color.
    /// </summary>
    public partial class FilterTextureWindow : Form
    {
        ShapeList shapeList;
        string action;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterTextureWindow"/> class.
        /// </summary>
        /// <param name="act"></param>
        /// <param name="shape"></param>
        public FilterTextureWindow(string act, ShapeList shape)
        {
            this.action = act;
            this.shapeList = shape;
            InitializeComponent();
        }

        /// <summary>
        /// used to apply a filter for the selected texture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count == 1)
            {
                string texture = " ";
                foreach (string check in this.checkedListBox1.CheckedItems)
                {
                    texture = check;
                }

                this.shapeList.filter(this.action + ":" + texture);

                this.Close();
            }
        }
    }
}
