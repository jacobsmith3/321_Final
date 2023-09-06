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
    /// window is used for filtering the letters by a number and operator.
    /// </summary>
    public partial class FiltershapecountWindow : Form
    {
        ShapeList shapeList;
        string action;

        /// <summary>
        /// Initializes a new instance of the <see cref="FiltershapecountWindow"/> class.
        /// </summary>
        /// <param name="act"></param>
        /// <param name="shape"></param>
        public FiltershapecountWindow(string act, ShapeList shape)
        {
            this.shapeList = shape;
            this.action = act;
            InitializeComponent();
        }

        /// <summary>
        /// used to apply the chosen number and operator to the letter list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count == 1 && this.checkedListBox2.CheckedItems.Count == 1)
            {
                string op = " ";
                foreach (string check in this.checkedListBox1.CheckedItems)
                {
                    op = check;
                }

                string number = " ";
                foreach (string check in this.checkedListBox2.CheckedItems)
                {
                    number = check;
                }

                this.shapeList.filter(this.action + ":" + op + ":" + number);
                this.Close();
            }
        }
    }
}
