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
    /// Window is for filter by color.
    /// </summary>
    public partial class FilterColorWindow : Form
    {
        string color;
        ShapeList shapeList;
        string action;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterColorWindow"/> class.
        /// </summary>
        /// <param name="act"></param>
        /// <param name="shape"></param>
        public FilterColorWindow(string act, ShapeList shape)
        {
            this.action = act;
            this.shapeList = shape;
            InitializeComponent();
        }

        /// <summary>
        /// for applying the filter with the selected color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Color_Click(object sender, EventArgs e)
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

        /// <summary>
        /// for getting the color the user would like to switch to.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            if (this.color != null)
            {
                this.shapeList.filter(this.action + ":" + this.color);
                this.Close();
            }
        }
    }
}
