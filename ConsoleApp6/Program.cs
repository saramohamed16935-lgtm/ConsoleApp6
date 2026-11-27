//Assignment:
//Q1:
//using System;
//class Program
//{
//static void Main()
// {
//  int pages = 464;
// if (pages > 300)
//{
//Console.WriteLine("Long Book");
//}
//else
//{
// Console.WriteLine("Short Book");
//}
//}
//}
//Q2:
/*using System;
class Program
{
    static void Main()
    {
        int pages = 464;
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("Ypu can borrow this book");

        }
    }
}*/

//Q3:
/*using System;
class Program
{
    static void Main()
    {
        string title = "Refactoring";
        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }
    }
}*/
//Q4:
/*using System;
class Program
{
    static void Main()
    {
        int pages = 464;
        string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);


    }
}*/
// Q5:
/*using System;
class Program
{
    static void Main()
    {
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for( int i = 0; i < books.Length ; i++)
        {
            Console.WriteLine((i+1) + ". " + books[i]); // 1.clean code , 2.The Pragmatic Programmer , 3.Refactoring
        }
    }
}*/
//Q6:
/*using System;
class Program
{
    static void Main()
    {
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        int i = 0;
        while ( i < books.Length)
        {
            Console.WriteLine(books[i]);  // Clean Code 
            i++;                         //The Pragmatic Programmer
                                          // Refactoring
  
        }


    }
}*/
//Q7:
/*using System;
class Program
{
    static void Main()
    {
        int i = 0;
        do
        {
            Console.WriteLine("Checking book"); ;
            i++;                                     // Checking book
                                                      //Checking book
                                                       //Checking book
        }
        while (i < 3);
    }
}*/
// Q8:
/*using System;
class Program
{
    static void Main()
    {
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        foreach(string book in books)
        {                                               //Clean Code
                                                       //The Pragmatic Programmer
                                                        //Refactoring
            Console.WriteLine(book);
        }

    }
}*/

// Q9:
/*using System;
class Program
{
    static void Main()
    {
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for(int i = 0; i < books.Length; i++)
        {
            if (books[i] == "Refactoring") // output:
                                           // The Pragmatic Programmer
                                           // Refactoring
            {
                break;
            }
            Console.WriteLine(books[i]);
        }
    }
}*/
// Q10:
/*using System;
class Program
{
    static void Main()
    {
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == "The Pragmatic Programmer"){        //output:
                                                                //Clean Code 
                                                                //Refactoring
                continue;
            }
            Console.WriteLine(books[i]);
        }
        }
}*/
// Q11:
/*using System;
class Program
{
    static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
    static void PrintFirstBook()
    {
        if(books .Length == 0)
        {
            return;
        }                                       // output:
                                                // Clean code
        Console.WriteLine(books[0]);
    }
    static void Main()
    {
        PrintFirstBook();
    }
}*/


