namespace Alphabet
{
    /// <summary>
    /// letter class that is used to set up the alphabet class letters.
    /// </summary>
    public abstract class Letter
    {
        public abstract List<string> Build { get;  }

        public abstract char letter { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Letter"/> class.
        /// </summary>
        public Letter() { }
    }
}