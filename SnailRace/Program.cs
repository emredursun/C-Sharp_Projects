using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_SnailRace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set tracklength and startingpositions contenders + defines speed interval as randoms
            int trackLength = 330;
            int totalDisplacement1 = 0;
            int totalDisplacement2 = 0;
            Random speedInterval1 = new Random();
            Random speedInterval2 = new Random();

            Console.WriteLine(
                "\n\t\t\t\tWelcome to Snail Racing Game.\n" +
                "\nPress a key to start the contest and please answer any questions respectively that will be asked soon.\n" +
                "\n######################################################################################################\n\n");

            // To create new snails with name, min speed and max speed you need to get inputs from users
            Snail snail1 = new Snail();
            Console.Write("Enter the name for the first snail: ");
            snail1.SnailName = Console.ReadLine();
            Console.Write($"Enter the minimum speed for {snail1.SnailName}: ");
            snail1.MinSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the maximum speed for {snail1.SnailName}: ");
            snail1.MaxSpeed = Convert.ToInt32(Console.ReadLine());

            while (snail1.MaxSpeed <= snail1.MinSpeed)
            {
                Console.WriteLine("Your maximum speed should be higher then your minimum speed.");
                Console.WriteLine("Give a new number for the maximum speed: ");
                snail1.MaxSpeed = Convert.ToInt32(Console.ReadLine());
            }


            Snail snail2 = new Snail();
            Console.Write("\nEnter the name for the second snail: ");
            snail2.SnailName = Console.ReadLine();
            Console.Write($"Enter the minimum speed for {snail2.SnailName}: ");
            snail2.MinSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the maximum speed for {snail2.SnailName}: ");
            snail2.MaxSpeed = Convert.ToInt32(Console.ReadLine());

            while (snail2.MaxSpeed <= snail2.MinSpeed)
            {
                Console.WriteLine("Your maximum speed should be higher then your minimum speed.");
                Console.WriteLine("Give a new number for the maximum speed: ");
                snail2.MaxSpeed = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            int counter = 5;
            do
            {
                Console.WriteLine($"\n\t\t\t\tThe race will start in {counter} soconds!");
                Thread.Sleep(1000);
                counter--;
                Console.Clear();
            } while (counter > 0);


            //do-while loop until one of contenders completes the full track and wins
            int round = 1;
            do
            {
                int displacement1 = speedInterval1.Next(snail1.MinSpeed, snail1.MaxSpeed);
                totalDisplacement1 += displacement1;
                int displacement2 = speedInterval2.Next(snail2.MinSpeed, snail2.MaxSpeed);
                totalDisplacement2 += displacement2;

                if (round == 1) Console.WriteLine($"\t\t{round}st Round");
                else if(round == 2) Console.WriteLine($"\t\t{round}nd Round");
                else if (round == 3) Console.WriteLine($"\t\t{round}rd Round");
                else Console.WriteLine($"\t\t{round}th Round");
                round++;

                Console.WriteLine($"{snail1} moves {((double)displacement1 / 10):F1} cm for a total of {totalDisplacement1} mm.");
                Console.WriteLine($"{snail2} moves {((double)displacement2 / 10):F1} cm for a total of {totalDisplacement2} mm.\n");
                Thread.Sleep(2000); //Set timer on 2 seconds 
            }
            while (totalDisplacement1 < trackLength && totalDisplacement2 < trackLength);

            //Declare winner
            if (totalDisplacement1 >= trackLength)
            {
                Console.Write($"\n{snail1}");
                Thread.Sleep(1000);
                Console.Write($" won");
                Thread.Sleep(1000);
                Console.Write($" the race");
                Thread.Sleep(1000);
                Console.Write($" in {round}");
                Thread.Sleep(1000);
                Console.Write($" rounds!\n");
                Thread.Sleep(2000);
            }
            else if (totalDisplacement2 >= trackLength)
            {

                Console.WriteLine($"\n{snail2} won the race in {round} rounds!\n");
                Thread.Sleep(2000);
            }



            #region Check out
            Console.WriteLine("\nPress any key to close the Console Window!");
            Console.ReadKey();
            #endregion
        }
    }
}
