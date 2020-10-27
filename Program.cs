using System;

namespace Birthdays
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            int noOfFriends = 15;
            string[] firstNames = new string[noOfFriends];
            string[] lastNames = new string[noOfFriends];
            string[] telephones = new string[noOfFriends];
            string[] datesOfBirth = new string[noOfFriends];

            loopToGetData(noOfFriends, firstNames, lastNames, telephones, datesOfBirth);

            // printFriendsBirthdays(4 string[])
            

        }

        // method displayInfoToScreen()
        static void displayInfoToScreen(int i)
        {
            if (i == 0)
            {
                Console.WriteLine("Data for {0}st person", i + 1);
            }
            if (i == 1)
            {
                Console.WriteLine("Data for {0}nd person", i + 1);
            }
            if (i == 2)
                Console.WriteLine("Data for {0}rd person", i + 1);
            if (i >= 3)
                Console.WriteLine("Data for {0}th person", i + 1);
        }


        // method signature == static void AskUserDetails()
        static void AskUserDetails(string message, string[] array, int i) 
        {
            Console.Write(message);
            array[i] = Console.ReadLine();
        }

        static void loopToGetData(int noOfFriends,    string[] firstNames, 
                                  string[] lastNames, string[] telephones, 
                                  string[] datesOfBirth)
        {
            for (int i = 0; i < noOfFriends; i++)
            {
                displayInfoToScreen(i);
                // replace the following code with method
                // static void AskUserDetails(string message, string[] array, int i) {}
                AskUserDetails("Give me your first name: ", firstNames, i);
                AskUserDetails("Give me your last name: ", lastNames, i);
                AskUserDetails("Give me your telephone: ", telephones, i);
                AskUserDetails("Give me your date of birth: ", datesOfBirth, i);
            }
        }
        
        

    }
}
