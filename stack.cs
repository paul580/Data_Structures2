using System;
using System.Collections.Generic;

namespace data_structures_2
{
    class Stack
    {
        private List<int> elements = new List<int>();

        //Push
        public void Push(int elementToPush) {
            elements.Add(elementToPush);
        }

        //Pop
        public int? Pop() {
            if (elements.Count == 0)
            {
                return null;
            }
            int lastIndex = elements.Count - 1;

            int lastElement = elements[lastIndex];

            //Destroy last element
            elements.RemoveAt(lastIndex);

            return lastElement;
        }

        //Top
        public int? Top() {
            if (elements.Count == 0)
            {
                return null;
            }

            int lastIndex = elements.Count - 1;

            int lastElement = elements[lastIndex];

            return lastElement;
        }

        //Bottom
        public int? Bottom() {
            if (elements.Count == 0)
            {
                return null;
            }
            return elements[0];
        }

        public override string ToString() {
            string stackAsString = "";
            
            for (int i = 0; i < elements.Count; i++)
            {
                int inverseIndex = elements.Count - i - 1;

                //Asumamos que hay una lista de 5 elementos
                //elements.Count => 5
                //i = 0
                //5 - 0 - 1 => 4

                //i = 1
                //5 - 1 - 1 => 3

                // System.Console.WriteLine(inverseIndex);

                stackAsString += elements[inverseIndex];
                stackAsString += "\n";
            }

            return stackAsString;
        }
    }
}
