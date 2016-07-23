using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    namespace ConsoleApplication
    {
        class Program
        {
            static void Main(string[] args)
            {


                // Create the link list.
                string[] original = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                ArrayList originalLinkedList = new ArrayList(original);
                Display(originalLinkedList, "The original list values:");


                // Create the link list.
                string[] key = { "t", "m", "e", "s", "f", "k", "j", "a", "x", "n", "o", "v", "l", "u", "c", "h", "z", "g", "y", "b", "w", "p", "d", "r", "i", "q" };
                ArrayList keyLinkedList = new ArrayList(key);
                Display(keyLinkedList, "The key list values:");


                Console.Write("Word to encode: ");
                string input = Console.ReadLine();
                Console.Write("\n\n");

                Char[] inputArray = new Char[50];
                inputArray = input.ToCharArray();



                //Encoded linked list
                ArrayList encodedList = new ArrayList();
                ArrayList decodedLinkedList = new ArrayList();
                String[] decodedArray = new String[50];

                int index1, index2;


                for (int i = 0; i < inputArray.Length; i++)
                {

                    index1 = Array.IndexOf(original, inputArray[i].ToString());
                    encodedList.Add(key[index1]);
                }


                Display(encodedList, "Encoded word:");


                for (int i = 0; i < inputArray.Length; i++)
                {

                    decodedArray = encodedList.ToArray();
                    index2 = Array.IndexOf(key, decodedArray[i]);
                    decodedLinkedList.Add(original[index2]);

                }

                Display(decodedLinkedList, "Decoded word:");

                encodedList.Clear();


                Console.ReadLine();


            }




            private static void Display(ArrayList words, string test)
            {
                Console.WriteLine(test);
                foreach (string word in words)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine("\n");
                Console.ReadLine();

            }







        }
    }

}
