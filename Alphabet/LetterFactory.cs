using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    /// <summary>
    /// used to help with the creation of letters do the amount of classes for the letters.
    /// </summary>
    public class LetterFactory
    {
        private Dictionary<char, Type> letters = new Dictionary<char, Type>();

        private delegate void OnLetter(char op, Type type);

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterFactory"/> class.
        /// </summary>
        public LetterFactory()
        {
            this.TraverseAvailableLetters((op, type) => this.letters.Add(op, type));
        }

        /// <summary>
        /// used to create letters by the character given.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Letter CreateLetterNode(char letter)
        {
            if (this.letters.ContainsKey(letter))
            {
                object letterNodeObject = Activator.CreateInstance(this.letters[letter]);
                if (letterNodeObject is Letter)
                {
                    return (Letter)letterNodeObject;
                }
            }

            throw new Exception("unhandled Letter");
        }

        /// <summary>
        /// by using reflection and linq it sores up all the classes releted to letter.
        /// </summary>
        /// <param name="onLetter"></param>
        private void TraverseAvailableLetters(OnLetter onLetter)
        {
            Type lettertype = typeof(Letter);
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                IEnumerable<Type> Ltypes = assembly.GetTypes().Where(type => type.IsSubclassOf(lettertype));

                foreach (var types in Ltypes)
                {
                    PropertyInfo LetterField = types.GetProperty("letter");
                    if (LetterField != null) 
                    {
                        object value = (object)LetterField.GetValue(Activator.CreateInstance(types));
                        if (value is char)
                        {
                            char lettersymbol = (char)value;
                            onLetter(lettersymbol, types);
                        }
                    }
                }
            }
        }
    }
}
