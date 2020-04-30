using System;
using System.Collections.Generic;

namespace  Data_structures2 
{
    class Queue 
    {
          private List<int> elements = new List<int>();

          //Enqueue
          public void Enqueue(int elementToEnqueue)
            {
                elements.Add(elementToEnqueue);
                System.Console.WriteLine($"Enqueue({elementToEnqueue})");
            }

          //Dequeue
          public int Dequeue() 
            {
              int firstElement = elements[0];

              elements.RemoveAt(0);

              return firstElement;
            }

          public int? Front()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            int firstElement = elements[0];

            return firstElement;
        }

        //Rear
        public int? Rear()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            int lastPosition = elements.Count - 1;

            return elements[lastPosition];
        }


        public override string ToString()
        {
            string queueAsString = "";
            queueAsString += "---------------------\n";
            foreach (var item in elements)
            {
                queueAsString += $"{item} | ";

            }
            queueAsString += "\n---------------------\n";

            return queueAsString;
        }
    }
}
