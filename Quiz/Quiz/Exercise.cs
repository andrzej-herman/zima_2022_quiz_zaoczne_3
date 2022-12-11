using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Exercise
    {
        // INSTRUKCJA 
        public void Test()
        {
            var x = 6;
            var y = 7;  

            if (x == 8 && y == 10)
            {
                // kod 1
            }
            else
            {
                // kod 2
            }
        }

        // PĘTLA
        public void Test2()
        {
            //var lista = new List<int>();
            //lista.Add(34);
            //lista.Add(15);

            // foreach (var liczba in lista)
            // {
            //     Console.WriteLine(liczba);
            // }




            // for
            // foreach
            // while

            //short x = 0; 
            //while (true)
            //{
            //    Console.WriteLine(x);
            //    x++;    
            //}

            
        }


        void Test3()
        {
            var numbers = new List<int>();
            numbers.Add(67);
            numbers.Add(15);
            numbers.Add(289);
            numbers.Add(113);
            numbers.Add(8);
            numbers.Add(51);


            Console.WriteLine();


            var newNumbers = numbers.Where(x => x < 52).ToList();
            Console.WriteLine(newNumbers);
        }


    }
}
