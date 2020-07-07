using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // GreetUser function calls "private static void GreetUser()" method 
            // to greet users and ask some questions to collect some informations about their trip!
            GreetUser();

            // Ask the user about how much time and money they are budgeting for their trip.
            GetInfoAboutTimeBudget();

            // Ask the user about the time difference between their home and where they are going.
            GetInfoAboutTimeDifference();

            // Ask the user the area of their travel destination country/ region in square kilometers.
            GetInfoAboutCountry();

            // Ask the user to enter the longitude and latitude for their home and their travel destination.
            GetInfoAboutDistance();

            Console.WriteLine("\nPress any key to close the Console Window!");
            Console.ReadKey();
        }

        // Part 1 – Greeting
        private static void GreetUser()
        {
            // Ask user name
            Console.Write("\n\tEnter your full name: ");
            string userFullName = Console.ReadLine();

            // Welcome users
            Console.WriteLine($"\n\tWelcome to TripPlanner App, {userFullName}!");

            // Ask user for trip destination
            Console.Write("\nWhere would you like to go: ");
            string userDestination = Console.ReadLine();

            // Tell user, their destination sounds like a great trip!
            Console.WriteLine($"\n\t{userDestination} sounds great this time of year!");
        }

        // Part 2 – Travel time and Budget
        private static void GetInfoAboutTimeBudget()
        {
            // Get information about the travel time of the passengers!
            Console.Write("\nHow many days are you going to spend in your destination: ");
            int userTravelTimeInDays = Convert.ToInt32(Console.ReadLine());
            int userTravelTimeInHours = ConvertTimeFrom(userTravelTimeInDays, "hours");
            int userTravelTimeInMinutes = ConvertTimeFrom(userTravelTimeInDays, "minutes");

            // Get information about the total budget of the passengers!
            Console.Write("\nWhat is your total budget for the trip in USD: ");
            var inputAmount = Console.ReadLine();
            double userTotalBudgetInUS = Convert.ToDouble(inputAmount.Replace(".", ","));
            double userBudgetPerDay = userTotalBudgetInUS / userTravelTimeInDays;

            // Get information about the travel time of the passengers!
            Console.Write("\nWhat is the currency symbol(US, EU, TL, YEN, RON) for your destination: ");
            string userDestinationCurrencySymbol = Console.ReadLine();
            double userConvertedBudget = ConvertCurrencyFrom(userTotalBudgetInUS, userDestinationCurrencySymbol);
            double userConvertedBudgetPerDay = userConvertedBudget / userTravelTimeInDays;

            // Tell user, about their travel time!
            Console.WriteLine($"\n\tIf you are traveling for {userTravelTimeInDays} days that is the same as {userTravelTimeInHours} hours or {userTravelTimeInMinutes} minutes.");

            // Tell user, about their budget in USD for the whole trip and how much they can spend in USD per day
            Console.WriteLine($"\n\tIf you are going to spend ${userTotalBudgetInUS:F2} that means daily you can spend up to ${userBudgetPerDay:F2} in US.");
            Console.WriteLine($"\n\tYour total budget in {userDestinationCurrencySymbol} is {userConvertedBudget:F2} which per day is {userConvertedBudgetPerDay:F2} {userDestinationCurrencySymbol}.");

        }

        private static int ConvertTimeFrom(int userTravelTimeInDays, string userTravelTimeIn)
        {
            if (userTravelTimeIn == "hours")
            {
                return (userTravelTimeInDays * 24);
            }
            else if (userTravelTimeIn == "minutes")
            {
                return (userTravelTimeInDays * 24 * 60);
            }
            else
                return userTravelTimeInDays;
        }

        private static double ConvertCurrencyFrom(double userTotalBudgetInUS, string userDestinationCurrencySymbol)
        {
            if (userDestinationCurrencySymbol == "EU")
            {
                return (userTotalBudgetInUS * 0.92);
            }
            else if (userDestinationCurrencySymbol == "TL")
            {
                return (userTotalBudgetInUS * 6.98);
            }
            else if (userDestinationCurrencySymbol == "YEN")
            {
                return (userTotalBudgetInUS * 107.75);
            }
            else if (userDestinationCurrencySymbol == "RON")
            {
                return (userTotalBudgetInUS * 4.46);
            }
            else
                return userTotalBudgetInUS;
        }

        // Part 3 – Time Difference
        private static void GetInfoAboutTimeDifference()
        {
            // Get information from user about the time difference between their home and where they are going.
            Console.Write("\nWhat is the time difference in hours, between your home and your destination: ");
            int userDestinationTimeDifference = Convert.ToInt32(Console.ReadLine());


            if (userDestinationTimeDifference < 0)
            {
                TimeSpan midnight = TimeSpan.FromHours(userDestinationTimeDifference + 24);
                TimeSpan noon = TimeSpan.FromHours(userDestinationTimeDifference + 12);
                string midnightTimeDifference = midnight.ToString("hh':'mm");
                string noonTimeDifference = noon.ToString("hh':'mm");
                Console.WriteLine($"\n\tThat means that when it is midnight at home it will be {midnightTimeDifference} in your travel destination " +
                    $"\n\tand when it is noon at home it will be {noonTimeDifference} in your travel destination.");
            }
            else
            {
                TimeSpan midnight = TimeSpan.FromHours(userDestinationTimeDifference);
                TimeSpan noon = TimeSpan.FromHours(userDestinationTimeDifference + 12);
                string midnightTimeDifference = midnight.ToString("hh':'mm");
                string noonTimeDifference = noon.ToString("hh':'mm");
                Console.WriteLine($"\n\tThat means that when it is 'Midnight' at home it will be {midnightTimeDifference} in your travel destination " +
                    $"\n\tand when it is 'Noon' at home it will be {noonTimeDifference} in your travel destination.");
            }
        }

        // Part 4 – Country/Region Area
        private static void GetInfoAboutCountry()
        {
        // Get information from user about their travel destination country/region in square kilometers. 
        MAKEYOURCHOICE:
            Console.WriteLine("\nThis calculator provides conversion of square kilometers to square miles and backwards (sq mi to sq km).");
            Console.Write("\nMake your conversion choice?\n\n\t (sq km to sq mi) : '1'\n\t (sq mi to sq km) : '2' => ");
            double areaOfTravelDestinationInSqKm, areaOfTravelDestinationInSqMi;
            char userChoice = Convert.ToChar(Console.ReadLine());
            switch (userChoice)
            {
                case '1':
                    Console.Write("\nWhat is the area of your destination country/region 'in square kilometers': ");
                    areaOfTravelDestinationInSqKm = Convert.ToDouble(Console.ReadLine());
                    areaOfTravelDestinationInSqMi = areaOfTravelDestinationInSqKm * 0.38610;
                    Console.WriteLine($"\n\tIn square miles that is {areaOfTravelDestinationInSqMi:F2}.");
                    break;
                case '2':
                    Console.Write("\nWhat is the area of your destination country/region 'in square miles': ");
                    areaOfTravelDestinationInSqMi = Convert.ToDouble(Console.ReadLine());
                    areaOfTravelDestinationInSqKm = areaOfTravelDestinationInSqMi * 2.58999;
                    Console.WriteLine($"\n\tIn square kilometer is {String.Format("{0:n2}", areaOfTravelDestinationInSqKm)}.");
                    break;
                default:
                    //Console.Clear();
                    Console.WriteLine("\nYou entered an invalid value! Please enter a valid value.");
                    goto MAKEYOURCHOICE;
            }
        }

        // Part 5 – String.format() IS DONE

        // Part 6 – Optional Extension - How Far?
        private static void GetInfoAboutDistance()
        {
            // Get information from user about the longitude and latitude for their home and their travel destination
            Console.WriteLine("\n\tTo able to calculate the distance between your home and your travel destination," +
                " \n\tyou need to enter the longitude and latitude for your home and your travel destination.");

            string mainInput;
            double latitudeOfHome;
            double longitudeOfHome;
            double latitudeOfDestination;
            double longitudeOfDestination;

            Console.Write("\nEnter the following informations, respectively and seperate them by a dash sign(-):\n\n\tThe latitude and the longitude for your home : ");

            mainInput = Console.ReadLine();
            var inputLatitudeOfHome = mainInput.Split('-')[0];
            var inputLongitudeOfHome = mainInput.Split('-')[1];
            latitudeOfHome = Convert.ToDouble(inputLatitudeOfHome.Replace(".", ","));
            longitudeOfHome = Convert.ToDouble(inputLongitudeOfHome.Replace(".", ","));

            Console.Write("\nAnd also enter the following informations, respectively and seperate them by a dash sign(-):\n\n\tThe latitude and the longitude for your destination : ");

            mainInput = Console.ReadLine();
            var inputLatitudeOfDestination = mainInput.Split('-')[0];
            var inputLongitudeOfDestination = mainInput.Split('-')[1];
            latitudeOfDestination = Convert.ToDouble(inputLatitudeOfDestination.Replace(".", ","));
            longitudeOfDestination = Convert.ToDouble(inputLongitudeOfDestination.Replace(".", ","));


            latitudeOfHome = Math.PI * latitudeOfHome / 180;
            latitudeOfDestination = Math.PI * latitudeOfDestination / 180;
            double theta = longitudeOfHome - longitudeOfDestination;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(latitudeOfHome) * Math.Sin(latitudeOfDestination) + Math.Cos(latitudeOfHome) *
                Math.Cos(latitudeOfDestination) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

        MAKEYOURCHOICE:
            Console.Write("\nChoose a unit of distance: \n\n\t (Kilometers) :     'K'\n\t (Nautical Miles) : 'N'\n\t (Miles) :          'M' => ");
            char userChoice = Convert.ToChar(Console.ReadLine());
            switch (userChoice)
            {
                case 'K':
                case 'k':
                    //Kilometers
                    double distInKm = dist * 1.609344;
                    Console.WriteLine($"\n\tThe distance between your home and your travel destination is {distInKm:F2} kilometers.");
                    break;
                case 'N':
                case 'n':
                    //Nautical Miles 
                    double distInNuMi = dist * 0.8684;
                    Console.WriteLine($"\n\tThe distance between your home and your travel destination is {distInNuMi:F2} nautical miles.");
                    break;
                case 'M':
                case 'm':
                    //Miles
                    double distInMi = dist;
                    Console.WriteLine($"\n\tThe distance between your home and your travel destination is {distInMi:F2} miles.");
                    break;
                default:
                    //Console.Clear();
                    Console.WriteLine("\nYou entered an invalid value! Please enter a valid value.");
                    goto MAKEYOURCHOICE;
            }
        }
    }
}
