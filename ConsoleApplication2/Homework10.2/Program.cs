using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.	Write a program which manages books amount. 
            //You will need init it with starting amount of books. 
            //And write 2 methods which can increase and decrease this amount.
            //(use ref or out to implement this functionality)

            int numberOfBooks = 20;
            int numberOfBooksToAdd = 3;
            int numberOfBooksToRemove = 4;
            int result = AddBooks(ref numberOfBooks, numberOfBooksToAdd);
            result = RemoveBooks(ref numberOfBooks, numberOfBooksToRemove);

            Console.WriteLine("We got {0} books.", result);
            Console.ReadLine();

        }

        static int AddBooks(ref int numberOfBooks, int numberOfBooksToAdd)
        {
            numberOfBooks += numberOfBooksToAdd;
            return numberOfBooks;
        }

        static int RemoveBooks(ref int numberOfBooks, int numberOfBooksToRemove)
        {
            numberOfBooks -= numberOfBooksToRemove;
            return numberOfBooks;
        }


    }
}
