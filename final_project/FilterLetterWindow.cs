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
    /// window is used for filtering by letter.
    /// </summary>
    public partial class FilterLetterWindow : Form
    {
        ShapeList shapelist;
        string action;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterLetterWindow"/> class.
        /// </summary>
        /// <param name="act"></param>
        /// <param name="shape"></param>
        public FilterLetterWindow(string act, ShapeList shape)
        {
            this.action = act;
            this.shapelist = shape;
            InitializeComponent();
        }

        /// <summary>
        /// used to apply the letter selected tot he filtered list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count == 1)
            {
                string letter = " ";
                foreach (string check in this.listBox1.SelectedItems)
                {
                    letter = check;
                }

                this.shapelist.filter(this.action + ":" + letter);
                this.Close();
            }
        }
    }
}
