using System;
using System.Data.SQLite;
using System.Linq;
using System.Collections.Generic;

namespace yetAnotherMovieDB
{
    class Program
    {
        public static void Main()
        {
            // Call the constructor that has no parameters.
            Movie movie = new Movie();
            Console.WriteLine("What is your movie name?");
            movie.Title = Console.ReadLine();
            Console.WriteLine("What is your movie type? DVD, Bluray, or Digital?");
            movie.MovieType = Console.ReadLine();
            //have to convert int to string since NumOfCopies is an int in the Movie class
            string movieCopies;
            Console.WriteLine("How many copies do you have?");
            movieCopies = Console.ReadLine();
            
            //convert movieCopies from string to int and return answer depending on number of copies owned

            int x = movie.NumOfCopies;
            if (!Int32.TryParse(movieCopies, out x))
            {
                Console.WriteLine("Invalid data input. Only whole numbers accepted. Please try again.");
                Main(); //is calling Main the best way?
                //want to continue the loop but continue doesn't work here
            }
            else if (x == 0)
            {
                Console.WriteLine("You have to enter a number greater than 1.");
                Main(); //is calling Main the best way?
                //want to continue the loop but continue doesn't work here
            }
            else if (x == 1)
            {
                Console.WriteLine(x + " copy of " + movie.Title + " of type " + movie.MovieType + " has been added to your database.");
            }
            else
            {
                Console.WriteLine(x + " copies of " + movie.Title + " of type " + movie.MovieType + " has been added to your database.");
            }
            Console.ReadKey();


        }

    }
}
