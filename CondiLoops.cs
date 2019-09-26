using System;

namespace CondiLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppingList = { "shirt", "Shoes", "Dress", "Hat" };
            Console.WriteLine(shoppingList[1]);
            float[] numList = { 31, 72, 82, 28, 29, };
            Console.WriteLine(numList[1]);

            foreach (string i in shoppingList)
            {
                Console.WriteLine(i);
            }

            foreach (float i in numList)
            {
                Console.WriteLine(i);
            }

            for (float i = 0; i < numList.Length; i++) 
            {
                Console.WriteLine(i);
            };

            foreach (float i in numList)
            {
                var newList = i * 10;
                Console.WriteLine(newList);
            }

            foreach(float i in numList)
            {
                if (i > 15 )
                {
                    Console.WriteLine("Greater number");
                }else
                {
                    Console.WriteLine(" less number");
                }
            }


        }
    }
}
