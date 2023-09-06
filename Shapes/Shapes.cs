using System.ComponentModel;
using System.Drawing;

namespace Shapes
{
    /// <summary>
    /// used to hold the data for a shape.
    /// </summary>
    public abstract class Shape : INotifyPropertyChanged
    {
        /// <summary>
        /// shape name.
        /// </summary>
        private string shape;

        /// <summary>
        /// the color of the shape.
        /// </summary>
        private string color;

        /// <summary>
        /// the texture of the shape.
        /// </summary>
        private string texture;
        private int index;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="shp"></param>
        /// <param name="clr"></param>
        /// <param name="text"></param>
        public Shape(string shp, string clr, string text)
        {
            this.shape = shp;
            this.color = clr;
            this.texture = text;
        }

        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// used to get/set the shape.
        /// </summary>
        public string shapes
        {
            get
            {
                return this.shape;
            }

            set
            {
                this.shape = value;
            }
        }

        /// <summary>
        /// gets/sets the color.
        /// </summary>
        public string Clr
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        /// <summary>
        /// gets/sets the texture.
        /// </summary>
        public string Texture
        {
            get
            {
                return this.texture;
            }

            set
            {
                this.texture = value;
            }
        }

        /// <summary>
        /// gets/sets the index.
        /// </summary>
        public int Ind
        {
            get { return index; }
            set { index = value; }
        }
    }
}