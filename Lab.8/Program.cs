using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes the StudentName ArrayList.
            Console.WriteLine("");
            ArrayList StudentName = new ArrayList();
            StudentName.Add("1.Chris");
            StudentName.Add("2.Zac");
            StudentName.Add("3.William");
            StudentName.Add("3.Drew");
            StudentName.Add("4.DeMarko");
            StudentName.Add("5.Dr.K");
            StudentName.Add("6.Sam");
            StudentName.Add("7.Terrell");
            StudentName.Add("8.Terri");


            // Creates and initializes the Hometown ArrayList.
            ArrayList Hometown = new ArrayList();
            Hometown.Add("WestBloom Feild");
            Hometown.Add("North carloina");
            Hometown.Add("troy");
            Hometown.Add("Detroit");
            Hometown.Add("Northville");
            Hometown.Add("Farmington");
            Hometown.Add("Jacksonville");
            Hometown.Add("Dallas");
            Hometown.Add("Huston");

            // Creates and initializes the food ArrayList.
            ArrayList Food = new ArrayList();
            Food.Add("Pizza");
            Food.Add("Collard Greens");
            Food.Add("Ramen Noodles");
            Food.Add("Oranages");
            Food.Add("Chicken");
            Food.Add("Steak");
            Food.Add("Shwarmmas");
            Food.Add("pigs feet");
            Food.Add("Grapes");
            int studIndex = 0;
            string info = "";

            bool repeat = true;
            while (repeat)
            {
                for (int i = 0; i < StudentName.Count; i++)
                {
                    Console.WriteLine(StudentName[i]);
                }
                //Prompt
                Console.WriteLine("Welcome to our C# Class. Which Student would you like to laern more about? Enter an number 1-8.");

                String input = Console.ReadLine();
                studIndex = int.Parse(input);

                if (studIndex >= StudentName.Count || studIndex < 0)
                {
                    Console.WriteLine("That Student does not exist! Please try agian");
                }
                else
                {
                    repeat = false;
                }
            }
            bool repeat2 = true;
            while (repeat2)
            {

                //prompt
                Console.WriteLine($"Student {StudentName[studIndex]}. What would you like to know  more about {StudentName[studIndex]}? either Food or Hometown or exit");
                info = Console.ReadLine().ToLower();


                if (info == "food")
                {
                    Console.WriteLine($"There favorite food is {Food[studIndex]}");
                }
                else if (info == "hometown")
                {
                    Console.WriteLine($"There hometown is {Hometown[studIndex]}");
                }
                else if(info=="exit")
                    {
                    repeat2 = false;
                }
                else
                {
                    repeat2 = false;

                }
                Console.WriteLine("That all the information that we have at the second, thanks for your input. would you like to findout somthing about somone else?");
            } 



        }



    }
}

