using Alphabet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// used to do the operatiosn for the listboxes in form1.
    /// </summary>
    public class ShapeList
    {
        /// <summary>
        /// holds the list for the shapelistbox.
        /// </summary>
        private List<shapehelper> shapes = new List<shapehelper>();

        /// <summary>
        /// holds the info for letters in the letter listbox.
        /// </summary>
        private List<(Letter, List<shapehelper>)> alphas = new List<(Letter, List<shapehelper>)>();

        /// <summary>
        /// used for getting a filtered list of the letters list.
        /// </summary>
        private IEnumerable<(Letter, List<shapehelper>)> alphasFilter;

        /// <summary>
        /// used for getting a filtered list of the shapes list.
        /// </summary>
        private IEnumerable<shapehelper> shapesFilter;

        /// <summary>
        /// used to hold the object state for undos.
        /// </summary>
        private Stack<UndoAction> Undo = new Stack<UndoAction>();

        /// <summary>
        /// used to update the lists in the UI.
        /// </summary>
        public event PropertyChangedEventHandler editPropertyChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeList"/> class.
        /// </summary>
        public ShapeList()
        {
            this.alphasFilter = new List<(Letter, List<shapehelper>)>();
            this.shapesFilter = new List<shapehelper>();
        }

        /// <summary>
        /// adds a shape to the shapes list and then gets added to the UI.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="clr"></param>
        /// <param name="texture"></param>
        public void addshape(string shape, string clr, string texture)
        {
            shapehelper shapehelper = new shapehelper(shape, clr, texture);
            shapehelper.Ind = this.shapes.Count;
            this.Undo.Push(new UndoCreateShape(shapehelper));
            this.shapes.Add(shapehelper);
            this.editPropertyChanged(this.shapes[shapehelper.Ind], new PropertyChangedEventArgs("s"));
        }

        /// <summary>
        /// edits shapes and then updates the UI.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="shape"></param>
        /// <param name="clr"></param>
        /// <param name="texture"></param>
        public void editshape(int index, string shape, string clr, string texture)
        {
            string originalshape = this.shapes[index].shapes;
            string originalcolor = this.shapes[index].Clr;
            string originalTexture = this.shapes[index].Texture;
            this.shapes[index].shapes = shape;
            this.shapes[index].Clr = clr;
            this.shapes[index].Texture = texture;
            this.Undo.Push(new UndoEditShape(new shapehelper(originalshape,originalcolor,originalTexture), this.shapes[index]));
            this.editPropertyChanged(this.shapes[index], new PropertyChangedEventArgs("s"));
        }

        /// <summary>
        /// edits but doesnt add to the undo stack.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="shape"></param>
        /// <param name="clr"></param>
        /// <param name="texture"></param>
        public void Undoeditshape(int index, string shape, string clr, string texture)
        {
            this.shapes[index].shapes = shape;
            this.shapes[index].Clr = clr;
            this.shapes[index].Texture = texture;
            this.editPropertyChanged(this.shapes[index], new PropertyChangedEventArgs("s"));
        }

        /// <summary>
        /// removes shape from the list for the undo create call.
        /// </summary>
        /// <param name="helper"></param>
        public void RemoveShape(shapehelper helper)
        {
            foreach (shapehelper shapehelper in this.shapes)
            {
                if (shapehelper == helper)
                {
                    this.shapes.Remove(shapehelper);
                    this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("s"));
                    break;
                }
            }
        }

        /// <summary>
        /// gets the shape at index of the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Shape getShape(int index)
        {
            return (Shape)this.shapes[index];
        }

        /// <summary>
        /// hets the end coutn of the list and sets the count of a shape to this.
        /// </summary>
        /// <returns></returns>
        public int getIndex()
        {
            return this.shapes.Count - 1;
        }

        /// <summary>
        /// gets the shapes list.
        /// </summary>
        /// <returns></returns>
        public List<shapehelper> getshapes()
        {
            return new List<shapehelper>(this.shapes);
        }

        /// <summary>
        /// gest the letter list.
        /// </summary>
        /// <returns></returns>
        public List<(Letter, List<shapehelper>)> getalpha()
        {
            return new List<(Letter, List<shapehelper>)>(this.alphas);
        }

        /// <summary>
        /// used to update the lists in form1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Propertychanged(object sender, PropertyChangedEventArgs e)
        {
            Shape shape = (Shape)sender;
            int index = shape.Ind;
            this.shapes[index] = (shapehelper)shape;
            this.editPropertyChanged(this.shapes[index], new PropertyChangedEventArgs("shape"));
        }

        /// <summary>
        /// puts a datapoint in alphalist into words for the UI.
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="helper"></param>
        /// <returns></returns>
        public string getlettertext(char letter, List<shapehelper> helper)
        {
            string expression = letter.ToString() + " [";
            foreach (shapehelper shape in helper)
            {
                expression += getshapetext(shape) + ",";
            }

            expression = expression.Remove(expression.Length - 1) + "]";
            return expression;
        }

        /// <summary>
        /// puts the datapoint in shapes list into words for UI.
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public string getshapetext(Shape shape)
        {
            return shape.shapes + " (Color: " + shape.Clr + "; Texture: " + shape.Texture + ")";
        }

        /// <summary>
        /// removes a letter from the alphalist then updates the UI list.
        /// </summary>
        /// <param name="index"></param>
        public void removeLetter(int index)
        {
            this.Undo.Push(new UndoDeleteLetter(this.alphas[index].Item1, this.alphas[index].Item2));
            this.alphas.RemoveAt(index);
            this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
        }

        /// <summary>
        /// is called when undoing the creation of a letter. One part of many.
        /// </summary>
        /// <param name="index"></param>
        public void UndoremoveLetter(int index)
        {
            this.alphas.RemoveAt(index);
            this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
        }

        /// <summary>
        /// Creates a letter and inputs it into the alpha list.
        /// </summary>
        /// <param name="indices"></param>
        /// <param name="letter"></param>
        /// <exception cref="Exception"></exception>
        public void CreateLetter(List<int> indices, char letter)
        {
            LetterFactory factory = new LetterFactory();
            Letter letter1 = factory.CreateLetterNode(letter);
            if (letter1.Build.Count != indices.Count)
            {
                throw new Exception("Not enough shapes to create Letter");
            }

            //removes the shapes that would create the letter
            List<string> strings = letter1.Build.ToList<string>();
            foreach (int index in indices)
            {
                if (!strings.Contains(this.shapes[index].shapes))
                {
                    throw new Exception("Not correct shapes for this letter");
                }
                else
                {
                    strings.Remove(this.shapes[index].shapes);
                }
            }

            //gets the shapes that makeup the letter.
            List<shapehelper> Using = new List<shapehelper>();
            foreach (int index in indices)
            {
                Using.Add(this.shapes[index]);
            }

            for (int index = 0; index < Using.Count; index++)
            {
                this.shapes.Remove(Using[index]);
            }

            this.Undo.Push(new UndoCreateLetter(letter1.letter, Using));
            this.alphas.Add((letter1, Using));
            this.editPropertyChanged(this.alphas, new PropertyChangedEventArgs("l"));
        }

        /// <summary>
        /// pushes to the undo stack.
        /// </summary>
        /// <param name="undo"></param>
        public void PushUndo(UndoAction undo)
        {
            this.Undo.Push(undo);
        }

        /// <summary>
        /// Pop item form the undo stack.
        /// </summary>
        /// <returns></returns>
        public UndoAction PopUndo()
        {
            return this.Undo.Pop();
        }

        /// <summary>
        /// Peeks into the undo stack.
        /// </summary>
        /// <returns></returns>
        public UndoAction PeekUndo()
        {
            return this.Undo.Peek();
        }

        /// <summary>
        /// removes a letter by the item instead of by index.
        /// </summary>
        /// <param name="tuple"></param>
        public void removeLetterbyItem((Letter, List<shapehelper>) tuple)
        {
            this.alphas.Remove(tuple);
            this.editPropertyChanged(this.alphas, new PropertyChangedEventArgs("l"));
        }

        /// <summary>
        /// adds shape by item.
        /// </summary>
        /// <param name="helper"></param>
        public void AddshapebyItem(shapehelper helper)
        {
            this.shapes.Add(helper);
            this.editPropertyChanged(this.alphas, new PropertyChangedEventArgs("s"));
        }

        /// <summary>
        /// Adds letter by item.
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="shapehelpers"></param>
        public void AddletterbyItem(Letter letter, List<shapehelper> shapehelpers)
        {
            this.alphas.Add((letter, shapehelpers));
            this.editPropertyChanged(this.alphas, new PropertyChangedEventArgs("l"));
        }

        /// <summary>
        /// gets the total number of items in the undo stack.
        /// </summary>
        /// <returns></returns>
        public int UndoCount()
        {
            return this.Undo.Count;
        }

        /// <summary>
        /// filters not only the shapes but also the letters by using LINQ.
        /// </summary>
        /// <param name="filteraction"></param>
        public void filter(string filteraction)
        {
            string action = filteraction.Split(':')[0];
            string filter = filteraction.Split(":")[1];
            if (action == "shape")
            {
                this.shapesFilter = this.shapes.Where(shpe => shpe.shapes == filter);
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("s"));
            }
            else if (action == "color")
            {
                this.shapesFilter = this.shapes.Where(shpe => shpe.Clr == filter);
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("s"));
            }
            else if (action == "texture")
            {
                this.shapesFilter = this.shapes.Where(shpe => shpe.Texture == filter);
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("s"));
            }
            else if (action == "shapeL")
            {
                this.alphasFilter = this.alphas.Where(ltr => ltr.Item2.Any(shp => shp.shapes == filter));
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
            }
            else if (action == "colorL")
            {
                this.alphasFilter = this.alphas.Where(ltr => ltr.Item2.Any(shp => shp.Clr == filter));
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
            }
            else if (action == "textureL")
            {
                this.alphasFilter = this.alphas.Where(ltr => ltr.Item2.Any(shp => shp.Texture == filter));
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
            }
            else if (action == "Letter")
            {
                this.alphasFilter = this.alphas.Where(ltr => ltr.Item1.letter == char.Parse(filter));
                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
            }
            else if (action == "Num")
            {
                int num = int.Parse(filteraction.Split(":")[2]);
                if (filter == "<")
                {
                    this.alphasFilter = this.alphas.Where(ltr => ltr.Item2.Count < num);

                }
                else if (filter == ">")
                {
                    this.alphasFilter = this.alphas.Where(ltr => ltr.Item2.Count > num);
                }
                else
                {
                    this.alphasFilter = this.alphas.Where(ltr => ltr.Item2.Count == num);
                }

                this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
            }
        }

        /// <summary>
        /// gets the Ienuerable for the filtering of shapes.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<shapehelper> getshapefilter() { return this.shapesFilter; }

        /// <summary>
        /// gets the inumerable for the filtering of letters.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<(Letter, List<shapehelper>)> getalphafilter() { return this.alphasFilter; }

        /// <summary>
        /// reset alpha filter so it doesnt have any query using linq.
        /// </summary>
        public void resetAlphafilter()
        {
            this.alphasFilter = new List<(Letter, List<shapehelper>)>();
            this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("l"));
        }

        /// <summary>
        /// reset the shapes filter so it doesnt have any query using linq.
        /// </summary>
        public void resetShapefilter()
        {
            this.shapesFilter = new List<shapehelper>();
            this.editPropertyChanged(this.shapes, new PropertyChangedEventArgs("s"));
        }
    }
}
