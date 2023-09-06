namespace final_project
{
    using Alphabet;
    using Shapes;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// The main window that the user will see.
    /// </summary>
    public partial class MainWindow : Form
    {
        private ShapeList shapeList= new ShapeList();

        public MainWindow()
        {
            this.shapeList.editPropertyChanged += this.Form1listchange;
            InitializeComponent();
        }

        /// <summary>
        /// this is the updater that updates all the lists depending on the inputs from the shapelist class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1listchange(object sender, PropertyChangedEventArgs e)
        {
            // if altering a letter
            if (e.PropertyName == "l")
            {
                this.listBox2.Items.Clear();
                this.listBox3.Items.Clear();

                // if a shape filter is activated
                if (this.shapeList.getshapefilter().Any())
                {
                    foreach (Shape shape in this.shapeList.getshapefilter())
                    {
                        this.listBox2.Items.Add(this.shapeList.getshapetext(shape));
                    }
                }
                else
                {
                    foreach (Shape shape in this.shapeList.getshapes())
                    {
                        this.listBox2.Items.Add(this.shapeList.getshapetext(shape));
                    }
                }

                // if a letter filter is applied.
                if (this.shapeList.getalphafilter().Any())
                {
                    foreach (var letter in this.shapeList.getalphafilter())
                    {
                        this.listBox3.Items.Add(this.shapeList.getlettertext(letter.Item1.letter, letter.Item2));
                    }
                }
                else
                {
                    foreach (var letter in this.shapeList.getalpha())
                    {
                        this.listBox3.Items.Add(this.shapeList.getlettertext(letter.Item1.letter, letter.Item2));
                    }
                }
            }

            // if altering a shape
            else
            {
                this.listBox2.Items.Clear();

                // if a filter is applied
                if (this.shapeList.getshapefilter().Any())
                {
                    foreach (Shape shape in this.shapeList.getshapefilter())
                    {
                        this.listBox2.Items.Add(this.shapeList.getshapetext(shape));
                    }
                }
                else
                {
                    foreach (Shape shape in this.shapeList.getshapes())
                    {
                        this.listBox2.Items.Add(this.shapeList.getshapetext(shape));
                    }
                }
            }
        }

        /// <summary>
        /// the dropdown button for deleting letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (this.shapeList.getalphafilter().Any())
            {
                var shape = this.shapeList.getalphafilter().ElementAt(this.listBox3.SelectedIndex);
                index = this.shapeList.getalpha().IndexOf(shape);
            }
            else
            {
                index = this.listBox3.SelectedIndex;
            }

            this.shapeList.removeLetter(index);
        }

        /// <summary>
        /// the dropdown button for creating the shapes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBox2.ClearSelected();
            Add_EditWindow win = new Add_EditWindow(this.shapeList);
            win.Show();
        }

        /// <summary>
        /// the inital dropdown button that decides if certain dropdown buttons can be used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox2.Items.Count == 0)
            {
                this.editToolStripMenuItem.Enabled = false;
            }
            else if (this.listBox2.Items.Count != 0 && this.listBox2.SelectedItems.Count != 1)
            {
                this.editToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.editToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// editing button for editing the shape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            
            // makes sure that a fiter isnt applied
            if (this.shapeList.getshapefilter().Any())
            {
                var shape = this.shapeList.getshapefilter().ElementAt(this.listBox2.SelectedIndex);
                index = this.shapeList.getshapes().IndexOf(shape);
            }
            else
            {
                index = this.listBox2.SelectedIndex;
            }

            Add_EditWindow win = new Add_EditWindow(this.shapeList, index);
            //this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
            win.Show();
        }

        /// <summary>
        /// create letter button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char letter = this.listBox1.Text[0];
            List<int> indices = new List<int>();
            foreach (int i in this.listBox2.SelectedIndices)
            {
                indices.Add(i);
            }

            this.shapeList.CreateLetter(indices, letter);
        }

        /// <summary>
        /// the main letter dropdown menu button that enables its dropdwon menu buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox3.Items.Count == 0)
            {
                this.filterToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.filterToolStripMenuItem.Enabled = true;
            }

            if (this.listBox2.SelectedItems.Count == 0 || this.listBox1.SelectedItems.Count == 0)
            {
                this.createLetterToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.createLetterToolStripMenuItem.Enabled = true;
            }

            if (this.listBox3.Items.Count == 0 || this.listBox3.SelectedIndices.Count == 0)
            {
                this.deleteLetterToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.deleteLetterToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// undo menu button that undoes the last action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.shapeList.UndoCount() == 0)
            {
                return;
            }
            else
            {
                UndoAction action = this.shapeList.PopUndo();
                UndoCreateLetter DeleteL = action as UndoCreateLetter;
                if (DeleteL != null)
                {
                    DeleteL.Execute(this.shapeList);
                }

                UndoDeleteLetter CreateL = action as UndoDeleteLetter;
                if (CreateL != null)
                {
                    CreateL.Execute(this.shapeList);
                }

                UndoCreateShape DeleteS = action as UndoCreateShape;
                if (DeleteS != null)
                {
                    DeleteS.Execute(this.shapeList);
                }

                UndoEditShape EditS = action as UndoEditShape;
                if (EditS != null)
                {
                    EditS.Execute(this.shapeList);
                }
            }
        }

        /// <summary>
        /// filters for the shapes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.filterToolStripMenuItem1.Enabled == false)
            {
                this.shapeToolStripMenuItem.Enabled = false;
                this.colorToolStripMenuItem.Enabled = false;
                this.textureToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.shapeToolStripMenuItem.Enabled = true;
                this.colorToolStripMenuItem.Enabled = true;
                this.textureToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// filters for the letter list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.filterToolStripMenuItem.Enabled == false)
            {
                this.containsShapeToolStripMenuItem.Enabled = false;
                this.containsColorToolStripMenuItem.Enabled = false;
                this.containsTextureToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.containsShapeToolStripMenuItem.Enabled = true;
                this.containsColorToolStripMenuItem.Enabled = true;
                this.containsTextureToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// filter by shape button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltershapeWindow win = new FiltershapeWindow("shape", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filter by shape in letter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void containsShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltershapeWindow win = new FiltershapeWindow("shapeL", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filters shape by color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterColorWindow win = new FilterColorWindow("color", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filters shape by texture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterTextureWindow win = new FilterTextureWindow("texture", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filters letters by shapes that have a certain color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void containsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterColorWindow win = new FilterColorWindow("colorL", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filters the letters for shapes with a certain texture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void containsTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterTextureWindow win = new FilterTextureWindow("textureL", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filter sltters by certain letter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterLetterWindow win = new FilterLetterWindow("Letter", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// filters letters by number of shapes it contains.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nOfShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltershapecountWindow win = new FiltershapecountWindow("Num", this.shapeList);
            win.Show();
        }

        /// <summary>
        /// resets the filter for shapes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopFilterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.shapeList.resetShapefilter();
        }

        /// <summary>
        /// resets the filter for letter list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.shapeList.resetAlphafilter();
        }
    }
}