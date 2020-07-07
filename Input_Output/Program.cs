using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will do a short interview with you to create your short biography. If you are ready!\n\n\t\t Please press the Enter key to start the interview!");
            Console.ReadLine();
            Console.WriteLine("What is your full name?");
            string fullName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            // int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where were you born?");
            string birthPlace = Console.ReadLine();

            string mainInput;
            int graduationYear;
            string bachelorDeg;
            string nameOfUni;
            string placeOfUni;

            Console.WriteLine("Enter the following informations, respectively and seperate them by a dash sign:\n Your graduation year: The name of your degree: The name of the university: The place of the university:");

            mainInput = Console.ReadLine();
            graduationYear = Convert.ToInt32(mainInput.Split('-')[0]);
            bachelorDeg = mainInput.Split('-')[1];
            nameOfUni = mainInput.Split('-')[2];
            placeOfUni = mainInput.Split('-')[3];




            Console.WriteLine("In which city do you live now?");
            string livingPlace = Console.ReadLine();

            Console.WriteLine("Are you single? (Single/Married)");
            string maritalStatus = Console.ReadLine();

            if (maritalStatus == "Married")
            {
                Console.WriteLine("Do you have any children? (Yes/No)");
                string checkKids = Console.ReadLine();
                if (checkKids == "Yes")
                {
                    Console.WriteLine("How many children do you have?");
                    int numOfKids = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your biography was created as follows.\n");
                    Console.WriteLine($"My name is {fullName}, {age} years old and born in {birthPlace}.");
                    Console.WriteLine($"I graduated in {graduationYear} from {bachelorDeg} at the {nameOfUni} in {placeOfUni}.");
                    Console.WriteLine($"I am {maritalStatus} and have {numOfKids} children. I currently live with my family in {livingPlace}.");
                }
                else if (checkKids == "No")
                {
                    Console.WriteLine("Your biography was created as follows.\n");
                    Console.WriteLine($"My name is {fullName}, {age} years old and born in {birthPlace}.");
                    Console.WriteLine($"I graduated in {graduationYear} from {bachelorDeg} at the {nameOfUni} in {placeOfUni}.");
                    Console.WriteLine($"I am married and have no children. I currently live with my family in {livingPlace}.");
                }
                else
                {
                    Console.WriteLine("You entered the answer in the wrong format. Your interview is over!");
                    Console.ReadKey();
                }
            }
            else if (maritalStatus == "Single")
            {
                Console.WriteLine("Your biography was created as follows.\n");
                Console.WriteLine($"My name is {fullName}, {age} years old and born in {birthPlace}.");
                Console.WriteLine($"I graduated in {graduationYear} from {bachelorDeg} at the {nameOfUni} in {placeOfUni}.");
                Console.WriteLine($"I am single and I currently live alone in {livingPlace}.");
            }
            else
            {
                Console.WriteLine("You entered the answer in the wrong format. Your interview is over!");
                Console.ReadKey();
            }


            Console.ReadKey();
        }
    }
}
